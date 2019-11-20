using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushDataToServer
{
    public partial class MainFrm : Form
    {
        OpenFileDialog chooseFolder;
        string[] filePath;
        string path;

        public MainFrm()
        {
            InitializeComponent();
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

        private void btnBFrom_Click(object sender, EventArgs e)
        {
            txtFrom.Text = ChooseFolder();
        }

        private void btnBTo_Click(object sender, EventArgs e)
        {
            txtTo.Text = ChooseFolder();
        }

        private void btnBTemp_Click(object sender, EventArgs e)
        {
            txtTemp.Text = ChooseFolder();
        }

        private void EditFile()
        {
            filePath = Directory.GetFiles(txtFrom.Text, " *.LA20_517ALA201NO1");
            if (filePath != null)
            {
                foreach (string file in filePath)
                {
                    path = Path.GetFileName(file);
                    string text = File.ReadAllText(file);
                    text = text.Replace("", "\n\r");
                    File.WriteAllText(txtTo.Text + "\\" + path, text);
                    File.Move(file, txtTemp.Text + "\\" + path);
                }
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            EditFile();
        }
    }
}
