using Microsoft.Data.SqlClient;
using StockMate.Models;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StockMate.Services
{
    public class ProductService
    {
        #region -- Load Category and Supplier to ComboBox --

        public void LoadSupplier(SfComboBox comboBox)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loadCategory = "SELECT SupplierId, SupplierName FROM Supplier";
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loadCategory, conn);
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                comboBox.ValueMember = "SupplierId";
                comboBox.DisplayMember = "SupplierName";
                comboBox.DataSource = dt;
            }
        }

        public void LoadCategory(SfComboBox comboBox)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loadCategory = "SELECT CategoryId, CategoryName FROM Category";
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loadCategory, conn);
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                comboBox.ValueMember = "CategoryId";
                comboBox.DisplayMember = "CategoryName";
                comboBox.DataSource = dt;
            }
        }

        #endregion

        #region -- Get Total Rows --

        public async Task<int> GetTotalRowCountAsync()
        {
            using var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString);
            string sql = "SELECT COUNT(*) FROM Products";  // Adjust joins/filters as needed
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
            await conn.OpenAsync();
            return (int)await cmd.ExecuteScalarAsync();
        }

        #endregion

        #region -- Create Product --

        public void AddProduct(string name, string sku, int category, int supplier, int quantity, int reorderlevel, Form form)
        {
            try
            {
                if (!string.IsNullOrEmpty(name) && category > 0 && supplier > 0)
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "INSERT INTO Products (SKU, ProductName, CategoryId, SupplierId, Quantity, ReorderLevel, CreatedAt) VALUES (@sku, @productName, @category, @supplier, @quantity, @reorderlevel, @createdat);SELECT CAST(SCOPE_IDENTITY() AS INT)";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@sku", sku);
                            cmd.Parameters.AddWithValue("@productName", name);
                            cmd.Parameters.AddWithValue("@category", category);
                            cmd.Parameters.AddWithValue("@supplier", supplier);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@reorderlevel", reorderlevel);
                            cmd.Parameters.AddWithValue("@createdat", DateTime.Now);

                            conn.Open();
                            int newProductId = cmd.ExecuteNonQuery();

                            if (newProductId > 0)
                            {
                                MessageBoxAdv.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot add product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region -- Read Products --

        public async Task LoadProductsPaged(DataGridView dataGrid, int pageIndex, int pageSize)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT p.ProductId, p.SKU, p.ProductName, c.CategoryName, s.SupplierName, p.Quantity, p.ReorderLevel, p.CreatedAt " +
                    "FROM Products p " +
                    "INNER JOIN Supplier s ON p.SupplierId = s.SupplierId " +
                    "INNER JOIN Category c ON p.CategoryId = c.CategoryId " +
                    "ORDER BY p.ProductId " +
                    "OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

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

        public ProductDetails GetProductDetails(int productId)
        {
            ProductDetails product = null;
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT ProductId, SKU, ProductName, CategoryId, SupplierId, ReorderLevel FROM Products p WHERE ProductId = @productId";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new ProductDetails()
                            {
                                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                                SKU = reader.GetString(reader.GetOrdinal("SKU")),
                                ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                                SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId")),
                                ReorderLevel = reader.GetInt32(reader.GetOrdinal("ReorderLevel"))
                            };
                        }
                    }
                }
            }

            return product;
        }

        #endregion


        #region -- Update Product --

        public void UpdateProduct(int productId, string name, string sku, int category, int supplier, int reorderlevel, Form form)
        {
            try
            {
                if (!string.IsNullOrEmpty(name) && category > 0 && supplier > 0)
                {
                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string updateQuery = "UPDATE Products SET ProductName = @productName, SKU = @sku, CategoryId = @categoryId, SupplierId = @supplierId, ReorderLevel = @reorderLevel WHERE ProductId = @productId";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@productId", productId);
                            cmd.Parameters.AddWithValue("@productName", name);
                            cmd.Parameters.AddWithValue("@sku", sku);
                            cmd.Parameters.AddWithValue("@categoryId", category);
                            cmd.Parameters.AddWithValue("@supplierId", supplier);
                            cmd.Parameters.AddWithValue("@reorderLevel", reorderlevel);

                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBoxAdv.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.DialogResult = DialogResult.OK;
                                form.Close();
                            }
                            else
                            {
                                MessageBoxAdv.Show("Cannot update product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}