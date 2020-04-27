using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class StockOutForm : FormCommon
    {
        #region VARIABLE
        private PrintItem printData { get; set; }
        private List<PrintItem> listPrintItems { get; set; }
        private OutputItem outData { get; set; }
        private pts_stock stockData { get; set; }
        private List<pts_stock> listStock { get; set; }

        private pts_noplan noplanData { get; set; }
        private List<pts_noplan> listNoPlan { get; set; }

        private pts_stockout_log stockOutData { get; set; }
        private List<pts_stockout_log> listStockOut { get; set; }

        private pts_item itemData { get; set; }
        private pts_supplier supplierData { get; set; }
        private m_mes_user mUserData { get; set; }
        private pts_issue_code issueCode { get; set; }
        private pts_destination destinationData { get; set; }
        private ErrorProvider errorProvider = new ErrorProvider();
        #endregion

        #region FORM EVENT
        public StockOutForm()
        {
            InitializeComponent();
            tc_Main.ItemSize = new Size(0, 1);
            supplierData = new pts_supplier();
            printData = new PrintItem();
            outData = new OutputItem();
            itemData = new pts_item();
            stockData = new pts_stock();
            mUserData = new m_mes_user();
            noplanData = new pts_noplan();
            issueCode = new pts_issue_code();
            stockOutData = new pts_stockout_log();
            destinationData = new pts_destination();
            listPrintItems = new List<PrintItem>();
            listStock = new List<pts_stock>();
            listNoPlan = new List<pts_noplan>();
            listStockOut = new List<pts_stockout_log>();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            GetCmb();
        }
        #endregion

        #region STOCK-OUT NO PLANNED
        #region BUTTONS EVENT
        private void btnNoPlanRegister_Click(object sender, EventArgs e)
        {
            try
            {
                #region CHECK INFO BEFORE ADD ITEM
                //Check item empty
                if (string.IsNullOrEmpty(txtNoPlanItemCD.Text))
                {
                    CustomMessageBox.Notice("Item can't empty! Please check and scan barcode again!");
                    return;
                }
                //Check issue code empty
                if (string.IsNullOrEmpty(cmbNoPlanIssueCD.Text))
                {
                    errorProvider.SetError(cmbNoPlanIssueCD, "Please choose issue code!");
                    return;
                }
                //Check destination empty
                if (string.IsNullOrEmpty(cmbNoPlanDestinationCD.Text))
                {
                    errorProvider.SetError(cmbNoPlanDestinationCD, "Please choose destination!");
                    return;
                }
                //Check user code empty
                if (string.IsNullOrEmpty(txtNoPlanUserCD.Text))
                {
                    errorProvider.SetError(txtNoPlanUserCD, "Please fill user code!");
                    return;
                }
                //Check stock-in-hand qty
                if (double.Parse(txtNoPlanWHQty.Text) == 0)
                {
                    CustomMessageBox.Notice("Don't have item in stock. Please check and try again!");
                    return;
                }
                //Check stock-out qty
                if (string.IsNullOrEmpty(txtNoPlanStockOutQty.Text) || double.Parse(txtNoPlanStockOutQty.Text) == 0)
                {
                    CustomMessageBox.Notice("Please fill stock-out qty!");
                    return;
                }
                //When issue code is 30 then required fill comment
                if ((int)cmbNoPlanIssueCD.SelectedValue == 30 && string.IsNullOrEmpty(txtNoPlanComment.Text))
                {
                    CustomMessageBox.Notice("Please fill comment when Scrap Item!");
                    return;
                }
                double temp;
                double stockOutQty = double.Parse(txtNoPlanStockOutQty.Text);
                string noplancd = "NP" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                //If stock out qty > packing qty then alert
                if (stockOutQty > double.Parse(txtNoPlanWHQty.Text))
                {
                    //if (CustomMessageBox.Warring("Stock-out qty is over than stock-in-hand qty!" + Environment.NewLine + "Are you sure to continue?") == DialogResult.No)
                    CustomMessageBox.Notice("Stock-out qty is over than stock-in-hand qty! Please set another!");
                    return;
                }
                if (CustomMessageBox.Question("Are you sure add this stock-out item?") == DialogResult.No) return;
                #endregion

                #region ADD NEW NO-PLAN
                //Add noplan item into list
                listNoPlan.Add(new pts_noplan
                {
                    noplan_cd = noplancd,
                    destination_cd = cmbNoPlanDestinationCD.SelectedValue.ToString(),
                    item_cd = txtNoPlanItemCD.Text,
                    noplan_qty = stockOutQty,
                    noplan_usercd = txtNoPlanUserCD.Text,
                    noplan_date = dtpNoPlanStockOutDate.Value,
                });
                #endregion

                //Check all packing in dgv
                foreach (DataGridViewRow dr in dgvNoPlan.Rows)
                {
                    //Get packing stockOutQty & packing code
                    stockData = dr.DataBoundItem as pts_stock;

                    //If packing is empty then skip it
                    if (stockData.packing_qty <= 0) continue;

                    if (string.IsNullOrEmpty(stockData.order_no)) stockData.order_no = txtNoPlanSetNumber.Text;
                    else
                    {
                        if (CustomMessageBox.Question("This stock item have set number: " + stockData.order_no + "." + Environment.NewLine + "Do you want to change to set number: " + txtNoPlanSetNumber.Text + "?") == DialogResult.Yes) stockData.order_no = txtNoPlanSetNumber.Text;
                    }
                    //Get item info
                    itemData = itemData.GetItem(stockData.item_cd);
                    //Get supplier
                    supplierData = supplierData.GetSupplier(new pts_supplier { supplier_cd = stockData.supplier_cd });

                    #region ADD STOCK-OUT ITEM
                    //If stock-out qty > packing qty then stock-out next pack
                    if (stockOutQty > stockData.packing_qty)
                    {
                        temp = stockData.packing_qty;
                        stockOutQty = stockOutQty - stockData.packing_qty;
                    }
                    else //When stock-out qty < pack qty then get a number = stock-out qty
                    {
                        temp = stockOutQty;
                        stockOutQty = 0;
                    }
                    //Add stock-out item into a list
                    listStockOut.Add(new pts_stockout_log
                    {
                        packing_cd = stockData.packing_cd,
                        process_cd = noplancd,
                        issue_cd = (int)cmbNoPlanIssueCD.SelectedValue,
                        stockout_date = dtpNoPlanStockOutDate.Value,
                        stockout_user_cd = txtNoPlanUserCD.Text,
                        stockout_qty = temp,
                        comment = txtNoPlanComment.Text,
                        remark = "N",
                    });
                    #region ADD LIST LABEL STOCK-OUT AND LIST ITEM FOR CSV
                    //Add new label stock-out
                    printData.ListPrintItem.Add(new PrintItem
                    {
                        Item_Number = txtNoPlanItemCD.Text,
                        Item_Name = itemData.item_name,
                        SupplierName = supplierData.supplier_name,
                        Invoice = txtNoPlanInvoice.Text,
                        Delivery_Date = dtpNoPlanStockOutDate.Value,
                        Delivery_Qty = temp,
                        SupplierCD = supplierData.supplier_cd,
                        //OrderNo = stockData.order_no,
                        isRec = false,
                        Label_Qty = 1
                    });
                    //Add Output item
                    outData.listOutputItem.Add(new OutputItem
                    {
                        issue_cd = (int)cmbNoPlanIssueCD.SelectedValue,
                        destination_cd = cmbNoPlanDestinationCD.SelectedValue.ToString(),
                        item_number = txtNoPlanItemCD.Text,
                        //item_name = itemData.item_name,
                        //supplier_cd = supplierData.supplier_cd,
                        //supplier_name = supplierData.supplier_name,
                        //supplier_invoice = txtNoPlanInvoice.Text,
                        order_number = stockData.order_no,
                        delivery_date = dtpNoPlanStockOutDate.Value,
                        delivery_qty = temp,
                        incharge = txtNoPlanUserCD.Text,
                    });
                    #endregion
                    #endregion

                    #region CALCULATOR, ADD LIST STOCK ITEM AND ADD LIST LABEL STOCK-ON-HAND
                    //Calculator pack qty in stock
                    stockData.packing_qty = stockData.packing_qty - temp;
                    listStock.Add(stockData);
                    //Add new label stock-in when it not empty
                    if (stockData.packing_qty > 0)
                    {
                        printData.ListPrintItem.Add(new PrintItem
                        {
                            Item_Number = txtNoPlanItemCD.Text,
                            Item_Name = itemData.item_name,
                            SupplierName = supplierData.supplier_name,
                            Invoice = txtNoPlanInvoice.Text,
                            Delivery_Date = stockData.stockin_date,
                            Delivery_Qty = stockData.packing_qty,
                            SupplierCD = supplierData.supplier_cd,
                            //OrderNo = stockData.order_no,
                            isRec = false,
                            Label_Qty = 1
                        });
                    }
                    #endregion

                    //If get enough stock-out qty then break
                    if (stockOutQty == 0) break;
                }
                //Update grid in inspection tab
                UpdateProcessGrid(0);
                btnNoPlanInspection.Visible = true;
                if (CustomMessageBox.Question("Successful!. Do you want go to Inspection Tab to see it?") == DialogResult.Yes)
                    tc_Main.SelectedTab = tab_Inspection;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnNoPlanInspection_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Inspection;
        }

        private void btnNoPlanSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingFrm = new SettingForm();
            settingFrm.ShowDialog();
        }

        private void btnNoplanClear_Click(object sender, EventArgs e)
        {
            //Clear all fields of No plan tab
            txtNoPlanWHQty.Clear();
            txtNoPlanUserCD.Clear();
            txtNoPlanItemCD.Clear();
            txtNoPlanInvoice.Clear();
            txtNoPlanComment.Clear();
            txtNoPlanSetNumber.Clear();
            txtNoPlanStockOutQty.Clear();
            UpdateNoPlanGrid(false);
            dgvNoPlan.DataSource = null;
            cmbNoPlanIssueCD.Text = null;
            cmbNoPlanDestinationCD.Text = null;
        }
        #endregion

        #region FIELDS EVENT
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //When scan barcode or press Enter key
                if (e.KeyCode == Keys.Enter)
                {
                    string[] barcode = txtBarcode.Text.Split(';');
                    //Get item number
                    txtNoPlanItemCD.Text = barcode[0];
                    //Get invoice
                    txtNoPlanInvoice.Text = barcode[3];
                    txtBarcode.Clear();
                    //Update grid and search stock item
                    UpdateNoPlanGrid(true);
                    //Calculator W/H qty of current item
                    txtNoPlanWHQty.Text = dgvNoPlan.Rows.Cast<DataGridViewRow>()
                        .Sum(x => Convert.ToDouble(x.Cells["packing_qty"].Value)).ToString();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void cmbNoPlanIssueCD_Format(object sender, ListControlConvertEventArgs e)
        {
            string code = ((pts_issue_code)e.ListItem).issue_cd.ToString();
            string iname = ((pts_issue_code)e.ListItem).issue_name;
            e.Value = code + ": " + iname;
        }

        private void cmbNoPlanDestinationCD_Format(object sender, ListControlConvertEventArgs e)
        {
            string code = ((pts_destination)e.ListItem).destination_cd;
            string iname = ((pts_destination)e.ListItem).destination_name;
            e.Value = code + ": " + iname;
        }

        private void txtItemCDStockOut_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNoPlanItemCD, null);
            lbNoPlanItem.Text = "Item Name";
            lbNoPlanItem.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            if (!string.IsNullOrEmpty(txtNoPlanItemCD.Text))
            {
                try
                {
                    lbNoPlanItem.Text = itemData.GetItem(txtNoPlanItemCD.Text).item_name;
                    lbNoPlanItem.BackColor = Color.Lime;
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txtNoPlanItemCD, "Wrong Item Code" +
                                           Environment.NewLine + ex.Message);
                }
            }
        }

        private void txtStockOutUser_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNoPlanUserCD, null);
            lbNoPlanUser.Text = "User Name";
            lbNoPlanUser.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            if (!string.IsNullOrEmpty(txtNoPlanUserCD.Text))
            {
                try
                {
                    lbNoPlanUser.Text = mUserData.GetUser(txtNoPlanUserCD.Text).user_name;
                    lbNoPlanUser.BackColor = Color.Lime;
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txtNoPlanUserCD, "Wrong User Code" +
                                           Environment.NewLine + ex.Message);
                }
            }
        }

        private void cmbNoPlanIssueCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbNoPlanIssueCD.Text))
                errorProvider.SetError(cmbNoPlanIssueCD, null);
        }

        private void cmbNoPlanDestinationCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbNoPlanDestinationCD.Text))
                errorProvider.SetError(cmbNoPlanDestinationCD, null);
        }

        private void txtNoPlanStockOutQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbSign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSign.Checked) txtNoPlanStockOutQty.Text = "-" + txtNoPlanStockOutQty.Text;
            else txtNoPlanStockOutQty.Text = txtNoPlanStockOutQty.Text.Replace("-", "");
        }

        private void tab_NoPlan_Paint(object sender, PaintEventArgs e)
        {
            if (dgvProcess.Rows.Count > 0) btnNoPlanInspection.Visible = true;
            else btnNoPlanInspection.Visible = false;
            UpdateNoPlanGrid(false);
            txtBarcode.Focus();
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
                issueCode.GetListIssueCode();
                cmbNoPlanIssueCD.DataSource = issueCode.listIssueCode;
                cmbNoPlanIssueCD.DisplayMember = "issue_name";
                cmbNoPlanIssueCD.ValueMember = "issue_cd";
                cmbNoPlanIssueCD.Text = null;
                destinationData.GetListDestination(string.Empty, string.Empty);
                cmbNoPlanDestinationCD.DataSource = destinationData.listdestination;
                cmbNoPlanDestinationCD.DisplayMember = "destination_name";
                cmbNoPlanDestinationCD.ValueMember = "destination_cd";
                cmbNoPlanDestinationCD.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update No plan tab grid
        /// </summary>
        /// <param name="isSearch">true: search stock item</param>
        private void UpdateNoPlanGrid(bool isSearch)
        {
            if (isSearch)
            {
                //Search stock item with item code and invoice
                if (!stockData.SearchItem(new pts_stock { item_cd = txtNoPlanItemCD.Text, invoice = txtNoPlanInvoice.Text }))
                {
                    CustomMessageBox.Error("This stock item is not exist! Please check and try again!");
                    lbNoPlanItem.Text = "Item Name";
                    txtNoPlanItemCD.Clear();
                    return;
                }
            }
            dgvNoPlan.DataSource = stockData.listStockItems;
            dgvNoPlan.Columns["stock_id"].HeaderText = "Stock ID";
            dgvNoPlan.Columns["packing_cd"].HeaderText = "Packing Code";
            dgvNoPlan.Columns["item_cd"].HeaderText = "Item Code";
            dgvNoPlan.Columns["supplier_cd"].HeaderText = "Supplier Code";
            dgvNoPlan.Columns["order_no"].HeaderText = "Order Number";
            dgvNoPlan.Columns["invoice"].HeaderText = "Invoice";
            dgvNoPlan.Columns["stockin_date"].HeaderText = "Stock In Date";
            dgvNoPlan.Columns["stockin_user_cd"].HeaderText = "Incharge";
            dgvNoPlan.Columns["stockin_qty"].HeaderText = "Stock In Qty";
            dgvNoPlan.Columns["packing_qty"].HeaderText = "Packing Qty";
            dgvNoPlan.Columns["registration_user_cd"].HeaderText = "Reg User";
            dgvNoPlan.Columns["registration_date_time"].HeaderText = "Reg Date";
            if (dgvNoPlan.Rows.Count > 0) tsRows.Text = dgvNoPlan.Rows.Count.ToString();
            else tsRows.Text = "None";
        }
        #endregion
        #endregion

        #region INSPECTION STOCK-OUT
        #region BUTTONS EVENT
        private void btnStockOutReg_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                //Add no-plan item into DB
                if (listNoPlan.Count > 0)
                {
                    n = noplanData.AddMultiItem(listNoPlan);
                    CustomMessageBox.Notice("Add " + n + " No-Planned item successed!");
                }
                //Add stock-out logs into DB
                if (listStockOut.Count > 0)
                {
                    n = stockOutData.AddMultiItem(listStockOut);
                    outData.ExportCSV(outData.listOutputItem);
                    CustomMessageBox.Notice("Add " + n + " Stock-Out logs!");
                }
                //Update packing qty of stock item in DB
                foreach (pts_stock item in listStock)
                {
                    item.UpdateItem(item);
                }
                //Update stock qty
                itemData.ListStockOutUpdateValue(outData.listOutputItem);
                CustomMessageBox.Notice("Register completed!");
                ClearInspection();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                listPrintItems.Clear();
                if (dgvPrintList.Rows.Count == 0)
                {
                    CustomMessageBox.Notice("Don't have item to print!");
                    return;
                }
                if (printData.CheckPrinterIsOffline(SettingItem.printerSName))
                {
                    CustomMessageBox.Notice("Printer is offline");
                    return;
                }
                foreach (DataGridViewRow dr in dgvPrintList.Rows)
                {
                    listPrintItems.Add(dr.DataBoundItem as PrintItem);
                    dr.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                }
                if (printData.PrintItems(listPrintItems, false))
                    CustomMessageBox.Notice("Print items are completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnPrintManual_Click(object sender, EventArgs e)
        {
            try
            {
                listPrintItems.Clear();
                if (dgvPrintList.Rows.Count == 0)
                {
                    CustomMessageBox.Notice("Don't have item to print!");
                    return;
                }
                if (printData.CheckPrinterIsOffline(SettingItem.printerSName))
                {
                    CustomMessageBox.Notice("Printer is offline");
                    return;
                }
                foreach (DataGridViewRow dr in dgvPrintList.SelectedRows)
                {
                    listPrintItems.Add(dr.DataBoundItem as PrintItem);
                    dr.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (printData.PrintItems(listPrintItems, true))
                    CustomMessageBox.Notice("Print items are completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnInspectionClear_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Warring("Data is not register." + Environment.NewLine + "Are you sure to clear it?") == DialogResult.Yes)
                ClearInspection();
        }

        private void btnInspectionBack_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_NoPlan;
        }
        #endregion

        #region SUB EVENT
        /// <summary>
        /// Update datagridview to show process data
        /// </summary>
        /// <param name="state">0: No planned. 1: Planning. 2: Request</param>
        private void UpdateProcessGrid(int state)
        {
            switch (state)
            {
                case 0:
                    dgvProcess.DataSource = listNoPlan;
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
            dgvPrintList.DataSource = printData.ListPrintItem;
        }

        private void ClearInspection()
        {
            listStock.Clear();
            listNoPlan.Clear();
            listStockOut.Clear();
            outData.listOutputItem.Clear();
            printData.ListPrintItem.Clear();
            dgvProcess.DataSource = null;
            dgvPrintList.DataSource = null;
        }
        #endregion

        #endregion
    }
}
