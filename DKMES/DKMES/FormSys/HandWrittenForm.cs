using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DKMES.Common;
using System.Threading;

namespace DKMES.FormSys
{
    public partial class HandWrittenForm : Form
    {
        Char[] charList = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'U', 'W', 'X', 'Y', 'Z' };
        int index;
        List<string> CharList = new List<string>();

        public HandWrittenForm()
        {
            InitializeComponent();
            cmbCharList.DataSource = charList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                CharList.Clear();
                txtNumChar.Clear();
                picHandWritten.Image = null;
                btnSelect.Enabled = false;
                btnSave.Enabled = false;
                lbNumChar.Text = "None";
                tsStatus.Text = "Waiting";
                index = cmbCharList.SelectedIndex;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(28, 28);
            Bitmap32 bmp32 = new Bitmap32(bmp);
            if (int.Parse(txtNumChar.Text) < CharList.Count)
            {
                string[] CharLoad = CharList[int.Parse(txtNumChar.Text)].Split(',');
                bmp32.LockBitmap();
                int c = 0;
                for (int i = 0; i < bmp32.ImageBytes.Count() - 4; i += 4)
                {
                    bmp32.ImageBytes[i] = byte.Parse(CharLoad[c]);
                    bmp32.ImageBytes[i + 1] = byte.Parse(CharLoad[c]);
                    bmp32.ImageBytes[i + 2] = byte.Parse(CharLoad[c]);
                    bmp32.ImageBytes[i + 3] = 255;
                    c++;
                }
                bmp32.UnlockBitmap();
                bmp.SetResolution(168, 168);
                Bitmap bmpnew = new Bitmap(bmp, new Size(168, 168));
                picHandWritten.Image = bmpnew;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadCharCSV saveCSV = new LoadCharCSV(charList[index]);
            saveCSV.saveChar(CharList);
        }

        private void txtNumChar_TextChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                LoadCharCSV loadcsv = new LoadCharCSV(charList[index]);
                CharList = loadcsv.getChar(charList[index]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbNumChar.Text = CharList.Count + " rows";
            tsStatus.Text = "Complete";
            btnSave.Enabled = true;
        }
    }
}
