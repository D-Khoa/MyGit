using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EndplayGTCheck.Vo;
using EndplayGTCheck.Common;

namespace EndplayGTCheck.FormCommon
{
    public partial class EndplayCheckMainForm : CommonForm
    {
        #region VARIABLE
        EndplayCheckVo Vo = new EndplayCheckVo();
        EndplayCheckVo.Product prod = new EndplayCheckVo.Product();
        TfSQL sql = new TfSQL();
        DataTable prodtable;
        int c;
        string judge;
        string GTinput = string.Empty;
        string Codeinput = string.Empty;
        string[] baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
        #endregion

        #region LOAD SETTING FILE
        public EndplayCheckMainForm()
        {
            InitializeComponent();
            TimerConnect.Enabled = true;
            cmbBaudrateGT.DataSource = baudrate;
            cmbBaudrateGT.SelectedIndex = 3;
            cmbBaudrateCode.DataSource = baudrate;
            cmbBaudrateCode.SelectedIndex = 3;
            prodtable = new DataTable();
            prodtable = prod.GetTable();
            Vo.SetFile = @"\Setting.txt";
            if (File.Exists(Vo.SetFile))
            {
                foreach (string line in File.ReadAllLines(Vo.SetFile))
                {
                    if (line.Contains("model")) prod.Model = line.Remove(0, 6);
                    if (line.Contains("site")) prod.Site = line.Remove(0, 5);
                    if (line.Contains("factory")) prod.Factory = line.Remove(0, 8);
                    if (line.Contains("line")) prod.Line = line.Remove(0, 5);
                    if (line.Contains("process")) prod.Process = line.Remove(0, 8);
                    if (line.Contains("lot")) prod.Lot = line.Remove(0, 4);
                    if (line.Contains("URL")) txtURL.Text = line.Remove(0, 4);
                    if (line.Contains("min")) numMin.Value = decimal.Parse(line.Remove(0, 4));
                    if (line.Contains("max")) numMax.Value = decimal.Parse(line.Remove(0, 4));
                    if (line.Contains("timer")) numTimer.Value = decimal.Parse(line.Remove(0, 6));
                }
                cmbModel.Text = prod.Model;
                cmbSite.Text = prod.Site;
                cmbFact.Text = prod.Factory;
                cmbLine.Text = prod.Line;
                cmbProc.Text = prod.Process;
                txtLot.Text = prod.Lot;
                c = (int)numTimer.Value;
            }
        }
        #endregion

