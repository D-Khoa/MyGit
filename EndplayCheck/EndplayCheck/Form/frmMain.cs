using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EndplayCheck
{
    public partial class frmMain : Form
    {
        #region Data Input
        string GTinput = String.Empty;
        string BarcodeInput = String.Empty;

        delegate void SetTextCallBack(string text);
        #endregion

        #region Struct Data
        struct BrushPress
        {
            DataTable dt;
            private string serno;
            public string lot;
            public string model;
            public string site;
            public string factory;
            public string line;
            public string process;
            public string inspect;
            private string inspectdate;
            private string inspecttime;
            private string inspectdata;
            private string judge;
            private string status;
            private string remark;

            public void InputData(string barcode, DateTime date, string data, string judge_st)
            {
                serno = barcode;
                process = "BrushpressProc";
                inspect = "BrushpressIns";
                inspectdate = date.ToString("yyyy-MM-dd");
                inspecttime = date.ToString("HH:mm:ss");
                inspectdata = data;
                judge = judge_st;
                status = "";
                remark = "";
            }

            public DataTable ExportToTable()
            {
                dt = new DataTable();
                DataRow dr = dt.NewRow();
                dt.Columns.Add("serno");
                dt.Columns.Add("lot");
                dt.Columns.Add("model");
                dt.Columns.Add("site");
                dt.Columns.Add("factory");
                dt.Columns.Add("line");
                dt.Columns.Add("process");
                dt.Columns.Add("inspect");
                dt.Columns.Add("date");
                dt.Columns.Add("time");
                dt.Columns.Add("inspectdata");
                dt.Columns.Add("judge");
                dt.Columns.Add("status");
                dt.Columns.Add("remark");
                dr[0] = serno;
                dr[1] = lot;
                dr[2] = model;
                dr[3] = site;
                dr[4] = factory;
                dr[5] = line;
                dr[6] = process;
                dr[7] = inspect;
                dr[8] = inspectdate;
                dr[9] = inspecttime;
                dr[10] = inspectdata;
                dr[11] = judge;
                dr[12] = status;
                dr[13] = remark;
                dt.Rows.Add(dr);
                return dt;
            }

            public void ClearTable()
            {
                dt = new DataTable();
                dt.Clear();
            }

            public void ExportToCSV(string path)
            {
                using (StreamWriter wr = new StreamWriter(path))
                {
                    wr.Write("\"");
                    wr.Write(serno);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(lot);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(model);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(site);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(factory);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(line);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(process);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(inspect);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(inspectdate);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(inspecttime);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(inspectdata);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(judge);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(status);
                    wr.Write("\"");
                    wr.Write(",");
                    wr.Write("\"");
                    wr.Write(remark);
                    wr.Write("\"");
                    wr.Write(wr.NewLine);
                    wr.Close();
                }
            }
        }
        #endregion

        #region Variable
        BrushPress DtOut = new BrushPress();

        string settingfold = @"\Setting\";
        string settingpath = @"\Setting\setting.txt";
        List<string> SetList = new List<string>();
        float max = 10;
        float min = 0;
        string fromfile;
        string tofile;
        string svURL;
        #endregion

        #region Setup COM Port & SQL Connection
        public TfSQL sql;

        public frmMain()
        {
            InitializeComponent();
            string[] baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cmbBaudRate.Items.AddRange(baudrate);
            cmbBaudRate.SelectedIndex = 3;
            cmbBaudRate2.Items.AddRange(baudrate);
            cmbBaudRate2.SelectedIndex = 3;
            Storage sto = Storage.getStorage();
            sto.server = "192.168.145.12";
            sto.database = "pqmdb";
            sto.user = "pqm";
            sto.pass = "dbuser";
            sql = new TfSQL();
            if (!Directory.Exists(settingfold))
                Directory.CreateDirectory(settingfold);
            if (!File.Exists(settingpath))
                File.Create(settingpath);
            else
            {
                foreach (string line in File.ReadLines(settingpath))
                {
                    SetList.Add(line);
                }
                if (SetList.Count >= 6)
                {
                    DtOut.model = SetList[0];
                    DtOut.site = SetList[1];
                    DtOut.factory = SetList[2];
                    DtOut.line = SetList[3];
                    DtOut.process = SetList[4];
                    txtURL.Text = SetList[5];
                    cmbModel.Text = DtOut.model;
                    cmbSite.Text = DtOut.site;
                    cmbFact.Text = DtOut.factory;
                    cmbLine.Text = DtOut.line;
                    cmbProc.Text = DtOut.process;
                }
            }
        }
        #endregion

        #region Setup Combobox
        private void frmMain_Load(object sender, EventArgs e)
        {
            sql.getComboBoxData("select distinct model from processtbl order by model asc", ref cmbModel);
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtOut.model = cmbModel.Text;
            sql.getComboBoxData("select distinct site from processtbl where model = '" + cmbModel.Text + "' order by site asc", ref cmbSite);
            sql.getComboBoxData("select distinct factory from processtbl where model = '" + cmbModel.Text +
                "' order by factory asc", ref cmbFact);
            sql.getComboBoxData("select distinct line from processtbl where model = '" + cmbModel.Text + "' order by line asc", ref cmbLine);
            sql.getComboBoxData("select distinct process from processtbl where model = '" + cmbModel.Text +
                "' order by process asc", ref cmbProc);
        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtOut.site = cmbSite.Text;
        }

        private void cmbFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtOut.factory = cmbFact.Text;
        }

        private void cmbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtOut.line = cmbLine.Text;
        }

        private void cmbProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtOut.process = cmbProc.Text;
        }

        private void txtLot_TextChanged(object sender, EventArgs e)
        {
            DtOut.lot = txtLot.Text;
        }

        private void WriteSetFile()
        {
            SetList.Clear();
            SetList.Add(DtOut.model);
            SetList.Add(DtOut.site);
            SetList.Add(DtOut.factory);
            SetList.Add(DtOut.line);
            SetList.Add(DtOut.process);
            SetList.Add(svURL);
            using (StreamWriter sw = new StreamWriter(settingpath))
            {
                foreach (string line in SetList)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
        }
        #endregion

        #region Connection GT2
        private void srGTComp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            GTinput = srGTComp.ReadLine();
            if (GTinput != String.Empty)
            {
                SetText(GTinput);
            }
        }

        private void SetText(string text)
        {
            if (this.lbGTInput.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lbGTInput.Text = text;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!srGTComp.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    srGTComp.PortName = cmbCOM.Text;
                    srGTComp.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    srGTComp.Open();
                }
                else
                {
                    btnConnect.Text = "Connect";
                    srGTComp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnConnect.Text = "Connect";
                srGTComp.Close();
            }
        }
        #endregion

        #region Connection Barcode
        private void srBarcode_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BarcodeInput = srBarcode.ReadLine();
            if (!string.IsNullOrEmpty(BarcodeInput))
            {
                SetText2(BarcodeInput);
                SendKeys.SendWait(BarcodeInput);
            }
        }

        private void SetText2(string text)
        {
            if (this.lbBarcode.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
                lbBarcode.Text = text;
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!srBarcode.IsOpen)
                {
                    btnConnect2.Text = "Disconnect";
                    srBarcode.PortName = cmbCOM2.Text;
                    srBarcode.BaudRate = Convert.ToInt32(cmbBaudRate2.Text);
                    srBarcode.Open();
                }
                else
                {
                    btnConnect2.Text = "Connect";
                    srBarcode.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnConnect2.Text = "Connect";
                srBarcode.Close();
            }
        }
        #endregion

        #region Status Refresh
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            cmbCOM.DataSource = SerialPort.GetPortNames();
            cmbCOM2.DataSource = SerialPort.GetPortNames();
            WriteCSV();

            //STATUS GT PORT
            if (!srGTComp.IsOpen)
            {
                lbST.Text = "Disconnect";
                lbST.BackColor = Color.Red;
            }
            else
            {
                lbST.Text = "Connected";
                lbST.BackColor = Color.Green;
            }
            //STATUS BARCODE PORT
            if (!srBarcode.IsOpen)
            {
                lbST2.Text = "Disconnect";
                lbST2.BackColor = Color.Red;
            }
            else
            {
                lbST2.Text = "Connected";
                lbST2.BackColor = Color.Green;
            }
        }
        #endregion

        #region Choose URL, write CSV and send data
        private void WriteCSV()
        {
            if (!string.IsNullOrEmpty(lbBarcode.Text))
            {
                string judge = "0";
                string path = @"GTDataOut\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                fromfile = path + DtOut.model + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                float data = float.Parse(lbGTInput.Text);
                if ((data > max) || (data < min))
                    judge = "1";
                else judge = "0";
                DtOut.InputData(lbBarcode.Text, DateTime.Now, lbGTInput.Text, judge);
                DtOut.ExportToCSV(fromfile);
                dgvData.DataSource = DtOut.ExportToTable();
                dgvData.Refresh();
                GTinput = "0";
                BarcodeInput = string.Empty;
                SetText2(BarcodeInput);
                SetText(GTinput);
            }
        }

        private void SendData()
        {
            tofile = svURL + DtOut.model + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            if (File.Exists(fromfile))
                File.Move(fromfile, tofile);
            DtOut.ClearTable();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog SVfolder = new OpenFileDialog();
            SVfolder.ValidateNames = false;
            SVfolder.CheckFileExists = false;
            SVfolder.CheckPathExists = false;
            SVfolder.FileName = "Select folder";
            if (SVfolder.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = Path.GetDirectoryName(SVfolder.FileName) + @"\";
                svURL = txtURL.Text;
                WriteSetFile();
            }
        }
        #endregion

        #region Counter for send data to server
        int c;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Length > 0)
            {
                c = (int)numCounter.Value;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                numCounter.Enabled = false;
                if (bkgSendTo.IsBusy)
                    bkgSendTo.CancelAsync();
                else
                    bkgSendTo.RunWorkerAsync();
            }
            else
                MessageBox.Show("Select Server URL before Start!");
        }

        private void bkgSendTo_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = c; i >= 0; i--)
            {
                Thread.Sleep(1000);
                bkgSendTo.ReportProgress(i);
                if (bkgSendTo.CancellationPending)
                {
                    e.Cancel = true;
                    bkgSendTo.ReportProgress(c);
                    return;
                }
            }
        }

        private void bkgSendTo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int p = e.ProgressPercentage;
            tsStatus.Text = "Waiting...";
            tsTimer.Text = p.ToString() + " s";
        }

        private void bkgSendTo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                tsStatus.Text = "Stop send data";
            else if (e.Error != null)
                tsStatus.Text = "Error while sending";
            else
            {
                tsStatus.Text = "Send data...";
                SendData();
                bkgSendTo.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bkgSendTo.IsBusy)
            {
                bkgSendTo.CancelAsync();
                tsStatus.Text = "Stopped";
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                numCounter.Enabled = true;
            }
        }
        #endregion

    }
}