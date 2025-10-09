namespace StockMate.Forms.Login
{
    partial class frmConnection
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtServer = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnExit = new Syncfusion.WinForms.Controls.SfButton();
            btnSaveConnection = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15, 15, 15, 3);
            gradientPanel1.Size = new Size(311, 330);
            gradientPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel1);
            flowLayoutPanel1.Controls.Add(gradientPanel3);
            flowLayoutPanel1.Controls.Add(autoLabel2);
            flowLayoutPanel1.Controls.Add(gradientPanel6);
            flowLayoutPanel1.Controls.Add(autoLabel5);
            flowLayoutPanel1.Controls.Add(gradientPanel7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 15);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(281, 264);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel3.Location = new Point(13, 15);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(47, 17);
            autoLabel3.TabIndex = 0;
            autoLabel3.Text = "Server";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.Silver;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtServer);
            gradientPanel4.Location = new Point(13, 37);
            gradientPanel4.Margin = new Padding(3, 5, 3, 3);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(6, 6, 6, 3);
            gradientPanel4.Size = new Size(252, 30);
            gradientPanel4.TabIndex = 1;
            // 
            // txtServer
            // 
            txtServer.BeforeTouchSize = new Size(238, 16);
            txtServer.BorderStyle = BorderStyle.None;
            txtServer.Dock = DockStyle.Fill;
            txtServer.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServer.Location = new Point(6, 6);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(238, 16);
            txtServer.TabIndex = 0;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel1.Location = new Point(13, 75);
            autoLabel1.Margin = new Padding(3, 5, 3, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(68, 17);
            autoLabel1.TabIndex = 4;
            autoLabel1.Text = "Username";
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.Silver;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(txtUsername);
            gradientPanel3.Location = new Point(13, 97);
            gradientPanel3.Margin = new Padding(3, 5, 3, 3);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(6, 6, 6, 3);
            gradientPanel3.Size = new Size(252, 30);
            gradientPanel3.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(238, 16);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(6, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 16);
            txtUsername.TabIndex = 0;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel2.Location = new Point(13, 135);
            autoLabel2.Margin = new Padding(3, 5, 3, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(66, 17);
            autoLabel2.TabIndex = 6;
            autoLabel2.Text = "Password";
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.Silver;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(txtPassword);
            gradientPanel6.Location = new Point(13, 157);
            gradientPanel6.Margin = new Padding(3, 5, 3, 3);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Padding = new Padding(6, 6, 6, 3);
            gradientPanel6.Size = new Size(252, 30);
            gradientPanel6.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(238, 16);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 16);
            txtPassword.TabIndex = 0;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(43, 48, 59);
            autoLabel5.Location = new Point(13, 195);
            autoLabel5.Margin = new Padding(3, 5, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(63, 17);
            autoLabel5.TabIndex = 8;
            autoLabel5.Text = "Database";
            // 
            // gradientPanel7
            // 
            gradientPanel7.BorderColor = Color.Silver;
            gradientPanel7.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel7.Controls.Add(txtDatabase);
            gradientPanel7.Location = new Point(13, 217);
            gradientPanel7.Margin = new Padding(3, 5, 3, 3);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Padding = new Padding(6, 6, 6, 3);
            gradientPanel7.Size = new Size(252, 30);
            gradientPanel7.TabIndex = 9;
            // 
            // txtDatabase
            // 
            txtDatabase.BeforeTouchSize = new Size(238, 16);
            txtDatabase.BorderStyle = BorderStyle.None;
            txtDatabase.Dock = DockStyle.Fill;
            txtDatabase.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.Location = new Point(6, 6);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(238, 16);
            txtDatabase.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnExit);
            gradientPanel2.Controls.Add(btnSaveConnection);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(15, 279);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(281, 48);
            gradientPanel2.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(182, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            // 
            // btnSaveConnection
            // 
            btnSaveConnection.BackColor = Color.FromArgb(79, 143, 246);
            btnSaveConnection.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveConnection.ForeColor = Color.White;
            btnSaveConnection.Location = new Point(66, 6);
            btnSaveConnection.Name = "btnSaveConnection";
            btnSaveConnection.Size = new Size(110, 34);
            btnSaveConnection.Style.BackColor = Color.FromArgb(79, 143, 246);
            btnSaveConnection.Style.ForeColor = Color.White;
            btnSaveConnection.TabIndex = 9;
            btnSaveConnection.Text = "Save";
            btnSaveConnection.UseVisualStyleBackColor = false;
            btnSaveConnection.Click += btnSaveConnection_Click;
            // 
            // frmConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Inter Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientSize = new Size(311, 330);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmConnection";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Connection";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtServer;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private Syncfusion.WinForms.Controls.SfButton btnSaveConnection;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDatabase;
    }
}