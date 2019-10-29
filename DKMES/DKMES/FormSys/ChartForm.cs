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

        public ChartForm()
        {
            InitializeComponent();
        }

        public void OxyScale(bool center)
        {
            int w = picChart.Width;
            int h = picChart.Height;
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
        }

        private void picChart_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen1, new Point(0, O.Y), new Point(picChart.Width, O.Y));
            e.Graphics.DrawLine(pen1, new Point(O.X, 0), new Point(O.X, picChart.Height));
            if (O.X != 0)
                e.Graphics.DrawString("O", DefaultFont, brush1, O.X - 15, O.Y + 5);
            else
                e.Graphics.DrawString("O", DefaultFont, brush1, 0, O.Y + 5);
        }

        private void picChart_Resize(object sender, EventArgs e)
        {
        }
    }
}
