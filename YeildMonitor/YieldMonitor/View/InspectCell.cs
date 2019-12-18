using System.Drawing;
using System.Windows.Forms;

namespace YieldMonitor.View
{
    public partial class InspectCell : UserControl
    {
        public string model
        {
            get { return lbmodel.Text; }
            set { lbmodel.Text = value; }
        }
        public double input
        {
            get { return double.Parse(lbInput.Text); }
            set { lbInput.Text = value.ToString(); }
        }
        public double output
        {
            get { return double.Parse(lbOutput.Text); }
            set { lbOutput.Text = value.ToString(); }
        }
        public double yeild
        {
            get { return double.Parse(lbYeild.Text); }
            set { lbYeild.Text = value.ToString(); }
        }

        public Color color
        {
            get { return pnlInfo.BackColor; }
            set { pnlInfo.BackColor = value; }
        }

        public InspectCell()
        {
            InitializeComponent();
        }

        public void InspectCell_Paint(object sender, PaintEventArgs e)
        {
            lbInspectName.Text = this.Name;
            lbInput.Text = input.ToString();
            lbOutput.Text = output.ToString();
        }
    }
}
