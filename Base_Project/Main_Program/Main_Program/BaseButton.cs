using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Program
{
    public partial class BaseButton : UserControl
    {
        public BaseButton()
        {
            InitializeComponent();
            btnBase.MouseHover += BtnBase_MouseHover;
            btnBase.MouseLeave += BtnBase_MouseLeave;
            btnBase.Click += BtnBase_Click;
        }

        private void BtnBase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void BtnBase_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Leave");
        }

        private void BtnBase_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hover");
        }
    }
}
