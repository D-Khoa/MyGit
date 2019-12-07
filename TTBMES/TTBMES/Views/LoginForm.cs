using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TTBMES.Models;

namespace TTBMES.Views
{
    public partial class LoginForm : Form
    {
        TfSQL SQL = new TfSQL();
        StringBuilder cmd = new StringBuilder();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserData.GetUserData().AppName = AppName_lbl.Text;
            Username_txt.Focus();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cmd.Clear();
            cmd.Append("select a.user_name, b.factory_cd from m_mes_user a left join m_login_password b ");
            cmd.Append("on a.user_cd = b.user_cd ");
            cmd.Append("where b.user_cd ='").Append(Username_txt.Text);
            cmd.Append("' and b.password ='").Append(Password_txt.Text.Encrypt()).Append("' ");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                UserData.GetUserData().UserCode = Username_txt.Text;
                UserData.GetUserData().UserName = dt.Rows[0]["user_name"].ToString();
                UserData.GetUserData().FactoryCode = dt.Rows[0]["factory_cd"].ToString();
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Username_txt.Focus();
            Password_txt.Clear();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
