using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class AccountManager2019Form : FormCommonNCVP
    {
        public AccountManager2019Form()
        {
            InitializeComponent();
        }

        private void AccountManager2019Form_Load(object sender, EventArgs e)
        {

        }

        #region BUTTONS
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtAssetCode_TextChanged(object sender, EventArgs e)
        {
            if(txtAssetCode.Text.Length > 10)
            {
                txtAssetCode.Text.Remove(10);
            }
        }
    }
}
