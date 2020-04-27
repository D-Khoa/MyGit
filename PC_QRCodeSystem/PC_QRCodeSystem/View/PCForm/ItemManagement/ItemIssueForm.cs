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


namespace PC_QRCodeSystem.View
{
    public partial class ItemIssueForm : FormCommon
    {
        #region VARIABLE
        bool editMode { get; set; }
        pts_issue_code ptsissuecode { get; set; }
        pts_issue_code ptsissuecodecbm { get; set; }
        #endregion

        #region FORM EVENT
        public ItemIssueForm()
        {
            InitializeComponent();
            ptsissuecodecbm = new pts_issue_code();
            ptsissuecode = new pts_issue_code();
            pnlSubButtons.Visible = false;
            pnlButtons.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            editMode = false;
        }

        private void ItemIssueForm_Load(object sender, EventArgs e)
        {
            Getcmbdata();
        }

        private void cmbIssueCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbIssueCode.Text))
                {
                    txtIssueCode.Text = "Issue Name";
                    txtIssueCode.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                    return;
                }
                txtIssueCode.Text = cmbIssueCode.SelectedValue.ToString();
                txtIssueCode.BackColor = Color.FromKnownColor(KnownColor.Lime);
            }
            catch
            {
                txtIssueCode.Clear();
                txtIssueCode.BackColor = Color.FromKnownColor(KnownColor.Yellow);
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
            ClearOK();
            editMode = false;
            UnlockFields(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            editMode = true;
            UnlockFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Warring("This action is not undo" + Environment.NewLine + "Are you sure delete this item issue?") == DialogResult.No)
                return;
            int n = 0;
            n = ptsissuecode.Delete(ptsissuecode.issue_cd);
            ClearOK();
            Getcmbdata();
            UpdateGrid(true);
            CustomMessageBox.Notice("Delete " + n + " Issue Code");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOK();
            txtIssueCode.Text = "Issue Name";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                string messstring = string.Empty;
                #region Add And Update Issue Code
                {
                    if (editMode)
                    {  //CALL FUNTION UPDATE SUPPLIER
                        n = ptsissuecode.UpdateIssueCode(new pts_issue_code
                        {
                            issue_cd = int.Parse(cmbIssueCode.Text),
                            issue_name = txtIssueCode.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {  //CALL FUNCTION ADD NEW SUPPLIER
                        n = ptsissuecode.AddIssueCode(new pts_issue_code
                        {
                            issue_cd = int.Parse(cmbIssueCode.Text),
                            issue_name = txtIssueCode.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                }
                #endregion
                ClearOK();
                Getcmbdata();
                UnlockFields(false);
                UpdateGrid(true);
                if (editMode) messstring = "Update ";
                else messstring = "Add ";
                CustomMessageBox.Notice(messstring + n + " Issue Code Complete!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearOK();
            UnlockFields(false);
        }
        #endregion

        #region SUB PROGRAM
        /// <summary>
        /// Sub Program Update data
        /// </summary>
        private void UpdateGrid(bool isSearch)
        {
            try
            {
                if (isSearch)
                {
                    ptsissuecode.listIssueCode.Clear();
                    if (string.IsNullOrEmpty(cmbIssueCode.Text)) ptsissuecode.GetListIssueCode();
                    else
                    {
                        ptsissuecode = ptsissuecode.GetIssueCode(int.Parse(cmbIssueCode.Text));
                        ptsissuecode.listIssueCode.Add(ptsissuecode);
                    }
                    dgvIssueCode.DataSource = ptsissuecode.listIssueCode;
                    dgvIssueCode.Columns["issue_cd"].HeaderText = "Issue Code";
                    dgvIssueCode.Columns["issue_name"].HeaderText = "Issue Name";
                    dgvIssueCode.Columns["registration_user_cd"].HeaderText = "Registration User";
                    dgvIssueCode.Columns["registration_date_time"].HeaderText = "Registration Date";
                    dgvIssueCode.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        /// <summary>
        /// Get commobox from database
        /// </summary>
        private void Getcmbdata()
        {
            ptsissuecodecbm.GetListIssueCode();
            cmbIssueCode.DataSource = ptsissuecodecbm.listIssueCode;
            cmbIssueCode.DisplayMember = "issue_cd";
            cmbIssueCode.ValueMember = "issue_name";
            cmbIssueCode.Text = null;
        }

        /// <summary>
        /// Sub program Clear Show datagrirview
        /// </summary>
        private void ClearOK()
        {
            txtIssueCode.Clear();
            cmbIssueCode.Text = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            ptsissuecode.listIssueCode.Clear();
            dgvIssueCode.DataSource = null;
        }

        /// <summary>
        /// Unlock all fields of items
        /// </summary>
        /// <param name="edit"></param>
        private void UnlockFields(bool edit)
        {
            pnlButtons.Visible = !edit;
            pnlSubButtons.Visible = edit;
            txtIssueCode.ReadOnly = !edit;
            if (edit) cmbIssueCode.DropDownStyle = ComboBoxStyle.DropDown;
            else cmbIssueCode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Double click datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvIssueCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ptsissuecode = dgvIssueCode.Rows[e.RowIndex].DataBoundItem as pts_issue_code;
            cmbIssueCode.Text = ptsissuecode.issue_cd.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion
    }
}

