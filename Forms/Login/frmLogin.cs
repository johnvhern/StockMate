using StockMate.Helpers;
using StockMate.Properties;
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

namespace StockMate.Forms.Login
{
    public partial class frmLogin : MetroForm
    {
        private bool isPasswordVisible = false;
        private LoginService loginService = new LoginService();
        public frmLogin()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnSignIn);
            txtPassword.PasswordChar = '●';
        }

        private void lblChangeConnection_Click(object sender, EventArgs e)
        {
            new frmConnection().ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
                imgShowPass.Visible = true;
            else
                imgShowPass.Visible = false;
        }

        private void imgShowPass_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '●';
                imgShowPass.Image = Resources.eye_password;
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                imgShowPass.Image = Resources.eye_off_password;
                isPasswordVisible = true;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            loginService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim(), this);
        }
    }
}
