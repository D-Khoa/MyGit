using System;
using System.Drawing;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class AssetMaster2019Form : FormCommonNCVP
    {
        AssetMaster2019Vo vo;
        AssetInfoVo voInfo;

        public AssetMaster2019Form()
        {
            InitializeComponent();
            vo = new AssetMaster2019Vo();
            voInfo = new AssetInfoVo();
        }

        private void AssetMaster2019Form_Load(object sender, EventArgs e)
        {
            ValueObjectList<AssetMaster2019Vo> assetType = (ValueObjectList<AssetMaster2019Vo>)DefaultCbmInvoker
                                                           .Invoke(new GetAssetTypeCbm(), new AssetMaster2019Vo());
            cmbAssetType.DisplayMember = "asset_type";
            cmbAssetType.DataSource = assetType.GetList();
            ValueObjectList<AssetMaster2019Vo> assetLife = (ValueObjectList<AssetMaster2019Vo>)DefaultCbmInvoker
                                                           .Invoke(new GetAssetLifeCbm(), new AssetMaster2019Vo());
            cmbLife.DisplayMember = "asset_life";
            cmbLife.DataSource = assetLife.GetList();
            reNew();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAssetCode.TextLength > 10)
            {
                string str = txtAssetCode.Text;
                string[] arrListStr = str.Split(',');
                txtAssetCode.Text = arrListStr[0];
            }
            vo.label_status = "'1'";
            if (chkPasted.Checked)
                vo.label_status += ",'Pasted'";
            if (chkNotPaste.Checked)
                vo.label_status += ",'Not Paste'";
            if (chkCantPaste.Checked)
                vo.label_status += ",'Cant Paste'";
            AssetMaster2019Vo searchVo = (AssetMaster2019Vo)DefaultCbmInvoker
                                         .Invoke(new AssetMaster2019Cbm(), new AssetMaster2019Vo()
                                         {
                                             asset_cd = txtAssetCode.Text,
                                             asset_name = txtAssetName.Text,
                                             asset_type = cmbAssetType.Text,
                                             asset_life = cmbLife.Text,
                                             checkDateFrom = dtpDateFrom.Checked,
                                             checkDateTo = dtpDateTo.Checked,
                                             label_status = vo.label_status
                                         });
            vo.asset_data = searchVo.asset_data;
            updateGrid();
        }

        private void updateGrid()
        {
            dgvAssetGrid.DataSource = vo.asset_data;
            #region SET COLUMNS NAME
            dgvAssetGrid.Columns["asset_cd"].HeaderText = "Asset Code";
            dgvAssetGrid.Columns["asset_no"].HeaderText = "Asset No";
            dgvAssetGrid.Columns["asset_name"].HeaderText = "Asset Name";
            dgvAssetGrid.Columns["asset_serial"].HeaderText = "Asset Serial";
            dgvAssetGrid.Columns["asset_model"].HeaderText = "Asset Model";
            dgvAssetGrid.Columns["asset_life"].HeaderText = "Life";
            dgvAssetGrid.Columns["acquistion_cost"].HeaderText = "Acquisition Cost";
            dgvAssetGrid.Columns["acquistion_date"].HeaderText = "Acquisition Date";
            dgvAssetGrid.Columns["asset_invoice"].HeaderText = "Invoice";
            dgvAssetGrid.Columns["asset_po"].HeaderText = "P/O";
            dgvAssetGrid.Columns["asset_type"].HeaderText = "Asset Type";
            dgvAssetGrid.Columns["factory_cd"].HeaderText = "Factory";
            dgvAssetGrid.Columns["asset_supplier"].HeaderText = "Supplier";
            dgvAssetGrid.Columns["label_status"].HeaderText = "Label";
            #endregion
            dgvAssetGrid.Refresh();
            tsNumberOfRow.Text = vo.asset_data.Rows.Count.ToString() + " rows";
        }

        private void dgvAssetGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (dgvAssetGrid.Rows[e.RowIndex].Cells["label_status"].Value.ToString())
            {
                case "Pasted":
                    e.CellStyle.BackColor = Color.Lime;
                    break;
                case "Not Paste":
                    e.CellStyle.BackColor = Color.Yellow;
                    break;
                case "Cant Paste":
                    e.CellStyle.BackColor = Color.Red;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reNew();
        }

        private void reNew()
        {
            txtAssetCode.Clear();
            txtAssetName.Clear();
            cmbLife.Text = null;
            cmbAssetType.Text = null;
            dtpDateFrom.Checked = false;
            dtpDateTo.Checked = false;
            dgvAssetGrid.DataSource = null;
            txtAssetCode.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog();
            saveF.Filter = "Excel Documents (*.xlsx)|*.xlsx|Excel 97-2003 Documents (*.xls)|*.xls|All file (*.*)|*.*";
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                saveF.FileName.CreateExcelWorkBook();
                vo.asset_data.DatatableToExcel();
                saveF.FileName.SaveAndExit(true);
            }
        }

        private void dgvAssetGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = dgvAssetGrid.SelectedRows.Count > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AssetMaster2019Vo deleteVo = (AssetMaster2019Vo)DefaultCbmInvoker
                                         .Invoke(new AssetMaster2019Cbm(), new AssetMaster2019Vo()
                                         {
                                             asset_cd = txtAssetCode.Text,
                                             asset_name = txtAssetName.Text,
                                             asset_type = cmbAssetType.Text,
                                             asset_life = cmbLife.Text,
                                         });
        }

        private void dgvAssetGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssetGrid.SelectedRows.Count > 0)
            {
                CallUpdateForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CallUpdateForm();
        }

        private void CallUpdateForm()
        {
            #region GET DATA FROM DGV TO VOINFO
            voInfo.asset_cd = dgvAssetGrid.SelectedRows[0].Cells["asset_cd"].Value.ToString();
            voInfo.asset_no = (int)dgvAssetGrid.SelectedRows[0].Cells["asset_no"].Value;
            voInfo.asset_name = dgvAssetGrid.SelectedRows[0].Cells["asset_name"].Value.ToString();
            voInfo.asset_serial = dgvAssetGrid.SelectedRows[0].Cells["asset_serial"].Value.ToString();
            voInfo.asset_model = dgvAssetGrid.SelectedRows[0].Cells["asset_model"].Value.ToString();
            voInfo.asset_life = (double)dgvAssetGrid.SelectedRows[0].Cells["asset_life"].Value;
            voInfo.acquistion_cost = (double)dgvAssetGrid.SelectedRows[0].Cells["acquistion_cost"].Value;
            voInfo.acquistion_date = (DateTime)dgvAssetGrid.SelectedRows[0].Cells["acquistion_date"].Value;
            voInfo.asset_invoice = dgvAssetGrid.SelectedRows[0].Cells["asset_invoice"].Value.ToString();
            voInfo.asset_po = dgvAssetGrid.SelectedRows[0].Cells["asset_po"].Value.ToString();
            voInfo.asset_type = dgvAssetGrid.SelectedRows[0].Cells["asset_type"].Value.ToString();
            voInfo.factory_cd = dgvAssetGrid.SelectedRows[0].Cells["factory_cd"].Value.ToString();
            voInfo.asset_supplier = dgvAssetGrid.SelectedRows[0].Cells["asset_supplier"].Value.ToString();
            voInfo.label_status = dgvAssetGrid.SelectedRows[0].Cells["label_status"].Value.ToString();
            #endregion
            UpdateAssetForm upAssetFrm = new UpdateAssetForm(voInfo, false);
            upAssetFrm.TitleText = "Update Asset Module";
            upAssetFrm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateAssetForm addAssetFrm = new UpdateAssetForm();
            addAssetFrm.TitleText = "Add Asset Module";
            addAssetFrm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssetMaster2019Form_Resize(object sender, EventArgs e)
        {
            grbInfo.Location = new Point((this.Width / 2) - (grbInfo.Width / 2), grbInfo.Location.Y);
            grbButtons.Location = new Point((this.Width / 2) - (grbButtons.Width / 2), grbButtons.Location.Y);
        }

        private void cmbLife_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
