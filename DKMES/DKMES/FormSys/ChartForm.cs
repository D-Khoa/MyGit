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

namespace DKMES.FormSys
{
    public partial class ChartForm : Form
    {
        Point O = new Point();
        Pen pen1 = new Pen(Color.Black);
        Pen pen2 = new Pen(Color.Blue);
        Brush brush1 = new SolidBrush(Color.Black);
        Brush brush2 = new SolidBrush(Color.Red);
        int w;
        int h;

        public ChartForm()
        {
            InitializeComponent();
            w = this.Width;
            h = this.Height;
        }

        public Image OxyScale(bool center)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics drawOxy = Graphics.FromImage(bmp);
            if (center)
            {
                O.X = w / 2;
                O.Y = h / 2;
            }
            else
            {
                O.X = 50;
                O.Y = h - 50;
            }
            drawOxy.DrawLine(pen1, new Point(0, O.Y), new Point(w, O.Y));
            drawOxy.DrawLine(pen1, new Point(O.X, 0), new Point(O.X, h));
            if (O.X != 0)
                drawOxy.DrawString("O", DefaultFont, brush1, O.X - 15, O.Y + 5);
            else
                drawOxy.DrawString("O", DefaultFont, brush1, 0, O.Y + 5);
            return bmp;
        }

        private void ChartForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(OxyScale(true), 0, 0);
        }

        private void ChartForm_SizeChanged(object sender, EventArgs e)
        {
            w = this.Width;
            h = this.Height;
            Invalidate();
        }
    }
}
