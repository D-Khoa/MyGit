using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem
{
    public partial class FormCommon : Form
    {
        #region ALL OPTION FIELDS
        /// <summary>
        /// Get tittle of form
        /// </summary>
        public string tittle
        {
            get { return lbTittle.Text; }
            set { lbTittle.Text = value; }
        }

        /// <summary>
        /// Get username
        /// </summary>
        public string name
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        /// <summary>
        /// Get user position
        /// </summary>
        public string position
        {
            get { return lbPosition.Text; }
            set { lbPosition.Text = value; }
        }

        /// <summary>
        /// Get department
        /// </summary>
        public string dept
        {
            get { return lbDept.Text; }
            set { lbDept.Text = value; }
        }

        /// <summary>
        /// Get login time of user
        /// </summary>
        public DateTime logintime
        {
            get { return DateTime.Parse(lbLoginTime.Text); }
            set { lbLoginTime.Text = value.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        /// <summary>
        /// list role of user
        /// </summary>
        public List<string> listper { get; set; }

        public FormCommon()
        {
            InitializeComponent();
            listper = new List<string>();
            timerFormLoad.Enabled = true;
        }

        private void FormCommon_Load(object sender, EventArgs e)
        {
            tittle = this.Text;
            dept = UserData.dept;
            name = UserData.username;
            position = UserData.position;
            logintime = UserData.logintime;
            listper = UserData.role_permision;
            this.Text = tittle + "-QRCode System";
            lbOnlineTime.Text = TimeSpan.FromSeconds(UserData.onTime).ToString();
            SettingItem settingItem = new SettingItem();
            settingItem.LoadSetting();
        }
        #endregion

        #region BUTTONS EVENT
        public void CheckPermision(Control.ControlCollection controls)
        {
            if (UserData.role_permision != null)
            {
                foreach (Control control in controls)
                {
                    if (!UserData.role_permision.Contains(control.Tag) && (control.Tag != null))
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpfrm = new ChangePasswordForm();
            cpfrm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Question("Are you sure to log-out?") == DialogResult.Yes)
            {
                m_login_password mlog = new m_login_password();
                UserData.isOnline = mlog.LogIO(UserData.usercode, false);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SUB EVENT
        private void FormCommon_Shown(object sender, EventArgs e)
        {
            FormCommon frm = (FormCommon)sender;
            CheckPermision(frm.Controls);
        }

        private void timerFormLoad_Tick(object sender, EventArgs e)
        {
            if (!UserData.isOnline && !string.IsNullOrEmpty(UserData.usercode)) this.Close();
            lbOnlineTime.Text = TimeSpan.FromSeconds(UserData.onTime).ToString();
        }

        private void FormCommon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserData.isOnline)
            {
                if (CustomMessageBox.Question("Are you want to close?") == DialogResult.No)
                    e.Cancel = true;
            }
        }
        #endregion
    }
}
