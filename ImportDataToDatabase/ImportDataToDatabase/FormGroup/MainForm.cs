using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using ImportDataToDatabase.Common;

namespace ImportDataToDatabase.FormGroup
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
                int num = CounterCSV(txtFolderSource.Text);
            }
        }

        //COUNTER NUMBER OF CSV FILES IN SOURCE FOLDER
        private int CounterCSV(string path)
        {
            filespath = Directory.GetFiles(path, "*.csv");
            int num = filespath.Count();
            lbNumCSV.Text = num.ToString();
            return num;
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
            for (int i = 1; i <= numcol; i++)
            {
                dt.Columns.Add(i.ToString());
            }
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

        //IMPORT DATA FROM CSV TO DB
        private void ImportToDB(string file)
        {
            try
            {
                SQLCommon sql = new SQLCommon();
                sql.InsertDatatableToDB(ref table);
            }
            catch
            {
                MoveToFolder(file);
            }
        }

        //MOVE FILE WRONG FORMAT TO SAVE FOLER
        private void MoveToFolder(string file)
        {
            string tofile = txtFolderSave.Text + Path.GetFileName(file);
            File.Move(file, tofile);
        }

        //COMPARE FORMAT FILE
        private void CompareFormat(string[] files)
        {
            foreach (string file in files)
            {
                if (ReadCSV(file, 17, ref table))
                {
                    ImportToDB(file);
                    table.Clear();
                    File.Delete(file);
                }
                else MoveToFolder(file);
            }
            CounterCSV(txtFolderSource.Text);
        }


        #region SETTING TIMER FOR SEND DATA
        //BUTTON START FOR START COUNTING
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnExit.Enabled = false;
            c = (int)numTimer.Value;
            if (bwSendData.IsBusy) bwSendData.CancelAsync();
            else bwSendData.RunWorkerAsync();
        }

        //COUNTING....
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

        //UPDATE COUNTER EACH 1S
        private void bwSendData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsStatus.Text = "Counting for send...";
            tsTimer.Text = e.ProgressPercentage.ToString() + " s";
        }

        //UPDATE STATUS
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
                CompareFormat(filespath);
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
            System.Diagnostics.Process.Start(setpath);
        }
        #endregion
    }
}
