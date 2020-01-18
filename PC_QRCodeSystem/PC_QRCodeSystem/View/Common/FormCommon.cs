using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem
{
    public partial class FormCommon : Form
    {
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
        }

        private void FormCommon_Load(object sender, EventArgs e)
        {
            name = UserData.username;
            dept = UserData.dept;
            logintime = UserData.logintime;
            listper = UserData.role_permision;
            tittle = this.Text;
            this.Text = tittle + "-QRCode System";
        }

        /// <summary>
        /// Check permision of controls
        /// </summary>
        /// <param name="controls"></param>
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

        /// <summary>
        /// When form have been shown, check premision
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCommon_Shown(object sender, EventArgs e)
        {
            FormCommon frm = (FormCommon)sender;
            CheckPermision(frm.Controls);
        }

        /// <summary>
        /// Set log out button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Noice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GetData gdata = new GetData();
                gdata.LogOut();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType().BaseType == typeof(FormCommon))
                    {
                        frm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Set change password button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpfrm = new ChangePasswordForm();
            cpfrm.ShowDialog();
        }
    }
}
