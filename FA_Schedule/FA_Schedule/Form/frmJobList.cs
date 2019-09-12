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
        string plancre_tbl = "public.m_plan_created";
        string planup_tbl = "public.m_plan_updated";
        Storage sto;
        DataTable dt;
        bool tab1_select = true;
        bool tab2_select = false;

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
            dgvPlan.Refresh();
            dgvUpLog.Refresh();
            if (tab1_select)
            {
                getTable(ref plancre_tbl, ref dt);
                dgvPlan.DataSource = dt;

            }
            if (tab2_select)
            {
                getTable(ref planup_tbl, ref dt);
                dgvUpLog.DataSource = dt;
            }
        }

        private void getTable(ref string table, ref DataTable dtem)
        {
            dtem = new DataTable();
            string cmd = "select * from " + table + " where 1=1 ";
            if (txtPID.Text != "")
            {
                cmd += "and plan_id = '" + txtPID.Text + "'";
            }
            if (txtPName.Text != "")
            {
                cmd += "and plan_name = '" + txtPName.Text + "'";
            }
            sql.datatable(cmd, ref dtem);
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
            dt.Clear();
            if (tab1_select)
                dgvPlan.DataSource = dt;
            if (tab2_select)
                dgvUpLog.DataSource = dt;
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

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            tab1_select = true;
            tab2_select = false;
            dgvPlan.Refresh();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            tab1_select = false;
            tab2_select = true;
            dgvUpLog.Refresh();
        }
    }
}
