using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_QRCodeSystem.View
{
    public partial class PRODForm : FormCommon
    {
        public PRODForm()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm rqFrm = new RequestForm();
            rqFrm.Show();
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {

        }
    }
}
