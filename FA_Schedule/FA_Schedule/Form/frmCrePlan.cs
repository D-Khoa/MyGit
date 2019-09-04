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
    public partial class frmCrePlan : Form
    {
        sqlfirst sql = new sqlfirst();
        public frmCrePlan()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            txtPIC.Text = sto.name;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCre_Click(object sender, EventArgs e)
        {
            string cmd;
            try
            {
                cmd = "insert into public.m_schplan(sch_name, model, pic_id, date_create, date_original, stt_id, sch_cmt) values('"
                    + txtSchName.Text + "','" + txtModel.Text + "','" + txtPIC.Text + "','" + dtCre.Text + "','"
                    + dtOri.Text + "','" + numStt.Value.ToString() + "','" + txtCmt.Text + "')";
                sql.sqlExecuteNonQ(cmd);
                MessageBox.Show("Đã tạo plan thành công!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
