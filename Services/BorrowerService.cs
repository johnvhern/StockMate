using StockMate.Models;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView;
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
    public class BorrowerService
    {
        #region -- Load Category and Supplier to ComboBox --

        public void LoadDepartment(SfComboBox comboBox)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loadCategory = "SELECT DepartmentId, DepartmentName FROM Department";
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loadCategory, conn);
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                comboBox.ValueMember = "DepartmentId";
                comboBox.DisplayMember = "DepartmentName";
                comboBox.DataSource = dt;
            }
        }

        public void LoadProducts(SfComboBox comboBox)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loadCategory = "SELECT ProductId, ProductName FROM Products";
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loadCategory, conn);
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                comboBox.ValueMember = "ProductId";
                comboBox.DisplayMember = "ProductName";
                comboBox.DataSource = dt;
            }
        }

        #endregion

        #region -- Create Borrower --

        public void AddSupplier(int departmentId, string borrowerName, int productId, int quantity, Form form)
        {
            try
            {
                if (!string.IsNullOrEmpty(borrowerName) && departmentId > 0 && productId > 0)
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "INSERT INTO Borrower (DepartmentId, BorrowerName, ProductId, Quantity, CreatedAt) VALUES (@departmentId, @borrowerName, @productId, @quantity, @createdat);";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@departmentId", departmentId);
                            cmd.Parameters.AddWithValue("@borrowerName", borrowerName);
                            cmd.Parameters.AddWithValue("@productId", productId);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@createdat", DateTime.Now);

                            conn.Open();
                            int newBorrowerId = cmd.ExecuteNonQuery();

                            if (newBorrowerId > 0)
                            {
                                MessageBoxAdv.Show("Borrower added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot add borrower. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion -- Create Borrower --

        #region -- Get Total Rows --

        public int GetTotalRowCountAsync()
        {
            using var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString);
            string sql = "SELECT COUNT(*) FROM Supplier";  // Adjust joins/filters as needed
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }

        #endregion -- Get Total Rows --

        #region -- Read Borrower --

        public async Task LoadBorrower(DataGridView dataGrid, int pageIndex, int pageSize)
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

        public SupplierDetails GetSupplierDetails(int supplierId)
        {
            SupplierDetails supplier = null;
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT SupplierId, SupplierName, ContactPerson, Email, MobileNumber, Address FROM Supplier WHERE SupplierId = @supplierId";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplier = new SupplierDetails()
                            {
                                SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId")),
                                SupplierName = reader.GetString(reader.GetOrdinal("SupplierName")),
                                ContactPerson = reader.GetString(reader.GetOrdinal("ContactPerson")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                MobileNumber = reader.GetString(reader.GetOrdinal("MobileNumber")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                            };
                        }
                    }
                }
            }
            return supplier;
        }

        #endregion -- Read Borrower --

        #region -- Update Borrower --

        public void UpdateSupplier(int supplierId, string name, string contactPerson, string email, string mobileNumber, string address, Form form)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "UPDATE Supplier SET SupplierName = @name, ContactPerson = @contactPerson, Email = @email, MobileNumber = @mobileNumber, Address = @address WHERE SupplierId = @supplierId;";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue(@"supplierId", supplierId);
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
                                MessageBoxAdv.Show("Supplier updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot update supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion -- Update Borrower --
    }
}