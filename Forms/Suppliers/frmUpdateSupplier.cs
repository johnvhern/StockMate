using StockMate.Models;
using StockMate.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.Forms.Suppliers
{
    public partial class frmUpdateSupplier : MetroForm
    {
        private readonly SupplierService supplierService;
        private int supplierId;
        public frmUpdateSupplier(int supplierId)
        {
            InitializeComponent();

            supplierService = new SupplierService();
            this.supplierId = supplierId;
        }

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            SupplierDetails supplier = supplierService.GetProductDetails(supplierId);
            if (supplier != null)
            {
                txtSupplierName.Text = supplier.SupplierName;
                txtContactPerson.Text = supplier.ContactPerson;
                txtEmailAddress.Text = supplier.Email;
                txtMobileNumber.Text = supplier.MobileNumber;
                txtAddress.Text = supplier.Address;
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }
}
