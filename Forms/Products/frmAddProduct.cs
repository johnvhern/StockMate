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
    public partial class frmAddProduct : MetroForm
    {
        private readonly AddProductService addProductService;
        private int selectedCategory;
        private int selectedSupplier;
        public frmAddProduct()
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnAddProduct);
            ButtonStyle.WhiteButton(btnCancel);
            addProductService = new AddProductService();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            addProductService.LoadCategory(cmbCategory);
            addProductService.LoadSupplier(cmbSupplier);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null)
            {
                selectedCategory = Convert.ToInt32(cmbCategory.SelectedValue);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue != null)
            {
                selectedSupplier = Convert.ToInt32(cmbSupplier.SelectedValue); 
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int reorderlevel = Convert.ToInt32(txtReorderLevel.Text);
            addProductService.AddProduct(txtProductName.Text, txtSKU.Text, selectedCategory, selectedSupplier, quantity, reorderlevel, this);
        }
    }
}
