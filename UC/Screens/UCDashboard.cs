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
        private readonly ProductService productService= new ProductService();
        private readonly SupplierService supplierService = new SupplierService();
        public UCDashboard()
        {
            InitializeComponent();
            ButtonStyle.DashboardQuickActionBtn(btnAddBorrower);
            ButtonStyle.DashboardQuickActionBtn(btnAddProduct);
            ButtonStyle.DashboardQuickActionBtn(btnAddSupplier);
            ButtonStyle.DashboardQuickActionBtn(btnViewReports);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (new frmAddProduct().ShowDialog() == DialogResult.OK)
            {
                loadCounts();
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (new frmAddSupplier().ShowDialog() == DialogResult.OK)
            {
                loadCounts();
            }
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {

        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            loadCounts();
        }

        private void loadCounts()
        {
            int totalProducts = productService.GetTotalRowCountAsync();
            int totalSupplier = supplierService.GetTotalRowCountAsync();

            txtTotalProducts.Text = totalProducts.ToString();
            txtTotalSupplier.Text = totalSupplier.ToString();
        }
    }
}
