using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class UpdateAccountInfoForm : FormCommonNCVP
    {
        AccountInfoVo inVo = new AccountInfoVo();
        UserLocationVo userlocVo = new UserLocationVo();
        DataTable dtAsset = new DataTable();

        public UpdateAccountInfoForm()
        {
            InitializeComponent();
            pnlAddAccount.Visible = true;
        }

        public UpdateAccountInfoForm(AccountInfoVo vo)
        {
            InitializeComponent();
            inVo = vo;
            pnlAddAccount.Visible = false;
            this.Width -= pnlAddAccount.Width;
        }

        private void UpdateAccountInfoForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<UnitInfoVo> unitVo =
                (ValueObjectList<UnitInfoVo>)DefaultCbmInvoker.Invoke(new GetUnitInfoCbm(), new UnitInfoVo());
            cmbUnit.DataSource = unitVo.GetList();
            cmbUnit.DisplayMember = "unit_name";
            cmbUnit.ValueMember = "unit_id";
            cmbUnit.Text = null;
            ValueObjectList<AccountCodeVo> accVo =
                (ValueObjectList<AccountCodeVo>)DefaultCbmInvoker.Invoke(new GetAccountCodeCbm(), new AccountCodeVo());
            cmbAccountCode.DataSource = accVo.GetList();
            cmbAccountCode.DisplayMember = "account_code_name";
            cmbAccountCode.ValueMember = "account_code_id";
            cmbAccountCode.Text = null;
            ValueObjectList<RankInfoVo> rankVo =
                (ValueObjectList<RankInfoVo>)DefaultCbmInvoker.Invoke(new GetRankInfoCbm(), new RankInfoVo());
            cmbRank.DataSource = rankVo.GetList();
            cmbRank.DisplayMember = "rank_name";
            cmbRank.ValueMember = "rank_id";
            cmbRank.Text = null;
            ValueObjectList<AccountLocationVo> sectionVo =
               (ValueObjectList<AccountLocationVo>)DefaultCbmInvoker.Invoke(new GetAccountLocationCbm(), new AccountLocationVo());
            cmbSection.DataSource = sectionVo.GetList();
            cmbSection.DisplayMember = "account_location_name";
            cmbSection.ValueMember = "account_location_id";
            cmbSection.Text = null;
            ValueObjectList<LocationInfoVo> locationVo =
               (ValueObjectList<LocationInfoVo>)DefaultCbmInvoker.Invoke(new GetLocationInfoCbm(), new LocationInfoVo());
            cmbLocation.DataSource = locationVo.GetList();
            cmbLocation.DisplayMember = "location_name";
            cmbLocation.ValueMember = "location_id";
            cmbLocation.Text = null;
            AssetMaster2019Vo assetVo = (AssetMaster2019Vo)DefaultCbmInvoker.Invoke(new AssetMaster2019Cbm(), new AssetMaster2019Vo
            {
                asset_cd = inVo.asset_cd,
                asset_no = inVo.asset_no
            });
            dtAsset = assetVo.asset_data;
            GetUpdateInfo();
        }

        public void GetUpdateInfo()
        {
            txtAssetCode.Text = inVo.asset_cd;
            cmbAssetNo.Text = inVo.asset_no.ToString();
            txtUserCode.Text = inVo.user_location_cd;
            lbUserLocation.Text = inVo.user_location_name;
            txtQty.Text = inVo.qty.ToString();
            txtComment.Text = inVo.comment_data;
            cmbAccountCode.Text = inVo.account_code_name;
            cmbRank.Text = inVo.rank_name;
            cmbSection.Text = inVo.account_location_name;
            cmbUnit.Text = inVo.unit_name;
            dtpDeprStart.Value = inVo.depreciation_start;
            dtpDeprEnd.Value = inVo.depreciation_end;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInfoVo outVo = new AccountInfoVo
                {
                    asset_id = cmbAssetNo.ValueMember,
                    user_location_id = userlocVo.user_location_id,
                    qty = int.Parse(txtQty.Text),
                    unit_id = cmbUnit.ValueMember,
                    depreciation_start = dtpDeprStart.Value,
                    depreciation_end = dtpDeprEnd.Value,
                    account_code_id = cmbAccountCode.ValueMember,
                    rank_id = cmbRank.ValueMember,
                    account_location_id = int.Parse(cmbSection.ValueMember),
                    location_id = int.Parse(cmbLocation.ValueMember),
                    comment_data = txtComment.Text
                };
                outVo = (AccountInfoVo)DefaultCbmInvoker.Invoke(new UpdateAccountInfoCbm(), outVo);
                MessageBox.Show("Update finish!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARRING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pnlAddAccount.Visible)
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvAddAccount.Rows.Count > 0)
            {
                if (MessageBox.Show("Data has not been saved. Are you sure to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtAssetCode_TextChanged(object sender, EventArgs e)
        {
            DataView dwAssetNo = new DataView(dtAsset);
            cmbAssetNo.DataSource = dtAsset.Select("asset_cd ='" + txtAssetCode.Text + "'");
            cmbAssetNo.DisplayMember = "asset_no";
            cmbAssetNo.ValueMember = "asset_id";
        }

        private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            userlocVo = (UserLocationVo)DefaultCbmInvoker.Invoke(new GetUserLocationCbm(), new UserLocationVo
            {
                user_location_cd = txtUserCode.Text
            });
            lbUserLocation.Text = userlocVo.user_location_name;
        }
    }
}
