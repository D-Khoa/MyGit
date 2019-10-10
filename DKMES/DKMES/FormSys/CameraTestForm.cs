using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Dynamsoft.Core;
using Dynamsoft.UVC;

namespace DKMES.FormSys
{
    public partial class CameraTestForm : Form
    {
        #region VARIABLE
        CameraManager camman;
        ImageCore imagecore;
        Camera currcam;
        Color c;
        int r = 0;
        int g = 0;
        int b = 0;
        int o = 100;
        int X0, Y0, X1, Y1;
        bool btncheck = false;
        bool drawrect = false;
        #endregion

        #region SETUP CAMERA
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
                cmbListDevice.SelectedIndex = 0;
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
        #endregion

        #region DRAW PICTURE ON FRAME
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
            if (btncheck)
            {
                Thread.Sleep(50);
                SetPicture(HueRGB(bitmap));
            }
            //else
            //{
            //    Thread.Sleep(300);
            //    SetPicture(ColorToGrayscale(bitmap));
            //}
            else //if(drawrect)
            {
                //SetPicture(DrawRect(X0, Y0, X1, Y1, bitmap));
                Rectangle rect = DrawRect(X0, Y0, X1, Y1);
                SetPicture(HueRGB(bitmap, rect));
            }
            //else
            //{
            //    SetPicture(bitmap);
            //}
        }
        #endregion

        #region COLOR FIX
        private Image HueRGB(Image img)
        {
            Graphics gp = Graphics.FromImage(img);
            SolidBrush br = new SolidBrush(Color.FromArgb(o, r, g, b));
            gp.FillRectangle(br, new Rectangle(0, 0, img.Width, img.Height));
            return img;
        }

        private Image HueRGB(Image img, Rectangle rect)
        {
            Graphics gp = Graphics.FromImage(img);
            SolidBrush br = new SolidBrush(Color.FromArgb(o, r, g, b));
            gp.FillRectangle(br, rect);
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
                    bmp.SetPixel(x, y, Color.FromArgb(o, o, o));
                }
            }
            return bmp;
        }
        #endregion

        #region SETUP TRACKBAR AND NUMBERIC
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
        #endregion

        #region DRAW RECT WITH MOUSE MOVER
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X0 = e.X;
            Y0 = e.Y;
            X1 = X0;
            Y1 = Y0;
            drawrect = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawrect)
            {
                X1 = e.X;
                Y1 = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
            drawrect = false;
        }

        private Rectangle DrawRect(int x0, int y0, int x1, int y1)
        {
            int w = x1 - x0;
            int h = y1 - y0;
            Rectangle rect = new Rectangle(x0, y0, w, h);
            //Graphics gp = Graphics.FromImage(img);
            //Pen p = new Pen(Color.Red);
            //gp.DrawRectangle(p, rect);
            return rect;
        }
        #endregion

        private void btnHue_Click(object sender, EventArgs e)
        {
            if (!btncheck)
            {
                btncheck = true;
                groupBox1.Enabled = true;
                btnHue.Text = "Normal";
            }
            else
            {
                btncheck = false;
                groupBox1.Enabled = false;
                btnHue.Text = "Hue";
            }
        }

    }
}
