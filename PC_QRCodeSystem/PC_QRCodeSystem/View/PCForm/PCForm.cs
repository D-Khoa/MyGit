using System;
using System.Drawing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class PCForm : FormCommon
    {
        bool pcmMocde = false;
        pts_item itemData { get; set; }
        pts_request_log requestData { get; set; }

        public PCForm()
        {
            InitializeComponent();
            itemData = new pts_item();
            requestData = new pts_request_log();
            grt_Main.ItemSize = new Size(0, 1);
            if (UserData.position == "MGR")
            {
                pcmMocde = true;
                btnAccept.Text = "Confirm";
                this.Text += "[PC Manager]";
            }
            else
            {
                pcmMocde = false;
                btnAccept.Text = "Apccept";
            }
            rbtnAllRequest.Checked = true;
        }

        #region MAIN TAB
        /// <summary>
        /// Open Stock In Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStockIn_Click(object sender, EventArgs e)
        {
            //StockInForm inFrm = new StockInForm();
            StockInputForm inFrm = new StockInputForm();
            inFrm.Show();
        }

        /// <summary>
        /// Open Stock Out Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStockOut_Click(object sender, EventArgs e)
        {
            StockOutForm outFrm = new StockOutForm();
            outFrm.Show();
        }

        /// <summary>
        /// Open Stock Detail Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStockDetail_Click(object sender, EventArgs e)
        {
            StockDetailForm dtlFrm = new StockDetailForm();
            dtlFrm.Show();

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemManagement itemfrm = new ItemManagement();
            itemfrm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm spfrm = new SupplierForm();
            spfrm.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DestinationManager desmg = new DestinationManager();
            desmg.Show();
        }

        private void btnIssueCode_Click(object sender, EventArgs e)
        {
            ItemIssueForm issfrm = new ItemIssueForm();
            issfrm.Show();
        }

        private void btnUserPosition_Click(object sender, EventArgs e)
        {
            UserPosition upfrm = new UserPosition();
            upfrm.Show();
        }

        private void btnRequestLog_Click(object sender, EventArgs e)
        {
            grt_Main.SelectedTab = tab_Request;
        }
        #endregion

        #region APPROVE REQUEST TAB
        private void UpdateGrid()
        {
            if (rbtnAllRequest.Checked)
            {
                requestData.Search(new pts_request_log
                {
                    item_cd = string.Empty,
                    model_cd = string.Empty,
                    destination_cd = string.Empty,
                    m_confirm = true,
                    gm_confirm = true,
                    remark = string.Empty,
                }, true, true, false);
            }
            if (rbtnWaitApprove.Checked)
            {
                requestData.Search(new pts_request_log
                {
                    item_cd = string.Empty,
                    model_cd = string.Empty,
                    destination_cd = string.Empty,
                    m_confirm = true,
                    gm_confirm = true,
                    remark = "N",
                }, true, true, true);
            }
            if (rbtnApproved.Checked)
            {
                requestData.Search(new pts_request_log
                {
                    item_cd = string.Empty,
                    model_cd = string.Empty,
                    destination_cd = string.Empty,
                    m_confirm = true,
                    gm_confirm = true,
                    remark = "A",
                }, true, true, true);
            }
            if (rbtnReject.Checked)
            {
                requestData.Search(new pts_request_log
                {
                    item_cd = string.Empty,
                    model_cd = string.Empty,
                    destination_cd = string.Empty,
                    m_confirm = true,
                    gm_confirm = true,
                    remark = "R",
                }, true, true, true);
            }
            dgvRequest.DataSource = requestData.listRequestItem;
            foreach (DataGridViewRow dr in dgvRequest.Rows)
            {
                if (dr.Cells["remark"].Value.ToString() == "R")
                    dr.DefaultCellStyle.BackColor = Color.Red;
                else if (dr.Cells["remark"].Value.ToString() == "A" && (bool)dr.Cells["pc_m_cofirm"].Value)
                    dr.DefaultCellStyle.BackColor = Color.Lime;
                else
                    dr.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            grt_Main.SelectedTab = tab_Menu;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (pcmMocde)
            {
                foreach (DataGridViewCell cell in dgvRequest.SelectedCells)
                {
                    requestData.PC_MConfirm(new pts_request_log
                    {
                        request_id = (int)dgvRequest.Rows[cell.RowIndex].Cells["request_id"].Value,
                        comment = string.Empty,
                    });
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgvRequest.SelectedCells)
                {
                    requestData.PC_Approve(new pts_request_log
                    {
                        request_id = (int)dgvRequest.Rows[cell.RowIndex].Cells["request_id"].Value,
                        approve_usercd = UserData.usercode,
                        comment = string.Empty,
                        remark = "A"
                    });
                }
            }
            UpdateGrid();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvRequest.SelectedCells)
            {
                requestData.PC_Approve(new pts_request_log
                {
                    request_id = (int)dgvRequest.Rows[cell.RowIndex].Cells["request_id"].Value,
                    approve_usercd = UserData.usercode,
                    comment = string.Empty,
                    remark = "R"
                });
            }
            UpdateGrid();
        }
        #endregion

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            PlanningForm planFrm = new PlanningForm();
            planFrm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingFrm = new SettingForm();
            settingFrm.Show();
        }

        private void btnStockOutLog_Click(object sender, EventArgs e)
        {
            StockOutLogForm stockoutLogFrm = new StockOutLogForm();
            stockoutLogFrm.Show();
        }
    }
}
