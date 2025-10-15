using StockMate.Forms.Products;
using StockMate.Helpers;
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
            new frmAddProduct().ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {

        }
    }
}
