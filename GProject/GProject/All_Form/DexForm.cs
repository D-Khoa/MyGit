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
    public partial class DexForm : Form
    {
        public DexForm()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabSort);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabArea);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabAppear);
        }
    }
}
