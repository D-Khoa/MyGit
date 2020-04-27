using System;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class UserPosition : FormCommon
    {
        #region VARIABLE
        bool isUpdate = false;
        m_user_position userPositionCmb { get; set; }
        m_user_position userPositionData { get; set; }
        public UserPosition()
        {
            InitializeComponent();
            btnOK.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            userPositionCmb = new m_user_position();
            userPositionData = new m_user_position();
        }
        #endregion

        #region MAIN BUTTONS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            FieldsOption(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            FieldsOption(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                if (CustomMessageBox.Warring("Are you sure delete this user position?") == DialogResult.No) return;
                n = userPositionData.Delete(userPositionData);
                CustomMessageBox.Notice("Deleted " + n + " item!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            ClearAll();
            GetCmb();
            UpdateGrid(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            UpdateGrid(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                string messtring = string.Empty;
                if (isUpdate)
                {
                    n = userPositionData.Update(new m_user_position
                    {
                        user_position_id = userPositionData.user_position_id,
                        user_position_cd = cmbUserPositionCD.Text,
                        user_position_name = txtUserPositionName.Text,
                        registration_user_cd = UserData.usercode
                    });
                    messtring = "Update " + n + "completed";
                }
                else
                {
                    n = userPositionData.Add(new m_user_position
                    {
                        user_position_cd = cmbUserPositionCD.Text,
                        user_position_name = txtUserPositionName.Text,
                        registration_user_cd = UserData.usercode
                    });
                    messtring = "Add " + n + "completed";
                }
                ClearAll();
                GetCmb();
                UpdateGrid(true);
                FieldsOption(true);
                CustomMessageBox.Notice(messtring);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbUserPositionCD.Text))
                txtUserPositionName.Text = cmbUserPositionCD.SelectedValue.ToString();
            FieldsOption(true);
        }
        #endregion

        #region SUB EVENT
        private void UserPosition_Load(object sender, EventArgs e)
        {
            GetCmb();
            UpdateGrid(false);
        }

        private void cmbUserPositionCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Display user position name when change user position code
                if (!string.IsNullOrEmpty(cmbUserPositionCD.Text))
                    txtUserPositionName.Text = cmbUserPositionCD.SelectedValue.ToString();
                else
                    txtUserPositionName.Text = "User Position Name";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userPositionData = dgvData.Rows[e.RowIndex].DataBoundItem as m_user_position;
            cmbUserPositionCD.Text = userPositionData.user_position_cd;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion

        #region QUERY
        /// <summary>
        /// Update datagridview
        /// </summary>
        /// <param name="isSearch">if search data</param>
        public void UpdateGrid(bool isSearch)
        {
            if (isSearch)
                userPositionData.Search(cmbUserPositionCD.Text);
            dgvData.DataSource = null;
            dgvData.DataSource = userPositionData.listUserPosition;
            dgvData.Columns["user_position_id"].HeaderText = "Position ID";
            dgvData.Columns["user_position_cd"].HeaderText = "Position CD";
            dgvData.Columns["user_position_name"].HeaderText = "Position Name";
            dgvData.Columns["registration_user_cd"].HeaderText = "Registration User";
            dgvData.Columns["registration_date_time"].HeaderText = "Registration Date";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        /// <summary>
        /// Get data for combobox
        /// </summary>
        public void GetCmb()
        {
            userPositionCmb.Search(string.Empty);
            cmbUserPositionCD.DataSource = userPositionCmb.listUserPosition;
            cmbUserPositionCD.DisplayMember = "user_position_cd";
            cmbUserPositionCD.ValueMember = "user_position_name";
            cmbUserPositionCD.Text = null;
        }

        /// <summary>
        /// Clear all current data
        /// </summary>
        public void ClearAll()
        {
            dgvData.DataSource = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbUserPositionCD.Text = null;
            userPositionData.listUserPosition.Clear();
            txtUserPositionName.Text = "User Position Name";
        }

        /// <summary>
        /// Lock or unlock fields
        /// </summary>
        /// <param name="isLock">Lock option</param>
        public void FieldsOption(bool isLock)
        {
            btnOK.Visible = !isLock;
            btnCancel.Visible = !isLock;
            pnlButtons.Enabled = isLock;
            txtUserPositionName.ReadOnly = isLock;
            if (!isLock && !isUpdate)
                txtUserPositionName.Clear();
            if (!isLock)
                cmbUserPositionCD.DropDownStyle = ComboBoxStyle.DropDown;
            else cmbUserPositionCD.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
    }
}
