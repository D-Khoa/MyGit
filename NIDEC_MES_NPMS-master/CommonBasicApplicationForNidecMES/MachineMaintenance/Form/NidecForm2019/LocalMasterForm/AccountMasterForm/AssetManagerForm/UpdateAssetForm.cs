using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class UpdateAssetForm : FormCommonNCVP
    {
        AssetInfoVo voInfo = new AssetInfoVo();
        List<AssetInfoVo> infoList = new List<AssetInfoVo>();
        DataTable dataImport = new DataTable();
        bool checkAddFrm = true;
        string label;

        public UpdateAssetForm()
        {
            InitializeComponent();
        }

        public UpdateAssetForm(AssetInfoVo inVo, bool addForm)
        {
            InitializeComponent();
            checkAddFrm = addForm;
            if (!addForm)
            {
                this.Width -= dgvAddAssetList.Width;
                btnApply.Text = "Update Asset";
            }
            voInfo = inVo;
        }

        private void UpdateAssetForm_Load(object sender, EventArgs e)
        {
            dgvAddAssetList.Visible = checkAddFrm;
            btnAddAsset.Visible = checkAddFrm;
            btnImport.Visible = checkAddFrm;
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

        private void UpdateAssetEvent()
        {
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

        private void AddAssetList()
        {
            bool checkEmpty = false;
            foreach (Control x in grUpdate.Controls)
            {
                if (string.IsNullOrEmpty(x.Text) && !(x is Label) && (x.Name != txtAssetPO.Name))
                {
                    checkEmpty = true;
                    break;
                }
            }
            if (checkEmpty)
                MessageBox.Show("Must fill all infomation before add!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                voInfo = new AssetInfoVo
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
                };
                dgvAddAssetList.Rows.Add(voInfo.asset_cd, voInfo.asset_no, voInfo.asset_name, voInfo.asset_serial,
                    voInfo.asset_model, voInfo.asset_life, voInfo.acquistion_cost, voInfo.acquistion_date, voInfo.asset_invoice,
                    voInfo.asset_po, voInfo.asset_type, voInfo.factory_cd, voInfo.asset_supplier, voInfo.label_status);
                infoList.Add(voInfo);
                dgvAddAssetList.Refresh();
                btnAddAsset.Enabled = infoList.Count > 0;
                tsRowCount.Text = dgvAddAssetList.RowCount.ToString() + " rows";
            }
        }

        private void dgvAddAssetList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            infoList.RemoveAt(e.Row.Index);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnPasted.Checked)
                    label = "Pasted";
                else if (rbtnNotPaste.Checked)
                    label = "Not Paste";
                else
                    label = "Cant Paste";

                if (!checkAddFrm)
                    UpdateAssetEvent();
                else
                    AddAssetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openF = new OpenFileDialog();
                openF.Filter = "Excel Documents (*.xlsx)|*.xlsx|Excel 97-2003 Documents (*.xls)|*.xls|All file (*.*)|*.*";
                if (openF.ShowDialog() == DialogResult.OK)
                {
                    if (openF.FileName.OpenExcelWorkBook())
                    {
                        dataImport.ImportExcelToTable(true);
                    }
                }
                foreach (DataRow dr in dataImport.Rows)
                {
                    dgvAddAssetList.Rows.Add(dr);
                }
                dgvAddAssetList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach (AssetInfoVo inf in infoList)
                {
                    AssetMaster2019Vo addAsset = (AssetMaster2019Vo)DefaultCbmInvoker.Invoke(new AddAssetCbm(), inf);
                    i += addAsset.executeInt;
                }
                MessageBox.Show("Total " + i + " rows have been add!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            infoList.Clear();
            dgvAddAssetList.Rows.Clear();
            dgvAddAssetList.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAssetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want exit anyway?", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void txtAcqCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
