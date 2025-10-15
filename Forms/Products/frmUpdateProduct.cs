using StockMate.Helpers;
using StockMate.Models;
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
        private int selectedProduct;
        private int selectedCategory;
        private int selectedSupplier;
        public frmUpdateProduct(int selectedProduct)
        {
            InitializeComponent();
            ButtonStyle.BlueButton(btnUpdateProduct);
            ButtonStyle.WhiteButton(btnCancel);

            productService = new ProductService();
            this.selectedProduct = selectedProduct;
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            productService.LoadSupplier(cmbSupplier);
            productService.LoadCategory(cmbCategory);
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            ProductDetails product = productService.GetProductDetails(selectedProduct);
            if (product != null)
            {
                txtSKU.Text = product.SKU;
                txtProductName.Text = product.ProductName;
                cmbCategory.SelectedValue = product.CategoryId;
                cmbSupplier.SelectedValue = product.SupplierId;
                txtReorderLevel.Text = product.ReorderLevel.ToString();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
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

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int reorderlevel = Convert.ToInt32(txtReorderLevel.Text);
            productService.UpdateProduct(selectedProduct ,txtProductName.Text, txtSKU.Text, selectedCategory, selectedSupplier, reorderlevel, this);
        }
    }
}
