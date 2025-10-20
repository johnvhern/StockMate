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

        public void AddBorrower(int departmentId, string borrowerName, int productId, int quantity, Form form)
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
            string sql = "SELECT COUNT(*) FROM Borrower";  // Adjust joins/filters as needed
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
                string query = "SELECT b.BorrowerId, d.DepartmentName, b.BorrowerName, p.ProductName, b.Quantity, b.CreatedAt FROM Borrower b INNER JOIN Department d ON b.DepartmentId = d.DepartmentId INNER JOIN Products p ON b.ProductId = p.ProductId ORDER BY BorrowerId OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

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

        public BorrowerDetails GetBorrowerDetails(int borrowerId)
        {
            BorrowerDetails borrower = null;
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT BorrowerId, DepartmentId, BorrowerName, ProductId, Quantity FROM Borrower WHERE BorrowerId = @borrowerId";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            borrower = new BorrowerDetails()
                            {
                                BorrowerId = reader.GetInt32(reader.GetOrdinal("BorrowerId")),
                                DepartmentId = reader.GetInt32(reader.GetOrdinal("DepartmentId")),
                                BorrowerName = reader.GetString(reader.GetOrdinal("BorrowerName")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            };
                        }
                    }
                }
            }
            return borrower;
        }

        #endregion -- Read Borrower --

        #region -- Update Borrower --

        public void UpdateBorrower(int borrowerId, int quantity, Form form)
        {
            try
            {
                if (quantity > 0)
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "UPDATE Borrower SET Quantity = @quantity WHERE BorrowerId = @borrowerId;";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue(@"borrowerId", borrowerId);
                            cmd.Parameters.AddWithValue(@"quantity", quantity);

                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBoxAdv.Show("Borrower updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot update borrower. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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