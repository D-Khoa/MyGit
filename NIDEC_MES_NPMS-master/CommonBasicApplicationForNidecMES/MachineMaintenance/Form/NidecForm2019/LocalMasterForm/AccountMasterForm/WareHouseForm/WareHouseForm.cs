using System;
using System.Drawing;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class WareHouseForm : FormCommonNCVP
    {
        WareHouseVo vo = new WareHouseVo();

        public WareHouseForm()
        {
            InitializeComponent();

        }

        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<WareHouseVo> assetName =
      (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetAssetNameWHCbm(), new WareHouseVo());
            cmbAssetName.DisplayMember = "asset_name";
            cmbAssetName.DataSource = assetName.GetList();
            cmbAssetName.Text = null;

            ValueObjectList<WareHouseVo> rankCode =
                (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetRankCdWHCbm(), new WareHouseVo());
            cmbRankCode.DisplayMember = "rank";
            cmbRankCode.DataSource = rankCode.GetList();
            cmbRankCode.Text = null;

            ValueObjectList<WareHouseVo> assetType =
           (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetAssetTypeWHCbm(), new WareHouseVo());
            cmbAssetType.DisplayMember = "asset_type";
            cmbAssetType.DataSource = assetType.GetList();
            cmbAssetType.Text = null;

            ValueObjectList<WareHouseVo> inventoryTime =
         (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetInventoryTimeWHCbm(), new WareHouseVo());
            cmbInventory.DisplayMember = "inventory_times";
            cmbInventory.DataSource = inventoryTime.GetList();
            cmbInventory.Text = null;

            ValueObjectList<WareHouseVo> invoice =
        (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetInvoiceWHCbm(), new WareHouseVo());
            cmbInvoiceNo.DisplayMember = "invoice";
            cmbInvoiceNo.DataSource = invoice.GetList();
            cmbInvoiceNo.Text = null;

            ValueObjectList<WareHouseVo> labelStatus =
                  (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetLabelStatusWHCbm(), new WareHouseVo());
            cmbLabelStatus.DisplayMember = "label_status";
            cmbLabelStatus.DataSource = labelStatus.GetList();
            cmbLabelStatus.Text = null;

            ValueObjectList<WareHouseVo> locationcd =
                  (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new GetLocationWHCbm(), new WareHouseVo());
            cmbLocation.DisplayMember = "location";
            cmbLocation.DataSource = locationcd.GetList();
            cmbLocation.Text = null;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridBind();
            txtAssetCode.Text = "";
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
        private void GridBind()
        {
            try
            {
                WareHouseVo whvos = new WareHouseVo()
                {
                    asset_code = txtAssetCode.Text,
                    asset_name = cmbAssetName.Text,
                    asset_model = txtAssetModel.Text,
                    asset_type = cmbAssetType.Text,
                    rank = cmbRankCode.Text,
                    invoice = cmbInvoiceNo.Text,
                    location = cmbLocation.Text,
                    label_status = cmbLabelStatus.Text,
                    net_value = cmbNetValue.Text,
                    inventory_times= cmbInventory.Text,
                    
                };
                if (checkdata())
                {
                    WareHouseVo listvo = (WareHouseVo)DefaultCbmInvoker.Invoke(new SearchWareHouseCbm(), whvos);
                    dgvAccountData.DataSource = listvo.table;
                    //    calculator();
                    // ReviewStatusLable();
                }
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            renew();
        }
        public void renew ()
        {
            vo = new WareHouseVo();
            dgvAccountData.DataSource = null;

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
    }
}
