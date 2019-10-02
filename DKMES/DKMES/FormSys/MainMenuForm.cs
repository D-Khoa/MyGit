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
            ServerForm server = new ServerForm();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }
    }
}
