using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class StockDetailForm : FormCommon
    {
        #region VARIABLE
        private pts_item itemData { get; set; }
        private pts_item olditemData { get; set; }
        private pts_stock stockData { get; set; }
        private pts_stock oldStockData { get; set; }
        private m_mes_user userData { get; set; }
        private pts_stock_log stockLog { get; set; }
        private pts_item_type typeData { get; set; }
        private pts_supplier supplierData { get; set; }
        private List<pts_stock_log> listStockLog { get; set; }
        private ErrorProvider errprovider = new ErrorProvider();
        private string[] barcode;
        private bool isEditData;
        #endregion

        #region FORM EVENT
        public StockDetailForm()
        {
            InitializeComponent();
            itemData = new pts_item();
            olditemData = new pts_item();
            stockData = new pts_stock();
            oldStockData = new pts_stock();
            userData = new m_mes_user();
            stockLog = new pts_stock_log();
            typeData = new pts_item_type();
            supplierData = new pts_supplier();
            listStockLog = new List<pts_stock_log>();
            tc_MainStockDetail.ItemSize = new Size(0, 1);
        }

        private void StockDetailForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            txtItemCD.Focus();
            isEditData = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            tc_MainStockDetail.SelectedTab = tab_StockDetail;
        }
        #endregion

        #region FIELDS EVENT
        //GET BARCODE DATA INTO FIELDS IN FORM
        private void txtItemCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barcode = txtItemCD.Text.Split(';');
                //GET ITEM CODE
                txtItemCD.Text = barcode[0];
                //GET SUPPLIER CODE
                if (barcode.Length > 6)
                    txtSupplierCD.Text = barcode[6];
                //GET INVOICE
                txtInvoice.Text = barcode[3];
                //GET DATE
                dtpFromDate.Value = DateTime.Parse(barcode[4]);
                dtpToDate.Value = DateTime.Parse(barcode[4]);
                //GET ORDER NO
                //txtOrderNo.Text = barcode[7];
            }
        }

        private void txtItemCD_TextChanged(object sender, EventArgs e)
        {
            errprovider.SetError(txtItemCD, null);
            txtItemCD.BackColor = Color.White;
            if (string.IsNullOrEmpty(txtItemCD.Text))
                return;
            try
            {
                itemData = itemData.GetItem(txtItemCD.Text);
                lbItemName.Text = itemData.item_name;
                lbItemName.BackColor = Color.Lime;
            }
            catch
            {
                errprovider.SetError(txtItemCD, "Wrong item code!");
                txtItemCD.BackColor = Color.Yellow;
                lbItemName.Text = "Item Name";
                lbItemName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            }
        }

        private void txtSupplierCD_TextChanged(object sender, EventArgs e)
        {
            txtSupplierCD.BackColor = Color.White;
            if (string.IsNullOrEmpty(txtSupplierCD.Text))
                return;
            try
            {
                lbSupplierName.Text = supplierData.GetSupplier(new pts_supplier
                {
                    supplier_id = 0,
                    supplier_cd = txtSupplierCD.Text
                }).supplier_name;
                lbSupplierName.BackColor = Color.Lime;
            }
            catch
            {
                txtSupplierCD.BackColor = Color.Yellow;
                lbSupplierName.Text = "Supplier Name";
                lbSupplierName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            }
        }

        private void txtInCharge_TextChanged(object sender, EventArgs e)
        {
            txtInCharge.BackColor = Color.White;
            if (string.IsNullOrEmpty(txtInCharge.Text))
                return;
            try
            {
                userData = userData.GetUser(txtInCharge.Text);
                lbInchagre.Text = userData.user_name;
                lbInchagre.BackColor = Color.Lime;
            }
            catch
            {
                txtInCharge.BackColor = Color.Yellow;
                lbInchagre.Text = "User Incharge";
                lbInchagre.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            }
        }
        #endregion

        #region BUTTONS EVENT
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Question("Do you want update this item?") == DialogResult.No)
                    return;
                UpdateStock();
                ClearFields();
                UpdateGrid(false);
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Question("Do you want delete this item?") == DialogResult.No)
                    return;
                DeleteStock();
                ClearFields();
                UpdateGrid(false);
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFrm = new OpenFileDialog();
                openFrm.Filter = "CSV document (*.csv)|*.csv|Text file (*.txt)|*.txt|All file (*.*)|*.*";
                if (openFrm.ShowDialog() == DialogResult.OK)
                {
                    stockData.ExportToCSV((List<pts_stock>)dgvStockDetail.DataSource, openFrm.FileName);
                }
                CustomMessageBox.Notice("Export data to " + openFrm.FileName + " completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion

        #region SUB EVENTS
        /// <summary>
        /// Update Stock Detail Grid
        /// </summary>
        /// <param name="isSearch">true if search items</param>
        private void UpdateGrid(bool isSearch)
        {
            try
            {
                if (isSearch)
                {
                    stockData.SearchItem(new pts_stock
                    {
                        item_cd = txtItemCD.Text,
                        supplier_cd = txtSupplierCD.Text,
                        order_no = txtOrderNo.Text,
                        invoice = txtInvoice.Text,
                        stockin_user_cd = txtInCharge.Text,
                    }, dtpFromDate.Value, dtpToDate.Value, cbSearchDate.Checked);
                }
                dgvStockDetail.DataSource = stockData.listStockItems;
                dgvStockDetail.Columns["stock_id"].HeaderText = "Stock ID";
                dgvStockDetail.Columns["packing_cd"].HeaderText = "Packing Code";
                dgvStockDetail.Columns["item_cd"].HeaderText = "Item Code";
                dgvStockDetail.Columns["supplier_cd"].HeaderText = "Supplier Code";
                dgvStockDetail.Columns["order_no"].HeaderText = "Order No";
                dgvStockDetail.Columns["invoice"].HeaderText = "Invoice";
                dgvStockDetail.Columns["stockin_date"].HeaderText = "Stock-In Date";
                dgvStockDetail.Columns["stockin_user_cd"].HeaderText = "Stock-In User";
                dgvStockDetail.Columns["stockin_qty"].HeaderText = "Stock-In Qty";
                dgvStockDetail.Columns["packing_qty"].HeaderText = "Packing Qty";
                dgvStockDetail.Columns["registration_user_cd"].HeaderText = "Reg User";
                dgvStockDetail.Columns["registration_date_time"].HeaderText = "Reg Date";
                if (dgvStockDetail.Rows.Count > 0)
                    tsStockDetailRows.Text = dgvStockDetail.Rows.Count.ToString();
                else
                    tsStockDetailRows.Text = "None";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        /// <summary>
        /// Update Item Info Grid
        /// </summary>
        private void UpdateGrid()
        {
            dgvItemInfo.DataSource = itemData.listItems;
            dgvItemInfo.Columns["item_id"].HeaderText = "Item ID";
            dgvItemInfo.Columns["type_id"].HeaderText = "Type";
            dgvItemInfo.Columns["item_cd"].HeaderText = "Item Code";
            dgvItemInfo.Columns["item_name"].HeaderText = "Item Name";
            dgvItemInfo.Columns["item_location"].HeaderText = "Location";
            dgvItemInfo.Columns["item_unit"].HeaderText = "Unit";
            dgvItemInfo.Columns["lot_size"].HeaderText = "Lot Size";
            dgvItemInfo.Columns["wh_qty"].HeaderText = "WH Qty";
            dgvItemInfo.Columns["wip_qty"].HeaderText = "W.I.P Qty";
            dgvItemInfo.Columns["repair_qty"].HeaderText = "Repair Qty";
            dgvItemInfo.Columns["registration_user_cd"].HeaderText = "Reg User";
            dgvItemInfo.Columns["registration_date_time"].HeaderText = "Reg Date";
            if (dgvItemInfo.Rows.Count > 0)
            {
                int t = (int)dgvItemInfo.Rows[0].Cells["type_id"].Value;
                typeData = typeData.GetItemType(t);
                lbItemTypeName.Text = typeData.type_name;
                lbItemTypeName.BackColor = Color.Lime;
            }
        }

        /// <summary>
        /// Clear all fields
        /// </summary>
        private void ClearFields()
        {
            try
            {
                txtItemCD.Clear();
                txtInvoice.Clear();
                txtOrderNo.Clear();
                txtInCharge.Clear();
                txtPackingCD.Clear();
                txtPackingQty.Clear();
                txtStockInQty.Clear();
                txtSupplierCD.Clear();
                itemData.listItems.Clear();
                stockData.listStockItems.Clear();
                lbInchagre.Text = "User Incharge";
                lbInchagre.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                lbItemName.Text = "Item Name";
                lbItemName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                lbItemTypeName.Text = "Item Type Name";
                lbItemTypeName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                lbSupplierName.Text = "Supplier Name";
                lbSupplierName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        /// <summary>
        /// Update stock item
        /// </summary>
        private void UpdateStock()
        {
            try
            {
                listStockLog.Clear();
                #region CHECK ITEM CHANGE INFO AND ADD LOG INTO LIST LOGS
                if (txtItemCD.Text != oldStockData.item_cd)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.item_cd),
                        before_value = oldStockData.item_cd,
                        after_value = txtItemCD.Text
                    });
                }
                if (txtSupplierCD.Text != oldStockData.supplier_cd)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.supplier_cd),
                        before_value = oldStockData.item_cd,
                        after_value = txtSupplierCD.Text
                    });
                }
                if (txtInCharge.Text != oldStockData.stockin_user_cd)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.stockin_user_cd),
                        before_value = oldStockData.stockin_user_cd,
                        after_value = txtInCharge.Text
                    });
                }
                if (txtInvoice.Text != oldStockData.invoice)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.invoice),
                        before_value = oldStockData.invoice,
                        after_value = txtInvoice.Text
                    });
                }
                if (txtOrderNo.Text != oldStockData.order_no)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.order_no),
                        before_value = oldStockData.order_no,
                        after_value = txtOrderNo.Text
                    });
                }
                if (txtPackingCD.Text != oldStockData.packing_cd)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.packing_cd),
                        before_value = oldStockData.packing_cd,
                        after_value = txtPackingCD.Text
                    });
                }
                if (double.Parse(txtStockInQty.Text) != oldStockData.stockin_qty)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.stockin_qty),
                        before_value = oldStockData.stockin_qty.ToString(),
                        after_value = txtStockInQty.Text
                    });
                }
                if (double.Parse(txtPackingQty.Text) != oldStockData.packing_qty)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.packing_qty),
                        before_value = oldStockData.packing_qty.ToString(),
                        after_value = txtPackingQty.Text
                    });
                }
                if (dtpFromDate.Value != oldStockData.stockin_date)
                {
                    listStockLog.Add(new pts_stock_log
                    {
                        log_action = "Update",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = nameof(oldStockData.stockin_date),
                        before_value = oldStockData.stockin_date.ToString(),
                        after_value = dtpFromDate.Value.ToString()
                    });
                }
                #endregion

                string pack = oldStockData.packing_cd;
                int n = 0;
                if (listStockLog.Count <= 0)
                {
                    CustomMessageBox.Notice("No change has been detected!");
                    return;
                }
                    n = stockLog.AddMultiLog(listStockLog);
                //Update stock item
                stockData.UpdateItem(new pts_stock
                {
                    stock_id = oldStockData.stock_id,
                    item_cd = txtItemCD.Text,
                    supplier_cd = txtSupplierCD.Text,
                    stockin_user_cd = txtInCharge.Text,
                    invoice = txtInvoice.Text,
                    order_no = txtOrderNo.Text,
                    packing_cd = txtPackingCD.Text,
                    stockin_qty = double.Parse(txtStockInQty.Text),
                    packing_qty = double.Parse(txtPackingQty.Text),
                    stockin_date = dtpFromDate.Value,
                    registration_user_cd = UserData.usercode,
                    registration_date_time = DateTime.Now
                });
                CustomMessageBox.Notice("Update package: " + pack + " successful!" + Environment.NewLine + "Update " + n + " Logs!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        /// <summary>
        /// Delete stock item
        /// </summary>
        private void DeleteStock()
        {
            try
            {
                listStockLog.Clear();
                //Get all old data of fields in stock item
                for (int i = 0; i < oldStockData.GetType().GetProperties().Length; i++)
                {
                    stockLog = new pts_stock_log
                    {
                        log_action = "Delete",
                        log_user_cd = UserData.usercode,
                        stock_id = oldStockData.stock_id.ToString(),
                        stock_field = oldStockData.GetType().GetProperties()[i].Name,
                        before_value = oldStockData.GetType().GetProperties()[i].GetValue(oldStockData).ToString(),
                        after_value = "Deleted"
                    };
                    //Add logs item into list
                    listStockLog.Add(stockLog);
                }
                int id = oldStockData.stock_id;
                int n = stockLog.AddMultiLog(listStockLog);
                //Delete stock data
                oldStockData.DeleteItem();
                CustomMessageBox.Notice("Deleted item : " + id + " Successful!" + Environment.NewLine + "Update " + n + " logs!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void dgvStockDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (isEditData)
            {
                if (CustomMessageBox.Question("This item is edited but not update. Do you want cancel it?") == DialogResult.No)
                    return;
                isEditData = false;
            }
            itemData.listItems.Clear();
            olditemData = itemData.GetItem(dgvStockDetail.Rows[e.RowIndex].Cells["item_cd"].Value.ToString());
            //Get old stock data and show it in fields
            oldStockData = dgvStockDetail.Rows[e.RowIndex].DataBoundItem as pts_stock;
            txtItemCD.Text = oldStockData.item_cd;
            txtInvoice.Text = oldStockData.invoice;
            txtOrderNo.Text = oldStockData.order_no;
            txtPackingCD.Text = oldStockData.packing_cd;
            txtPackingQty.Text = oldStockData.packing_qty.ToString();
            txtStockInQty.Text = oldStockData.stockin_qty.ToString();
            txtSupplierCD.Text = oldStockData.supplier_cd;
            txtInCharge.Text = oldStockData.stockin_user_cd;
            dtpFromDate.Value = oldStockData.stockin_date;
            dtpToDate.Value = oldStockData.stockin_date;
            itemData.listItems.Add(olditemData);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            UpdateGrid();
        }

        private void dgvStockDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvStockDetail.Rows.Count; i++)
                dgvStockDetail.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void smenuStockDetail_Click(object sender, EventArgs e)
        {
            tc_MainStockDetail.SelectedTab = tab_StockDetail;
        }

        private void smenuLogDetail_Click(object sender, EventArgs e)
        {
            tc_MainStockDetail.SelectedTab = tab_LogDetail;
            //Search all logs
            stockLog.Search(new pts_stock_log
            {
                log_action = string.Empty,
                log_user_cd = string.Empty,
                stock_field = string.Empty,
            }, DateTime.Now, DateTime.Now, false);
            dgvLogDetail.DataSource = stockLog.listStockLog;
            for (int i = 0; i < dgvLogDetail.Rows.Count; i++)
            {
                dgvLogDetail.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            if (dgvLogDetail.Rows.Count > 0)
                tsStockDetailRows.Text = dgvLogDetail.Rows.Count.ToString();
        }
        #endregion

        #region PRINT
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pDL = new PrintDialog();
            PrintDocument pDOC = new PrintDocument();
            pDOC.DocumentName = "Print Doc";
            pDL.Document = pDOC;
            pDL.AllowSelection = true;
            pDL.AllowSomePages = true;
            if (pDL.ShowDialog() == DialogResult.OK)
            {
                pDOC.Print();
            }
        }

        PrintClass pcla = new PrintClass(400, 600, 10, 10, 10, 10);

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            PrintDocument pDOC = new PrintDocument();
            pDOC.DocumentName = "Print Doc";
            pDOC.PrintPage += PDOC_PrintPage;
            PrintPreviewDialog ppDL = new PrintPreviewDialog();
            ppDL.Document = pDOC;
            ppDL.ShowDialog();
        }

        private void PDOC_PrintPage(object sender, PrintPageEventArgs e)
        {
            int temp = 10;
            Bitmap page = new Bitmap(dgvStockDetail.Width, dgvStockDetail.Height);
            for (int c = 0; c < dgvStockDetail.Columns.Count; c++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(temp, 50, dgvStockDetail.Columns[c].Width, 100));
                e.Graphics.DrawString(dgvStockDetail.Columns[c].HeaderText, dgvStockDetail.Columns[c].InheritedStyle.Font, new SolidBrush(Color.Black), temp + 5, 90);
                temp += dgvStockDetail.Columns[c].Width;
            }
            e.Graphics.DrawImage(page, 0, 0);
        }
        #endregion
    }
}
