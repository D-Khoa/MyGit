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

    }
}
