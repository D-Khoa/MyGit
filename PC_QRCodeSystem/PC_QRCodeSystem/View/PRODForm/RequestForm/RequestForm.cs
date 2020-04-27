using System;
using System.Drawing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class RequestForm : FormCommon
    {
        #region VARIABLE
        pts_item itemdata { get; set; }
        pts_destination descmb { get; set; }
        pts_request_log requestdata { get; set; }
        bool mconfirm, gmconfirm, mMode, gmMode;
        ErrorProvider errorProvider = new ErrorProvider();
        #endregion

        public RequestForm()
        {
            InitializeComponent();
            itemdata = new pts_item();
            descmb = new pts_destination();
            requestdata = new pts_request_log();
            LockFields(true);
            mMode = false;
            gmMode = false;
            mconfirm = false;
            gmconfirm = false;
            btnConfirm.Visible = false;
            rbtnAllRequest.Checked = true;
        }

        #region FIELD EVENT
        private void RequestForm_Load(object sender, EventArgs e)
        {
            getCmbData();
            if (UserData.position == "MGR")
            {
                mMode = true;
                gmMode = false;
                btnConfirm.Visible = true;
                this.Text += "[Manager Mode]";
            }
            if (UserData.position == "GM")
            {
                mMode = false;
                gmMode = true;
                btnConfirm.Visible = true;
                this.Text += "[GM Mode]";
            }
        }

        /// <summary>
        /// Get list destination code
        /// </summary>
        private void getCmbData()
        {
            descmb.GetListDestination(string.Empty, UserData.dept);
            cmbDestination.DataSource = descmb.listdestination;
            cmbDestination.DisplayMember = "destination_cd";
            cmbDestination.ValueMember = "destination_name";
            cmbDestination.Text = null;
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDestination.Text))
                txtDestinationName.Text = cmbDestination.SelectedValue.ToString();
            else
                txtDestinationName.Text = "Destination Name";
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtItemName.BackColor = Color.FromKnownColor(KnownColor.Control);
                txtItemName.Text = "Item Name";
                errorProvider.SetError(txtItemCode, null);
                if (!string.IsNullOrEmpty(txtItemCode.Text))
                {
                    txtItemName.Text = itemdata.GetItem(txtItemCode.Text).item_name;
                    txtItemName.BackColor = Color.Lime;
                }
            }
            catch
            {
                errorProvider.SetError(txtItemCode, "Item Code isn't exist!");
                txtItemName.Text = "Item Name";
            }
        }

        private void txtModelCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtModelName.BackColor = Color.FromKnownColor(KnownColor.Control);
                txtModelName.Text = "Model Name";
                errorProvider.SetError(txtModelCode, null);
                if (!string.IsNullOrEmpty(txtModelCode.Text))
                {
                    txtModelName.Text = itemdata.GetItem(txtModelCode.Text).item_name;
                    txtModelName.BackColor = Color.Lime;
                }
            }
            catch
            {
                errorProvider.SetError(txtModelCode, "Model Code isn't exist!");
                txtModelName.Text = "Model Name";
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region BUTTON EVENT
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (mMode)
            {
                foreach (DataGridViewCell cell in dgvRequest.SelectedCells)
                {
                    requestdata.MConfirm(new pts_request_log
                    {
                        request_id = (int)dgvRequest.Rows[cell.RowIndex].Cells["request_id"].Value,
                        m_confirm = mconfirm,
                        comment = dgvRequest.Rows[cell.RowIndex].Cells["comment"].Value.ToString() + Environment.NewLine + "Manager confirmed",
                    });
                }
            }
            if (gmMode)
            {
                foreach (DataGridViewCell cell in dgvRequest.SelectedCells)
                {
                    requestdata.GMConfirm(new pts_request_log
                    {
                        request_id = (int)dgvRequest.Rows[cell.RowIndex].Cells["request_id"].Value,
                        gm_confirm = gmconfirm,
                        comment = dgvRequest.Rows[cell.RowIndex].Cells["comment"].Value.ToString() + Environment.NewLine + "GM Confirmed",
                    });
                }
            }
            UpdateGrid();
        }

        private void btnConfirm_Paint(object sender, PaintEventArgs e)
        {
            if (dgvRequest.SelectedCells.Count == 0) btnConfirm.Enabled = false;
            if (mconfirm || gmconfirm)
                btnConfirm.Text = "Confirm";
            else
                btnConfirm.Text = "Unconfirm";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                requestdata.Add(new pts_request_log
                {
                    item_cd = txtItemCode.Text,
                    model_cd = txtModelCode.Text,
                    destination_cd = cmbDestination.Text,
                    use_date = dtpUseDate.Value,
                    request_date = DateTime.Now,
                    request_qty = double.Parse(txtQty.Text),
                    request_usercd = UserData.usercode,
                    comment = txtComment.Text,
                    remark = "N",
                });
                MessageBox.Show("Add request completed!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!gmMode && requestdata.gm_confirm) || (!mMode && !gmMode && requestdata.m_confirm))
                {
                    MessageBox.Show("This request is confirmed!" + Environment.NewLine + "Please contact Manager or GM for change this request!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto finUpdate;
                }
                requestdata.Update(new pts_request_log
                {
                    item_cd = txtItemCode.Text,
                    model_cd = txtModelCode.Text,
                    destination_cd = cmbDestination.Text,
                    use_date = dtpUseDate.Value,
                    request_date = DateTime.Now,
                    request_qty = double.Parse(txtQty.Text),
                    request_usercd = UserData.usercode,
                    comment = txtComment.Text,
                    remark = "N",
                });
                MessageBox.Show("Update request completed!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finUpdate:
            LockFields(true);
            UpdateGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!gmMode && requestdata.gm_confirm) || (!mMode && !gmMode && requestdata.m_confirm))
                {
                    MessageBox.Show("This request is confirmed!" + Environment.NewLine + "Please contact Manager or GM for delete this request!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto finDelete;
                }
                if (MessageBox.Show("Are you sure delete this request?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    goto finDelete;
                requestdata.Delete();
                MessageBox.Show("Deleted request!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finDelete:
            LockFields(true);
            UpdateGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvRequest.DataSource = null;
            cmbDestination.Text = null;
            txtModelCode.Clear();
            txtItemCode.Clear();
            txtComment.Clear();
            txtQty.Clear();
            LockFields(true);
        }
        #endregion

        #region SUB EVENT
        private void UpdateGrid()
        {
            try
            {
                if (rbtnAllRequest.Checked)
                {
                    requestdata.SearchWithDept(new pts_request_log
                    {
                        item_cd = txtItemCode.Text,
                        model_cd = txtModelCode.Text,
                        destination_cd = cmbDestination.Text,
                    }, false, false, false, UserData.dept);
                }
                if (rbtnWaitConfirm.Checked)
                {
                    requestdata.SearchWithDept(new pts_request_log
                    {
                        item_cd = txtItemCode.Text,
                        model_cd = txtModelCode.Text,
                        destination_cd = cmbDestination.Text,
                        gm_confirm = false,
                    }, false, true, false, UserData.dept);
                }
                if (rbtnConfirmed.Checked)
                {
                    requestdata.SearchWithDept(new pts_request_log
                    {
                        item_cd = txtItemCode.Text,
                        model_cd = txtModelCode.Text,
                        destination_cd = cmbDestination.Text,
                        m_confirm = true,
                        gm_confirm = true,
                        pc_m_cofirm = false,
                    }, true, true, true, UserData.dept);
                }
                if (rbtnApproved.Checked)
                {
                    requestdata.SearchWithDept(new pts_request_log
                    {
                        item_cd = txtItemCode.Text,
                        model_cd = txtModelCode.Text,
                        destination_cd = cmbDestination.Text,
                        pc_m_cofirm = true,
                    }, false, false, true, UserData.dept);
                }
                dgvRequest.DataSource = null;
                dgvRequest.DataSource = requestdata.listRequestItem;
                dgvRequest.Columns["request_id"].HeaderText = "Request ID";
                dgvRequest.Columns["item_cd"].HeaderText = "Item Code";
                dgvRequest.Columns["model_cd"].HeaderText = "Model";
                dgvRequest.Columns["destination_cd"].HeaderText = "Destination Code";
                dgvRequest.Columns["use_date"].HeaderText = "Use Date";
                dgvRequest.Columns["request_date"].HeaderText = "Request Date";
                dgvRequest.Columns["request_qty"].HeaderText = "Request Qty";
                dgvRequest.Columns["request_usercd"].HeaderText = "Request User";
                dgvRequest.Columns["m_confirm"].HeaderText = "Manager Confirm";
                dgvRequest.Columns["gm_confirm"].HeaderText = "GM Confirm";
                dgvRequest.Columns["available_qty"].HeaderText = "Available Qty";
                dgvRequest.Columns["approve_usercd"].HeaderText = "Approve User";
                dgvRequest.Columns["pc_m_cofirm"].HeaderText = "PC Confirm";
                dgvRequest.Columns["comment"].HeaderText = "Comment";
                dgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                foreach (DataGridViewRow dr in dgvRequest.Rows)
                {
                    if ((bool)dr.Cells["m_confirm"].Value && (bool)dr.Cells["gm_confirm"].Value && (bool)dr.Cells["pc_m_cofirm"].Value)
                        dr.DefaultCellStyle.BackColor = Color.Lime;
                    else
                        dr.DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LockFields(bool isLock)
        {
            btnDelete.Enabled = !isLock;
            btnUpdate.Enabled = !isLock;
            btnConfirm.Enabled = !isLock;
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mMode)
                mconfirm = !(bool)dgvRequest.Rows[e.RowIndex].Cells["m_confirm"].Value;
            if (gmMode)
                gmconfirm = !(bool)dgvRequest.Rows[e.RowIndex].Cells["gm_confirm"].Value;
            btnConfirm.Refresh();
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            requestdata = dgvRequest.Rows[e.RowIndex].DataBoundItem as pts_request_log;
            txtItemCode.Text = requestdata.item_cd;
            txtModelCode.Text = requestdata.model_cd;
            txtComment.Text = requestdata.comment;
            txtQty.Text = requestdata.request_qty.ToString();
            cmbDestination.Text = requestdata.destination_cd;
            LockFields(false);
        }

        private void dgvRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRequest.Columns[e.ColumnIndex].Name == "m_confirm" || dgvRequest.Columns[e.ColumnIndex].Name == "gm_confirm" || dgvRequest.Columns[e.ColumnIndex].Name == "pc_m_cofirm")
            {
                if (e.Value != null && (bool)e.Value == false)
                    e.CellStyle.BackColor = Color.Red;
            }
            if (dgvRequest.Columns[e.ColumnIndex].Name == "approve_usercd")
            {
                if (string.IsNullOrEmpty(e.Value.ToString()) || e.Value.ToString() == "None")
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = Color.Lime;
            }
        }
        #endregion

    }
}
