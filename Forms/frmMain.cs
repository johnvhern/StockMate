using StockMate.Helpers;
using StockMate.UC.Screens;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.Forms
{
    public partial class frmMain : MetroForm
    {
        private SfButton activeButton;
        private UCDashboard dashboard;
        private UCProducts products;
        private UCSuppliers suppliers;
        private UCBorrower borrower;
        private UCStockAdjustment stockAdjustment;
        private UCSettings settings;
        public frmMain()
        {
            InitializeComponent();
            ButtonStyle.ChildButton(this);
            ColorActiveButton(btnDashboard);

            this.WindowState = FormWindowState.Maximized;

            dashboard = new UCDashboard();
            products = new UCProducts();
            settings = new UCSettings();
            suppliers = new UCSuppliers();
            borrower = new UCBorrower();
            stockAdjustment = new UCStockAdjustment();

            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, screenPanel, new object[] { true });

            this.Text = $"StockMate {Application.ProductVersion}";
        }

        private void ColorActiveButton(SfButton button)
        {
            if (activeButton != null)
            {
                activeButton.Style.BackColor = Color.FromArgb(243, 244, 246);
                activeButton.Style.BackColor = Color.FromArgb(243, 244, 246);
                activeButton.Style.ForeColor = Color.FromArgb(107, 114, 128);
                activeButton.Style.ImageForeColor = Color.FromArgb(107, 114, 128);
            }

            activeButton = button;
            activeButton.Style.BackColor = Color.White;
            activeButton.Style.ForeColor = Color.FromArgb(43, 48, 59);
            activeButton.Style.ImageForeColor = Color.FromArgb(43, 48, 59);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenScreen(new UCDashboard());
        }

        public void OpenScreen(UserControl control)
        {
            screenPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            screenPanel.Controls.Add(control);
            control.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenScreen(dashboard);
            ColorActiveButton(btnDashboard);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenScreen(products);
            ColorActiveButton(btnProducts);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenScreen(suppliers);
            ColorActiveButton(btnSuppliers);
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            OpenScreen(borrower);
            ColorActiveButton(btnBorrowers);
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            OpenScreen(stockAdjustment);
            ColorActiveButton(btnStockAdjustment);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenScreen(settings);
            ColorActiveButton(btnSettings);
        }
    }
}
