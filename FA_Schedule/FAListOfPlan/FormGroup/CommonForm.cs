using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAListOfPlan.Common;

namespace FAListOfPlan.FormGroup
{
    public partial class CommonForm : Form
    {
        public string TitleForm
        {
            get { return this.lbTitle.Text; }
            set { this.lbTitle.Text = value; }
        }

        public string SubTitleForm
        {
            get { return this.lbSubTitle.Text; }
            set { this.lbSubTitle.Text = value; }
        }

        public CommonForm()
        {
            InitializeComponent();
        }

        private void CommonForm_Load(object sender, EventArgs e)
        {
            this.lbUsername.Text = Userdata.getUser().Username;
            this.lbLocation.Text = Userdata.getUser().Location;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "LoginForm")
                {
                    Userdata.getUser().UserID = string.Empty;
                    Userdata.getUser().Username = string.Empty;
                    Userdata.getUser().Location = string.Empty;
                    f.Show();
                }
            }
        }
    }
}