        #region WRITE SETTING FILE
        private void EndplayCheckMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnExit.Enabled)
                e.Cancel = true;
            using (StreamWriter sw = new StreamWriter(Vo.SetFile))
            {
                sw.WriteLine("model=" + prod.Model);
                sw.WriteLine("site=" + prod.Site);
                sw.WriteLine("factory=" + prod.Factory);
                sw.WriteLine("line=" + prod.Line);
                sw.WriteLine("process=" + prod.Process);
                sw.WriteLine("lot=" + prod.Lot);
                sw.WriteLine("URL=" + txtURL.Text);
                sw.WriteLine("min=" + numMin.Value.ToString());
                sw.WriteLine("max=" + numMax.Value.ToString());
                sw.WriteLine("timer=" + numTimer.Value.ToString());
                sw.Close();
            }
        }
        #endregion

        #region SETUP COMBOBOX
        private void EndplayCheckMainForm_Load(object sender, EventArgs e)
        {
            sql.getComboBoxData("select distinct model from processtbl order by model asc", ref cmbModel);
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Model = cmbModel.Text;
            sql.getComboBoxData("select distinct site from processtbl where model = '" + cmbModel.Text + "' order by site asc", ref cmbSite);
            sql.getComboBoxData("select distinct factory from processtbl where model = '" + cmbModel.Text +
                "' order by factory asc", ref cmbFact);
            sql.getComboBoxData("select distinct line from processtbl where model = '" + cmbModel.Text + "' order by line asc", ref cmbLine);
            sql.getComboBoxData("select distinct process from processtbl where model = '" + cmbModel.Text +
                "' order by process asc", ref cmbProc);
        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Site = cmbSite.Text;
        }

        private void cmbFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Factory = cmbFact.Text;
        }

        private void cmbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Line = cmbLine.Text;
        }

        private void cmbProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Process = cmbProc.Text;
        }

        private void txtLot_TextChanged(object sender, EventArgs e)
        {
            prod.Lot = txtLot.Text;
        }

        #endregion

        #region Select Tabpage
        private void btnMeas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabMeas);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Vo.password))
            {
                InputPasswordForm fpass = new InputPasswordForm();
                if (fpass.ShowDialog() == DialogResult.OK)
                {
                    Vo.password = fpass.pass;
                    if (Vo.password == "1111")
                        tabControl1.SelectTab(tabSet);
                    else
                    {
                        MessageBox.Show("Wrong password!!!");
                        return;
                    }
                }
                fpass.Dispose();
            }
            else
                tabControl1.SelectTab(tabSet);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            Vo.password = string.Empty;
            tabControl1.SelectTab(tabMeas);
        }
        #endregion

        #region TIMER UPDATE STATUS
        private void TimerConnect_Tick(object sender, EventArgs e)
        {
            cmbGTCom.DataSource = SerialPort.GetPortNames();
            cmbCodeCom.DataSource = SerialPort.GetPortNames();
            if (!GTPort.IsOpen)
            {
                lbGTst.Text = "Disconnected";
                lbGTst.ForeColor = Color.Yellow;
                lbGTst.BackColor = Color.Red;
            }
            else
            {
                lbGTst.Text = "Connected";
                lbGTst.ForeColor = Color.Yellow;
                lbGTst.BackColor = Color.Green;
            }

            if (!CodePort.IsOpen)
            {
                lbCodest.Text = "Disconnected";
                lbCodest.ForeColor = Color.Yellow;
                lbCodest.BackColor = Color.Red;
            }
            else
            {
                lbCodest.Text = "Connected";
                lbCodest.ForeColor = Color.Yellow;
                lbCodest.BackColor = Color.Green;
            }
        }
        #endregion

        #region SETTING BUTTON (set Vo.SendtoFolder, set c)
        private void btnConnectGT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GTPort.IsOpen)
                {
                    btnConnectGT.Text = "Disconnect";
                    GTPort.PortName = cmbGTCom.Text;
                    GTPort.BaudRate = int.Parse(cmbBaudrateGT.Text);
                    GTPort.Open();
                }
                else
                {
                    btnConnectGT.Text = "Connect";
                    GTPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnConnectGT.Text = "Connect";
                GTPort.Close();
            }
        }

        private void btnConnectCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CodePort.IsOpen)
                {
                    btnConnectCode.Text = "Disconnect";
                    CodePort.PortName = cmbCodeCom.Text;
                    CodePort.BaudRate = int.Parse(cmbBaudrateCode.Text);
                    CodePort.Open();
                }
                else
                {
                    btnConnectCode.Text = "Connect";
                    CodePort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnConnectCode.Text = "Connect";
                CodePort.Close();
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (ofServer.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = Path.GetDirectoryName(ofServer.FileName) + @"\";
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            Vo.SendToFolder = txtURL.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        #endregion

        #region GET DATA INPUT AND SEND TO PROD, TO TABLE
        private void GTPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            GTinput = GTPort.ReadLine();
            if (GTinput != string.Empty)
            {
                if (decimal.Parse(GTinput) > numMax.Value || decimal.Parse(GTinput) < numMin.Value)
                    judge = "1";
                else
                    judge = "0";
            }
            else
                GTinput = "0";
        }

        private void CodePort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Codeinput = CodePort.ReadLine();
            if (Codeinput != string.Empty)
            {
                prod.InputData(Codeinput, GTinput, judge);
                prod.AddRow(ref prodtable);
                dgvData.Invoke(new MethodInvoker(delegate ()
                {
                    dgvData.DataSource = prodtable;
                }));
                SendKeys.SendWait(Codeinput);
            }
        }

        #endregion

        #region BACKGROUND PROCESS SEND DATA TO SERVER
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Vo.SendToFolder))
                MessageBox.Show("Must choose URL for server to continue!");
            else
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                btnExit.Enabled = false;
                numTimer.Enabled = false;
                c = (int)numTimer.Value;
                if (bkwSendData.IsBusy)
                    bkwSendData.CancelAsync();
                else
                    bkwSendData.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bkwSendData.IsBusy)
            {
                btnStart.Enabled = true;
                btnExit.Enabled = true;
                numTimer.Enabled = true;
                btnStop.Enabled = false;
                bkwSendData.CancelAsync();
            }
        }

        private void bkwSendData_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = c; i >= 0; i--)
            {
                Thread.Sleep(1000);
                bkwSendData.ReportProgress(i);
                if (bkwSendData.CancellationPending)
                {
                    e.Cancel = true;
                    bkwSendData.ReportProgress(c);
                    return;
                }
            }
        }

        private void bkwSendData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int p = e.ProgressPercentage;
            tsStatus.Text = "Processing...";
            tsTime.Text = p.ToString() + " s";
        }

        private void bkwSendData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                tsStatus.Text = "Stop send data";
            else if (e.Error != null)
                tsStatus.Text = "Error while sending data";
            else
            {
                tsStatus.Text = "Sending data file...";
                Vo.PathFolder = @"\DataOut\";
                if (!Directory.Exists(Vo.PathFolder))
                    Directory.CreateDirectory(Vo.PathFolder);
                Vo.PathFile = Vo.PathFolder + prod.Model + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                prodtable.ToCSVnoCol(Vo.PathFile);
                Vo.SendToFile = Vo.SendToFolder + prod.Model + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                File.Move(Vo.PathFile, Vo.SendToFile);
                prodtable.Clear();
                dgvData.DataSource = prodtable;
                bkwSendData.RunWorkerAsync();
            }
        }
        #endregion
    }
}
