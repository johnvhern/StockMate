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

namespace StockMate.Forms.Products
{
    public partial class frmUpdateProduct : MetroForm
    {
        private readonly ProductService productService;
        public frmUpdateProduct()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnUpdateProduct);
            ButtonStyle.WhiteButton(btnCancel);

            productService = new ProductService();
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            productService.LoadSupplier(cmbSupplier);
            productService.LoadCategory(cmbCategory);
        }
    }
}
