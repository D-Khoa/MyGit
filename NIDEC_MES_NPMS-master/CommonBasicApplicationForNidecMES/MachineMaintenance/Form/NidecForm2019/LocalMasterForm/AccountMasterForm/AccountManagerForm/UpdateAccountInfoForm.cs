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
        AccountInfoVo accountVo = new AccountInfoVo();
        ValueObjectList<UserLocationVo> userlocVoList = new ValueObjectList<UserLocationVo>();
        int user_location_id;

        public UpdateAccountInfoForm()
        {
            InitializeComponent();
            //pnlAddAccount.Visible = true;
        }

        public UpdateAccountInfoForm(int account_id)
        {
            InitializeComponent();
            //pnlAddAccount.Visible = false;
            //this.Width -= pnlAddAccount.Width;
            accountVo.account_main_id = account_id;
            accountVo = (AccountInfoVo)DefaultCbmInvoker.Invoke(new GetAccountInfoCbm(), accountVo);
        }

        private void UpdateAccountInfoForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<UnitInfoVo> unitVo =
                (ValueObjectList<UnitInfoVo>)DefaultCbmInvoker.Invoke(new GetUnitInfoCbm(), new UnitInfoVo());
            cmbUnit.DataSource = unitVo.GetList();
            cmbUnit.DisplayMember = "unit_name";
            cmbUnit.ValueMember = "unit_id";
            cmbUnit.SelectedItem = accountVo.unit_id;
            ValueObjectList<AccountCodeVo> accVo =
                (ValueObjectList<AccountCodeVo>)DefaultCbmInvoker.Invoke(new GetAccountCodeCbm(), new AccountCodeVo());
            cmbAccountCode.DataSource = accVo.GetList();
            cmbAccountCode.DisplayMember = "account_code_name";
            cmbAccountCode.ValueMember = "account_code_id";
            cmbAccountCode.SelectedItem = accountVo.account_code_id;
            ValueObjectList<RankInfoVo> rankVo =
                (ValueObjectList<RankInfoVo>)DefaultCbmInvoker.Invoke(new GetRankInfoCbm(), new RankInfoVo());
            cmbRank.DataSource = rankVo.GetList();
            cmbRank.DisplayMember = "rank_name";
            cmbRank.ValueMember = "rank_id";
            cmbRank.SelectedItem = accountVo.rank_id;
            ValueObjectList<AccountLocationVo> sectionVo =
               (ValueObjectList<AccountLocationVo>)DefaultCbmInvoker.Invoke(new GetAccountLocationCbm(), new AccountLocationVo());
            cmbSection.DataSource = sectionVo.GetList();
            cmbSection.DisplayMember = "account_location_name";
            cmbSection.ValueMember = "account_location_id";
            cmbSection.SelectedItem = accountVo.account_location_id;
            ValueObjectList<LocationInfoVo> locationVo =
               (ValueObjectList<LocationInfoVo>)DefaultCbmInvoker.Invoke(new GetLocationInfoCbm(), new LocationInfoVo());
            cmbLocation.DataSource = locationVo.GetList();
            cmbLocation.DisplayMember = "location_name";
            cmbLocation.ValueMember = "location_id";
            cmbLocation.SelectedItem = accountVo.location_id;
            ValueObjectList<AssetInfoVo> assetVoList = (ValueObjectList<AssetInfoVo>)DefaultCbmInvoker.Invoke(new GetAssetInfoCbm(), new AssetInfoVo
            {
                asset_id = accountVo.asset_id,
            });
            foreach (AssetInfoVo assetVo in assetVoList.GetList())
            {
                txtAssetCode.Text = assetVo.asset_cd;
                txtAssetNo.Text = assetVo.asset_no.ToString();
                accountVo.acquisition_cost = assetVo.acquistion_cost;
                accountVo.asset_life = assetVo.asset_life;
            }
            txtQty.Text = accountVo.qty.ToString();
            txtComment.Text = accountVo.comment_data;
            dtpDeprStart.Value = accountVo.depreciation_start;
            dtpDeprEnd.Value = accountVo.depreciation_end;
            getUserLocation(accountVo.user_location_id);
            CalcCost();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                AssetInfoVo outAsset = (AssetInfoVo)DefaultCbmInvoker.Invoke(new GetAssetInfoCbm(), new AssetInfoVo
                {
                    asset_cd = txtAssetCode.Text,
                    asset_no = int.Parse(txtAssetNo.Text)
                });
                AccountInfoVo outVo = new AccountInfoVo
                {
                    account_main_id = accountVo.account_main_id,
                    asset_id = outAsset.asset_id,
                    qty = int.Parse(txtQty.Text),
                    unit_id = int.Parse(cmbUnit.ValueMember),
                    account_code_id = int.Parse(cmbAccountCode.ValueMember),
                    account_location_id = int.Parse(cmbSection.ValueMember),
                    rank_id = int.Parse(cmbRank.ValueMember),
                    comment_data = txtComment.Text,
                    depreciation_start = dtpDeprStart.Value,
                    depreciation_end = dtpDeprEnd.Value,

                    location_id = int.Parse(cmbLocation.ValueMember),
                    user_location_id = user_location_id,
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
                if (MessageBox.Show("Data has not been saved. Are you sure to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            getUserLocation(txtUserCode.Text);
        }

        private void getUserLocation(int id)
        {
            userlocVoList = (ValueObjectList<UserLocationVo>)DefaultCbmInvoker.Invoke(new GetUserLocationCbm(), new UserLocationVo
            {
                user_location_id = id,
            });
            foreach (UserLocationVo userlocVo in userlocVoList.GetList())
            {
                user_location_id = userlocVo.user_location_id;
                txtUserCode.Text = userlocVo.user_location_cd;
                lbUserLocation.Text = userlocVo.user_location_name;
            }
        }

        private void getUserLocation(string cd)
        {
            userlocVoList = (ValueObjectList<UserLocationVo>)DefaultCbmInvoker.Invoke(new GetUserLocationCbm(), new UserLocationVo
            {
                user_location_cd = cd,
            });
            foreach (UserLocationVo userlocVo in userlocVoList.GetList())
            {
                user_location_id = userlocVo.user_location_id;
                txtUserCode.Text = userlocVo.user_location_cd;
                lbUserLocation.Text = userlocVo.user_location_name;
            }
        }

        private void CalcCost()
        {
            accountVo.monthly_depreciation = accountVo.acquisition_cost / (accountVo.asset_life * 12);
            TimeSpan totalMonth = DateTime.Now.Subtract(dtpDeprStart.Value);
            accountVo.accum_depreciation = accountVo.monthly_depreciation * ((totalMonth.TotalDays / 365) * 12);
            accountVo.current_depreciation = accountVo.accum_depreciation - accountVo.monthly_depreciation;
            accountVo.net_value = accountVo.acquisition_cost - accountVo.accum_depreciation;
            dgvCost.Rows.Add(accountVo.acquisition_cost, accountVo.monthly_depreciation, accountVo.current_depreciation, accountVo.accum_depreciation, accountVo.net_value);
        }
    }
}
