using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_Schedule
{
    public partial class frmLogin : Form
    {
        sqlfirst sql = new sqlfirst();
        string cmbsql = "select userid, passwd from usertbl";

        public frmLogin()
        {
            InitializeComponent();
            sql.server = "192.168.145.12";
            sql.database = "usrdb";
            sql.getComboBoxData(cmbsql, ref cmbUserID);
            cmbUserID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pass;
                pass = sql.sqlExecuteScalarString("select passwd from usertbl where userid = '"
                    + cmbUserID.Text + "'");
                if (txtPass.Text == pass)
                {
                    frmJobList frmJob = new frmJobList();
                    this.Hide();
                    frmJob.ShowDialog();
                }
                else
                    MessageBox.Show("Sai password!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
