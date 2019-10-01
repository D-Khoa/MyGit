using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace ImportDataToDatabase
{
    public partial class MainForm : Form
    {
        int c;
        string[] filespath;
        string setpath = @"D:\Setting\";
        DataTable table;

        public MainForm()
        {
            InitializeComponent();
            table = new DataTable();
        }

        //GET SETTING FILE
        private void MainForm_Load(object sender, EventArgs e)
        {
            string fileset = setpath + @"setting.txt";
            if (File.Exists(fileset))
            {
                foreach (string line in File.ReadAllLines(fileset))
                {
                    if (line.Contains("source=")) txtFolderSource.Text
                            = line.Remove(0, 7);
                    if (line.Contains("save=")) txtFolderSave.Text
                            = line.Remove(0, 5);
                    if (line.Contains("timer=")) numTimer.Text
                            = line.Remove(0, 6);
                }
            }
        }

        //SELECT SOURCE FOLDER
        private void btnFSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog FSopen = new OpenFileDialog();
            FSopen.CheckFileExists = false;
            FSopen.CheckPathExists = false;
            FSopen.ShowReadOnly = true;
            FSopen.FileName = "Select Folder";
            if (FSopen.ShowDialog() == DialogResult.OK)
            {
                txtFolderSource.Text = Path.GetDirectoryName(FSopen.FileName) + @"\";
                filespath = Directory.GetFiles(txtFolderSource.Text, "*.csv");
            }
        }

        //SELECT FOLDER FOR SAVE WRONG FORMAT FILE
        private void btnFSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog FSopen = new OpenFileDialog();
            FSopen.CheckFileExists = false;
            FSopen.CheckPathExists = false;
            FSopen.ShowReadOnly = true;
            FSopen.FileName = "Select Folder";
            if (FSopen.ShowDialog() == DialogResult.OK)
            {
                txtFolderSave.Text = Path.GetDirectoryName(FSopen.FileName) + @"\";
            }
        }

        //READ CSV AND COMPARE NUMBER OF COLUMNS
        private Boolean ReadCSV(string pathfile, int numcol, ref DataTable dt)
        {
            StreamReader reader = new StreamReader(pathfile, false);
            dt = new DataTable();
            dt.Columns.Add("serno");
            dt.Columns.Add("lot");
            dt.Columns.Add("model");
            dt.Columns.Add("site");
            dt.Columns.Add("factory");
            dt.Columns.Add("line");
            dt.Columns.Add("process");
            dt.Columns.Add("item");
            dt.Columns.Add("inspectdate");
            dt.Columns.Add("inspecttime");
            dt.Columns.Add("data");
            dt.Columns.Add("judge");
            dt.Columns.Add("status");
            dt.Columns.Add("remark");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Split('|');
                if (value.Count() == numcol)
                    dt.Rows.Add(value);
            }
            reader.Close();
            if (dt.Rows.Count == 0) return false;
            else return true;
        }

        //COMPARE FORMAT AND SEND FILE
        private void CompareAndSend(string[] files)
        {
            if (files != null)
            {
                foreach (string file in files)
                {
                    string tofile = txtFolderSave.Text + Path.GetFileName(file);
                    try
                    {
                        if (ReadCSV(file, 14, ref table))
                        {
                            SQLCommon sql = new SQLCommon();
                            sql.InsertDatatableToDB(ref table);
                            table.Clear();
                            File.Delete(file);
                        }
                        else
                        {
                            File.Move(file, tofile);
                        }
                    }
                    catch
                    {
                        File.Move(file, tofile);
                    }
                }
            }
            filespath = Directory.GetFiles(txtFolderSource.Text, "*.csv");
        }

        #region SETTING TIMER FOR SEND DATA
        //BUTTON START FOR START COUNTING
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnExit.Enabled = false;
            numTimer.Enabled = false;
            c = (int)numTimer.Value;
            if (bwSendData.IsBusy) bwSendData.CancelAsync();
            else bwSendData.RunWorkerAsync();
        }

        //COUNTING 1S
        private void bwSendData_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = c; i >= 0; i--)
            {
                bwSendData.ReportProgress(i);
                if (bwSendData.CancellationPending)
                {
                    e.Cancel = true;
                    bwSendData.ReportProgress(c);
                    return;
                }
                Thread.Sleep(1000);
            }
        }

        //SHOW COUNTER EACH 1S
        private void bwSendData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsStatus.Text = "Counting for send...";
            tsTimer.Text = e.ProgressPercentage.ToString() + " s";
        }

        //SEND FILE WHILE COUNTER = 0
        private void bwSendData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //IF CLICK BUTTON STOP
            if (e.Cancelled)
                tsStatus.Text = "Stop send data";
            //IF ERROR WHILE SEND
            else if (e.Error != null)
                tsStatus.Text = "Error while send data";
            //IF COUNTER = 0 AND SEND DATA TO DB
            else
            {
                tsStatus.Text = "Sending data...";
                CompareAndSend(filespath);
                bwSendData.RunWorkerAsync();
            }
        }

        //BUTTON STOP FOR STOP SEND DATA
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bwSendData.IsBusy)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnExit.Enabled = true;
                numTimer.Enabled = false;
                bwSendData.CancelAsync();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //WHILE TIMER COUTING NOT ALLOW FOR EXIT APPLICATION
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnExit.Enabled) e.Cancel = true;
            if (!Directory.Exists(setpath))
                Directory.CreateDirectory(setpath);
            string fileset = setpath + @"setting.txt";
            using (StreamWriter sw = new StreamWriter(fileset))
            {
                sw.WriteLine("source=" + txtFolderSource.Text);
                sw.WriteLine("save=" + txtFolderSave.Text);
                sw.WriteLine("timer=" + numTimer.Text);
                sw.Close();
            }
        }
        #endregion
    }
}
