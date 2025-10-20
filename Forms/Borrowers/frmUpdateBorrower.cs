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

namespace StockMate.Forms.Borrowers
{
    public partial class frmUpdateBorrower : MetroForm
    {
        private readonly BorrowerService borrowerService;
        private int borrowerId = 0;
        public frmUpdateBorrower(int borrowerId)
        {
            InitializeComponent();
            borrowerService = new BorrowerService();
            this.borrowerId = borrowerId;
        }

        private void frmUpdateBorrower_Load(object sender, EventArgs e)
        {
            borrowerService.LoadDepartment(cmbDepartment);
            borrowerService.LoadProducts(cmbProduct);
            LoadBorrowerDetails();
        }

        private void LoadBorrowerDetails()
        {
            BorrowerDetails borrower = borrowerService.GetBorrowerDetails(borrowerId);
            if (borrower != null)
            {
                cmbDepartment.SelectedValue = borrower.DepartmentId;
                txtBorrowerName.Text = borrower.BorrowerName;
                cmbProduct.SelectedValue = borrower.ProductId;
                txtQuantity.Text = borrower.Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Borrower not found.");
            }
        }

        private void btnUpdateBorrower_Click(object sender, EventArgs e)
        {
            borrowerService.UpdateBorrower(borrowerId, Convert.ToInt32(txtQuantity.Text), this);
        }
    }
}
