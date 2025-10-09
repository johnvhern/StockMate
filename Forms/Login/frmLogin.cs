using StockMate.Helpers;
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
        }

        private void lblChangeConnection_Click(object sender, EventArgs e)
        {
            new frmConnection().ShowDialog();
        }
    }
}
