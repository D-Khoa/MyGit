using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class AddItemForm : Form
    {
        public string name
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string pass
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string url
        {
            get { return txtURL.Text; }
            set { txtURL.Text = value; }
        }
        public AddItemForm()
        {
            InitializeComponent();
        }
    }
}
