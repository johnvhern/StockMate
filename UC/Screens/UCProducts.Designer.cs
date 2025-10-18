namespace StockMate.UC.Screens
{
    partial class UCProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblPage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPageSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            lblRecordFound = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnLast = new Syncfusion.WinForms.Controls.SfButton();
            btnNext = new Syncfusion.WinForms.Controls.SfButton();
            btnPrev = new Syncfusion.WinForms.Controls.SfButton();
            btnFirst = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnSearch = new Syncfusion.WinForms.Controls.SfButton();
            btnEdit = new Syncfusion.WinForms.Controls.SfButton();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddProduct = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            lblTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1207, 722);
            gradientPanel1.TabIndex = 1;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.Gainsboro;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Controls.Add(gradientPanel2);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(0, 0);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(20);
            gradientPanel3.Size = new Size(1207, 722);
            gradientPanel3.TabIndex = 1;
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.Gainsboro;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(dgvProducts);
            gradientPanel6.Dock = DockStyle.Fill;
            gradientPanel6.Location = new Point(20, 109);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Padding = new Padding(15);
            gradientPanel6.Size = new Size(1165, 550);
            gradientPanel6.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, SKU, ProductName, CategoryName, SupplierName, Quantity, ReorderLevel, Status, CreatedAt });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.LightGray;
            dgvProducts.Location = new Point(15, 15);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1133, 518);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductId";
            Column1.HeaderText = "ProductId";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // SKU
            // 
            SKU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SKU.DataPropertyName = "SKU";
            dataGridViewCellStyle2.Padding = new Padding(0, 7, 0, 7);
            SKU.DefaultCellStyle = dataGridViewCellStyle2;
            SKU.HeaderText = "SKU";
            SKU.Name = "SKU";
            SKU.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Supplier";
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "ReorderLevel";
            ReorderLevel.Name = "ReorderLevel";
            ReorderLevel.ReadOnly = true;
            ReorderLevel.Visible = false;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "Created At";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderStyle = BorderStyle.None;
            gradientPanel5.Controls.Add(lblPage);
            gradientPanel5.Controls.Add(txtPageSize);
            gradientPanel5.Controls.Add(lblRecordFound);
            gradientPanel5.Controls.Add(btnLast);
            gradientPanel5.Controls.Add(btnNext);
            gradientPanel5.Controls.Add(btnPrev);
            gradientPanel5.Controls.Add(btnFirst);
            gradientPanel5.Dock = DockStyle.Bottom;
            gradientPanel5.Location = new Point(20, 659);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Size = new Size(1165, 41);
            gradientPanel5.TabIndex = 1;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.AutoSize = false;
            lblPage.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(335, 24);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(402, 17);
            lblPage.TabIndex = 6;
            lblPage.Text = "Page 1 of 1";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPageSize
            // 
            txtPageSize.AccessibilityEnabled = true;
            txtPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPageSize.BeforeTouchSize = new Size(238, 16);
            txtPageSize.BorderColor = Color.DimGray;
            txtPageSize.BorderStyle = BorderStyle.FixedSingle;
            txtPageSize.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPageSize.IntegerValue = 50L;
            txtPageSize.Location = new Point(1024, 19);
            txtPageSize.Name = "txtPageSize";
            txtPageSize.Size = new Size(51, 22);
            txtPageSize.TabIndex = 5;
            txtPageSize.Text = "50";
            txtPageSize.TextAlign = HorizontalAlignment.Center;
            txtPageSize.KeyDown += txtPageSize_KeyDown;
            // 
            // lblRecordFound
            // 
            lblRecordFound.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordFound.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordFound.Location = new Point(0, 24);
            lblRecordFound.Name = "lblRecordFound";
            lblRecordFound.Size = new Size(98, 17);
            lblRecordFound.TabIndex = 4;
            lblRecordFound.Text = "Record Found: 1";
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Segoe UI Semibold", 9F);
            btnLast.ImageSize = new Size(16, 16);
            btnLast.Location = new Point(1126, 19);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(39, 22);
            btnLast.Style.Image = Properties.Resources.chevron_last;
            btnLast.TabIndex = 3;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI Semibold", 9F);
            btnNext.ImageSize = new Size(16, 16);
            btnNext.Location = new Point(1081, 19);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 22);
            btnNext.Style.Image = Properties.Resources.chevron_right;
            btnNext.TabIndex = 2;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.Font = new Font("Segoe UI Semibold", 9F);
            btnPrev.ImageSize = new Size(16, 16);
            btnPrev.Location = new Point(979, 19);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(39, 22);
            btnPrev.Style.Image = Properties.Resources.chevron_left;
            btnPrev.TabIndex = 1;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirst.Font = new Font("Segoe UI Semibold", 9F);
            btnFirst.ImageSize = new Size(16, 16);
            btnFirst.Location = new Point(934, 19);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(39, 22);
            btnFirst.Style.Image = Properties.Resources.chevron_first;
            btnFirst.TabIndex = 0;
            btnFirst.Click += btnFirst_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnSearch);
            gradientPanel2.Controls.Add(btnEdit);
            gradientPanel2.Controls.Add(btnRefresh);
            gradientPanel2.Controls.Add(btnAddProduct);
            gradientPanel2.Controls.Add(gradientPanel4);
            gradientPanel2.Controls.Add(lblTitle);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1165, 89);
            gradientPanel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ImageSize = new Size(16, 16);
            btnSearch.Location = new Point(1092, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ImageSize = new Size(16, 16);
            btnEdit.Location = new Point(81, 37);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 36);
            btnEdit.Style.Image = Properties.Resources.square_pen__3_;
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ImageSize = new Size(16, 16);
            btnRefresh.Location = new Point(162, 37);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 36);
            btnRefresh.Style.Image = Properties.Resources.refresh_ccw;
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ImageSize = new Size(16, 16);
            btnAddProduct.Location = new Point(0, 37);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 36);
            btnAddProduct.Style.Image = Properties.Resources.plus__3_;
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "New";
            btnAddProduct.TextAlign = ContentAlignment.MiddleRight;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gradientPanel4.BorderColor = Color.Gainsboro;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(textBoxExt1);
            gradientPanel4.Controls.Add(pictureBox1);
            gradientPanel4.Location = new Point(814, 37);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(272, 36);
            gradientPanel4.TabIndex = 1;
            // 
            // textBoxExt1
            // 
            bannerTextInfo1.Text = "Search products...";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo1);
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
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(43, 48, 59);
            lblTitle.Location = new Point(-6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Products";
            // 
            // UCProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            DoubleBuffered = true;
            Name = "UCProducts";
            Size = new Size(1207, 722);
            Load += UCProducts_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTitle;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.Controls.SfButton btnAddProduct;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private DataGridView dgvProducts;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.WinForms.Controls.SfButton btnLast;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
        private Syncfusion.WinForms.Controls.SfButton btnPrev;
        private Syncfusion.WinForms.Controls.SfButton btnFirst;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblRecordFound;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtPageSize;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPage;
        private Syncfusion.WinForms.Controls.SfButton btnEdit;
        private Syncfusion.WinForms.Controls.SfButton btnSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}
