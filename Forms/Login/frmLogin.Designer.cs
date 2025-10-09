namespace StockMate.Forms.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtProductName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnSignIn = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblChangeConnection = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtProductName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel6);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(20, 0, 20, 20);
            gradientPanel1.Size = new Size(516, 212);
            gradientPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel2);
            flowLayoutPanel1.Controls.Add(gradientPanel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(172, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 0, 15, 0);
            flowLayoutPanel1.Size = new Size(324, 133);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel3.Location = new Point(18, 5);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(68, 17);
            autoLabel3.TabIndex = 2;
            autoLabel3.Text = "Username";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.Silver;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtProductName);
            gradientPanel4.Location = new Point(18, 27);
            gradientPanel4.Margin = new Padding(3, 5, 3, 3);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(6, 6, 6, 3);
            gradientPanel4.Size = new Size(287, 30);
            gradientPanel4.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.BeforeTouchSize = new Size(238, 16);
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(6, 6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(273, 16);
            txtProductName.TabIndex = 0;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel2.Location = new Point(18, 65);
            autoLabel2.Margin = new Padding(3, 5, 3, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(66, 17);
            autoLabel2.TabIndex = 4;
            autoLabel2.Text = "Password";
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.Silver;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(textBoxExt1);
            gradientPanel5.Location = new Point(18, 87);
            gradientPanel5.Margin = new Padding(3, 5, 3, 3);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(6, 6, 6, 3);
            gradientPanel5.Size = new Size(287, 30);
            gradientPanel5.TabIndex = 5;
            // 
            // textBoxExt1
            // 
            textBoxExt1.BeforeTouchSize = new Size(238, 16);
            textBoxExt1.BorderStyle = BorderStyle.None;
            textBoxExt1.Dock = DockStyle.Fill;
            textBoxExt1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt1.Location = new Point(6, 6);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(273, 16);
            textBoxExt1.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnSignIn);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(172, 154);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(18, 0, 18, 0);
            gradientPanel3.Size = new Size(324, 38);
            gradientPanel3.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.Dock = DockStyle.Top;
            btnSignIn.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(18, 0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(288, 32);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderStyle = BorderStyle.None;
            gradientPanel6.Controls.Add(autoLabel1);
            gradientPanel6.Controls.Add(pictureBox1);
            gradientPanel6.Dock = DockStyle.Left;
            gradientPanel6.Location = new Point(20, 21);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(152, 171);
            gradientPanel6.TabIndex = 4;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel1.Location = new Point(15, 142);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(112, 27);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "StockMate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(lblChangeConnection);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(20, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(476, 21);
            gradientPanel2.TabIndex = 0;
            // 
            // lblChangeConnection
            // 
            lblChangeConnection.Cursor = Cursors.Hand;
            lblChangeConnection.Dock = DockStyle.Right;
            lblChangeConnection.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChangeConnection.ForeColor = Color.FromArgb(43, 48, 59);
            lblChangeConnection.Location = new Point(342, 0);
            lblChangeConnection.Name = "lblChangeConnection";
            lblChangeConnection.Size = new Size(134, 17);
            lblChangeConnection.TabIndex = 0;
            lblChangeConnection.Text = "| Change Connection |";
            lblChangeConnection.TextAlign = ContentAlignment.MiddleRight;
            lblChangeConnection.Click += lblChangeConnection_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Inter Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientSize = new Size(516, 212);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProductName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.WinForms.Controls.SfButton btnSignIn;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblChangeConnection;
    }
}