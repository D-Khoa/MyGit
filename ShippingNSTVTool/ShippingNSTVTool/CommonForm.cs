using System.Windows.Forms;

namespace ShippingNSTVTool
{
    public partial class CommonForm : Form
    {
        public string TitleText
        {
            get
            {
                return this.lbTitle.Text;
            }

            set
            {
                this.lbTitle.Text = value;
            }
        }

        public CommonForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Waring", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
