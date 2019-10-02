using System.Windows.Forms;
using DKMES.Common;

namespace DKMES.FormSys
{
    public partial class CommonForm : Form
    {
        public string FormTitle
        {
            get { return this.lbTitle.Text; }
            set { this.lbTitle.Text = value; }
        }

        public CommonForm()
        {
            InitializeComponent();
            lbusername.Text = Userdata.GetData().userName;
            lbfactory.Text = Userdata.GetData().factory;
        }
    }
}
