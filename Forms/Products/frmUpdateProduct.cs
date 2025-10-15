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
                cmbSupplier.SelectedValue= product.SupplierId;
                txtReorderLevel.Text = product.ReorderLevel.ToString();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }
}
