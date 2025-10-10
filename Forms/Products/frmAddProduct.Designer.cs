namespace StockMate.Forms.Products
{
    partial class frmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            const int SC_MOVE = 0xF010; // Move command
            const int WM_EXITSIZEMOVE = 0x0232; // Event when dragging stops

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return; // Ignore the double-click event on the title bar
            }

            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtProductName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtSKU = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cmbCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cmbSupplier = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtQuantity = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtReorderLevel = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnAddProduct = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtProductName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSKU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).BeginInit();
            gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel9).BeginInit();
            gradientPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtReorderLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15, 0, 15, 5);
            gradientPanel1.Size = new Size(399, 492);
            gradientPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel4);
            flowLayoutPanel1.Controls.Add(gradientPanel5);
            flowLayoutPanel1.Controls.Add(autoLabel5);
            flowLayoutPanel1.Controls.Add(gradientPanel6);
            flowLayoutPanel1.Controls.Add(autoLabel6);
            flowLayoutPanel1.Controls.Add(gradientPanel7);
            flowLayoutPanel1.Controls.Add(autoLabel7);
            flowLayoutPanel1.Controls.Add(gradientPanel8);
            flowLayoutPanel1.Controls.Add(autoLabel8);
            flowLayoutPanel1.Controls.Add(gradientPanel9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(369, 382);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel3.Location = new Point(13, 15);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(90, 17);
            autoLabel3.TabIndex = 0;
            autoLabel3.Text = "Product Name";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.Silver;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtProductName);
            gradientPanel4.Location = new Point(13, 37);
            gradientPanel4.Margin = new Padding(3, 5, 3, 3);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(6, 6, 6, 3);
            gradientPanel4.Size = new Size(342, 30);
            gradientPanel4.TabIndex = 1;
            // 
            // txtProductName
            // 
            bannerTextInfo1.Text = "Enter product name...";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(txtProductName, bannerTextInfo1);
            txtProductName.BeforeTouchSize = new Size(250, 16);
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(6, 6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(328, 16);
            txtProductName.TabIndex = 0;
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel4.Location = new Point(13, 75);
            autoLabel4.Margin = new Padding(3, 5, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(33, 17);
            autoLabel4.TabIndex = 2;
            autoLabel4.Text = "SKU";
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.Silver;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(txtSKU);
            gradientPanel5.Location = new Point(13, 97);
            gradientPanel5.Margin = new Padding(3, 5, 3, 3);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(6, 6, 6, 3);
            gradientPanel5.Size = new Size(342, 30);
            gradientPanel5.TabIndex = 3;
            // 
            // txtSKU
            // 
            bannerTextInfo2.Text = "Optional";
            bannerTextInfo2.Visible = true;
            bannerTextProvider1.SetBannerText(txtSKU, bannerTextInfo2);
            txtSKU.BeforeTouchSize = new Size(250, 16);
            txtSKU.BorderStyle = BorderStyle.None;
            txtSKU.Dock = DockStyle.Fill;
            txtSKU.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(6, 6);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(328, 16);
            txtSKU.TabIndex = 0;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel5.Location = new Point(13, 135);
            autoLabel5.Margin = new Padding(3, 5, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(62, 17);
            autoLabel5.TabIndex = 4;
            autoLabel5.Text = "Category";
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.Silver;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(cmbCategory);
            gradientPanel6.Location = new Point(13, 157);
            gradientPanel6.Margin = new Padding(3, 5, 3, 3);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(342, 30);
            gradientPanel6.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.AllowDropDownResize = false;
            cmbCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategory.AutoCompleteSuggestDelay = 200;
            cmbCategory.BackColor = Color.White;
            cmbCategory.BorderStyle = BorderStyle.None;
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbCategory.Font = new Font("Inter", 9.75F);
            cmbCategory.Location = new Point(0, 0);
            cmbCategory.Margin = new Padding(0);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(340, 28);
            cmbCategory.Style.EditorStyle.BackColor = Color.White;
            cmbCategory.Style.EditorStyle.Font = new Font("Inter", 9.75F);
            cmbCategory.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            cmbCategory.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F);
            cmbCategory.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cmbCategory.Style.TokenStyle.Font = new Font("Inter", 9.75F);
            cmbCategory.TabIndex = 0;
            cmbCategory.TabStop = false;
            cmbCategory.Text = "Select Category";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel6.Location = new Point(13, 195);
            autoLabel6.Margin = new Padding(3, 5, 3, 0);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(55, 17);
            autoLabel6.TabIndex = 6;
            autoLabel6.Text = "Supplier";
            // 
            // gradientPanel7
            // 
            gradientPanel7.BorderColor = Color.Silver;
            gradientPanel7.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel7.Controls.Add(cmbSupplier);
            gradientPanel7.Location = new Point(13, 217);
            gradientPanel7.Margin = new Padding(3, 5, 3, 3);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Size = new Size(342, 30);
            gradientPanel7.TabIndex = 7;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AllowDropDownResize = false;
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSupplier.AutoCompleteSuggestDelay = 200;
            cmbSupplier.BackColor = Color.White;
            cmbSupplier.BorderStyle = BorderStyle.None;
            cmbSupplier.Dock = DockStyle.Fill;
            cmbSupplier.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbSupplier.Font = new Font("Inter", 9.75F);
            cmbSupplier.Location = new Point(0, 0);
            cmbSupplier.Margin = new Padding(0);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(340, 28);
            cmbSupplier.Style.EditorStyle.BackColor = Color.White;
            cmbSupplier.Style.EditorStyle.Font = new Font("Inter", 9.75F);
            cmbSupplier.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            cmbSupplier.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F);
            cmbSupplier.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cmbSupplier.Style.TokenStyle.Font = new Font("Inter", 9.75F);
            cmbSupplier.TabIndex = 1;
            cmbSupplier.TabStop = false;
            cmbSupplier.Text = "Select Supplier";
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // autoLabel7
            // 
            autoLabel7.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel7.Location = new Point(13, 255);
            autoLabel7.Margin = new Padding(3, 5, 3, 0);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(56, 17);
            autoLabel7.TabIndex = 8;
            autoLabel7.Text = "Quantity";
            // 
            // gradientPanel8
            // 
            gradientPanel8.BorderColor = Color.Silver;
            gradientPanel8.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel8.Controls.Add(txtQuantity);
            gradientPanel8.Location = new Point(13, 277);
            gradientPanel8.Margin = new Padding(3, 5, 3, 3);
            gradientPanel8.Name = "gradientPanel8";
            gradientPanel8.Padding = new Padding(6, 6, 6, 3);
            gradientPanel8.Size = new Size(342, 30);
            gradientPanel8.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.AccessibilityEnabled = true;
            txtQuantity.BeforeTouchSize = new Size(250, 16);
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.IntegerValue = 1L;
            txtQuantity.Location = new Point(6, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(328, 16);
            txtQuantity.TabIndex = 0;
            txtQuantity.Text = "1";
            // 
            // autoLabel8
            // 
            autoLabel8.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel8.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel8.Location = new Point(13, 315);
            autoLabel8.Margin = new Padding(3, 5, 3, 0);
            autoLabel8.Name = "autoLabel8";
            autoLabel8.Size = new Size(88, 17);
            autoLabel8.TabIndex = 10;
            autoLabel8.Text = "Reorder Level";
            // 
            // gradientPanel9
            // 
            gradientPanel9.BorderColor = Color.Silver;
            gradientPanel9.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel9.Controls.Add(txtReorderLevel);
            gradientPanel9.Location = new Point(13, 337);
            gradientPanel9.Margin = new Padding(3, 5, 3, 3);
            gradientPanel9.Name = "gradientPanel9";
            gradientPanel9.Padding = new Padding(6, 6, 6, 3);
            gradientPanel9.Size = new Size(342, 30);
            gradientPanel9.TabIndex = 11;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.AccessibilityEnabled = true;
            txtReorderLevel.BeforeTouchSize = new Size(250, 16);
            txtReorderLevel.BorderStyle = BorderStyle.None;
            txtReorderLevel.Dock = DockStyle.Fill;
            txtReorderLevel.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorderLevel.IntegerValue = 1L;
            txtReorderLevel.Location = new Point(6, 6);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(328, 16);
            txtReorderLevel.TabIndex = 1;
            txtReorderLevel.Text = "1";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnCancel);
            gradientPanel2.Controls.Add(btnAddProduct);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(15, 439);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(369, 48);
            gradientPanel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(143, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 38);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(79, 143, 246);
            btnAddProduct.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(245, 6);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(110, 38);
            btnAddProduct.Style.BackColor = Color.FromArgb(79, 143, 246);
            btnAddProduct.Style.ForeColor = Color.White;
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(autoLabel2);
            gradientPanel3.Controls.Add(autoLabel1);
            gradientPanel3.Dock = DockStyle.Top;
            gradientPanel3.Location = new Point(15, 0);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(369, 57);
            gradientPanel3.TabIndex = 3;
            // 
            // autoLabel2
            // 
            autoLabel2.AutoSize = false;
            autoLabel2.Dock = DockStyle.Fill;
            autoLabel2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel2.Location = new Point(0, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(369, 30);
            autoLabel2.TabIndex = 99;
            autoLabel2.Text = "Add New Product";
            autoLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Bottom;
            autoLabel1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.DimGray;
            autoLabel1.Location = new Point(0, 30);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Padding = new Padding(1, 0, 0, 0);
            autoLabel1.Size = new Size(369, 27);
            autoLabel1.TabIndex = 99;
            autoLabel1.Text = "Enter the details of the new product to add to your inventory.";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 492);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddProduct";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtProductName).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSKU).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).EndInit();
            gradientPanel8.ResumeLayout(false);
            gradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel9).EndInit();
            gradientPanel9.ResumeLayout(false);
            gradientPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtReorderLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProductName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSKU;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel9;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnAddProduct;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtQuantity;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtReorderLevel;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCategory;
        private Syncfusion.WinForms.ListView.SfComboBox cmbSupplier;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}