using System;
using System.Windows.Forms;
using DKMES.Common;

namespace DKMES.FormSys
{
    public partial class LoginForm : Form
    {
        TfSQL SQL = new TfSQL();

        public LoginForm()
        {
            InitializeComponent();
            SQL.strConnection = Properties.Settings.Default.MESDB_CONNECTION;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string cmd = "select distinct user_cd from m_mes_user order by user_cd";
            SQL.getComboBoxData(cmd, ref cmbUserCD, true);
            cmbUserCD.Focus();
        }

        private void cmbUserCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                EncryptDecrypt encrypt = new EncryptDecrypt();
                string pass = txtPassword.Text;
                pass = encrypt.Encrypt(pass);

                string usercd = cmbUserCD.Text;
                string cmd = "select password from m_login_password where user_cd ='" + usercd +
                             "' and password ='" + pass + "'";
                if (!string.IsNullOrEmpty(SQL.sqlExecuteScalarString(cmd)))
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password!!!");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Input password!!!");
                txtPassword.Focus();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
