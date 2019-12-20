using System;
using System.Drawing;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class WareHouseForm  :  FormCommonNCVP
    {
        WareHouseVo vo = new WareHouseVo();

        public WareHouseForm()
        {
            InitializeComponent();
       
        }

        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
            {
                account_depreciation_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                account_depreciation_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                warehouse_main_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                warehouse_main_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            }

            ValueObjectList<WareHouseVo> assetName = 
                (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetAssetNameWHCbm(), new WareHouseVo());
            cmbAssetName.DisplayMember = "asset_name";
            cmbAssetName.DataSource = assetName.GetList();
            cmbAssetName.Text = null;

            ValueObjectList<WareHouseVo> rankCode =
                (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetRankCdWHCbm(), new WareHouseVo());
            cmbRankCode.DisplayMember = "rank_cd";
            cmbRankCode.DataSource = rankCode.GetList();
            cmbRankCode.Text = null;

            ValueObjectList<WareHouseVo> assetType =
           (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetAssetTypeWHCbm(), new WareHouseVo());
            cmbAssetType.DisplayMember = "asset_type";
            cmbAssetType.DataSource = assetType.GetList();
            cmbAssetType.Text = null;

            ValueObjectList<WareHouseVo> inventoryTime =
         (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetInventoryTimeWHCbm(), new WareHouseVo());
            cmbInventory.DisplayMember = "invertory_time_cd";
            cmbInventory.DataSource = inventoryTime.GetList();
            cmbInventory.Text = null;

            ValueObjectList<WareHouseVo> invoice =
        (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetInvoiceWHCbm(), new WareHouseVo());
            cmbInvoiceNo.DisplayMember = "asset_invoice";
            cmbInvoiceNo.DataSource = invoice.GetList();
            cmbInvoiceNo.Text = null;

            ValueObjectList<WareHouseVo> labelStatus =
                  (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetLabelStatusWHCbm(), new WareHouseVo());
            cmbLabelStatus.DisplayMember = "label_status";
            cmbLabelStatus.DataSource = labelStatus.GetList();
            cmbLabelStatus.Text = null;

            ValueObjectList<WareHouseVo> locationcd =
                  (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetLocationWHCbm(), new WareHouseVo());
            cmbLocation.DisplayMember = "location_cd";
            cmbLocation.DataSource = locationcd.GetList();
            cmbLocation.Text = null;

        }

        public void trimcode()
        {
            if (txtAssetCode.TextLength >= 7)
            {
                // asset_Code_txt.Text = full_asset_Code_txt.Text.Substring(0, 10);
                string str = txtAssetCode.Text;
                string[] arrListStr = str.Split(',');
                txtAssetCode.Text = arrListStr[0];
                txtAssetCode.Enabled = false;
            }
            else
            {
                txtAssetCode.Enabled = true;
                txtAssetCode.Text = "";
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            account_depreciation_dgv.Visible = false;
            warehouse_main_dgv.Visible = true;
            GridBind();
            txtAssetCode.Text = "";

        }

        private void GridBind()
        {
            try
            {
                WareHouseVo whvos = new WareHouseVo()
                {
                    asset_type = cmbAssetType.Text,
                    asset_cd = txtAssetCode.Text,
                    asset_model = txtAssetModel.Text,
                    asset_name = cmbAssetName.Text,
                    rank_cd = cmbRankCode.Text,
                    location_cd = cmbLocation.Text,
                    net_value = cmbNetValue.Text,
                    asset_invoice = cmbInvoiceNo.Text,
                    label_status = cmbLabelStatus.Text,
                    invertory_time_cd = cmbInventory.Text,

                };
                ValueObjectList<WareHouseVo> whData = (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new SearchWareHouseCbm(), whvos);
                //if (checkdata())
                //{
                //    if (select_search_cbm.Text == "Search History")
                //    {
                //        ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new SearchWareHouseMainCbm(), whvos);
                //        warehouse_main_dgv.DataSource = listvo.GetList();
                //    }
                //    else if (select_search_cbm.Text == "Search List")
                //    {
                //        ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new SearchListWareHouseMainCbm(), whvos);
                //        warehouse_main_dgv.DataSource = listvo.GetList();
                //        foreach (DataGridViewRow dr in warehouse_main_dgv.Rows)
                //        {
                //            string after = (string)dr.Cells["colafterlocation"].Value;
                //            string nowloc = (string)dr.Cells["colnowlocation"].Value;
                //            if (after != nowloc)
                //            {
                //                dr.DefaultCellStyle.ForeColor = Color.Blue;
                //            }
                //        }
                //        invertory_alarm();
                //        counter();
                //    }
                //    //   calculator();
                //}
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        bool checkdata()
        {
            if (cmbInventory.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Invertory");
                popUpMessage.Warning(messageData, Text);
                cmbInventory.Focus();
                return false;
            }
            return true;
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

        private void btnTransferAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountDepr_Click(object sender, EventArgs e)
        {

        }

        private void btnRankDepr_Click(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtAssetCode_TextChanged(object sender, EventArgs e)
        {
            trimcode();
        }
    }
}
