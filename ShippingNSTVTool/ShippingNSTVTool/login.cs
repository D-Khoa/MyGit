using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingNSTVTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TfSQL con = new TfSQL();
            string sql = "select distinct user_name from m_user order by user_name";
            con.getComboBoxData(sql, ref cbmname);

            AcceptButton = btnlogin;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (cbmname.Text != "")
            {
                TfSQL con = new TfSQL();
                string sqlpass = "select user_pass from m_user where user_name = '" + cbmname.Text + "'";
                //  select user_pass from m_user where user_name = 'dang'
                if (con.sqlExecuteScalarString(sqlpass) == txtpass.Text)
                {
                    Form lt = new MainForm();
                    lt.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Pass is not correct", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("User name is null.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
