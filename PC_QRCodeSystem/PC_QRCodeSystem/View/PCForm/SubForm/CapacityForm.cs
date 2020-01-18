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
    public partial class CapacityForm : Form
    {
        /// <summary>
        /// Get capacity number
        /// </summary>
        public double capacityNumber { get; set; }
        public CapacityForm()
        {
            InitializeComponent();
        }

        private void CapacityForm_Load(object sender, EventArgs e)
        {
            txtCapacity.Text = capacityNumber.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            capacityNumber = double.Parse(txtCapacity.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CapacityForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
