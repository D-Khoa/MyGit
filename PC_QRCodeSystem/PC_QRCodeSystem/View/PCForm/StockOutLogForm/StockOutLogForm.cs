using System;
using System.Drawing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class StockOutLogForm : FormCommon
    {
        #region VARIABLE
        private pts_item itemData { get; set; }
        private pts_plan planData { get; set; }
        private m_mes_user userData { get; set; }
        private pts_stock stockData { get; set; }
        private pts_noplan noplanData { get; set; }
        private pts_destination desCode { get; set; }
        private pts_issue_code issueCode { get; set; }
        private pts_request_log requestData { get; set; }
        private pts_stockout_log stockoutData { get; set; }
        private ErrorProvider errorProvider = new ErrorProvider();
        #endregion

        #region FORM EVENT
        public StockOutLogForm()
        {
            InitializeComponent();
            itemData = new pts_item();
            planData = new pts_plan();
            userData = new m_mes_user();
            stockData = new pts_stock();
            noplanData = new pts_noplan();
            desCode = new pts_destination();
            issueCode = new pts_issue_code();
            requestData = new pts_request_log();
            stockoutData = new pts_stockout_log();
        }

        private void StockOutLogForm_Load(object sender, EventArgs e)
        {
            GetCmb();
        }
        #endregion

        #region SUB EVENT
        /// <summary>
        /// Get list issue code, destination into combobox
        /// </summary>
        private void GetCmb()
        {
            try
            {
                //Get list issue code
                issueCode.GetListIssueCode();
                cmbIssueCD.DataSource = issueCode.listIssueCode;
                cmbIssueCD.DisplayMember = "issue_name";
                cmbIssueCD.ValueMember = "issue_cd";
                cmbIssueCD.Text = null;
                //Get list destination code
                desCode.GetListDestination(string.Empty, string.Empty);
                cmbDestination.DataSource = desCode.listdestination;
                cmbDestination.DisplayMember = "destination_name";
                cmbDestination.ValueMember = "destination_cd";
                cmbDestination.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update data grid
        /// </summary>
        /// <param name="isSearch"></param>
        private void UpdateGrid(bool isSearch)
        {
            if (isSearch)
            {
                int issuecode = 0;
                string descode = string.Empty;
                if (cmbIssueCD.SelectedValue != null) issuecode = (int)cmbIssueCD.SelectedValue;
                if (cmbDestination.SelectedValue != null) descode = cmbDestination.SelectedValue.ToString();
                stockoutData.Search(new pts_stockout_log
                {
                    issue_cd = issuecode,
                    process_cd = txtProcessCD.Text,
                    stockout_user_cd = txtUserCD.Text
                }, txtItemCD.Text, txtInvoice.Text, txtSetNumber.Text, descode, dtpFromDate.Value, dtpToDate.Value, cbSearchDate.Checked);
            }
            if (stockoutData.listStockOutItem != null)
                dgvData.DataSource = stockoutData.listStockOutItem;
            if (dgvData.Rows.Count > 0)
            {
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    dgvData.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            dgvData.Columns["stockout_id"].HeaderText = "ID";
            dgvData.Columns["packing_cd"].HeaderText = "Packing Code";
            dgvData.Columns["process_cd"].HeaderText = "Process Code";
            dgvData.Columns["issue_cd"].HeaderText = "Issue Code";
            dgvData.Columns["stockout_date"].HeaderText = "Stock-Out Date";
            dgvData.Columns["stockout_user_cd"].HeaderText = "Incharge";
            dgvData.Columns["stockout_qty"].HeaderText = "Stoc-Out Qty";
            dgvData.Columns["real_qty"].HeaderText = "Real Qty";
            dgvData.Columns["received_user_cd"].HeaderText = "Receive User";
            dgvData.Columns["comment"].HeaderText = "Comment";
            dgvData.Columns["remark"].HeaderText = "Remark";
            dgvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        /// <summary>
        /// Update process grid with data from noplan, plan, request
        /// </summary>
        private void UpdateProcessGrid()
        {
            if (planData.listPlan.Count > 0)
            {
                dgvProcess.DataSource = planData.listPlan;
                dgvProcess.Columns["plan_id"].HeaderText = "ID";
                dgvProcess.Columns["plan_cd"].HeaderText = "Process ID";
                dgvProcess.Columns["destination_cd"].HeaderText = "Destination Code";
                dgvProcess.Columns["model_cd"].HeaderText = "Model Code";
                dgvProcess.Columns["set_number"].HeaderText = "Set Number";
                dgvProcess.Columns["plan_date"].HeaderText = "Plan Date";
                dgvProcess.Columns["plan_qty"].HeaderText = "Qty";
                dgvProcess.Columns["plan_usercd"].HeaderText = "Incharge";
                dgvProcess.Columns["delivery_date"].HeaderText = "Delivery Date";
                dgvProcess.Columns["comment"].HeaderText = "Comment";
            }
            if (noplanData.listNoPlan.Count > 0)
            {
                dgvProcess.DataSource = noplanData.listNoPlan;
                dgvProcess.Columns["noplan_id"].HeaderText = "ID";
                dgvProcess.Columns["noplan_cd"].HeaderText = "Process Code";
                dgvProcess.Columns["destination_cd"].HeaderText = "Destination Code";
                dgvProcess.Columns["item_cd"].HeaderText = "Item Code";
                dgvProcess.Columns["noplan_qty"].HeaderText = "Qty";
                dgvProcess.Columns["noplan_usercd"].HeaderText = "Incharge";
                dgvProcess.Columns["noplan_date"].HeaderText = "Date";
            }
            if (requestData.listRequestItem.Count > 0)
            {
                dgvProcess.DataSource = requestData.listRequestItem;
                dgvProcess.Columns["request_id"].HeaderText = "ID";
                dgvProcess.Columns["request_cd"].HeaderText = "Process Code";
                dgvProcess.Columns["item_cd"].HeaderText = "Item Code";
                dgvProcess.Columns["model_cd"].HeaderText = "Model Code";
                dgvProcess.Columns["destination_cd"].HeaderText = "Destination Code";
                dgvProcess.Columns["use_date"].HeaderText = "Use Date";
                dgvProcess.Columns["request_date"].HeaderText = "Request Date";
                dgvProcess.Columns["request_qty"].HeaderText = "Request Qty";
                dgvProcess.Columns["request_usercd"].HeaderText = "Request User";
                dgvProcess.Columns["m_confirm"].HeaderText = "Manager Confirm";
                dgvProcess.Columns["gm_confirm"].HeaderText = "GM Confirm";
                dgvProcess.Columns["available_qty"].HeaderText = "Available Qty";
                dgvProcess.Columns["approve_usercd"].HeaderText = "Approve User";
                dgvProcess.Columns["pc_m_cofirm"].HeaderText = "PC Confirm";
                dgvProcess.Columns["comment"].HeaderText = "Comment";
                dgvProcess.Columns["remark"].HeaderText = "Remark";
            }
            dgvProcess.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void ClearFields()
        {
            txtUserCD.Clear();
            txtItemCD.Clear();
            txtBarcode.Clear();
            txtInvoice.Clear();
            txtProcessCD.Clear();
            txtSetNumber.Clear();
            cmbIssueCD.Text = null;
            cmbDestination.Text = null;
            planData.listPlan.Clear();
            noplanData.listNoPlan.Clear();
            requestData.listRequestItem.Clear();
            stockoutData.listStockOutItem.Clear();
            dgvData.DataSource = null;
            dgvProcess.DataSource = null;
        }
        #endregion

        #region FIELDS EVENT
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] barcode = txtBarcode.Text.Split(';');
                txtItemCD.Text = barcode[0];
                txtInvoice.Text = barcode[3];
                dtpFromDate.Value = DateTime.Parse(barcode[4]);
                dtpToDate.Value = DateTime.Parse(barcode[4]);
            }
        }

        private void cmbIssueCD_Format(object sender, ListControlConvertEventArgs e)
        {
            string code = ((pts_issue_code)e.ListItem).issue_cd.ToString();
            string iname = ((pts_issue_code)e.ListItem).issue_name;
            e.Value = code + ": " + iname;
        }

        private void cmbDestination_Format(object sender, ListControlConvertEventArgs e)
        {
            string code = ((pts_destination)e.ListItem).destination_cd;
            string iname = ((pts_destination)e.ListItem).destination_name;
            e.Value = code + ": " + iname;
        }

        private void cmbIssueCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbIssueCD.Text))
                errorProvider.SetError(cmbIssueCD, null);
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDestination.Text))
                errorProvider.SetError(cmbDestination, null);
        }

        private void txtItemCD_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtItemCD, null);
            lbItemName.Text = "Item Name";
            lbItemName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            if (!string.IsNullOrEmpty(txtItemCD.Text))
            {
                try
                {
                    lbItemName.Text = itemData.GetItem(txtItemCD.Text).item_name;
                    lbItemName.BackColor = Color.Lime;
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txtItemCD, "Wrong Item Code" +
                                           Environment.NewLine + ex.Message);
                }
            }
        }

        private void txtUserCD_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtUserCD, null);
            lbUserName.Text = "User Name";
            lbUserName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            if (!string.IsNullOrEmpty(txtUserCD.Text))
            {
                try
                {
                    lbUserName.Text = userData.GetUser(txtUserCD.Text).user_name;
                    lbUserName.BackColor = Color.Lime;
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txtUserCD, "Wrong User Code" +
                                           Environment.NewLine + ex.Message);
                }
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count <= 0) return;
            stockoutData = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].DataBoundItem as pts_stockout_log;
            try
            {
                planData.listPlan.Clear();
                noplanData.listNoPlan.Clear();
                requestData.listRequestItem.Clear();
                planData.Search(new pts_plan { plan_cd = stockoutData.process_cd });
                noplanData.Search(new pts_noplan { noplan_cd = stockoutData.process_cd });
                requestData.Search(new pts_request_log { request_cd = stockoutData.process_cd }, false, false, false);
                UpdateProcessGrid();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }
        #endregion

        #region BUTTONS EVENT
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(true);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion
    }
}