using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Program
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void grActors_Paint(object sender, PaintEventArgs e)
        {
            int x = grGeneral.Location.X;
            grActors.Width = x;
        }

        private void grFeature_Paint(object sender, PaintEventArgs e)
        {
            int w = grGeneral.Width;
            Point p = new Point();
            p.X = grGeneral.Location.X + w;
            p.Y = grFeature.Location.Y;
            grFeature.Width = grActors.Width + w;
            grFeature.Location = p;
        }
    }
}
