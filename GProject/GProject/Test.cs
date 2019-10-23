﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GProject.Common;

namespace GProject
{
    public partial class Test : Form
    {
        BaseGraphics gp;
        Bitmap bmp;
        int firstX, secondX, firstW;
        public Test()
        {
            InitializeComponent();
            gp = new BaseGraphics(Properties.Resources.aGOgp, 10, 1);
            picboxsetup();
            drawdot();
            firstX = button2.Location.X;
            firstW = button2.Width;
            secondX = this.Width - firstW - firstX;
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
            //this.Width = 50 + 8 * w;
        }

        private void timer1_Tick(object sender, EventArgs e)
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
        }

        int aX, bX;
        private void Test_ResizeBegin(object sender, EventArgs e)
        {
            bX = this.Width;
        }

        private void Test_ResizeEnd(object sender, EventArgs e)
        {
            aX = this.Width;
            int x = button1.Location.X + button1.Width;
            if (button2.Location.X < firstX)
            {
                button2.Width = this.Width - secondX - button2.Location.X;
                if (button2.Location.X < x)
                    button2.Location = new Point(x, button2.Location.Y);
            }
            else
            {
                button2.Location = new Point(this.Width - secondX - firstW, button2.Location.Y);
                button2.Width = firstW;
            }
        }

        private void Test_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
