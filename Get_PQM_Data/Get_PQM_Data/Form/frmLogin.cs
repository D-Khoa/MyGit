using System;
using System.Windows.Forms;

namespace Get_PQM_Data
{
    public partial class frmLogin : Form
    {
        TfSQL sql;

        public frmLogin()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            sto.name = "usrdb";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            sql = new TfSQL();
            sql.getComboBoxData("select userid from usertbl", ref cmbUserID);
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
                    txtPass.Text = "";
                    cmbUserID.Focus();
                    Storage sto = Storage.getStorage();
                    sto.id = cmbUserID.Text;
                    frmMain frmJob = new frmMain();
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
