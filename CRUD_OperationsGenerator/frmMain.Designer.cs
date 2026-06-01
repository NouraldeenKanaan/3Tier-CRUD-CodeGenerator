namespace CRUD_OperationsGenerator
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            panelLeft = new Panel();
            btnAddTable = new Button();
            btnColumnAdd = new Button();
            chkNull = new CheckBox();
            chkPK = new CheckBox();
            lblColType = new Label();
            cbColType = new ComboBox();
            lblColName = new Label();
            txtColName = new TextBox();
            lblColumnBuilderHeader = new Label();
            lblSingularName = new Label();
            txtSingularName = new TextBox();
            lblTableName = new Label();
            txtTableName = new TextBox();
            lblTableConfigHeader = new Label();
            panelRight = new Panel();
            btnClose = new Button();
            btnGenerate = new Button();
            lblGridTitle = new Label();
            dgvColumns = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colPK = new DataGridViewTextBoxColumn();
            colNullable = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Controls.Add(lblHeaderSubtitle);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1333, 115);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblHeaderSubtitle.Location = new Point(35, 65);
            lblHeaderSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(362, 20);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Configure table variables, add columns and generate.";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(32, 18);
            lblHeaderTitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(332, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "CRUD Generation Studio";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(248, 250, 252);
            panelLeft.Controls.Add(btnAddTable);
            panelLeft.Controls.Add(btnColumnAdd);
            panelLeft.Controls.Add(chkNull);
            panelLeft.Controls.Add(chkPK);
            panelLeft.Controls.Add(lblColType);
            panelLeft.Controls.Add(cbColType);
            panelLeft.Controls.Add(lblColName);
            panelLeft.Controls.Add(txtColName);
            panelLeft.Controls.Add(lblColumnBuilderHeader);
            panelLeft.Controls.Add(lblSingularName);
            panelLeft.Controls.Add(txtSingularName);
            panelLeft.Controls.Add(lblTableName);
            panelLeft.Controls.Add(txtTableName);
            panelLeft.Controls.Add(lblTableConfigHeader);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 115);
            panelLeft.Margin = new Padding(4, 5, 4, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(453, 808);
            panelLeft.TabIndex = 1;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = Color.FromArgb(37, 99, 235);
            btnAddTable.Cursor = Cursors.Hand;
            btnAddTable.FlatAppearance.BorderSize = 0;
            btnAddTable.FlatStyle = FlatStyle.Flat;
            btnAddTable.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTable.ForeColor = Color.White;
            btnAddTable.Location = new Point(33, 281);
            btnAddTable.Margin = new Padding(4, 5, 4, 5);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(378, 43);
            btnAddTable.TabIndex = 13;
            btnAddTable.Text = "+ Add Table";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // btnColumnAdd
            // 
            btnColumnAdd.BackColor = Color.FromArgb(37, 99, 235);
            btnColumnAdd.Cursor = Cursors.Hand;
            btnColumnAdd.Enabled = false;
            btnColumnAdd.FlatAppearance.BorderSize = 0;
            btnColumnAdd.FlatStyle = FlatStyle.Flat;
            btnColumnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColumnAdd.ForeColor = Color.White;
            btnColumnAdd.Location = new Point(39, 680);
            btnColumnAdd.Margin = new Padding(4, 5, 4, 5);
            btnColumnAdd.Name = "btnColumnAdd";
            btnColumnAdd.Size = new Size(373, 55);
            btnColumnAdd.TabIndex = 12;
            btnColumnAdd.Text = "+ Add Column";
            btnColumnAdd.UseVisualStyleBackColor = false;
            btnColumnAdd.Click += btnColumnAdd_Click;
            // 
            // chkNull
            // 
            chkNull.AutoSize = true;
            chkNull.Enabled = false;
            chkNull.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNull.ForeColor = Color.FromArgb(71, 85, 105);
            chkNull.Location = new Point(227, 608);
            chkNull.Margin = new Padding(4, 5, 4, 5);
            chkNull.Name = "chkNull";
            chkNull.Size = new Size(60, 24);
            chkNull.TabIndex = 11;
            chkNull.Text = "Null";
            chkNull.UseVisualStyleBackColor = true;
            // 
            // chkPK
            // 
            chkPK.AutoSize = true;
            chkPK.Checked = true;
            chkPK.CheckState = CheckState.Checked;
            chkPK.Enabled = false;
            chkPK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkPK.ForeColor = Color.FromArgb(71, 85, 105);
            chkPK.Location = new Point(40, 608);
            chkPK.Margin = new Padding(4, 5, 4, 5);
            chkPK.Name = "chkPK";
            chkPK.Size = new Size(117, 24);
            chkPK.TabIndex = 10;
            chkPK.Text = "Primary Key";
            chkPK.UseVisualStyleBackColor = true;
            // 
            // lblColType
            // 
            lblColType.AutoSize = true;
            lblColType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColType.ForeColor = Color.FromArgb(71, 85, 105);
            lblColType.Location = new Point(35, 500);
            lblColType.Margin = new Padding(4, 0, 4, 0);
            lblColType.Name = "lblColType";
            lblColType.Size = new Size(76, 20);
            lblColType.TabIndex = 8;
            lblColType.Text = "Data Type";
            // 
            // cbColType
            // 
            cbColType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColType.Enabled = false;
            cbColType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbColType.FormattingEnabled = true;
            cbColType.Items.AddRange(new object[] { "string", "byte", "short", "int", "long", "float", "double", "decimal", "DateTime", "bool" });
            cbColType.Location = new Point(39, 531);
            cbColType.Margin = new Padding(4, 5, 4, 5);
            cbColType.Name = "cbColType";
            cbColType.Size = new Size(372, 31);
            cbColType.TabIndex = 9;
            // 
            // lblColName
            // 
            lblColName.AutoSize = true;
            lblColName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColName.ForeColor = Color.FromArgb(71, 85, 105);
            lblColName.Location = new Point(35, 400);
            lblColName.Margin = new Padding(4, 0, 4, 0);
            lblColName.Name = "lblColName";
            lblColName.Size = new Size(104, 20);
            lblColName.TabIndex = 6;
            lblColName.Text = "Column Name";
            // 
            // txtColName
            // 
            txtColName.Enabled = false;
            txtColName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColName.Location = new Point(39, 431);
            txtColName.Margin = new Padding(4, 5, 4, 5);
            txtColName.Name = "txtColName";
            txtColName.Size = new Size(372, 30);
            txtColName.TabIndex = 7;
            // 
            // lblColumnBuilderHeader
            // 
            lblColumnBuilderHeader.AutoSize = true;
            lblColumnBuilderHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColumnBuilderHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblColumnBuilderHeader.Location = new Point(33, 346);
            lblColumnBuilderHeader.Margin = new Padding(4, 0, 4, 0);
            lblColumnBuilderHeader.Name = "lblColumnBuilderHeader";
            lblColumnBuilderHeader.Size = new Size(151, 25);
            lblColumnBuilderHeader.TabIndex = 5;
            lblColumnBuilderHeader.Text = "Column Builder";
            // 
            // lblSingularName
            // 
            lblSingularName.AutoSize = true;
            lblSingularName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSingularName.ForeColor = Color.FromArgb(71, 85, 105);
            lblSingularName.Location = new Point(35, 200);
            lblSingularName.Margin = new Padding(4, 0, 4, 0);
            lblSingularName.Name = "lblSingularName";
            lblSingularName.Size = new Size(146, 20);
            lblSingularName.TabIndex = 3;
            lblSingularName.Text = "Singular Table Name";
            // 
            // txtSingularName
            // 
            txtSingularName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSingularName.Location = new Point(39, 231);
            txtSingularName.Margin = new Padding(4, 5, 4, 5);
            txtSingularName.Name = "txtSingularName";
            txtSingularName.Size = new Size(372, 30);
            txtSingularName.TabIndex = 4;
            txtSingularName.Validating += txtSingularName_Validating;
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTableName.ForeColor = Color.FromArgb(71, 85, 105);
            lblTableName.Location = new Point(35, 100);
            lblTableName.Margin = new Padding(4, 0, 4, 0);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(88, 20);
            lblTableName.TabIndex = 1;
            lblTableName.Text = "Table Name";
            // 
            // txtTableName
            // 
            txtTableName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTableName.Location = new Point(39, 131);
            txtTableName.Margin = new Padding(4, 5, 4, 5);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(372, 30);
            txtTableName.TabIndex = 2;
            txtTableName.Validating += txtTableName_Validating;
            // 
            // lblTableConfigHeader
            // 
            lblTableConfigHeader.AutoSize = true;
            lblTableConfigHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableConfigHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblTableConfigHeader.Location = new Point(33, 46);
            lblTableConfigHeader.Margin = new Padding(4, 0, 4, 0);
            lblTableConfigHeader.Name = "lblTableConfigHeader";
            lblTableConfigHeader.Size = new Size(189, 25);
            lblTableConfigHeader.TabIndex = 0;
            lblTableConfigHeader.Text = "Table Configuration";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnClose);
            panelRight.Controls.Add(btnGenerate);
            panelRight.Controls.Add(lblGridTitle);
            panelRight.Controls.Add(dgvColumns);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(453, 115);
            panelRight.Margin = new Padding(4, 5, 4, 5);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(33, 38, 33, 38);
            panelRight.Size = new Size(880, 808);
            panelRight.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(108, 680);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(320, 77);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerate.BackColor = Color.FromArgb(16, 185, 129);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Enabled = false;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(482, 680);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(320, 77);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Code";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblGridTitle.Location = new Point(28, 40);
            lblGridTitle.Margin = new Padding(4, 0, 4, 0);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(163, 28);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Column Schema";
            // 
            // dgvColumns
            // 
            dgvColumns.AllowUserToAddRows = false;
            dgvColumns.AllowUserToResizeRows = false;
            dgvColumns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvColumns.BackgroundColor = Color.White;
            dgvColumns.BorderStyle = BorderStyle.None;
            dgvColumns.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvColumns.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvColumns.ColumnHeadersHeight = 36;
            dgvColumns.Columns.AddRange(new DataGridViewColumn[] { colName, colType, colPK, colNullable });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(29, 78, 216);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvColumns.DefaultCellStyle = dataGridViewCellStyle2;
            dgvColumns.EnableHeadersVisualStyles = false;
            dgvColumns.GridColor = Color.FromArgb(226, 232, 240);
            dgvColumns.Location = new Point(33, 94);
            dgvColumns.Margin = new Padding(4, 5, 4, 5);
            dgvColumns.MultiSelect = false;
            dgvColumns.Name = "dgvColumns";
            dgvColumns.ReadOnly = true;
            dgvColumns.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvColumns.RowHeadersVisible = false;
            dgvColumns.RowHeadersWidth = 51;
            dgvColumns.RowTemplate.Height = 38;
            dgvColumns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColumns.Size = new Size(813, 554);
            dgvColumns.TabIndex = 1;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Column Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Data Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.ReadOnly = true;
            colType.Width = 150;
            // 
            // colPK
            // 
            colPK.HeaderText = "PK";
            colPK.MinimumWidth = 6;
            colPK.Name = "colPK";
            colPK.ReadOnly = true;
            colPK.Width = 80;
            // 
            // colNullable
            // 
            colNullable.HeaderText = "Nullable";
            colNullable.MinimumWidth = 6;
            colNullable.Name = "colNullable";
            colNullable.ReadOnly = true;
            colNullable.Width = 125;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 923);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1261, 867);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schema definition & CRUD Generator";
            Load += frmMain_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTableConfigHeader;
        private System.Windows.Forms.Label lblSingularName;
        private System.Windows.Forms.TextBox txtSingularName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblColumnBuilderHeader;
        private System.Windows.Forms.Label lblColType;
        private System.Windows.Forms.ComboBox cbColType;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.CheckBox chkNull;
        private System.Windows.Forms.CheckBox chkPK;
        private System.Windows.Forms.Button btnColumnAdd;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNullable;
        private Button btnClose;
        private Button btnAddTable;
        private ErrorProvider errorProvider1;
    }
}