using StockMate.Forms.Suppliers;
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
    public partial class UCSuppliers : UserControl
    {
        public UCSuppliers()
        {
            InitializeComponent();
            ButtonStyle.GreenButton(btnAddSupplier);
            ButtonStyle.BlueButton(btnEdit);
            ButtonStyle.BlueButton(btnSearch);
            ButtonStyle.WhiteButton(btnRefresh);

            ButtonStyle.BlueButton(btnFirst);
            ButtonStyle.BlueButton(btnPrev);
            ButtonStyle.BlueButton(btnNext);
            ButtonStyle.BlueButton(btnLast);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            new frmAddSupplier().ShowDialog();
        }
    }
}
