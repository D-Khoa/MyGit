using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using TTBMES.Models;

namespace TTBMES.Views
{
    public partial class FinalCheckForm : FormCommon
    {
        public FinalCheckForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Waring", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
