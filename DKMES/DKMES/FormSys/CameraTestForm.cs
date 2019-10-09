using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Dynamsoft.Core;
using Dynamsoft.Common;
using Dynamsoft.UVC;

namespace DKMES.FormSys
{
    public partial class CameraTestForm : Form
    {
        CameraManager camman;
        ImageCore imagecore;
        Camera currcam;
        Color c;
        int r = 0;
        int g = 0;
        int b = 0;
        int o = 100;
        bool btncheck = false;

        public CameraTestForm()
        {
            InitializeComponent();
            camman = new CameraManager("1234");
            imagecore = new ImageCore();
        }

        private void CameraTestForm_Load(object sender, EventArgs e)
        {
            if (camman.GetCameraNames() != null)
            {
                foreach (string name in camman.GetCameraNames())
                {
                    cmbListDevice.Items.Add(name);
                }
            }
        }

        private void cmbListDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currcam != null)
            {
                currcam.OnFrameCaptrue -= curcam_OnFramCapture;
                currcam.Close();
            }
            if (camman != null)
            {
                currcam = camman.SelectCamera((short)cmbListDevice.SelectedIndex);
                currcam.Open();
                currcam.OnFrameCaptrue += curcam_OnFramCapture;
            }
        }

        private void SetPicture(Image img)
        {
            Bitmap temp = ((Bitmap)(img)).Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new MethodInvoker(
                    delegate ()
                    {
                        pictureBox1.Image = temp;
                    }));
            }
            else
            {
                pictureBox1.Image = temp;
            }
        }

        private void curcam_OnFramCapture(Bitmap bitmap)
        {
            if (!btncheck)
            {
                Thread.Sleep(50);
                SetPicture(HueRGB(bitmap));
            }
            else
            {
                Thread.Sleep(300);
                SetPicture(ColorToGrayscale(bitmap));
            }
        }

        private Image HueRGB(Image img)
        {
            Graphics gp = Graphics.FromImage(img);
            SolidBrush br = new SolidBrush(Color.FromArgb(o, r, g, b));
            gp.FillRectangle(br, new Rectangle(0, 0, img.Width, img.Height));
            return img;
        }

        private Image ColorToGrayscale(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    c = bmp.GetPixel(x, y);
                    r = (int)(c.R * 0.299);
                    g = (int)(c.G * 0.587);
                    b = (int)(c.B * 0.114);
                    o = r + g + b;
                    bmp.SetPixel(x, y, Color.FromArgb(o,o,o));
                }
            }
            return bmp;
        }

        private void trackR_Scroll(object sender, EventArgs e)
        {
            numR.Value = trackR.Value;
            r = trackR.Value;
        }

        private void trackG_Scroll(object sender, EventArgs e)
        {
            numG.Value = trackG.Value;
            g = trackG.Value;
        }

        private void trackB_Scroll(object sender, EventArgs e)
        {
            numB.Value = trackB.Value;
            b = trackB.Value;
        }

        private void numR_ValueChanged(object sender, EventArgs e)
        {
            trackR.Value = (int)numR.Value;
        }

        private void numG_ValueChanged(object sender, EventArgs e)
        {
            trackG.Value = (int)numG.Value;
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            trackB.Value = (int)numB.Value;
        }

        private void trackOpt_Scroll(object sender, EventArgs e)
        {
            numOpt.Value = trackOpt.Value;
            o = trackOpt.Value;
        }

        private void numOpt_ValueChanged(object sender, EventArgs e)
        {
            trackOpt.Value = (int)numOpt.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!btncheck)
                btncheck = true;
            else
                btncheck = false;
        }
    }
}
