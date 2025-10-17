using StockMate.Helpers;
using StockMate.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.Forms.Suppliers
{
    public partial class frmAddSupplier : MetroForm
    {
        private readonly SupplierService supplierService;
        public frmAddSupplier()
        {
            InitializeComponent();
            ButtonStyle.WhiteButton(btnCancel);
            ButtonStyle.BlueButton(btnAddSupplier);

            supplierService = new SupplierService();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            supplierService.AddSupplier(txtSupplierName.Text, txtContactPerson.Text, txtEmailAddress.Text, txtMobileNumber.Text, txtAddress.Text, this);
        }
    }
}
