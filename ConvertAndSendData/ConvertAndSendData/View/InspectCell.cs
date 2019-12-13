using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ConvertAndSendData.View
{
    public partial class InspectCell : UserControl
    {
        public string input { get; set; }
        public string output { get; set; }
        public string yeild { get; set; }

        public InspectCell()
        {
            InitializeComponent();
        }

        private void InspectCell_Paint(object sender, PaintEventArgs e)
        {
            lbInspectName.Text = this.Name;
            lbInput.Text = this.input;
            lbOutput.Text = this.output;
            lbYeild.Text = this.yeild;
        }
    }
}
