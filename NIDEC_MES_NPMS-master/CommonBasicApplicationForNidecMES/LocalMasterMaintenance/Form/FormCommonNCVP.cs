using System;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Form
{
    public partial class FormCommonNCVP : Com.Nidec.Mes.Framework.FormCommonBase
    {
        public FormCommonNCVP()
        {
            InitializeComponent();
        }

        private void FormCommonNCVP_Load(object sender, System.EventArgs e)
        {
            pnlUserInfo.Width = Math.Max(lbLastLogin.Width, lbUserName.Width) + 20;
        }
    }
}
