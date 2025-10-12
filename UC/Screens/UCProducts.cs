using StockMate.Forms.Products;
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
    public partial class UCProducts : UserControl
    {
        private readonly AddProductService addProductService;
        public UCProducts()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnAddProduct);
            dgvProducts.AutoGenerateColumns = false;

            addProductService = new AddProductService();
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();

            if (frmAddProduct.ShowDialog() == DialogResult.OK)
            {
                await addProductService.LoadProducts(dgvProducts);
            }
        }

        private async void UCProducts_Load(object sender, EventArgs e)
        {
            await addProductService.LoadProducts(dgvProducts);
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProducts.Columns["CreatedAt"].DefaultCellStyle.Format = "d";  // Short date pattern, e.g. 10/12/2025
        }
    }
}
