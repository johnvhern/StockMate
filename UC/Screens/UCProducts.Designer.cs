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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnAddProduct = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Controls.Add(gradientPanel2);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(0, 0);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(20);
            gradientPanel3.Size = new Size(1207, 722);
            gradientPanel3.TabIndex = 1;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.Gainsboro;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(dataGridView1);
            gradientPanel5.Dock = DockStyle.Fill;
            gradientPanel5.Location = new Point(20, 81);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(15);
            gradientPanel5.Size = new Size(1165, 619);
            gradientPanel5.TabIndex = 1;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnAddProduct);
            gradientPanel2.Controls.Add(gradientPanel4);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1165, 61);
            gradientPanel2.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ImageSize = new Size(16, 16);
            btnAddProduct.Location = new Point(1003, 8);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(162, 36);
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
            gradientPanel4.Location = new Point(725, 8);
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
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoLabel1.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            autoLabel1.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel1.Location = new Point(0, 8);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(213, 30);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Products Inventory";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(15, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1133, 587);
            dataGridView1.TabIndex = 0;
            // 
            // UCProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCProducts";
            Size = new Size(1207, 722);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.Controls.SfButton btnAddProduct;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private DataGridView dataGridView1;
    }
}
