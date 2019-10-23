using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GProject.Common;
using System.Threading;

namespace GProject
{
    public partial class Test : Form
    {
        Bitmap bmp;
        BaseGraphics gp;
        double oldw, oldh, neww, newh, dw, dh;
        double cow, coh, cox, coy, cnw, cnh, cnx, cny;
        List<Control> oldcon = new List<Control>();

        public Test()
        {
            InitializeComponent();
            gp = new BaseGraphics(Properties.Resources.aGOgp, 10, 1);
            oldh = this.Height;
            oldw = this.Width;
            newh = this.Height;
            neww = this.Width;
            dw = neww - oldw;
            dh = newh - oldh;
            foreach (Control con in this.Controls)
            {
                oldcon.Add(con);
            }
            //bwClock.RunWorkerAsync();
            picboxsetup();
            drawdot();
        }

        private void drawdot()
        {
            bmp = new Bitmap(gp.Frames[0].Width, gp.Frames[0].Height);
            Graphics dot = Graphics.FromImage(bmp);
            Font f = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            dot.DrawString(":", f, new SolidBrush(Color.Black),
                new RectangleF(0, 0, gp.Frames[0].Width, gp.Frames[0].Height), sf);
        }

        private void picboxsetup()
        {
            int w = gp.Frames[0].Width;
            int h = gp.Frames[0].Height;
            pictureBox1.Width = w;
            pictureBox1.Height = h;
            pictureBox2.Width = w;
            pictureBox2.Height = h;
            pictureBox3.Width = w;
            pictureBox3.Height = h;
            pictureBox4.Width = w;
            pictureBox4.Height = h;
            pictureBox5.Width = w;
            pictureBox5.Height = h;
            pictureBox6.Width = w;
            pictureBox6.Height = h;
            pictureBox7.Width = w;
            pictureBox7.Height = h;
            pictureBox8.Width = w;
            pictureBox8.Height = h;
            pictureBox1.Location = new Point(20, label1.Height + 10);
            pictureBox2.Location = new Point(pictureBox1.Location.X + w, pictureBox1.Location.Y);
            pictureBox3.Location = new Point(pictureBox2.Location.X + w, pictureBox2.Location.Y);
            pictureBox4.Location = new Point(pictureBox3.Location.X + w, pictureBox3.Location.Y);
            pictureBox5.Location = new Point(pictureBox4.Location.X + w, pictureBox4.Location.Y);
            pictureBox6.Location = new Point(pictureBox5.Location.X + w, pictureBox5.Location.Y);
            pictureBox7.Location = new Point(pictureBox6.Location.X + w, pictureBox6.Location.Y);
            pictureBox8.Location = new Point(pictureBox7.Location.X + w, pictureBox7.Location.Y);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 10)
            {
                pictureBox1.Image = gp.Frames[0];
                pictureBox2.Image = gp.Frames[now.Hour];
            }
            else
            {
                int h1 = (now.Hour / 10);
                int h2 = (now.Hour % 10);
                pictureBox1.Image = gp.Frames[h1];
                pictureBox2.Image = gp.Frames[h2];
            }
            if (now.Minute < 10)
            {
                pictureBox4.Image = gp.Frames[0];
                pictureBox5.Image = gp.Frames[(now.Minute)];
            }
            else
            {
                int m1 = (now.Minute / 10);
                int m2 = (now.Minute % 10);
                pictureBox4.Image = gp.Frames[m1];
                pictureBox5.Image = gp.Frames[m2];
            }
            if (now.Second < 10)
            {
                pictureBox7.Image = gp.Frames[0];
                pictureBox8.Image = gp.Frames[now.Second];
            }
            else
            {
                int s1 = (now.Second / 10);
                int s2 = (now.Second % 10);
                pictureBox7.Image = gp.Frames[s1];
                pictureBox8.Image = gp.Frames[s2];
            }
            if (now.Second % 2 != 0)
            {
                pictureBox3.Image = bmp;
                pictureBox6.Image = bmp;
            }
            else
            {
                pictureBox3.Image = null;
                pictureBox6.Image = null;
            }
            //bwClock.RunWorkerAsync();
        }

        private void Test_Resize(object sender, EventArgs e)
        {
            neww = this.Width;
            newh = this.Height;
            foreach (Control con in this.Controls)
            {
                int i = oldcon.IndexOf(con);
                int x = con.Location.X - oldcon[i].Location.X;
                int y = con.Location.Y - oldcon[i].Location.Y;
            }
        }

        private void Test_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void Test_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void Test_Paint(object sender, PaintEventArgs e)
        {
            //int x = button1.Location.X + button1.Width;
            //if (button2.Location.X < x)
            //{
            //    button2.Width = this.Width - secondX - button2.Location.X;
            //    button2.Location = new Point(x, button2.Location.Y);
            //}
            //else
            //{
            //    button2.Location = new Point(this.Width - secondX - firstW, button2.Location.Y);
            //    button2.Width = firstW;
            //}

        }

    }
}
