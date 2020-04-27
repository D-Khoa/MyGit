using System;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class DestinationManager : FormCommon
    {
        #region VARIABLE
        bool editMode { get; set; }
        bool firstload { get; set; }

        m_department deptcbm { get; set; }
        m_department ptsdept { get; set; }
        pts_destination destcbm { get; set; }
        pts_destination ptsdest { get; set; }
        m_mes_user userposition { get; set; }
        m_mes_user userpositioncbm { get; set; }

        #endregion

        public DestinationManager()
        {
            InitializeComponent();
            #region SETUP CONTROL
            deptcbm = new m_department();
            ptsdept = new m_department();
            destcbm = new pts_destination();
            ptsdest = new pts_destination();
            userposition = new m_mes_user();
            userpositioncbm = new m_mes_user();
            editMode = false;
            firstload = true;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            #endregion
        }
        #region FORM LOAD
        private void DestinationManager_Load(object sender, EventArgs e)
        {
            GetCmbData();
        }

        private void DestinationManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnOK.Visible)
            {
                if (MessageBox.Show("You are in processing! Are you sure exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        #endregion
        #region EVENT CHANGE TEXT ON FIELDS
        private void cmbDepartmentCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbDepartmentCode.Text) && !firstload)
                {
                    userposition = userposition.GetPositionUser(cmbDepartmentCode.Text, "MGR");
                    txtMUserCode.Text = userposition.user_cd;
                    txtMUserName.Text = userposition.user_name;
                    txtDepartmantName.Text = cmbDepartmentCode.SelectedValue.ToString();
                    userposition = userposition.GetPositionUser(cmbDepartmentCode.Text, "GM");
                    txtGMUserCode.Text = userposition.user_cd;
                    txtGMUserName.Text = userposition.user_name;

                }
                else
                    txtDepartmantName.Text = "Department Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDestinationCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbDestinationCode.Text))

                    txtDestinationName.Text = cmbDestinationCode.SelectedValue.ToString();

                else
                    txtDestinationName.Text = "Destination Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region MAIN BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbDepartmentCode.Enabled = true;
            UnlockFields(false);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbDepartmentCode.Enabled = true;
            UnlockFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This action is not undo" + Environment.NewLine + "Are you sure delete this?", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            int n = 0;
            if (rbtnDepartMent.Checked)
            {
                n = ptsdept.DeleteDept(ptsdept.dept_id);
            }
            if (rbtnDestinationCode.Checked)
            {
                n = ptsdest.DeleteDest(ptsdest.destination_id);
            }
            ClearFields();
            GetCmbData();
            UpdateGrid(true);
            txtGMUserCode.Text = null;
            txtGMUserName.Text = null;
            txtMUserCode.Text = null;
            txtMUserName.Text = null;
            MessageBox.Show("Delete " + n + " Item", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SUB BUTTON
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                string messstring = string.Empty;
                #region ADD & UPDATE DEPARTMENT
                if (rbtnDepartMent.Checked)
                {
                    //Edit mode for update item
                    if (editMode)
                    {
                        n = ptsdept.UpdateDept(new m_department
                        {
                            dept_cd = cmbDepartmentCode.Text,
                            dept_name = txtDepartmantName.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {
                        //CALL FUNCTION ADD NEW ITEM TYPE
                        n = ptsdept.AddDepartment(new m_department
                        {
                            dept_cd = cmbDepartmentCode.Text,
                            dept_name = txtDepartmantName.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    deptcbm.GetListDepartment();
                }
                #endregion

                #region ADD & UPDATE DESTINATION
                if (rbtnDestinationCode.Checked)
                {
                    //Edit mode for update item
                    if (editMode)
                    {
                        n = ptsdest.UpdateDest(new pts_destination
                        {
                            destination_id = ptsdest.destination_id,
                            destination_cd = cmbDestinationCode.Text,
                            destination_name = txtDestinationName.Text,
                            dept_cd = cmbDepartmentCode.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {
                        //CALL FUNCTION ADD NEW ITEM LOCATION

                        n = ptsdest.AddDestination(new pts_destination
                        {
                            destination_cd = cmbDestinationCode.Text,
                            destination_name = txtDestinationName.Text,
                            dept_cd = cmbDepartmentCode.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    destcbm.GetListDestination(string.Empty, string.Empty);
                }
                #endregion

                ClearFields();
                GetCmbData();
                UpdateGrid(true);
                txtGMUserCode.Text = null;
                txtGMUserName.Text = null;
                txtMUserCode.Text = null;
                txtMUserName.Text = null;

                if (editMode) messstring = "Update ";
                else messstring = "Add ";
                MessageBox.Show(messstring + n + " item complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (rbtnDepartMent.Checked)
                    cmbDepartmentCode.Enabled = true;
                if (rbtnDestinationCode.Checked)
                    cmbDepartmentCode.Enabled = false;
            }
            LockAllNameTextbox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (rbtnDepartMent.Checked)
                LockAllNameTextbox();
            if (rbtnDestinationCode.Checked)
            {
                cmbDepartmentCode.Enabled = false;
                LockAllNameTextbox();
            }
        }
        #endregion
        #region QUERY BUTTON
        private void GetCmbData()
        {
            deptcbm.GetListDepartment();
            cmbDepartmentCode.DataSource = deptcbm.listDept;
            cmbDepartmentCode.DisplayMember = "dept_cd";
            cmbDepartmentCode.ValueMember = "dept_name";
            cmbDepartmentCode.Text = null;
            destcbm.GetListDestination(string.Empty, string.Empty);
            cmbDestinationCode.DataSource = destcbm.listdestination;
            cmbDestinationCode.DisplayMember = "destination_cd";
            cmbDestinationCode.ValueMember = "destination_name";
            cmbDestinationCode.Text = null;
            firstload = false;
        }
        private void UpdateGrid(bool isSearch)
        {
            if (rbtnDepartMent.Checked)
            {
                if (isSearch)
                    ptsdept.GetListDepartment();
                dgvData.DataSource = null;
                dgvData.DataSource = ptsdept.listDept;
                dgvData.Columns["dept_cd"].HeaderText = "Dept CD";
                dgvData.Columns["dept_name"].HeaderText = "Dept Name";
                dgvData.Columns["registration_user_cd"].HeaderText = "Registration User";
                dgvData.Columns["registration_date_time"].HeaderText = "Registration Date";

            }
            if (rbtnDestinationCode.Checked)
            {
                if (isSearch)
                    ptsdest.GetListDestination(string.Empty, string.Empty);
                dgvData.DataSource = null;
                dgvData.DataSource = ptsdest.listdestination;
                dgvData.Columns["destination_id"].HeaderText = "Destination ID";
                dgvData.Columns["destination_cd"].HeaderText = "Destination CD";
                dgvData.Columns["destination_name"].HeaderText = "Destination Name";
                dgvData.Columns["dept_cd"].HeaderText = "Dept CD";
                dgvData.Columns["registration_user_cd"].HeaderText = "Registration User";
                dgvData.Columns["registration_date_time"].HeaderText = "Registration Date";
            }
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            isSearch = false;
        }
        private void ClearFields()
        {
            cmbDepartmentCode.Text = null;
            cmbDestinationCode.Text = null;
            txtDepartmantName.Text = "Department Name";
            txtDestinationName.Text = "Destination Name";
            txtGMUserCode.Text = null;
            txtGMUserName.Text = null;
            txtMUserCode.Text = null;
            txtMUserName.Text = null;
            dgvData.DataSource = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void UnlockFields(bool edit)
        {
            editMode = edit;
            if (rbtnDepartMent.Checked)
            {
                txtDepartmantName.ReadOnly = false;
                txtDestinationName.ReadOnly = true;

                if (!edit) txtDepartmantName.Text = string.Empty;
                cmbDepartmentCode.DropDownStyle = ComboBoxStyle.DropDown;
            }
            if (rbtnDestinationCode.Checked)
            {
                txtDestinationName.ReadOnly = false;
                txtDepartmantName.ReadOnly = true;
                if (!edit) txtDestinationName.Text = string.Empty;
                cmbDestinationCode.DropDownStyle = ComboBoxStyle.DropDown;
            }
            btnOK.Visible = true;
            btnCancel.Visible = true;
            pnlButtons.Enabled = false;
        }
        private void LockAllNameTextbox()
        {
            btnOK.Visible = false;
            btnCancel.Visible = false;
            pnlButtons.Enabled = true;
            txtDepartmantName.ReadOnly = true;
            txtDestinationName.ReadOnly = true;
            cmbDepartmentCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinationCode.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get data from datagrid to department
            if (rbtnDepartMent.Checked)
            {
                ptsdept = dgvData.Rows[e.RowIndex].DataBoundItem as m_department;
                cmbDepartmentCode.Text = ptsdept.dept_cd.ToString();
            }
            //Get data from datagrid to pts item location
            if (rbtnDestinationCode.Checked)
            {
                ptsdest = dgvData.Rows[e.RowIndex].DataBoundItem as pts_destination;
                cmbDestinationCode.Text = ptsdest.destination_cd.ToString();
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion
        #region SUB EVENT
        private void rbtnDepartMent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDepartMent.Checked)
            {
                cmbDepartmentCode.Enabled = true;
                txtDepartmantName.Enabled = true;
                cmbDestinationCode.Enabled = false;
                txtDestinationName.Enabled = false;
                txtGMUserCode.Enabled = true;
                txtGMUserName.Enabled = true;
                txtMUserCode.Enabled = true;
                txtMUserName.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsdept.listDept;
                txtDepartmantName.BackColor = System.Drawing.Color.Yellow;
                txtDestinationName.BackColor = System.Drawing.Color.Gray;
                rbtnDepartMent.BackColor = System.Drawing.Color.Yellow;
                rbtnDestinationCode.BackColor = System.Drawing.Color.Transparent;
            }
            if (rbtnDestinationCode.Checked)
            {
                cmbDepartmentCode.Enabled = false;
                txtDepartmantName.Enabled = false;
                cmbDestinationCode.Enabled = true;
                txtDestinationName.Enabled = true;
                txtGMUserCode.Enabled = true;
                txtGMUserName.Enabled = true;
                txtMUserCode.Enabled = true;
                txtMUserName.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsdest.listdestination;
                txtDepartmantName.BackColor = System.Drawing.Color.Gray;
                txtDestinationName.BackColor = System.Drawing.Color.Yellow;
                rbtnDepartMent.BackColor = System.Drawing.Color.Transparent;
                rbtnDestinationCode.BackColor = System.Drawing.Color.Yellow;
            }
        }

        #endregion


    }
}
