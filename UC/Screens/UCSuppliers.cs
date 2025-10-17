using StockMate.Forms.Suppliers;
using StockMate.Helpers;
using StockMate.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.UC.Screens
{
    public partial class UCSuppliers : UserControl
    {
        private readonly SupplierService supplierService;
        private int _pageIndex = 1;
        private int _pageSize = 50;
        private int _totalPageIndex = 0;
        private int productId = 0;
        public UCSuppliers()
        {
            InitializeComponent();
            ButtonStyle.GreenButton(btnAddSupplier);
            ButtonStyle.BlueButton(btnEdit);
            ButtonStyle.BlueButton(btnSearch);
            ButtonStyle.WhiteButton(btnRefresh);

            ButtonStyle.BlueButton(btnFirst);
            ButtonStyle.BlueButton(btnPrev);
            ButtonStyle.BlueButton(btnNext);
            ButtonStyle.BlueButton(btnLast);

            supplierService = new SupplierService();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            new frmAddSupplier().ShowDialog();
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
            await supplierService.LoadSupplier(dgvSuppliers, _pageIndex, _pageSize);
            dgvSuppliers.ClearSelection();
            productId = 0;
            int totalRows = await supplierService.GetTotalRowCountAsync();
            _totalPageIndex = (int)Math.Ceiling((double)totalRows / _pageSize);
            lblRecordFound.Text = $"Record Found: {totalRows}";
            lblPage.Text = $"Page {_pageIndex} of {_totalPageIndex}";
            lblTitle.Focus();
            UpdateButtons(_pageIndex, _totalPageIndex);
        }

        private async Task LoadLastPageAsync()
        {
            int totalRows = await supplierService.GetTotalRowCountAsync();
            _totalPageIndex = (int)Math.Ceiling((double)totalRows / _pageSize);
            _pageIndex = _totalPageIndex;
            LoadPageAsync();
        }

        private void UCSuppliers_Load(object sender, EventArgs e)
        {
            LoadPageAsync();
        }

        private void dgvSuppliers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSuppliers.Columns["CreatedAt"].DefaultCellStyle.Format = "d";  // Short date pattern, e.g. 10/12/2025
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

        private async void btnLast_Click(object sender, EventArgs e)
        {
            await LoadLastPageAsync();
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
    }
}
