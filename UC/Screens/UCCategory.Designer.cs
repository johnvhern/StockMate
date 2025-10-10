namespace StockMate.UC.Screens
{
    partial class UCCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo5 = new Syncfusion.Windows.Forms.BannerTextInfo();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            btnAddProduct = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvProducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxExt1
            // 
            bannerTextInfo4.Text = "Search products...";
            bannerTextInfo4.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo4);
            textBoxExt1.BeforeTouchSize = new Size(238, 16);
            textBoxExt1.BorderStyle = BorderStyle.None;
            textBoxExt1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt1.Location = new Point(29, 9);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(238, 16);
            textBoxExt1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search__3_;
            pictureBox1.Location = new Point(7, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ImageSize = new Size(16, 16);
            btnAddProduct.Location = new Point(1948, 8);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(162, 21);
            btnAddProduct.Style.Image = Properties.Resources.plus__3_;
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gradientPanel4.BorderColor = Color.Gainsboro;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(textBoxExt1);
            gradientPanel4.Controls.Add(pictureBox1);
            gradientPanel4.Location = new Point(1670, 8);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(272, 21);
            gradientPanel4.TabIndex = 1;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.Gainsboro;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(dgvProducts);
            gradientPanel5.Dock = DockStyle.Fill;
            gradientPanel5.Location = new Point(20, 81);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(15);
            gradientPanel5.Size = new Size(1165, 619);
            gradientPanel5.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle5.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, SKU, ProductName, CategoryName, SupplierName, Quantity, ReorderLevel, CreatedAt });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(15);
            dataGridViewCellStyle6.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.LightGray;
            dgvProducts.Location = new Point(15, 15);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1133, 587);
            dgvProducts.TabIndex = 0;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Product Id";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // SKU
            // 
            SKU.DataPropertyName = "SKU";
            SKU.HeaderText = "SKU";
            SKU.Name = "SKU";
            SKU.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Supplier";
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "Reorder Level";
            ReorderLevel.Name = "ReorderLevel";
            ReorderLevel.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "Created At";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(sfButton1);
            gradientPanel2.Controls.Add(gradientPanel6);
            gradientPanel2.Controls.Add(btnAddProduct);
            gradientPanel2.Controls.Add(gradientPanel4);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1165, 61);
            gradientPanel2.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1207, 722);
            gradientPanel1.TabIndex = 2;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.Gainsboro;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Controls.Add(gradientPanel2);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(0, 0);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(20);
            gradientPanel3.Size = new Size(1207, 722);
            gradientPanel3.TabIndex = 1;
            // 
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoLabel1.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            autoLabel1.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel1.Location = new Point(0, 8);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(110, 30);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Category";
            // 
            // sfButton1
            // 
            sfButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sfButton1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfButton1.ImageSize = new Size(16, 16);
            sfButton1.Location = new Point(1003, 8);
            sfButton1.Name = "sfButton1";
            sfButton1.Size = new Size(162, 36);
            sfButton1.Style.Image = Properties.Resources.plus__3_;
            sfButton1.TabIndex = 4;
            sfButton1.Text = "Add Product";
            sfButton1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel6
            // 
            gradientPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gradientPanel6.BorderColor = Color.Gainsboro;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(textBoxExt2);
            gradientPanel6.Controls.Add(pictureBox2);
            gradientPanel6.Location = new Point(725, 8);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(272, 36);
            gradientPanel6.TabIndex = 3;
            // 
            // textBoxExt2
            // 
            bannerTextInfo5.Text = "Search products...";
            bannerTextInfo5.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt2, bannerTextInfo5);
            textBoxExt2.BeforeTouchSize = new Size(238, 16);
            textBoxExt2.BorderStyle = BorderStyle.None;
            textBoxExt2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt2.Location = new Point(29, 9);
            textBoxExt2.Name = "textBoxExt2";
            textBoxExt2.Size = new Size(238, 16);
            textBoxExt2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search__3_;
            pictureBox2.Location = new Point(7, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // UCCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCCategory";
            Size = new Size(1207, 722);
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
        private Syncfusion.WinForms.Controls.SfButton btnAddProduct;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewTextBoxColumn CreatedAt;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private PictureBox pictureBox2;
    }
}
