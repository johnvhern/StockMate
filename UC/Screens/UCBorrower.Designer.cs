namespace StockMate.UC.Screens
{
    partial class UCBorrower
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvSuppliers = new DataGridView();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnSearch = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            btnEdit = new Syncfusion.WinForms.Controls.SfButton();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddBorrower = new Syncfusion.WinForms.Controls.SfButton();
            lblTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblPage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPageSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            lblRecordFound = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnLast = new Syncfusion.WinForms.Controls.SfButton();
            btnNext = new Syncfusion.WinForms.Controls.SfButton();
            btnPrev = new Syncfusion.WinForms.Controls.SfButton();
            btnFirst = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderColor = Color.Gainsboro;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(gradientPanel4);
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(20);
            gradientPanel1.Size = new Size(1207, 722);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.Gainsboro;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(dgvSuppliers);
            gradientPanel4.Dock = DockStyle.Fill;
            gradientPanel4.Location = new Point(20, 109);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(15);
            gradientPanel4.Size = new Size(1165, 543);
            gradientPanel4.TabIndex = 2;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.AllowUserToResizeRows = false;
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dgvSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 48, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(79, 143, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.GridColor = Color.LightGray;
            dgvSuppliers.Location = new Point(15, 15);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(1133, 511);
            dgvSuppliers.TabIndex = 2;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnSearch);
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Controls.Add(btnEdit);
            gradientPanel3.Controls.Add(btnRefresh);
            gradientPanel3.Controls.Add(btnAddBorrower);
            gradientPanel3.Controls.Add(lblTitle);
            gradientPanel3.Dock = DockStyle.Top;
            gradientPanel3.Location = new Point(20, 20);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(1165, 89);
            gradientPanel3.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ImageSize = new Size(16, 16);
            btnSearch.Location = new Point(1092, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 36);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
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
            gradientPanel5.TabIndex = 15;
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
            // btnEdit
            // 
            btnEdit.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ImageSize = new Size(16, 16);
            btnEdit.Location = new Point(81, 37);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 36);
            btnEdit.Style.Image = Properties.Resources.square_pen__3_;
            btnEdit.TabIndex = 14;
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
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddBorrower
            // 
            btnAddBorrower.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBorrower.ImageSize = new Size(16, 16);
            btnAddBorrower.Location = new Point(0, 37);
            btnAddBorrower.Name = "btnAddBorrower";
            btnAddBorrower.Size = new Size(75, 36);
            btnAddBorrower.Style.Image = Properties.Resources.plus__3_;
            btnAddBorrower.TabIndex = 12;
            btnAddBorrower.Text = "New";
            btnAddBorrower.TextAlign = ContentAlignment.MiddleRight;
            btnAddBorrower.Click += btnAddBorrower_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(43, 48, 59);
            lblTitle.Location = new Point(-6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 30);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Borrowers";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(lblPage);
            gradientPanel2.Controls.Add(txtPageSize);
            gradientPanel2.Controls.Add(lblRecordFound);
            gradientPanel2.Controls.Add(btnLast);
            gradientPanel2.Controls.Add(btnNext);
            gradientPanel2.Controls.Add(btnPrev);
            gradientPanel2.Controls.Add(btnFirst);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(20, 652);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1165, 48);
            gradientPanel2.TabIndex = 0;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.AutoSize = false;
            lblPage.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(337, 31);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(404, 17);
            lblPage.TabIndex = 20;
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
            txtPageSize.TabIndex = 19;
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
            lblRecordFound.TabIndex = 18;
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
            btnLast.TabIndex = 17;
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
            btnNext.TabIndex = 16;
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
            btnPrev.TabIndex = 15;
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
            btnFirst.TabIndex = 14;
            // 
            // UCBorrower
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCBorrower";
            Size = new Size(1207, 722);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.WinForms.Controls.SfButton btnEdit;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.WinForms.Controls.SfButton btnAddBorrower;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTitle;
        private Syncfusion.WinForms.Controls.SfButton btnSearch;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
        private DataGridView dgvSuppliers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPage;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtPageSize;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblRecordFound;
        private Syncfusion.WinForms.Controls.SfButton btnLast;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
        private Syncfusion.WinForms.Controls.SfButton btnPrev;
        private Syncfusion.WinForms.Controls.SfButton btnFirst;
    }
}
