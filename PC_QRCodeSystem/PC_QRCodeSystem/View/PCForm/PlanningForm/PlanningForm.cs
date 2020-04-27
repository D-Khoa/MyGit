using System;
using System.Drawing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class PlanningForm : FormCommon
    {
        #region VARIABLE
        private pts_plan planData { get; set; }
        private pts_item modelData { get; set; }
        private pts_stock stockData { get; set; }
        private m_mes_user userData { get; set; }
        private pts_destination desData { get; set; }
        private ErrorProvider errorProvider { get; set; }

        private string des_cd;
        #endregion

        #region FORM EVENT
        public PlanningForm()
        {
            InitializeComponent();
            planData = new pts_plan();
            modelData = new pts_item();
            stockData = new pts_stock();
            userData = new m_mes_user();
            desData = new pts_destination();
            errorProvider = new ErrorProvider();
            tc_PlanManagement.SelectedTab = tab_Main;
            tc_PlanManagement.ItemSize = new Size(0, 1);
        }

        private void PlanningForm_Load(object sender, EventArgs e)
        {
            GetCmb();
            ClearFields();
            LockButtons(true);
            rbtnNoCheckDate.Checked = true;
        }
        #endregion

        #region BUTTONS EVENT
        private void btnOpenPlan_Click(object sender, EventArgs e)
        {
            PlanItemForm planFrm = new PlanItemForm(dgvPlanData.Rows[dgvPlanData.SelectedCells[0].RowIndex].DataBoundItem as pts_plan);
            planFrm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtPlanCD.Text = "plan-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                planData.Add(new pts_plan
                {
                    plan_cd = txtPlanCD.Text,
                    plan_usercd = txtUserCD.Text,
                    model_cd = txtModelCD.Text,
                    set_number = txtSetNumber.Text,
                    destination_cd = des_cd,
                    plan_qty = double.Parse(txtPlanQty.Text),
                    plan_date = dtpPlanDate.Value,
                    delivery_date = dtpDeliveryDate.Value,
                    comment = txtComment.Text,
                });
                CustomMessageBox.Notice("Add new plan successed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            UpdateGrid(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                planData.Update(new pts_plan
                {
                    plan_cd = txtPlanCD.Text,
                    model_cd = txtModelCD.Text,
                    plan_usercd = txtUserCD.Text,
                    set_number = txtSetNumber.Text,
                    destination_cd = cmbDestinationCD.SelectedValue.ToString(),
                    plan_qty = double.Parse(txtPlanQty.Text),
                    plan_date = dtpPlanDate.Value,
                    delivery_date = dtpDeliveryDate.Value,
                    comment = txtComment.Text,
                });
                CustomMessageBox.Notice("Update plan successed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            UpdateGrid(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                planData.Delete();
                CustomMessageBox.Notice("Delet plan successed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            UpdateGrid(false);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LockButtons(true);
            UpdateGrid(false);
        }
        #endregion

        #region FIELDS EVENT
        private void txtUserCD_TextChanged(object sender, EventArgs e)
        {
            lbUserName.Text = "User Name";
            errorProvider.SetError(txtUserCD, null);
            lbUserName.BackColor = Color.FromKnownColor(KnownColor.Control);
            if (string.IsNullOrEmpty(txtUserCD.Text))
                return;
            try
            {
                lbUserName.Text = userData.GetUser(txtUserCD.Text).user_name;
                lbUserName.BackColor = Color.Lime;
            }
            catch
            {
                errorProvider.SetError(txtUserCD, "Wrong user code");
            }
        }

        private void txtModelCD_TextChanged(object sender, EventArgs e)
        {
            lbModelName.Text = "Model Name";
            errorProvider.SetError(txtModelCD, null);
            lbModelName.BackColor = Color.FromKnownColor(KnownColor.Control);
            if (string.IsNullOrEmpty(txtModelCD.Text))
                return;
            try
            {
                modelData = modelData.GetItem(txtModelCD.Text);
            }
            catch
            {
                errorProvider.SetError(txtModelCD, "Wrong Model Code");
            }
            if (modelData.type_id != 0)
                errorProvider.SetError(txtModelCD, "This item is not type 0 item!");
            lbModelName.Text = modelData.item_name;
            lbModelName.BackColor = Color.Lime;
            try
            {
                stockData = stockData.GetItem(new pts_stock { item_cd = txtModelCD.Text }, false);
            }
            catch
            {
                errorProvider.SetError(txtModelCD, "No Item in stock");
            }
            if (!string.IsNullOrEmpty(stockData.order_no)) txtSetNumber.Text = stockData.order_no;
            else txtSetNumber.Text = "None";
        }

        private void cmbDestinationCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDestinationCD.Text)) des_cd = cmbDestinationCD.SelectedValue.ToString();
            else des_cd = string.Empty;
        }

        private void cmbDestinationCD_Format(object sender, ListControlConvertEventArgs e)
        {
            string code = ((pts_destination)e.ListItem).destination_cd;
            string iname = ((pts_destination)e.ListItem).destination_name;
            e.Value = code + ": " + iname;
        }

        private void txtPlanQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvPlanData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                planData = dgvPlanData.Rows[e.RowIndex].DataBoundItem as pts_plan;
                txtPlanCD.Text = planData.plan_cd;
                txtComment.Text = planData.comment;
                txtModelCD.Text = planData.model_cd;
                txtUserCD.Text = planData.plan_usercd;
                txtSetNumber.Text = planData.set_number;
                txtPlanQty.Text = planData.plan_qty.ToString();
                cmbDestinationCD.SelectedValue = planData.destination_cd;
                dtpPlanDate.Value = planData.plan_date;
                dtpDeliveryDate.Value = planData.delivery_date;
            }
            LockButtons(false);
        }

        private void dgvPlanData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
        }

        private void pnlMainTop_Paint(object sender, PaintEventArgs e)
        {
            int w = pnlMainTop.Width / 2;
            int w1 = pnlMain.Width / 2;
            int w2 = pnlMainButtons.Width / 2;
            int h1 = pnlMain.Height;
            pnlMain.Location = new Point(w - w1, 0);
            pnlMainButtons.Location = new Point(w - w2, h1);
        }
        #endregion

        #region SUB EVENT
        private void GetCmb()
        {
            desData.GetListDestination(string.Empty, string.Empty);
            cmbDestinationCD.DataSource = desData.listdestination;
            cmbDestinationCD.DisplayMember = "destination_name";
            cmbDestinationCD.ValueMember = "destination_cd";
            cmbDestinationCD.Text = null;
        }

        private void UpdateGrid(bool iSSearch)
        {
            try
            {
                #region SEARCH
                if (iSSearch)
                {
                    if (rbtnNoCheckDate.Checked)
                    {
                        planData.Search(new pts_plan
                        {
                            plan_cd = txtPlanCD.Text,
                            destination_cd = des_cd,
                            model_cd = txtModelCD.Text,
                            set_number = txtSetNumber.Text,
                            plan_usercd = txtUserCD.Text,
                        }, dtpPlanDate.Value, dtpPlanToDate.Value, 0);
                    }
                    if (rbtnPlanDate.Checked)
                    {
                        planData.Search(new pts_plan
                        {
                            plan_cd = txtPlanCD.Text,
                            destination_cd = des_cd,
                            model_cd = txtModelCD.Text,
                            set_number = txtSetNumber.Text,
                            plan_usercd = txtUserCD.Text,
                        }, dtpPlanDate.Value, dtpPlanToDate.Value, 1);
                    }
                    if (rbtnDeliveryDate.Checked)
                    {
                        planData.Search(new pts_plan
                        {
                            plan_cd = txtPlanCD.Text,
                            destination_cd = des_cd,
                            model_cd = txtModelCD.Text,
                            set_number = txtSetNumber.Text,
                            plan_usercd = txtUserCD.Text,
                        }, dtpDeliveryDate.Value, dtpDeliveryToDate.Value, 2);
                    }
                }
                #endregion

                dgvPlanData.DataSource = planData.listPlan;
                LockButtons(true);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void LockButtons(bool islock)
        {
            btnOpenPlan.Enabled = !islock;
            btnUpdate.Enabled = !islock;
            btnDelete.Enabled = !islock;
        }

        private void ClearFields()
        {
            txtUserCD.Clear();
            txtModelCD.Clear();
            txtPlanQty.Clear();
            txtSetNumber.Clear();
            cmbDestinationCD.Text = null;
            dgvPlanData.DataSource = null;
            lbUserName.Text = "User Name";
            lbModelName.Text = "Model Name";
        }
        #endregion
    }
}
