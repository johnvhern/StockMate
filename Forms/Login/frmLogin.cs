using StockMate.Helpers;
using StockMate.Properties;
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

namespace StockMate.Forms.Login
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnSignIn);
            txtPassword.PasswordChar = '\u25CF';
        }

        private void lblChangeConnection_Click(object sender, EventArgs e)
        {
            new frmConnection().ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                imgShowPass.Visible = true;
            }
            else
            {
                imgShowPass.Visible = false;
            }
        }

        private void imgShowPass_Click(object sender, EventArgs e)
        {
           
        }
    }
}
