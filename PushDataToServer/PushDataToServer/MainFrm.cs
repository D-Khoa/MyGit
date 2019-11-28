using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PushDataToServer
{
    public partial class MainFrm : Form
    {
        OpenFileDialog chooseFolder;
        List<string> setString;
        string[] filePath;
        string fromfolder, tofolder, tempfolder;
        string settingfile;
        string path;
        int c;

        public MainFrm()
        {
            InitializeComponent();
            setString = new List<string>();
            settingfile = @"D:\PushData\ini.txt";
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingfile))
            {
                setString = File.ReadLines(settingfile).ToList();
            }
            txtFrom.Text = setString[0].Remove(0, 14);
            txtTo.Text = setString[1].Remove(0, 12);
            txtTemp.Text = setString[2].Remove(0, 14);
            fromfolder = txtFrom.Text;
            tofolder = txtTo.Text;
            tempfolder = txtTemp.Text;
        }

        private void btnBTemp_Click(object sender, EventArgs e)
        {
            txtTemp.Text = ChooseFolder();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                if (!backgroundWorker1.IsBusy)
                {
                    btnPush.Enabled = false;
                    btnStop.Enabled = true;
                    txtFrom.ReadOnly = true;
                    txtTo.ReadOnly = true;
                    txtTemp.ReadOnly = true;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPush.Enabled = true;
            btnStop.Enabled = false;
            txtFrom.ReadOnly = false;
            txtTo.ReadOnly = false;
            txtTemp.ReadOnly = false;
            backgroundWorker1.CancelAsync();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (btnStop.Enabled)
                    e.Cancel = true;
                setString.Clear();
                setString.Add("From Folder = " + fromfolder);
                setString.Add("To Folder = " + tofolder);
                setString.Add("Temp Folder = " + tempfolder);
                if (!Directory.Exists(Path.GetDirectoryName(settingfile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(settingfile));
                File.WriteAllLines(settingfile, setString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            c = (int)numTimer.Value;
            for (int i = c; i >= 0; i--)
            {
                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(c);
                    return;
                }
                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsTimer.Text = e.ProgressPercentage.ToString() + " S";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Stop transfer!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    EditAndSendFile();
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string ChooseFolder()
        {
            chooseFolder = new OpenFileDialog();
            chooseFolder.CheckFileExists = false;
            chooseFolder.CheckPathExists = false;
            chooseFolder.ShowReadOnly = true;
            chooseFolder.FileName = "Select Folder";
            if (chooseFolder.ShowDialog() == DialogResult.OK)
            {
                return Path.GetDirectoryName(chooseFolder.FileName);
            }
            else
                return "";
        }

        private void EditAndSendFile()
        {
            filePath = Directory.GetFiles(fromfolder, "*.LA20_517ALA201NO1");
            if (filePath != null)
            {
                foreach (string file in filePath)
                {
                    path = Path.GetFileName(file);
                    string dataText = File.ReadAllText(file);
                    dataText = dataText.Replace("", Environment.NewLine);
                    File.WriteAllText(tofolder + "\\" + path, dataText);
                    if (!string.IsNullOrEmpty(txtTemp.Text))
                        File.Move(file, tempfolder + "\\" + path);
                }
            }
        }
    }

}