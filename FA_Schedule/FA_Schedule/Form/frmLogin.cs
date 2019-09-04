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
        //string cmbsql = "select user_name, pass, pic_id from m_user";

        public frmLogin()
        {
            InitializeComponent();
            sql.getComboBoxData("select user_name from m_user", ref cmbUserID);
            cmbUserID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pass;
                string id;
                pass = sql.sqlExecuteScalarString("select pass from m_user where user_name = '"
                    + cmbUserID.Text + "'");
                id = sql.sqlExecuteScalarString("select pic_id from m_user where user_name = '"
                    + cmbUserID.Text + "'");
                if (txtPass.Text == pass)
                {
                    Storage sto = Storage.getStorage();
                    sto.name = cmbUserID.Text;
                    sto.id = id;
                    frmJobList frmJob = new frmJobList();
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
