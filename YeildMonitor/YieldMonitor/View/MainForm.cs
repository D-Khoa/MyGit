using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using YieldMonitor.Model;
using System.Collections.Generic;

namespace YieldMonitor.View
{
    public partial class MainForm : Form
    {
        int counter;
        string setfile = @"D:\setting.ini";
        List<string> setlist = new List<string>();
        List<string> listTemp = new List<string>();
        List<string> listProcess = new List<string>();
        DateTime datechange = new DateTime();

        public MainForm()
        {
            InitializeComponent();
            dtpDateTo.Value = dtpDateTo.Value.AddDays(1);
            datechange = dtpDateFrom.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetData.GetProcessToList(ref listTemp, cmbModel.Text);
            cmbModel.GetModelToCombobox();
            cmbModel.Text = null;
            if (File.Exists(setfile))
            {
                foreach (string line in File.ReadLines(setfile))
                {
                    if (line.StartsWith("Model ="))
                        cmbModel.Text = (line.Trim().Split('='))[1];
                    if (line.StartsWith("From ="))
                        dtpDateFrom.Value = DateTime.Parse((line.Trim().Split('='))[1]);
                    if (line.StartsWith("To ="))
                        dtpDateTo.Value = DateTime.Parse((line.Trim().Split('='))[1]);
                    if (line.StartsWith("Timer ="))
                        numCounter.Value = decimal.Parse((line.Trim().Split('='))[1]);
                    if (line.StartsWith("Process"))
                    {
                        string name = (line.Trim().Split('='))[1];
                        AddCells(name);
                        listTemp.Remove(name);
                        listProcess.Add(name);
                    }
                }
            }
        }

        #region SUB EVENT
        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateFrom.Value > datechange)
                dtpDateTo.Value = dtpDateTo.Value.AddDays((dtpDateFrom.Value - datechange).TotalDays);
            else
                dtpDateTo.Value = dtpDateTo.Value.AddDays(-(datechange - dtpDateFrom.Value).TotalDays);
            datechange = dtpDateFrom.Value;
        }

        private void cmbModel_TextChanged(object sender, EventArgs e)
        {
            foreach (InspectCell cell in flpnlYeildShow.Controls.OfType<InspectCell>())
            {
                flpnlYeildShow.Controls.Clear();
                listTemp.Clear();
                listProcess.Clear();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnRun.Enabled)
                e.Cancel = true;
            else
            {
                setlist.Add("Model =" + cmbModel.Text);
                setlist.Add("From =" + dtpDateFrom.Value.ToString());
                setlist.Add("To =" + dtpDateTo.Value.ToString());
                setlist.Add("Timer =" + numCounter.Value.ToString());
                int i = 0;
                foreach (InspectCell cell in flpnlYeildShow.Controls.OfType<InspectCell>())
                {
                    i++;
                    setlist.Add("Process " + i + " =" + cell.Name);
                }
                if (!File.Exists(setfile))
                {
                    File.Create(setfile);
                    File.GetAccessControl(setfile);
                }
                File.WriteAllLines(setfile, setlist);
            }
        }
        #endregion

        #region BUTTON SETUP
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (listTemp.Count() == 0 && listProcess.Count() == 0)
                GetData.GetProcessToList(ref listTemp, cmbModel.Text);
            SettingForm stForm = new SettingForm();
            stForm.Model = cmbModel.Text;
            stForm.listTemp = listTemp;
            stForm.listprocess = listProcess;
            if (stForm.ShowDialog() == DialogResult.OK)
            {
                flpnlYeildShow.Controls.Clear();
                listProcess = stForm.listprocess;
                listTemp = stForm.listTemp;
                foreach (string name in stForm.listprocess)
                {
                    AddCells(name);
                }
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
                counter = (int)numCounter.Value;
                bwSend.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bwSend.IsBusy)
            {
                btnStop.Enabled = false;
                btnRun.Enabled = true;
                btnSetting.Enabled = true;
                bwSend.CancelAsync();
            }
        }
        #endregion

        #region BACKGROUND WORKER
        private void bwSend_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = counter; i >= 0; i--)
            {
                Thread.Sleep(1000);
                bwSend.ReportProgress(i);
                if (bwSend.CancellationPending)
                {
                    e.Cancel = true;
                    bwSend.ReportProgress(counter);
                    return;
                }
            }
            bwSend.ReportProgress(0);
        }

        private void bwSend_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsStatus.Text = "Waitting...";
            tsCounter.Text = e.ProgressPercentage.ToString() + " s";
        }

        private void bwSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                tsStatus.Text = "Stopped!!!";
                MessageBox.Show("Stop data syncing!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                tsStatus.Text = "Error!!!";
                MessageBox.Show(e.Error.ToString(), "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SearchEvent();
                bwSend.RunWorkerAsync();
            }
        }
        #endregion

        #region SUB PROGRAM
        private void SearchEvent()
        {
            StringBuilder table = new StringBuilder();
            table.Append(cmbModel.Text).Append(dtpDateFrom.Value.ToString("yyyyMM"));
            if (dtpDateFrom.Value.Month < dtpDateTo.Value.Month)
            {
                for (DateTime date = dtpDateFrom.Value; date <= dtpDateTo.Value; date.AddMonths(1))
                {
                    table.Append(",").Append(cmbModel.Text).Append(date.ToString("yyyyMM"));
                }
            }
            foreach (InspectCell cell in flpnlYeildShow.Controls.OfType<InspectCell>())
            {
                cell.input = GetData.GetInput(cell.Name, table.ToString(), dtpDateFrom.Value, dtpDateTo.Value);
                cell.output = GetData.GetOutput(cell.Name, table.ToString(), dtpDateFrom.Value, dtpDateTo.Value);
                if (cell.input > 0 && cell.output > 0)
                    cell.yeild = cell.output / cell.input;
                else
                    cell.yeild = 0;
                if (cell.yeild >= 0.85)
                    cell.color = Color.LimeGreen;
                else if (cell.yeild >= 0.5 && cell.yeild < 0.85)
                    cell.color = Color.Yellow;
                else if (cell.yeild < 0.5 && cell.input > 0)
                    cell.color = Color.Red;
                else
                    cell.color = Color.Silver;
                cell.lbYeild.Text = (cell.yeild * 100).ToString("0.##") + "%";
            }
        }

        private void AddCells(string name)
        {
            InspectCell icell = new InspectCell();
            icell.Name = name;
            icell.model = cmbModel.Text;
            icell.input = 0;
            icell.output = 0;
            icell.yeild = 0;
            icell.Width = 200;
            icell.Height = 200;
            flpnlYeildShow.Controls.Add(icell);
        }
        #endregion
    }
}
