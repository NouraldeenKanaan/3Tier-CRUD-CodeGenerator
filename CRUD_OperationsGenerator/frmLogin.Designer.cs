namespace CRUD_OperationsGenerator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblCreatedBy = new Label();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            panelRight = new Panel();
            lblDatabase = new Label();
            cbDatabase = new ComboBox();
            lblDBMS = new Label();
            cbDBMS = new ComboBox();
            btnLogin = new Button();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 41, 59);
            panelLeft.Controls.Add(lblCreatedBy);
            panelLeft.Controls.Add(lblBrandSubtitle);
            panelLeft.Controls.Add(lblBrandTitle);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 5, 4, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(347, 585);
            panelLeft.TabIndex = 0;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.FromArgb(148, 163, 184);
            lblCreatedBy.Location = new Point(35, 515);
            lblCreatedBy.Margin = new Padding(4, 0, 4, 0);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(210, 19);
            lblCreatedBy.TabIndex = 2;
            lblCreatedBy.Text = "Created by: Nouraldeen Kanaan";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandSubtitle.Location = new Point(35, 269);
            lblBrandSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(267, 77);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Generate structural source code instantly from your database.";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(29, 192);
            lblBrandTitle.Margin = new Padding(4, 0, 4, 0);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(225, 50);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "CRUD GenX";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblDatabase);
            panelRight.Controls.Add(cbDatabase);
            panelRight.Controls.Add(lblDBMS);
            panelRight.Controls.Add(cbDBMS);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(347, 0);
            panelRight.Margin = new Padding(4, 5, 4, 5);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(570, 585);
            panelRight.TabIndex = 1;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatabase.ForeColor = Color.FromArgb(71, 85, 105);
            lblDatabase.Location = new Point(53, 269);
            lblDatabase.Margin = new Padding(4, 0, 4, 0);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(119, 20);
            lblDatabase.TabIndex = 4;
            lblDatabase.Text = "Select Database";
            // 
            // cbDatabase
            // 
            cbDatabase.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDatabase.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDatabase.FormattingEnabled = true;
            cbDatabase.Location = new Point(53, 300);
            cbDatabase.Margin = new Padding(4, 5, 4, 5);
            cbDatabase.Name = "cbDatabase";
            cbDatabase.Size = new Size(479, 31);
            cbDatabase.TabIndex = 5;
            // 
            // lblDBMS
            // 
            lblDBMS.AutoSize = true;
            lblDBMS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBMS.ForeColor = Color.FromArgb(71, 85, 105);
            lblDBMS.Location = new Point(53, 154);
            lblDBMS.Margin = new Padding(4, 0, 4, 0);
            lblDBMS.Name = "lblDBMS";
            lblDBMS.Size = new Size(202, 20);
            lblDBMS.TabIndex = 2;
            lblDBMS.Text = "Database Management Sys.";
            // 
            // cbDBMS
            // 
            cbDBMS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDBMS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDBMS.FormattingEnabled = true;
            cbDBMS.Items.AddRange(new object[] { "Oracle", "Microsoft SQL Server", "MySQL", "PostgreSQL" });
            cbDBMS.Location = new Point(53, 185);
            cbDBMS.Margin = new Padding(4, 5, 4, 5);
            cbDBMS.Name = "cbDBMS";
            cbDBMS.Size = new Size(479, 31);
            cbDBMS.TabIndex = 3;
            cbDBMS.SelectedIndexChanged += cbDBMS_SelectedIndexChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(53, 415);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(480, 69);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Connect && Proceed";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(45, 62);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Database Settings";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 585);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Connection";
            Load += frmDataBaseLoginScreen_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDBMS;
        private System.Windows.Forms.ComboBox cbDBMS;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btnLogin;
    }
}