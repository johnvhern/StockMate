namespace StockMate.Forms
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            screenPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCategory = new Syncfusion.WinForms.Controls.SfButton();
            btnProducts = new Syncfusion.WinForms.Controls.SfButton();
            btnDashboard = new Syncfusion.WinForms.Controls.SfButton();
            btnStockAdjustment = new Syncfusion.WinForms.Controls.SfButton();
            btnBorrowers = new Syncfusion.WinForms.Controls.SfButton();
            btnSuppliers = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screenPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1354, 864);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(screenPanel);
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Controls.Add(gradientPanel4);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(0, 77);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(70, 20, 70, 70);
            gradientPanel3.Size = new Size(1354, 787);
            gradientPanel3.TabIndex = 1;
            // 
            // screenPanel
            // 
            screenPanel.BorderStyle = BorderStyle.None;
            screenPanel.Dock = DockStyle.Fill;
            screenPanel.Location = new Point(70, 83);
            screenPanel.Name = "screenPanel";
            screenPanel.Size = new Size(1214, 634);
            screenPanel.TabIndex = 2;
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderStyle = BorderStyle.None;
            gradientPanel6.Dock = DockStyle.Top;
            gradientPanel6.Location = new Point(70, 63);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(1214, 20);
            gradientPanel6.TabIndex = 1;
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderStyle = BorderStyle.None;
            gradientPanel4.Controls.Add(gradientPanel5);
            gradientPanel4.Dock = DockStyle.Top;
            gradientPanel4.Location = new Point(70, 20);
            gradientPanel4.Margin = new Padding(0);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(1214, 43);
            gradientPanel4.TabIndex = 0;
            // 
            // gradientPanel5
            // 
            gradientPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gradientPanel5.BackColor = Color.FromArgb(243, 244, 246);
            gradientPanel5.BorderStyle = BorderStyle.None;
            gradientPanel5.Controls.Add(tableLayoutPanel1);
            gradientPanel5.Location = new Point(0, 0);
            gradientPanel5.Margin = new Padding(0);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Size = new Size(887, 43);
            gradientPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(btnCategory, 2, 0);
            tableLayoutPanel1.Controls.Add(btnProducts, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel1.Controls.Add(btnStockAdjustment, 5, 0);
            tableLayoutPanel1.Controls.Add(btnBorrowers, 4, 0);
            tableLayoutPanel1.Controls.Add(btnSuppliers, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(887, 43);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Fill;
            btnCategory.Font = new Font("Inter", 9.75F);
            btnCategory.ForeColor = Color.FromArgb(107, 114, 128);
            btnCategory.ImageSize = new Size(16, 16);
            btnCategory.Location = new Point(298, 6);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(140, 31);
            btnCategory.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnCategory.Style.Image = Properties.Resources.list;
            btnCategory.TabIndex = 6;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.MiddleRight;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Fill;
            btnProducts.Font = new Font("Inter", 9.75F);
            btnProducts.ForeColor = Color.FromArgb(107, 114, 128);
            btnProducts.ImageSize = new Size(16, 16);
            btnProducts.Location = new Point(152, 6);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(140, 31);
            btnProducts.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnProducts.Style.Image = Properties.Resources.package;
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleRight;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(107, 114, 128);
            btnDashboard.ImageSize = new Size(16, 16);
            btnDashboard.Location = new Point(6, 6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 31);
            btnDashboard.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnDashboard.Style.Image = Properties.Resources.chart_column;
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStockAdjustment
            // 
            btnStockAdjustment.Dock = DockStyle.Fill;
            btnStockAdjustment.Font = new Font("Inter", 9.75F);
            btnStockAdjustment.ForeColor = Color.FromArgb(107, 114, 128);
            btnStockAdjustment.ImageSize = new Size(16, 16);
            btnStockAdjustment.Location = new Point(736, 6);
            btnStockAdjustment.Name = "btnStockAdjustment";
            btnStockAdjustment.Size = new Size(145, 31);
            btnStockAdjustment.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnStockAdjustment.Style.Image = Properties.Resources.blocks;
            btnStockAdjustment.TabIndex = 4;
            btnStockAdjustment.Text = "Stock Adjustment";
            btnStockAdjustment.TextAlign = ContentAlignment.MiddleRight;
            btnStockAdjustment.Click += btnStockAdjustment_Click;
            // 
            // btnBorrowers
            // 
            btnBorrowers.Dock = DockStyle.Fill;
            btnBorrowers.Font = new Font("Inter", 9.75F);
            btnBorrowers.ForeColor = Color.FromArgb(107, 114, 128);
            btnBorrowers.ImageSize = new Size(16, 16);
            btnBorrowers.Location = new Point(590, 6);
            btnBorrowers.Name = "btnBorrowers";
            btnBorrowers.Size = new Size(140, 31);
            btnBorrowers.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnBorrowers.Style.Image = Properties.Resources.user_check;
            btnBorrowers.TabIndex = 3;
            btnBorrowers.Text = "Borrowers";
            btnBorrowers.TextAlign = ContentAlignment.MiddleRight;
            btnBorrowers.Click += btnBorrowers_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Fill;
            btnSuppliers.Font = new Font("Inter", 9.75F);
            btnSuppliers.ForeColor = Color.FromArgb(107, 114, 128);
            btnSuppliers.ImageSize = new Size(16, 16);
            btnSuppliers.Location = new Point(444, 6);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(140, 31);
            btnSuppliers.Style.ForeColor = Color.FromArgb(107, 114, 128);
            btnSuppliers.Style.Image = Properties.Resources.users__4_;
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleRight;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderColor = Color.Gainsboro;
            gradientPanel2.BorderSides = Border3DSide.Bottom;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(0, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(0, 10, 0, 10);
            gradientPanel2.Size = new Size(1354, 77);
            gradientPanel2.TabIndex = 0;
            // 
            // autoLabel2
            // 
            autoLabel2.AutoSize = false;
            autoLabel2.Dock = DockStyle.Fill;
            autoLabel2.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel2.Location = new Point(0, 10);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Padding = new Padding(70, 0, 0, 0);
            autoLabel2.Size = new Size(1352, 29);
            autoLabel2.TabIndex = 1;
            autoLabel2.Text = "Inventory Management System";
            autoLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Bottom;
            autoLabel1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel1.Location = new Point(0, 39);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Padding = new Padding(71, 0, 0, 0);
            autoLabel1.Size = new Size(1352, 26);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Manage products, suppliers, and loans effortlessly";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1354, 864);
            Controls.Add(gradientPanel1);
            MinimumSize = new Size(1366, 768);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)screenPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnBorrowers;
        private Syncfusion.WinForms.Controls.SfButton btnSuppliers;
        private Syncfusion.WinForms.Controls.SfButton btnProducts;
        private Syncfusion.WinForms.Controls.SfButton btnDashboard;
        private Syncfusion.Windows.Forms.Tools.GradientPanel screenPanel;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.WinForms.Controls.SfButton btnCategory;
        private Syncfusion.WinForms.Controls.SfButton btnStockAdjustment;
    }
}