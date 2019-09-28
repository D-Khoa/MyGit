using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndplayGTCheck.FormCommon
{
    public partial class InputPasswordForm : Form
    {
        public string pass
        {
            get { return this.txtPass.Text; }
            set { this.txtPass.Text = value; }
        }
        public InputPasswordForm()
        {
            InitializeComponent();
        }
    }
}
