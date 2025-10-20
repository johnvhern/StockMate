namespace StockMate.Forms.Borrowers
{
    partial class frmUpdateBorrower
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
            components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cmbDepartment = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtBorrowerName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cmbProduct = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtQuantity = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnUpdateBorrower = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBorrowerName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).BeginInit();
            gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
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
            gradientPanel1.Size = new Size(399, 375);
            gradientPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel4);
            flowLayoutPanel1.Controls.Add(gradientPanel5);
            flowLayoutPanel1.Controls.Add(autoLabel5);
            flowLayoutPanel1.Controls.Add(gradientPanel6);
            flowLayoutPanel1.Controls.Add(autoLabel7);
            flowLayoutPanel1.Controls.Add(gradientPanel8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(369, 265);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel3.Location = new Point(13, 15);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(76, 17);
            autoLabel3.TabIndex = 0;
            autoLabel3.Text = "Department";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.Silver;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(cmbDepartment);
            gradientPanel4.Location = new Point(13, 37);
            gradientPanel4.Margin = new Padding(3, 5, 3, 3);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(342, 30);
            gradientPanel4.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.AllowDropDownResize = false;
            cmbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDepartment.AutoCompleteSuggestDelay = 200;
            cmbDepartment.BackColor = Color.White;
            cmbDepartment.BorderStyle = BorderStyle.None;
            cmbDepartment.Dock = DockStyle.Fill;
            cmbDepartment.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbDepartment.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            cmbDepartment.Enabled = false;
            cmbDepartment.Font = new Font("Inter", 9.75F);
            cmbDepartment.Location = new Point(0, 0);
            cmbDepartment.Margin = new Padding(0);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(340, 28);
            cmbDepartment.Style.EditorStyle.BackColor = Color.White;
            cmbDepartment.Style.EditorStyle.Font = new Font("Inter", 9.75F);
            cmbDepartment.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            cmbDepartment.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F);
            cmbDepartment.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cmbDepartment.Style.TokenStyle.Font = new Font("Inter", 9.75F);
            cmbDepartment.TabIndex = 0;
            cmbDepartment.Text = "Select Department";
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel4.Location = new Point(13, 75);
            autoLabel4.Margin = new Padding(3, 5, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(42, 17);
            autoLabel4.TabIndex = 2;
            autoLabel4.Text = "Name";
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.Silver;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(txtBorrowerName);
            gradientPanel5.Location = new Point(13, 97);
            gradientPanel5.Margin = new Padding(3, 5, 3, 3);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(6, 6, 6, 3);
            gradientPanel5.Size = new Size(342, 30);
            gradientPanel5.TabIndex = 2;
            // 
            // txtBorrowerName
            // 
            bannerTextInfo1.Text = "Enter borrower's name";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(txtBorrowerName, bannerTextInfo1);
            txtBorrowerName.BeforeTouchSize = new Size(328, 16);
            txtBorrowerName.BorderStyle = BorderStyle.None;
            txtBorrowerName.Dock = DockStyle.Fill;
            txtBorrowerName.Enabled = false;
            txtBorrowerName.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBorrowerName.Location = new Point(6, 6);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(328, 16);
            txtBorrowerName.TabIndex = 0;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel5.Location = new Point(13, 135);
            autoLabel5.Margin = new Padding(3, 5, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(53, 17);
            autoLabel5.TabIndex = 4;
            autoLabel5.Text = "Product";
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.Silver;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(cmbProduct);
            gradientPanel6.Location = new Point(13, 157);
            gradientPanel6.Margin = new Padding(3, 5, 3, 3);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(342, 30);
            gradientPanel6.TabIndex = 3;
            // 
            // cmbProduct
            // 
            cmbProduct.AllowDropDownResize = false;
            cmbProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProduct.AutoCompleteSuggestDelay = 200;
            cmbProduct.BackColor = Color.White;
            cmbProduct.BorderStyle = BorderStyle.None;
            cmbProduct.Dock = DockStyle.Fill;
            cmbProduct.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbProduct.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            cmbProduct.Enabled = false;
            cmbProduct.Font = new Font("Inter", 9.75F);
            cmbProduct.Location = new Point(0, 0);
            cmbProduct.Margin = new Padding(0);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(340, 28);
            cmbProduct.Style.EditorStyle.BackColor = Color.White;
            cmbProduct.Style.EditorStyle.Font = new Font("Inter", 9.75F);
            cmbProduct.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            cmbProduct.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F);
            cmbProduct.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cmbProduct.Style.TokenStyle.Font = new Font("Inter", 9.75F);
            cmbProduct.TabIndex = 0;
            cmbProduct.Text = "Select Product";
            // 
            // autoLabel7
            // 
            autoLabel7.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel7.Location = new Point(13, 195);
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
            gradientPanel8.Location = new Point(13, 217);
            gradientPanel8.Margin = new Padding(3, 5, 3, 3);
            gradientPanel8.Name = "gradientPanel8";
            gradientPanel8.Padding = new Padding(6, 6, 6, 3);
            gradientPanel8.Size = new Size(342, 30);
            gradientPanel8.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.AccessibilityEnabled = true;
            txtQuantity.BeforeTouchSize = new Size(328, 16);
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
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnCancel);
            gradientPanel2.Controls.Add(btnUpdateBorrower);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(15, 322);
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
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            // 
            // btnUpdateBorrower
            // 
            btnUpdateBorrower.BackColor = Color.FromArgb(79, 143, 246);
            btnUpdateBorrower.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBorrower.ForeColor = Color.White;
            btnUpdateBorrower.Location = new Point(245, 6);
            btnUpdateBorrower.Name = "btnUpdateBorrower";
            btnUpdateBorrower.Size = new Size(110, 38);
            btnUpdateBorrower.Style.BackColor = Color.FromArgb(79, 143, 246);
            btnUpdateBorrower.Style.ForeColor = Color.White;
            btnUpdateBorrower.TabIndex = 6;
            btnUpdateBorrower.Text = "Update";
            btnUpdateBorrower.UseVisualStyleBackColor = false;
            btnUpdateBorrower.Click += btnUpdateBorrower_Click;
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
            autoLabel2.Text = "Update Borrower";
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
            autoLabel1.Text = "Update the details of the borrower to update your inventory.";
            // 
            // frmUpdateBorrower
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 375);
            Controls.Add(gradientPanel1);
            Name = "frmUpdateBorrower";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmUpdateBorrower_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBorrowerName).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).EndInit();
            gradientPanel8.ResumeLayout(false);
            gradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.ListView.SfComboBox cmbDepartment;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBorrowerName;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProduct;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtQuantity;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateBorrower;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}