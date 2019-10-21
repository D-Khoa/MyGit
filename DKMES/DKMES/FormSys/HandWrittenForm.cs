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
        Char[] character = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'U', 'W', 'X', 'Y', 'Z' };
        int index;
        List<string> CharList = new List<string>();

        public HandWrittenForm()
        {
            InitializeComponent();
            cmbCharList.DataSource = character;
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
                List<int> il = new List<int>();
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        c = int.Parse(CharLoad[bmp.Width * y + x]);
                        bmp32.SetPixel(x, y, Color.FromArgb(255, c, c, c));
                    }
                }
                bmp32.UnlockBitmap();
                cutChar(bmp);
                bmp.SetResolution(168, 168);
                Bitmap bmpnew = new Bitmap(bmp, new Size(168, 168));
                picHandWritten.Image = bmpnew;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadCharCSV saveCSV = new LoadCharCSV(character[index]);
            saveCSV.saveChar(CharList);
        }

        private void txtNumChar_TextChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadCharCSV loadcsv = new LoadCharCSV(character[index]);
            CharList = loadcsv.getChar(character[index]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbNumChar.Text = CharList.Count + " rows";
            tsStatus.Text = "Complete";
            btnSave.Enabled = true;
        }

        public void cutChar(Bitmap img)
        {
            Graphics gp = Graphics.FromImage(img);
            Bitmap32 bmp32 = new Bitmap32(img);
            System.Drawing.Imaging.PixelFormat format = new System.Drawing.Imaging.PixelFormat();
            Point top, left, bot, right, prect;
            bmp32.LockBitmap();
            top = bmp32.TopPoint();
            left = bmp32.LeftPoint();
            bot = bmp32.BotPoint();
            right = bmp32.RightPoint();
            bmp32.Vector();
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {

                    bmp32.Compass(x, y);
                }
            }
            bmp32.UnlockBitmap();
            prect = new Point(left.X, top.Y);
            Rectangle rect = new Rectangle(prect, new Size(right.X - left.X, bot.Y - top.Y));
            Bitmap clone = img.Clone(rect, format);
            gp.DrawRectangle(new Pen(Color.Green), rect);
            picFitter.Image = clone;
        }
    }
}
