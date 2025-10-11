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
    }
}
