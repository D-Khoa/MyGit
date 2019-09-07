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
        Boolean check = false;
        string pname;
        string pid;
        public frmUpPlan()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            pname = sto.plan_name;
            pid = sto.plan_id;
            lbStt.Text = getStt();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd;
                if (!dtAdj.Checked)
                {
                    cmd = "INSERT INTO public.m_plan_updated(plan_id, plan_name, date_update, stt_id,"
                               + " date_adjusted, content, result_update, cmt)"
                               + "VALUES('" + pid + "','" + pname + "','" + DateTime.Now.ToString() + "','"
                               + numStt.Value.ToString() + "','" + dtAdj.Value.ToString() + "','"
                               + txtContent.Text + "','" + check + "','" + txtCmt.Text + "')";
                }
                else
                {
                    cmd = "INSERT INTO public.m_plan_updated(plan_id, plan_name, date_update, stt_id,"
                        + " content, result_update, cmt)"
                        + "VALUES('" + pid + "','" + pname + "','" + DateTime.Now.ToString() + "','"
                        + numStt.Value.ToString() + "','" + txtContent.Text + "','"
                        + check + "','" + txtCmt.Text + "')";
                }
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

        private string getStt()
        {
            string cmd = "select stt_name from public.m_plan_status where stt_id ='" + numStt.Value + "'";
            return sql.sqlExecuteScalarString(cmd);
        }
        private void numStt_ValueChanged(object sender, EventArgs e)
        {
            lbStt.Text = getStt();
        }
    }
}