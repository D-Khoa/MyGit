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
    public partial class frmJobList : Form
    {
        sqlfirst sql = new sqlfirst();
        Storage sto;
        DataTable dt;
        DataTable dt2;

        public frmJobList()
        {
            InitializeComponent();
            sto = Storage.getStorage();
            lbName.Text += sto.name;
            lbID.Text += sto.id;
        }

        private void btnCrePlan_Click(object sender, EventArgs e)
        {
            frmCrePlan fcre = new frmCrePlan();
            fcre.ShowDialog();
        }

        private void btnUpPlan_Click(object sender, EventArgs e)
        {
            sto.plan_name = txtPName.Text;
            sto.plan_id = txtPID.Text;
            if (txtPName.Text == "" && txtPID.Text == "")
                MessageBox.Show("Cần có tên plan hoặc id plan để tiếp tục!!!");
            else
            {
                frmUpPlan fup = new frmUpPlan();
                fup.ShowDialog();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void getTable()
        {
            string cmd;
            string cmd2;
            dt = new DataTable();
            dt2 = new DataTable();
            dgvPlan.Refresh();
            dgvUpLog.Refresh();
            if (txtPID.Text != "" && txtPName.Text != "")
            {
                cmd = "select * from public.m_plan_created where plan_id = '" + txtPID.Text + "' and "
                    + "plan_name = '" + txtPName.Text + "'";
                cmd2 = "select * from public.m_plan_updated where plan_id = '" + txtPID.Text + "' and "
                    + "plan_name = '" + txtPName.Text + "'";
            }
            else if (txtPID.Text != "")
            {
                cmd = "select * from public.m_plan_created where plan_id = '" + txtPID.Text + "'";
                cmd2 = "select * from public.m_plan_updated where plan_id = '" + txtPID.Text + "'";
            }
            else if (txtPName.Text != "")
            {
                cmd = "select * from public.m_plan_created where plan_name = '" + txtPName.Text + "'";
                cmd2 = "select * from public.m_plan_updated where plan_name = '" + txtPName.Text + "'";
            }
            else
            {
                cmd = "select * from public.m_plan_created";
                cmd2 = "select * from public.m_plan_updated";
            }
            sql.datatable(cmd, ref dt);
            sql.datatable(cmd2, ref dt2);
            dgvPlan.DataSource = dt;
            dgvUpLog.DataSource = dt2;
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPID.Text = dgvPlan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPName.Text = dgvPlan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtPName.Text = "";
        }

        private void btnPStt_Click(object sender, EventArgs e)
        {
            sto.stt_tb = "public.m_plan_status";
            frmStt fs = new frmStt();
            fs.Show();
        }

        private void btnIStt_Click(object sender, EventArgs e)
        {
            sto.stt_tb = "public.m_design_status";
            frmStt fs = new frmStt();
            fs.Show();
        }
    }
}
