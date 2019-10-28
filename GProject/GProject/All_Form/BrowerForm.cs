using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GProject.All_Form
{
    public partial class BrowerForm : Form
    {
        int x, y;
        Label l = new Label();

        public BrowerForm()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            int w = e.Bounds.Width;
            int h = e.Bounds.Height;
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
            Font f = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold, GraphicsUnit.Point);
            Font f2 = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Bold, GraphicsUnit.Point);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Tab 1", f, new SolidBrush(Color.Blue), e.Bounds, format);
            e.Graphics.DrawString("X", f2, new SolidBrush(Color.Black), new Point(w - 12, h / 4));
            if (x == (w - 12) && (y == h / 4))
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), new Rectangle(x, y, 10, 10));
            }
        }

        private void tabControl1_MouseMove_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            l.Location = new Point(x, y);
            l.Text = x + "," + y;
            l.Invalidate();
            l.Visible = true;
            l.Enabled = true;
        }
    }
}
