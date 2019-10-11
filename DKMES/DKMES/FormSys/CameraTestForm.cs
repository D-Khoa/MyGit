using System;
using System.Drawing;
using System.Windows.Forms;
using Dynamsoft.Core;
using Dynamsoft.UVC;
using DKMES.Common;

namespace DKMES.FormSys
{
    public partial class CameraTestForm : Form
    {
        #region VARIABLE
        CameraManager camman;
        ImageCore imagecore;
        Camera currcam;
        PictureBox picbox = new PictureBox();
        byte r = 0;
        byte g = 0;
        byte b = 0;
        byte o = 100;
        int key = 0;
        int n = 0;
        int X0, Y0, X1, Y1;
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
            switch (key)
            {
                case 0:
                    SetPicture(bitmap);
                    break;
                case 1:
                    SetPicture(HueRGB(bitmap));
                    break;
                case 2:
                    SetPicture(ColorToGrayscale(bitmap));
                    break;
                case 3:
                    SetPicture(RedFilter(bitmap));
                    break;
                case 4:
                    SetPicture(GreenFilter(bitmap));
                    break;
                case 5:
                    SetPicture(BlueFilter(bitmap));
                    break;
                case 6:
                    Rectangle rect = DrawRect(X0, Y0, X1, Y1);
                    SetPicture(HueRGB(bitmap, rect));
                    break;
                case 7:
                    CapturePicture(pictureBox1.Image, picbox);
                    key = 0;
                    break;
            }
        }

        private void CapturePicture(Image img, PictureBox pic)
        {
            Bitmap temp = new Bitmap(img, new Size(213, 160));
            //Bitmap temp = ((Bitmap)(img)).Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
            temp.SetResolution(213, 160);
            if (pic.InvokeRequired)
            {
                pic.BeginInvoke(new MethodInvoker(
                    delegate ()
                    {
                        pic.Name = "pic_" + n;
                        pic.Image = temp;
                    }));
            }
            else
            {
                pic.Image = temp;
                n++;
            }
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
            Bitmap32 bmp32 = new Bitmap32(bmp);
            bmp32.LockBitmap();
            bmp32.ToGrayScale(o);
            bmp32.UnlockBitmap();
            return bmp;
        }

        private Image RedFilter(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Bitmap32 bmp32 = new Bitmap32(bmp);
            bmp32.LockBitmap();
            bmp32.GetRed(o);
            bmp32.UnlockBitmap();
            return bmp;
        }

        private Image GreenFilter(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Bitmap32 bmp32 = new Bitmap32(bmp);
            bmp32.LockBitmap();
            bmp32.GetGreen(o);
            bmp32.UnlockBitmap();
            return bmp;
        }

        private Image BlueFilter(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Bitmap32 bmp32 = new Bitmap32(bmp);
            bmp32.LockBitmap();
            bmp32.GetBlue(o);
            bmp32.UnlockBitmap();
            return bmp;
        }
        #endregion

        #region SETUP TRACKBAR AND NUMBERIC
        private void trackR_Scroll(object sender, EventArgs e)
        {
            numR.Value = trackR.Value;
            r = (byte)trackR.Value;
        }

        private void trackG_Scroll(object sender, EventArgs e)
        {
            numG.Value = trackG.Value;
            g = (byte)trackG.Value;
        }

        private void trackB_Scroll(object sender, EventArgs e)
        {
            numB.Value = trackB.Value;
            b = (byte)trackB.Value;
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
            o = (byte)trackOpt.Value;
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

        #region BUTTON SET KEY
        private void btnNormal_Click(object sender, EventArgs e)
        {
            key = 0;
        }

        private void btnHue_Click(object sender, EventArgs e)
        {
            key = 1;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            key = 2;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            key = 3;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            key = 4;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            key = 5;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            key = 6;
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            n++;
            picbox = new PictureBox();
            picbox.Name = "pic_" + n;
            picbox.Width = 213;
            picbox.Height = 160;
            pnPicBoxes.Controls.Add(picbox);
            key = 7;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnPicBoxes.Controls.Clear();
        }
        #endregion

        private void CameraTestForm_Paint(object sender, PaintEventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            tsSizeForm.Text = w.ToString() + "X" + h.ToString();
        }
    }
}
