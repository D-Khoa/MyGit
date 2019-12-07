using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBMES.Views
{
    public partial class MainForm : FormCommon
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Statistic_btn_Click(object sender, EventArgs e)
        {

        }

        private void Tracking_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dataview_btn_Click(object sender, EventArgs e)
        {

        }

        private void FinalCheck_btn_Click(object sender, EventArgs e)
        {
            FinalCheckForm finalForm = new FinalCheckForm();
            this.Hide();
            finalForm.ShowDialog();
            this.Show();
        }

        private void Shipping_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
