using CRUD_OperationsGeneratorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_OperationsGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string Title = $"Datebase: {clsGlobal.DataBaseName}";

            lblGridTitle.Text = Title;
            cbColType.SelectedIndex = 3;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the highlighted validation errors before proceeding.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsGlobal.SingleTableName = txtSingularName.Text;
            clsGlobal.TableName = txtTableName.Text;

            txtSingularName.Enabled = false;
            txtTableName.Enabled = false;
            btnAddTable.Enabled = false;

            txtColName.Enabled = true;
            cbColType.Enabled = true;
            btnGenerate.Enabled = true;
            btnColumnAdd.Enabled = true;
        }

        private void btnColumnAdd_Click(object sender, EventArgs e)
        {
            dgvColumns.Rows.Add(txtColName.Text.Trim(), cbColType.Text.Trim(), chkPK.Checked, chkNull.Checked);

            chkPK.Checked = false;
            chkPK.Enabled = false;
            chkNull.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            clsGlobal.Columns.Clear();

            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                clsGlobal.Columns.Add(new clsColumn(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), (bool)row.Cells[2].Value, (bool)row.Cells[3].Value));
            }

            await clsGenerateCRUD.Generate();

            MessageBox.Show("Layers Generated successfully on your Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool ValidateTextBoxes(TextBox textBox, string fieldDisplayName, CancelEventArgs e)
        {
            string input = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, $"{fieldDisplayName} is required and cannot be empty.");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, string.Empty); // Clears the error visual
                return true;
            }
        }
        private void txtTableName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBoxes(txtTableName, "Table Name", e);
        }
        private void txtSingularName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBoxes(txtSingularName, "Singular Table aName", e);
        }
    }
}
