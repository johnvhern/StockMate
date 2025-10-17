using StockMate.Helpers;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.Forms.Suppliers
{
    public partial class frmAddSupplier : MetroForm
    {
        public frmAddSupplier()
        {
            InitializeComponent();
            ButtonStyle.WhiteButton(btnCancel);
            ButtonStyle.BlueButton(btnAddSupplier);
        }

        public class PhoneNumberValidator
        {
            // C# verbatim string for the regex pattern
            private const string PhilippinePhoneRegex = @"^((\+63|0)9\d{9}|(\+63|0)?\d{2}[-.\s]?\d{7}|(\+63|0)?2[-.\s]?\d{8})$";

            public static bool IsValidPhilippinePhoneNumber(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }

                // Remove all optional separators before validation to simplify the check
                string normalizedInput = Regex.Replace(input, @"[-.\s]", "");

                // Check against the regex pattern
                return Regex.IsMatch(normalizedInput, PhilippinePhoneRegex);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (!PhoneNumberValidator.IsValidPhilippinePhoneNumber(txtMobileNumber.Text))
            {
                txtMobileNumber.Focus();
                MessageBoxAdv.Show("Please enter a valid Philippine mobile or landline number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
