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

        public frmLogin()
        {
            InitializeComponent();
            sql.getComboBoxData("select pic_id from m_user", ref cmbUserID);
            cmbUserID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pass;
                string name;
                pass = sql.sqlExecuteScalarString("select pass from m_user where pic_id = '"
                    + cmbUserID.Text + "'");
                name = sql.sqlExecuteScalarString("select user_name from m_user where pic_id = '"
                    + cmbUserID.Text + "'");
                if (txtPass.Text == pass)
                {
                    Storage sto = Storage.getStorage();
                    sto.name = name;
                    sto.id = cmbUserID.Text;
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
