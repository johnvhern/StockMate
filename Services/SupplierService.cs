using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StockMate.Services
{
    public class SupplierService
    {
        #region -- Create Supplier --

        public class PhoneNumberValidator
        {
            // C# verbatim string for the regex pattern
            private const string PhilippinePhoneRegex = @"^((\+63|0)9\d{9}|(\+63|0)?\d{2}[-.\s]?\d{7}|(\+63|0)?2[-.\s]?\d{8})$";

            public static bool IsValidPhilippinePhoneNumber(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }

                // Remove all optional separators before validation to simplify the check
                string normalizedInput = Regex.Replace(input, @"[-.\s]", "");

                // Check against the regex pattern
                return Regex.IsMatch(normalizedInput, PhilippinePhoneRegex);
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                // This will throw an exception if the format is invalid
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                // Catches cases where the email string is null or empty
                return false;
            }
        }

        public void AddSupplier(string name, string contactPerson, string email, string mobileNumber, string address, Form form)
        {
            try
            {
                if (!PhoneNumberValidator.IsValidPhilippinePhoneNumber(mobileNumber))
                {
                    MessageBoxAdv.Show("Please enter a valid Philippine mobile or landline number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBoxAdv.Show("Please enter a email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "INSERT INTO Supplier (SupplierName, ContactPerson, Email, MobileNumber, Address, CreatedAt) VALUES (@name, @contactPerson, @email, @mobileNumber, @address, @createdat);";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@contactPerson", contactPerson);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@createdat", DateTime.Now);

                            conn.Open();
                            int newProductId = cmd.ExecuteNonQuery();

                            if (newProductId > 0)
                            {
                                MessageBoxAdv.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot add supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBoxAdv.Show($"Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region -- Get Total Rows --

        public async Task<int> GetTotalRowCountAsync()
        {
            using var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString);
            string sql = "SELECT COUNT(*) FROM Supplier";  // Adjust joins/filters as needed
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
            await conn.OpenAsync();
            return (int)await cmd.ExecuteScalarAsync();
        }

        #endregion

        #region -- Read Supplier --

        public async Task LoadSupplier(DataGridView dataGrid, int pageIndex, int pageSize)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT SupplierId, SupplierName, ContactPerson, Email, MobileNumber, Address, CreatedAt FROM Supplier ORDER BY SupplierId OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Offset", (pageIndex - 1) * pageSize);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }

        #endregion
    }
}
