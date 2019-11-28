using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class UpdateAssetForm : FormCommonNCVP
    {
        AssetInfoVo voInfo = new AssetInfoVo();

        public UpdateAssetForm()
        {
            InitializeComponent();
        }

        public UpdateAssetForm(AssetInfoVo inVo)
        {
            InitializeComponent();
            voInfo = inVo;
        }

        private void UpdateAssetForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<AssetMaster2019Vo> assetType = ((ValueObjectList<AssetMaster2019Vo>)DefaultCbmInvoker.Invoke(new GetAssetTypeCbm(), new AssetMaster2019Vo()));
            cmbAssetType.DisplayMember = "asset_type";
            cmbAssetType.DataSource = assetType.GetList();
            cmbAssetType.Text = null;
            txtAssetCode.Text = lbAssetCode.Text = voInfo.asset_cd;
            lbAssetNo.Text = voInfo.asset_no.ToString();
            numAssetNo.Value = voInfo.asset_no;
            txtAssetName.Text = lbAssetName.Text = voInfo.asset_name;
            txtAssetModel.Text = lbAssetModel.Text = voInfo.asset_model;
            txtAssetSerial.Text = lbAssetSerial.Text = voInfo.asset_serial;
            txtAssetInvoice.Text = lbInvoice.Text = voInfo.asset_invoice;
            txtAssetPO.Text = lbAssetPO.Text = voInfo.asset_po;
            txtAcqCost.Text = lbAcqCost.Text = voInfo.acquistion_cost.ToString();
            lbAcqDate.Text = voInfo.acquistion_date.ToString("yyyy-MM-dd");
            dtpAcqDate.Value = voInfo.acquistion_date;
            lbFactory.Text = voInfo.factory_cd;
            txtFactory.Text = UserData.GetUserData().FactoryCode;
            txtSupplier.Text = lbSupplier.Text = voInfo.asset_supplier;
            lbLife.Text = voInfo.asset_life.ToString();
            numLife.Value = (decimal)voInfo.asset_life;
            cmbAssetType.Text = lbAssetType.Text = voInfo.asset_type;
            switch (voInfo.label_status)
            {
                case "Pasted":
                    rbtnPasted.Checked = true;
                    break;
                case "Not Paste":
                    rbtnNotPaste.Checked = true;
                    break;
                case "Cant Paste":
                    rbtnCntPaste.Checked = true;
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                string label;
                if (rbtnPasted.Checked)
                    label = "Pasted";
                else if (rbtnNotPaste.Checked)
                    label = "Not Paste";
                else
                    label = "Cant Paste";
                AssetMaster2019Vo updateVo = (AssetMaster2019Vo)DefaultCbmInvoker.Invoke(new UpdateAssetCbm(), new AssetInfoVo()
                {
                    acquistion_cost = double.Parse(txtAcqCost.Text),
                    acquistion_date = dtpAcqDate.Value,
                    asset_cd = txtAssetCode.Text,
                    asset_invoice = txtAssetInvoice.Text,
                    asset_life = (double)numLife.Value,
                    asset_model = txtAssetModel.Text,
                    asset_name = txtAssetName.Text,
                    asset_no = (int)numAssetNo.Value,
                    asset_po = txtAssetPO.Text,
                    asset_serial = txtAssetSerial.Text,
                    asset_supplier = txtSupplier.Text,
                    asset_type = cmbAssetType.Text,
                    factory_cd = txtFactory.Text,
                    label_status = label
                });
                MessageBox.Show("Update completed " + updateVo.executeInt + " rows data!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAssetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want exit anyway?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
