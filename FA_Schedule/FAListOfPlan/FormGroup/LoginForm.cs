using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAListOfPlan.Common;

namespace FAListOfPlan.FormGroup
{
    public partial class LoginForm : Form
    {
        TfSQL sql = new TfSQL();
        string id;
        string name;
        string pass;
        string locate;

        public LoginForm()
        {
            InitializeComponent();
            cmbUserID.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sql.getComboBoxData("select distinct userid from user_tbl", ref cmbUserID);
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cmbUserID.Text;
            txtPassword.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pass = sql.sqlExecuteScalarString("select password from user_tbl where userid ='" + id +
                                              "' and password='" + txtPassword.Text + "'");
            if (!string.IsNullOrEmpty(pass))
            {
                txtPassword.Text = string.Empty;
                name = sql.sqlExecuteScalarString("select username from user_tbl where userid='" + id + "'");
                locate = sql.sqlExecuteScalarString("select location from user_tbl where userid='" + id + "'");
                Userdata.getUser().Username = name;
                Userdata.getUser().Location = locate;
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong password!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
