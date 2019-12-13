using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ConvertAndSendData.Model;

namespace ConvertAndSendData.View
{
    public partial class MainForm : Form
    {
        TfSQL SQL = new TfSQL();
        string cmd;

        public MainForm()
        {
            InitializeComponent();
            dtpDateTo.Value = dtpDateTo.Value.AddDays(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmd = "Select distinct model from modeltbl order by model";
            SQL.getComboBoxData(cmd, ref cmbModel);
            cmbModel.Text = null;
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.Value = dtpDateTo.Value.AddDays(1);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbModel.Text))
            {
                SettingForm stForm = new SettingForm(cmbModel.Text);
                if (stForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (string name in stForm.listprocess)
                    {
                        InspectCell icell = new InspectCell();
                        icell.Name = name;
                        icell.Width = 200;
                        icell.Height = 200;
                        flpnlYeildShow.Controls.Add(icell);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose model first!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEvent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!bwSend.IsBusy)
            {
                btnStop.Enabled = true;
                btnRun.Enabled = false;
                btnSetting.Enabled = false;
                bwSend.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnRun.Enabled = true;
            btnSetting.Enabled = true;
            bwSend.CancelAsync();
        }

        private void bwSend_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwSend_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void SearchEvent()
        {
            DataTable dt = new DataTable();
            foreach (InspectCell cell in flpnlYeildShow.Controls.OfType<InspectCell>())
            {
                dt.Clear();
                cmd = @"select count(*) as input, count(case when tjudge = '0' then 1 end) as output 
                        from lav10c201912 where process = '" + cell.Name + "'";
                SQL.sqlDataAdapterFillDatatable(cmd, ref dt);
                cell.input = dt.Rows[0]["input"].ToString();
                cell.output = dt.Rows[0]["output"].ToString();
            }
        }
    }
}
