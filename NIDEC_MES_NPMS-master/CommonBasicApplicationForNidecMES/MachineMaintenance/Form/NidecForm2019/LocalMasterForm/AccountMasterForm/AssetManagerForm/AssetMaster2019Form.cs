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
    public partial class AssetMaster2019Form : FormCommonNCVP
    {
        //CONNECT TO PQM DB
        public string connection = Properties.Settings.Default.CONNECTION_STRING;
        AssetMaster2019Vo vo;

        public AssetMaster2019Form()
        {
            InitializeComponent();
            vo = new AssetMaster2019Vo();
        }

        private void AssetMaster2019Form_Load(object sender, EventArgs e)
        {
            ValueObjectList<AssetMaster2019Vo> assetType = ((ValueObjectList<AssetMaster2019Vo>)DefaultCbmInvoker.Invoke(new GetAssetTypeCbm(), new AssetMaster2019Vo(), connection));
            cmbAssetType.DisplayMember = "asset_type";
            cmbAssetType.DataSource = assetType.GetList();
            ValueObjectList<AssetMaster2019Vo> assetLife = ((ValueObjectList<AssetMaster2019Vo>)DefaultCbmInvoker.Invoke(new GetAssetLifeCbm(), new AssetMaster2019Vo(), connection));
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
            AssetMaster2019Vo searchVo = (AssetMaster2019Vo)DefaultCbmInvoker.Invoke(new AssetMaster2019Cbm(), new AssetMaster2019Vo()
            {
                asset_cd = txtAssetCode.Text,
                asset_name = txtAssetName.Text,
                asset_type = cmbAssetType.Text,
                asset_life = cmbLife.Text,
                checkDateFrom = dtpDateFrom.Checked,
                checkDateTo = dtpDateTo.Checked
            }, connection);
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
                ExcelClass2019 excel = new ExcelClass2019(saveF.FileName);
                excel.CreateWorkBook();
                excel.AddDatatable(vo.asset_data);
                excel.SaveAndExit();
            }
        }

        private void dgvAssetGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = dgvAssetGrid.SelectedRows.Count > 0;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            AssetMaster2019Vo deleteVo = (AssetMaster2019Vo)DefaultCbmInvoker.Invoke(new AssetMaster2019Cbm(), new AssetMaster2019Vo()
            {
                asset_cd = txtAssetCode.Text,
                asset_name = txtAssetName.Text,
                asset_type = cmbAssetType.Text,
                asset_life = cmbLife.Text,
            }, connection);
        }

        private void dgvAssetGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
