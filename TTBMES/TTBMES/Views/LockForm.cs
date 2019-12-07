using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBMES.Views
{
    public partial class LockForm : Form
    {
        public string ConfimPass { get; set; }
        public string inputPass { get; set; }

        public LockForm(string inPass)
        {
            InitializeComponent();
            ConfimPass = inPass;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == ConfimPass)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtPass.Clear();
                txtPass.Focus();
                MessageBox.Show("Wrong Password!!!");
            }
        }

        private void LockForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
