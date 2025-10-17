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
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnSearch = new Syncfusion.WinForms.Controls.SfButton();
            btnEdit = new Syncfusion.WinForms.Controls.SfButton();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddSupplier = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            lblTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblPage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPageSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            lblRecordFound = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnLast = new Syncfusion.WinForms.Controls.SfButton();
            btnNext = new Syncfusion.WinForms.Controls.SfButton();
            btnPrev = new Syncfusion.WinForms.Controls.SfButton();
            btnFirst = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderColor = Color.Gainsboro;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Controls.Add(gradientPanel4);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(20);
            gradientPanel1.Size = new Size(1207, 722);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.Gainsboro;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(20, 109);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(15);
            gradientPanel3.Size = new Size(1165, 543);
            gradientPanel3.TabIndex = 5;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnSearch);
            gradientPanel2.Controls.Add(btnEdit);
            gradientPanel2.Controls.Add(btnRefresh);
            gradientPanel2.Controls.Add(btnAddSupplier);
            gradientPanel2.Controls.Add(gradientPanel5);
            gradientPanel2.Controls.Add(lblTitle);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1165, 89);
            gradientPanel2.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ImageSize = new Size(16, 16);
            btnSearch.Location = new Point(1092, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 36);
            btnSearch.TabIndex = 11;
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
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ImageSize = new Size(16, 16);
            btnRefresh.Location = new Point(162, 37);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 36);
            btnRefresh.Style.Image = Properties.Resources.refresh_ccw;
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ImageSize = new Size(16, 16);
            btnAddSupplier.Location = new Point(0, 37);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(75, 36);
            btnAddSupplier.Style.Image = Properties.Resources.plus__3_;
            btnAddSupplier.TabIndex = 8;
            btnAddSupplier.Text = "New";
            btnAddSupplier.TextAlign = ContentAlignment.MiddleRight;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // gradientPanel5
            // 
            gradientPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gradientPanel5.BorderColor = Color.Gainsboro;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(textBoxExt1);
            gradientPanel5.Controls.Add(pictureBox1);
            gradientPanel5.Location = new Point(814, 37);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Size = new Size(272, 36);
            gradientPanel5.TabIndex = 7;
            // 
            // textBoxExt1
            // 
            textBoxExt1.BeforeTouchSize = new Size(51, 22);
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
            lblTitle.Size = new Size(112, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Suppliers";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderStyle = BorderStyle.None;
            gradientPanel4.Controls.Add(lblPage);
            gradientPanel4.Controls.Add(txtPageSize);
            gradientPanel4.Controls.Add(lblRecordFound);
            gradientPanel4.Controls.Add(btnLast);
            gradientPanel4.Controls.Add(btnNext);
            gradientPanel4.Controls.Add(btnPrev);
            gradientPanel4.Controls.Add(btnFirst);
            gradientPanel4.Dock = DockStyle.Bottom;
            gradientPanel4.Location = new Point(20, 652);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(1165, 48);
            gradientPanel4.TabIndex = 3;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.AutoSize = false;
            lblPage.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(337, 31);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(404, 17);
            lblPage.TabIndex = 13;
            lblPage.Text = "Page 1 of 1";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPageSize
            // 
            txtPageSize.AccessibilityEnabled = true;
            txtPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPageSize.BeforeTouchSize = new Size(51, 22);
            txtPageSize.BorderColor = Color.DimGray;
            txtPageSize.BorderStyle = BorderStyle.FixedSingle;
            txtPageSize.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPageSize.IntegerValue = 50L;
            txtPageSize.Location = new Point(1024, 26);
            txtPageSize.Name = "txtPageSize";
            txtPageSize.Size = new Size(51, 22);
            txtPageSize.TabIndex = 12;
            txtPageSize.Text = "50";
            txtPageSize.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordFound
            // 
            lblRecordFound.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordFound.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordFound.Location = new Point(0, 31);
            lblRecordFound.Name = "lblRecordFound";
            lblRecordFound.Size = new Size(98, 17);
            lblRecordFound.TabIndex = 11;
            lblRecordFound.Text = "Record Found: 1";
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Segoe UI Semibold", 9F);
            btnLast.ImageSize = new Size(16, 16);
            btnLast.Location = new Point(1126, 26);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(39, 22);
            btnLast.Style.Image = Properties.Resources.chevron_last;
            btnLast.TabIndex = 10;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI Semibold", 9F);
            btnNext.ImageSize = new Size(16, 16);
            btnNext.Location = new Point(1081, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 22);
            btnNext.Style.Image = Properties.Resources.chevron_right;
            btnNext.TabIndex = 9;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.Font = new Font("Segoe UI Semibold", 9F);
            btnPrev.ImageSize = new Size(16, 16);
            btnPrev.Location = new Point(979, 26);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(39, 22);
            btnPrev.Style.Image = Properties.Resources.chevron_left;
            btnPrev.TabIndex = 8;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirst.Font = new Font("Segoe UI Semibold", 9F);
            btnFirst.ImageSize = new Size(16, 16);
            btnFirst.Location = new Point(934, 26);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(39, 22);
            btnFirst.Style.Image = Properties.Resources.chevron_first;
            btnFirst.TabIndex = 7;
            // 
            // UCSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCSuppliers";
            Size = new Size(1207, 722);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.Controls.SfButton btnSearch;
        private Syncfusion.WinForms.Controls.SfButton btnEdit;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.WinForms.Controls.SfButton btnAddSupplier;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTitle;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPage;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtPageSize;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblRecordFound;
        private Syncfusion.WinForms.Controls.SfButton btnLast;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
        private Syncfusion.WinForms.Controls.SfButton btnPrev;
        private Syncfusion.WinForms.Controls.SfButton btnFirst;
    }
}
