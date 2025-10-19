using StockMate.Helpers;
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

namespace StockMate.Forms.Borrowers
{
    public partial class frmAddBorrower : MetroForm
    {
        private readonly BorrowerService borrowerService;
        public frmAddBorrower()
        {
            InitializeComponent();

            ButtonStyle.WhiteButton(btnCancel);
            ButtonStyle.BlueButton(btnAddBorrower);

            borrowerService = new BorrowerService();
        }

        private void frmAddBorrower_Load(object sender, EventArgs e)
        {
            borrowerService.LoadDepartment(cmbDepartment);
            borrowerService.LoadProducts(cmbProduct);
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            int selectedDepartment = (int)cmbDepartment.SelectedValue;
            int selectedProduct = (int)cmbProduct.SelectedValue;
            borrowerService.AddBorrower(selectedDepartment, txtBorrowerName.Text, selectedProduct, Convert.ToInt32(txtQuantity.Text), this);
        }
    }
}
