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

namespace StockMate.Forms.Login
{
    public partial class frmConnection : MetroForm
    {
        ChangeConnectionService changeConnectionService = new ChangeConnectionService();
        public frmConnection()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnSaveConnection);
            ButtonStyle.WhiteButton(btnExit);
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            changeConnectionService.SaveConnection(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
        }
    }
}
