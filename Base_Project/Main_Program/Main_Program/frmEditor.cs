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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.ShowDialog();

        }
    }
}
