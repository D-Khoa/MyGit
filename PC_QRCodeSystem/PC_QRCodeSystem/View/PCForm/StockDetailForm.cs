using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class StockDetailForm : FormCommon
    {
        private string[] barcode;

        public StockDetailForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        //GET BARCODE DATA INTO FIELD IN FORM
        private void txtItemCD_TextChanged(object sender, EventArgs e)
        {
            //CHECK INPUT TEXT IS BARCODE
            if (txtItemCD.Text.Contains(";"))
            {
                barcode = txtItemCD.Text.Split(';');
                //GET ITEM CODE
                txtItemCD.Text = barcode[0];
                //GET ITEM NAME
                lbItemName.Text = barcode[1];
                //GET SUPPLIER NAME
                cmbSupplier.SelectedValue = barcode[2];
                //GET INVOICE
                txtInvoice.Text = barcode[3];
                //GET DATE
                dtpFromDate.Value = DateTime.Parse(barcode[4]);
                dtpToDate.Value = DateTime.Parse(barcode[4]);
            }
        }
    }
}
