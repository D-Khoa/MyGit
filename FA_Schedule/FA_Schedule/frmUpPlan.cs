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
    public partial class frmUpPlan : Form
    {
        sqlfirst sql = new sqlfirst();
        Boolean check;
        public frmUpPlan()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            txtPIC.Text = sto.name;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = "UPDATE public.m_schplan SET pic_id='" + txtPIC.Text + "', date_adjusted='" + dtAdj.Text
                    + "', stt_id='" + numStt.Value.ToString() + "', finish_update=" + check
                    + ", sch_cmt='" + txtCmt.Text + "' WHERE sch_name ='" + txtSchName.Text + "'";
                sql.sqlExecuteNonQ(cmd);
                MessageBox.Show("Đã cập nhật!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinish.CheckState == CheckState.Checked)
            {
                check = true;
            }
            else
                check = false;
        }
    }
}