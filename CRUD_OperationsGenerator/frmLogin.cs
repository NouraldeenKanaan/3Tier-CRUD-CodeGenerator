using CRUD_OperationsGeneratorBusiness;


namespace CRUD_OperationsGenerator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private async void frmDataBaseLoginScreen_Load(object sender, EventArgs e)
        {
            cbDBMS.SelectedIndex = 1;

            await _FillComboBox();
        }

        private async Task _FillComboBox()
        {
            List<string> Databases = await clsLoginInfo.GetDatabases();

            cbDatabase.Items.Clear();

            foreach (string database in Databases)
            {
                cbDatabase.Items.Add(database);
            }

            cbDatabase.SelectedIndex = 0;
        }

        private void cbDBMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDBMS.SelectedIndex != 1)
            {
                cbDatabase.Enabled = false;
                btnLogin.Enabled = false;

                MessageBox.Show("This Database Not available now.", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            cbDatabase.Enabled = true;
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.DataBaseName = cbDatabase.Text.Trim(); 

            frmMain frmMain = new frmMain();
            frmMain.FormClosed += (s, args) => this.Close();
            frmMain.Show();

            this.Hide();
        }
    }
}
