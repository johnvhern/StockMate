namespace StockMate.UC.Screens
{
    partial class UCSuppliers
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            btnAddProduct = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvProducts = new DataGridView();
            SupplierId = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            ContactPerson = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MobileNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnAddSupplier = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBox2 = new PictureBox();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxExt1
            // 
            bannerTextInfo1.Text = "Search products...";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo1);
            textBoxExt1.BeforeTouchSize = new Size(328, 16);
            textBoxExt1.BorderStyle = BorderStyle.None;
            textBoxExt1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt1.Location = new Point(29, 9);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(238, 16);
            textBoxExt1.TabIndex = 1;
            // 
            // textBoxExt2
            // 
            bannerTextInfo2.Text = "Search suppliers...";
            bannerTextInfo2.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt2, bannerTextInfo2);
            textBoxExt2.BeforeTouchSize = new Size(328, 16);
            textBoxExt2.BorderStyle = BorderStyle.None;
            textBoxExt2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt2.Location = new Point(29, 9);
            textBoxExt2.Name = "textBoxExt2";
            textBoxExt2.Size = new Size(238, 16);
            textBoxExt2.TabIndex = 1;
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
            btnAddProduct.Location = new Point(1873, 8);
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
            gradientPanel4.Location = new Point(1595, 8);
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
            gradientPanel5.Size = new Size(1090, 505);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { SupplierId, SupplierName, ContactPerson, Email, MobileNumber, Address, CreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.LightGray;
            dgvProducts.Location = new Point(15, 15);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1058, 473);
            dgvProducts.TabIndex = 0;
            // 
            // SupplierId
            // 
            SupplierId.DataPropertyName = "SupplierId";
            SupplierId.HeaderText = "Supplier Id";
            SupplierId.Name = "SupplierId";
            SupplierId.ReadOnly = true;
            SupplierId.Visible = false;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.HeaderText = "Supplier";
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // ContactPerson
            // 
            ContactPerson.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContactPerson.HeaderText = "Contact Person";
            ContactPerson.Name = "ContactPerson";
            ContactPerson.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // MobileNumber
            // 
            MobileNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MobileNumber.HeaderText = "Mobile Number";
            MobileNumber.Name = "MobileNumber";
            MobileNumber.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
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
            gradientPanel2.Controls.Add(btnAddSupplier);
            gradientPanel2.Controls.Add(gradientPanel6);
            gradientPanel2.Controls.Add(btnAddProduct);
            gradientPanel2.Controls.Add(gradientPanel4);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1090, 61);
            gradientPanel2.TabIndex = 0;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddSupplier.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ImageSize = new Size(16, 16);
            btnAddSupplier.Location = new Point(928, 8);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(162, 36);
            btnAddSupplier.Style.Image = Properties.Resources.plus__3_;
            btnAddSupplier.TabIndex = 4;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.TextAlign = ContentAlignment.MiddleRight;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // gradientPanel6
            // 
            gradientPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gradientPanel6.BorderColor = Color.Gainsboro;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(textBoxExt2);
            gradientPanel6.Controls.Add(pictureBox2);
            gradientPanel6.Location = new Point(650, 8);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(272, 36);
            gradientPanel6.TabIndex = 3;
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
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoLabel1.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            autoLabel1.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel1.Location = new Point(0, 8);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(112, 30);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Suppliers";
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1132, 608);
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
            gradientPanel3.Size = new Size(1132, 608);
            gradientPanel3.TabIndex = 1;
            // 
            // UCSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCSuppliers";
            Size = new Size(1132, 608);
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
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
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.WinForms.Controls.SfButton btnAddSupplier;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ContactPerson;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MobileNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}
