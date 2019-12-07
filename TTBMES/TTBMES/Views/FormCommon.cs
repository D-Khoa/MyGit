﻿using System;
using System.Windows.Forms;
using TTBMES.Models;

namespace TTBMES.Views
{
    public partial class FormCommon : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public FormCommon()
        {
            InitializeComponent();
        }

        public string TitleText
        {
            get
            { return this.Title_lbl.Text; }
            set
            { this.Title_lbl.Text = value; }
        }

        public string AppName
        {
            get
            { return this.AppName_lbl.Text; }
            set
            { this.AppName_lbl.Text = value; }
        }

        public string ControlId { get; set; }

        /// <summary>
        /// show with local settings
        /// </summary>
        /// <param name="fp"></param>
        /// <param name="arguments"></param>
        public void Show(FormCommon fp, object arguments = null)
        {
            if (fp != null) this.InvokeAuthorityControl(fp.Controls);
            this.Show();
        }

        /// <summary>
        /// showdialog with local settings
        /// </summary>
        /// <param name="fp"></param>
        /// <param name="arguments"></param>
        public void ShowDialog(FormCommon fp, object arguments = null)
        {
            if (fp != null) this.InvokeAuthorityControl(fp.Controls);
            this.ShowDialog();
        }


        /// <summary>
        /// Handles authorization control for the controls
        /// </summary>
        /// <param name="cntrl"></param>
        public void InvokeAuthorityControl(Control.ControlCollection cntrl)
        {

            if (UserData.GetUserData().ControlList != null && this.ControlId != null)
            {
                foreach (Control c in cntrl)
                {
                    if (c.GetType() == typeof(ButtonCommon))
                    {
                        ButtonCommon btnControl = (ButtonCommon)c;

                        btnControl.Enabled = string.IsNullOrEmpty(btnControl.ControlId) || UserData.GetUserData().ControlList.Contains(btnControl.ControlId);
                    }
                    if (c.GetType() == typeof(GroupBox))
                    {
                        InvokeAuthorityControl(c.Controls);
                    }
                    if (c.GetType() == typeof(Panel))
                    {
                        InvokeAuthorityControl(c.Controls);
                    }
                    if (c.GetType() == typeof(TabControl))
                    {
                        TabControl tabControl = (TabControl)c;

                        for (int i = 0; i < tabControl.TabPages.Count; i++)
                        {
                            string tpControlId = Convert.ToString(tabControl.TabPages[i].Tag);

                            if (string.IsNullOrEmpty(tpControlId))
                            {
                                InvokeAuthorityControl(tabControl.TabPages[i].Controls);
                            }
                            else
                            {
                                if (UserData.GetUserData().ControlList.Contains(tpControlId))
                                {
                                    InvokeAuthorityControl(tabControl.TabPages[i].Controls);
                                }
                                else
                                {
                                    tabControl.TabPages.Remove(tabControl.TabPages[i]);
                                    i--;
                                }
                            }
                        }
                        InvokeAuthorityControl(c.Controls);
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCommon_Load(object sender, EventArgs e)
        {
            this.UserName_lbl.Text += UserData.GetUserData().UserName;
            this.FactoryCode_lbl.Text += UserData.GetUserData().FactoryCode;
            this.AppName_lbl.Text = UserData.GetUserData().AppName;
            this.Title_lbl.Text = this.Text;
            if (!this.DesignMode)
            {
                this.Text += " - " + UserData.GetUserData().AppName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            FormCollection forms = Application.OpenForms;

            for (int formCount = forms.Count - 1; formCount >= 0; formCount--)
            {
                if (forms[formCount].GetType().BaseType != typeof(FormCommon))
                {
                    FormCommon frmopen = (FormCommon)forms[formCount];
                    frmopen.Close();

                    if (frmopen.CanFocus)
                    {
                        break;
                    }
                }
            }
        }
    }
}

