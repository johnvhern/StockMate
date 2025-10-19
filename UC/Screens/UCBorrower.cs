using StockMate.Forms.Borrowers;
using StockMate.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.UC.Screens
{
    public partial class UCBorrower : UserControl
    {
        public UCBorrower()
        {
            InitializeComponent();
            ButtonStyle.GreenButton(btnAddBorrower);
            ButtonStyle.BlueButton(btnEdit);
            ButtonStyle.WhiteButton(btnRefresh);

            ButtonStyle.BlueButton(btnSearch);

            ButtonStyle.BlueButton(btnFirst);
            ButtonStyle.BlueButton(btnPrev);
            ButtonStyle.BlueButton(btnNext);
            ButtonStyle.BlueButton(btnLast);
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            new frmAddBorrower().ShowDialog();
        }
    }
}
