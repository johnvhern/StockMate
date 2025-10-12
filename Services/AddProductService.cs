using Microsoft.Data.SqlClient;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StockMate.Services
{
    public class AddProductService
    {
        private DataTable dt = new DataTable();
        public async Task LoadProducts(DataGridView dataGrid)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loadProducts = "SELECT " +
                    "p.ProductID, " +
                    "p.SKU, " +
                    "p.ProductName, " +
                    "c.CategoryName, " +
                    "s.SupplierName, " +
                    "p.Quantity, " +
                    "p.ReorderLevel, " +
                    "p.CreatedAt FROM " +
                    "Products p " +
                    "INNER JOIN " +
                    "Supplier s ON p.SupplierID = s.SupplierID " +
                    "INNER JOIN " +
                    "Category c ON p.CategoryID = c.CategoryID";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loadProducts, conn))
                {
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                        //dataGrid.DataSource = dt;
                    }
                }
            }

            dataGrid.VirtualMode = true;
            dataGrid.RowCount = dt.Rows.Count;
            dataGrid.ColumnCount = dt.Columns.Count;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dataGrid.Columns[i].Name = dt.Columns[i].ColumnName;
            }

            // Subscribe to virtual mode events
            dataGrid.CellValueNeeded -= DataGrid_CellValueNeeded; // Detach if attached before
            dataGrid.CellValueNeeded += DataGrid_CellValueNeeded;

            dataGrid.CellValuePushed -= DataGrid_CellValuePushed; // Detach if attached before
            dataGrid.CellValuePushed += DataGrid_CellValuePushed;
        }

        private void DataGrid_CellValueNeeded(object? sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dt.Columns.Count)
            {
                e.Value = dt.Rows[e.RowIndex][e.ColumnIndex];
            }
        }

        private void DataGrid_CellValuePushed(object? sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dt.Columns.Count)
            {
                dt.Rows[e.RowIndex][e.ColumnIndex] = e.Value;
                // Optionally update database here or queue update
            }
        }


        public void AddProduct(string name, string sku, int category, int supplier, int quantity, int reorderlevel, Form form)
        {
            try
            {
                if (!string.IsNullOrEmpty(name) && category > 0  && supplier > 0)
                {
                    using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        string addProductQuery = "INSERT INTO Products (SKU, ProductName, CategoryId, SupplierId, Quantity, ReorderLevel, CreatedAt) VALUES (@sku, @productName, @category, @supplier, @quantity, @reorderlevel, @createdat)";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(addProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@sku", sku);
                            cmd.Parameters.AddWithValue("@productName", name);
                            cmd.Parameters.AddWithValue("@category", category);
                            cmd.Parameters.AddWithValue("@supplier", supplier);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@reorderlevel", reorderlevel);
                            cmd.Parameters.AddWithValue("@createdat", DateOnly.FromDateTime(DateTime.Now));

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
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
    }
}
