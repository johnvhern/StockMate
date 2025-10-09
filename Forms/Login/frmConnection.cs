using StockMate.Helpers;
using StockMate.Properties;
using StockMate.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.Forms.Login
{
    public partial class frmConnection : MetroForm
    {
        private bool isPasswordVisible = false;
        ChangeConnectionService changeConnectionService = new ChangeConnectionService();
        public frmConnection()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnSaveConnection);
            ButtonStyle.WhiteButton(btnExit);
            txtPassword.PasswordChar = '●';
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            changeConnectionService.SaveConnection(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            string connStr = Properties.Settings.Default.ConnectionString;

            if (!string.IsNullOrEmpty(connStr))
            {
                var builder = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(connStr);

                txtServer.Text = builder.DataSource;
                txtDatabase.Text = builder.InitialCatalog;
                txtUsername.Text = builder.UserID;
                txtPassword.Text = builder.Password;
            }
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
    }
}
