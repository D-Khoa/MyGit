using System;
using Com.Nidec.Mes.Framework.Login;
using Com.Nidec.Mes.GlobalMasterMaintenance;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.Rank;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.Units;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.Asset;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.WareHouse;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.UserLocation;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.InventoryForm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.AccountMainForm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.AccountCodeForm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.AccountLocationForm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.AccountWhForm.DetailPositionForm;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.VCVP
{
    public partial class FormMain2019 : GlobalMasterMaintenance.FormCommonNCVP
    {
        public FormMain2019()
        {
            InitializeComponent();
            MainMaster_grt.ItemSize = new System.Drawing.Size(0, 1);
        }

        private void FormMain2019_Load(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = false;
            List<string> list = UserData.GetUserData().ControlList;
            string a = SystemMaster_btn.ControlId;
            InvokeAuthorityControl(MasterMaintance_grb.Controls);
        }

        #region MAIN MENU
        private void SystemMaster_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = true;
            MainMaster_grt.SelectedTab = SystemMaster_tab;
        }

        private void LocalMaster_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = true;
            MainMaster_grt.SelectedTab = LocalMaster_tab;
        }

        private void NCVP_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = true;
            MainMaster_grt.SelectedTab = NCVC_tab;
        }

        private void NCVC_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = true;
            MainMaster_grt.SelectedTab = NCVC_tab;
        }

        private void NSTV_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.Visible = true;
            MainMaster_grt.SelectedTab = NSTV_tab;
        }

        private void ChangePass_btn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpfrm = new ChangePasswordForm();
            cpfrm.ShowDialog();
        }
        #endregion

        #region SYSTEM MASTER
        private void RegisterLocalUser_btn_Click(object sender, EventArgs e)
        {
            LocalUserMasterForm localUserFrm = new LocalUserMasterForm();
            localUserFrm.ShowDialog();
        }

        private void Language_btn_Click(object sender, EventArgs e)
        {
            CountryLanguageForm langFrm = new CountryLanguageForm();
            langFrm.ShowDialog();
        }

        private void Factory_btn_Click(object sender, EventArgs e)
        {
            FactoryMasterForm factFrm = new FactoryMasterForm();
            factFrm.ShowDialog();
        }

        private void UserFactory_btn_Click(object sender, EventArgs e)
        {
            UserFactoryForm userFactFrm = new UserFactoryForm();
            userFactFrm.ShowDialog();
        }

        private void Role_btn_Click(object sender, EventArgs e)
        {
            RoleForm roleFrm = new RoleForm();
            roleFrm.ShowDialog();
        }

        private void AuthController_btn_Click(object sender, EventArgs e)
        {
            AuthorityControlForm authControlFrm = new AuthorityControlForm();
            authControlFrm.ShowDialog();
        }

        private void RoleAuth_btn_Click(object sender, EventArgs e)
        {
            RoleAuthorityControlForm roleAuthFrm = new RoleAuthorityControlForm();
            roleAuthFrm.ShowDialog();
        }

        private void UserRole_btn_Click(object sender, EventArgs e)
        {
            UserRoleForm userRoleFrm = new UserRoleForm();
            userRoleFrm.ShowDialog();
        }

        private void Location_btn_Click(object sender, EventArgs e)
        {
            LocationForm locFrm = new LocationForm();
            locFrm.ShowDialog();
        }

        private void Building_btn_Click(object sender, EventArgs e)
        {
            BuildingForm builFrm = new BuildingForm();
            builFrm.ShowDialog();
        }
        #endregion

        #region LOCAL MASTER
        private void AssetMaster_btn_Click(object sender, EventArgs e)
        {
            AssetMaster2019Form assfrm = new AssetMaster2019Form();
            this.Hide();
            assfrm.ShowDialog();
            this.Show();
        }

        private void AccountManager_btn_Click(object sender, EventArgs e)
        {
            AccountManager2019Form accfrm = new AccountManager2019Form();
            this.Hide();
            accfrm.ShowDialog();
            this.Show();
        }
        #endregion

    }
}
