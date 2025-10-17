using StockMate.Forms.Products;
using StockMate.Forms.Suppliers;
using StockMate.Helpers;
using StockMate.Services;
using Syncfusion.Windows.Forms.Tools;
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
    public partial class UCDashboard : UserControl
    {
        private readonly ProductService productService;
        private readonly SupplierService supplierService;
        public UCDashboard()
        {
            InitializeComponent();
            ButtonStyle.DashboardQuickActionBtn(btnAddBorrower);
            ButtonStyle.DashboardQuickActionBtn(btnAddProduct);
            ButtonStyle.DashboardQuickActionBtn(btnAddSupplier);
            ButtonStyle.DashboardQuickActionBtn(btnViewReports);

            productService = new ProductService();
            supplierService = new SupplierService();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new frmAddProduct().ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            new frmAddSupplier().ShowDialog();
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {

        }

        private async void UCDashboard_Load(object sender, EventArgs e)
        {
            int totalProducts = await productService.GetTotalRowCountAsync();
            int totalSupplier = await supplierService.GetTotalRowCountAsync();

            txtTotalProducts.Text = totalProducts.ToString();
            txtTotalSupplier.Text = totalSupplier.ToString();
        }
    }
}
