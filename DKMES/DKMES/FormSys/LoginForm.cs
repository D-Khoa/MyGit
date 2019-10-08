using System;
using System.Windows.Forms;
using DKMES.Common;
using System.Collections.Generic;

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
                string passcmd = "select password from m_login_password where user_cd ='" + usercd +
                             "' and password ='" + pass + "'";
                if (!string.IsNullOrEmpty(SQL.sqlExecuteScalarString(passcmd)))
                {
                    this.Hide();
                    txtPassword.Clear();
                    string cmd = "select user_name from m_mes_user where user_cd = '" + usercd + "'";
                    Userdata.GetData().userName = SQL.sqlExecuteScalarString(cmd);
                    cmd = "select registration_user_cd from m_login_password where user_cd = '" + usercd + "'";
                    Userdata.GetData().reg_user = SQL.sqlExecuteScalarString(cmd);
                    cmd = "select factory_cd from m_login_password where user_cd = '" + usercd + "'";
                    Userdata.GetData().factory = SQL.sqlExecuteScalarString(cmd);
                    MainMenuForm mainform = new MainMenuForm();
                    mainform.ShowDialog();
                    this.Show();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
