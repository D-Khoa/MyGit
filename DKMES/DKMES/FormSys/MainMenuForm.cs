using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKMES.FormSys
{
    public partial class MainMenuForm : CommonForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            TransmissionTextForm trans = new TransmissionTextForm();
            trans.Show();
        }
    }
}
