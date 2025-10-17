using StockMate.Forms.Products;
using StockMate.Helpers;
using StockMate.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StockMate.UC.Screens
{
    public partial class UCProducts : UserControl
    {
        private readonly ProductService addProductService;
        private int _pageIndex = 1;
        private int _pageSize = 50;
        private int _totalPageIndex = 0;
        private int productId = 0;
        public UCProducts()
        {
            InitializeComponent();
            ButtonStyle.GreenButton(btnAddProduct);
            ButtonStyle.BlueButton(btnEdit);
            ButtonStyle.BlueButton(btnFirst);
            ButtonStyle.BlueButton(btnPrev);
            ButtonStyle.BlueButton(btnNext);
            ButtonStyle.BlueButton(btnLast);
            ButtonStyle.WhiteButton(btnRefresh);
            ButtonStyle.BlueButton(btnSearch);
            dgvProducts.AutoGenerateColumns = false;
            addProductService = new ProductService();

        }

        private void UpdateButtons(int pageIndex, int totalPages)
        {
            btnFirst.Enabled = pageIndex > 1;
            btnPrev.Enabled = pageIndex > 1;
            btnNext.Enabled = pageIndex < totalPages;
            btnLast.Enabled = pageIndex < totalPages;
        }

        private async void LoadPageAsync()
        {
            await addProductService.LoadProductsPaged(dgvProducts, _pageIndex, _pageSize);
            dgvProducts.ClearSelection();
            productId = 0;
            int totalRows = addProductService.GetTotalRowCountAsync();
            _totalPageIndex = (int)Math.Ceiling((double)totalRows / _pageSize);
            lblRecordFound.Text = $"Record Found: {totalRows}";
            lblPage.Text = $"Page {_pageIndex} of {_totalPageIndex}";
            lblTitle.Focus();
            UpdateButtons(_pageIndex, _totalPageIndex);
        }

        private void LoadLastPageAsync()
        {
            int totalRows = addProductService.GetTotalRowCountAsync();
            _totalPageIndex = (int)Math.Ceiling((double)totalRows / _pageSize);
            _pageIndex = _totalPageIndex;
            LoadPageAsync();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();

            if (frmAddProduct.ShowDialog() == DialogResult.OK)
            {
                LoadPageAsync();
            }
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            LoadPageAsync();
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProducts.Columns["CreatedAt"].DefaultCellStyle.Format = "d";  // Short date pattern, e.g. 10/12/2025

            if (dgvProducts.Columns[e.ColumnIndex].Name == "Status")
            {
                var quantity = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value);
                var reorderLevel = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ReorderLevel"].Value);

                if (quantity > reorderLevel)
                {
                    e.Value = "In Stock";
                    //e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (quantity <= reorderLevel)
                {
                    e.Value = "Low Stock";
                    //e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPageAsync();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            LoadPageAsync();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                LoadPageAsync();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _totalPageIndex)
            {
                _pageIndex++;
                LoadPageAsync();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LoadLastPageAsync();
        }

        private void txtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (int.TryParse(txtPageSize.Text, out int newPageSize) && newPageSize > 0)
                {
                    _pageSize = newPageSize;
                    _pageIndex = 1;  // reset to first page after changing page size
                    LoadPageAsync();  // call your async load method
                    lblTitle.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive integer for the page size.");
                    txtPageSize.Text = _pageSize.ToString();  // revert to valid value
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header clicks
            {
                // Assuming your data source has a column "ProductId"
                var id = dgvProducts.Rows[e.RowIndex].Cells[0].Value; // Assuming product Id is in column 0
                productId = Convert.ToInt32(id);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (productId == 0)
            {
                MessageBoxAdv.Show("Please select an item to edit.","No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmUpdateProduct frmUpdateProduct = new frmUpdateProduct(productId);
                if (frmUpdateProduct.ShowDialog() == DialogResult.OK)
                {
                    await addProductService.LoadProductsPaged(dgvProducts, _pageIndex, _pageSize);
                }
            }
        }
    }
}
