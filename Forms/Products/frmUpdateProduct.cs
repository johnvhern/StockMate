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

namespace StockMate.Forms.Products
{
    public partial class frmUpdateProduct : MetroForm
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnUpdateProduct);
            ButtonStyle.BlueButton(btnCancel);
        }
    }
}
