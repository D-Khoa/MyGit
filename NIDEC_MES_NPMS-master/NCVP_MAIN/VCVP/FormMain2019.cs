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

namespace Com.Nidec.Mes.VCVP
{
    public partial class FormMain2019 : GlobalMasterMaintenance.FormCommonNCVP
    {
        public FormMain2019()
        {
            InitializeComponent();
            MainMaster_grt.ItemSize = new System.Drawing.Size(0, 1);
        }

        private void SystemMaster_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.SelectedTab = SystemMaster_tab;
        }

        private void LocalMaster_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.SelectedTab = LocalMaster_tab;
        }

        private void NCVP_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.SelectedTab = NCVC_tab;
        }

        private void NCVC_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.SelectedTab = NCVC_tab;
        }

        private void NSTV_btn_Click(object sender, EventArgs e)
        {
            MainMaster_grt.SelectedTab = NSTV_tab;
        }

        private void ChangePass_btn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpfrm = new ChangePasswordForm();
            cpfrm.ShowDialog();
        }

        private void AssetMaster_btn_Click(object sender, EventArgs e)
        {
            AssetMaster2019Form assfrm = new AssetMaster2019Form();
            this.Hide();
            assfrm.ShowDialog();
            this.Show();
        }
    }
}
