using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class StockInputForm : FormCommon
    {
        #region ITEMS
        pts_item itemData { get; set; }
        pre_649 premacData { get; set; }
        pts_stock stockItem { get; set; }
        PrintItem printItem { get; set; }
        pts_supplier supplierItem { get; set; }
        List<PrintItem> listPrintItem { get; set; }
        List<pre_649> listPremac { get; set; }
        List<pre_649> listInputPremac { get; set; }
        BindingList<pts_stock> listStockItem { get; set; }

        TfPrint tfprinter = new TfPrint();
        Stopwatch stopWatch = new Stopwatch();
        ErrorProvider errorProvider = new ErrorProvider();

        public StockInputForm()
        {
            InitializeComponent();
            itemData = new pts_item();
            printItem = new PrintItem();
            stockItem = new pts_stock();
            premacData = new pre_649();
            supplierItem = new pts_supplier();
            listPrintItem = new List<PrintItem>();
            listPremac = new List<pre_649>();
            listInputPremac = new List<pre_649>();
            listStockItem = new BindingList<pts_stock>();
            tc_Main.ItemSize = new Size(0, 1);
        }

        private void StockInputForm_Load(object sender, EventArgs e)
        {
            rbtnEven.Checked = true;
            tc_Main.SelectedTab = tab_Main;
        }
        #endregion

        #region MAIN TAB
        #region BUTTON EVENT
        private void btnPremacImport_Click(object sender, EventArgs e)
        {
            try
            {
                //Set wait cursor when search data
                this.Cursor = Cursors.WaitCursor;
                //Start stopwatch for catch searching time
                stopWatch.Restart();
                //Get list data from premac 6-4-9 file
                listPremac = premacData.GetListPremacItem(SettingItem.premacFile);
                dgvPreInput.DataSource = listPremac;
                //Search data
                SearchPremacFile();
                //Rename file after get data
                //File.Move(SettingItem.premacFile, Path.ChangeExtension(SettingItem.premacFile, DateTime.Now.ToString("yyyyMMddHHmmss")));
                //Stop stopwatch and show time
                stopWatch.Stop();
                tsTime.Text = stopWatch.Elapsed.ToString("s\\.ff") + " s";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            this.Cursor = Cursors.Default;
            UpdatePremacGrid(true);
        }

        private void btnSearchPreInput_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                stopWatch.Restart();
                //search premac item from SQL
                premacData.Search(new pre_649
                {
                    item_number = txtItemNum.Text,
                    supplier_cd = txtSupplierCode.Text,
                    supplier_invoice = txtSupplierInvoice.Text,
                    order_number = txtOrderNo.Text,
                    po_number = txtPONo.Text,
                    incharge = txtIncharge.Text
                }, dtpFromDate.Value, dtpToDate.Value, cbCheckDate.Checked);
                dgvPreInput.ColumnHeadersVisible = false;
                dgvPreInput.DataSource = premacData.listPremacItem;
                dgvPreInput.ColumnHeadersVisible = true;
                stopWatch.Stop();
                tsTime.Text = stopWatch.Elapsed.ToString("s\\.ff") + " s";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            this.Cursor = Cursors.Default;
            UpdatePremacGrid(true);
        }

        private void btnAutoPacking_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int numberOfLot = 1;
                double sizePerLot = 1;
                double qtymod = 0;
                //Each row in datagridview
                foreach (DataGridViewRow dr in dgvPreInput.Rows)
                {
                    qtymod = 0;
                    //If item number is not exist in item database then skip it
                    try { itemData = itemData.GetItem(dr.Cells["item_number"].Value.ToString()); }
                    catch { continue; }
                    //Get lot size in database
                    sizePerLot = itemData.lot_size;
                    //If lot size = 0 then no cut lot
                    if (sizePerLot == 0) sizePerLot = (double)dr.Cells["item_name"].Value;
                    //Calculator number of lot
                    numberOfLot = (int)((double)dr.Cells["delivery_qty"].Value / sizePerLot);
                    //Add new label item into print list
                    printItem.ListPrintItem.Add(new PrintItem
                    {
                        Item_Number = dr.Cells["item_number"].Value.ToString(),
                        Item_Name = dr.Cells["item_name"].Value.ToString(),
                        SupplierCD = dr.Cells["supplier_cd"].Value.ToString(),
                        SupplierName = dr.Cells["supplier_name"].Value.ToString(),
                        Invoice = dr.Cells["supplier_invoice"].Value.ToString(),
                        Delivery_Date = (DateTime)dr.Cells["delivery_date"].Value,
                        Delivery_Qty = sizePerLot,
                        //OrderNo = dr.Cells["order_number"].Value.ToString(),
                        Remark = "P",
                        isRec = true,
                        Label_Qty = numberOfLot
                    });
                    //If the last lot is not enough, create an odd label for it
                    if (sizePerLot * numberOfLot < (double)dr.Cells["delivery_qty"].Value)
                    {
                        qtymod = (double)dr.Cells["delivery_qty"].Value - (sizePerLot * numberOfLot);
                        printItem.ListPrintItem.Add(new PrintItem
                        {
                            Item_Number = dr.Cells["item_number"].Value.ToString(),
                            Item_Name = dr.Cells["item_name"].Value.ToString(),
                            SupplierCD = dr.Cells["supplier_cd"].Value.ToString(),
                            SupplierName = dr.Cells["supplier_name"].Value.ToString(),
                            Invoice = dr.Cells["supplier_invoice"].Value.ToString(),
                            Delivery_Date = (DateTime)dr.Cells["delivery_date"].Value,
                            Delivery_Qty = qtymod,
                            //OrderNo = dr.Cells["order_number"].Value.ToString(),
                            Remark = "P",
                            isRec = true,
                            Label_Qty = 1
                        });
                    }
                    //Change color of row when add print item completed
                    dr.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                }
                //Update print list datagridview
                UpdatePrintGrid();
                tc_Main.SelectedTab = tab_Print;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnManualPacking_Click(object sender, EventArgs e)
        {
            try
            {
                double qtymod = 0;
                int numberOfLot = 1;
                double sizePerLot = 1;
                if (dgvPreInput.SelectedRows.Count <= 0)
                {
                    CustomMessageBox.Notice("Please select a row before packing!");
                    return;
                }
                if (rbtnEven.Checked)
                {
                    foreach (DataGridViewRow dr in dgvPreInput.SelectedRows)
                    {
                        double deliveryQty = (double)dr.Cells["delivery_qty"].Value;
                        if (deliveryQty <= 0)
                        {
                            CustomMessageBox.Notice("This lot is null");
                            return;
                        }
                        sizePerLot = double.Parse(txtCapacity.Text);
                        if (sizePerLot == 0) sizePerLot = deliveryQty;
                        numberOfLot = (int)(deliveryQty / sizePerLot);
                        printItem.ListPrintItem.Add(new PrintItem
                        {
                            Item_Number = dr.Cells["item_number"].Value.ToString(),
                            Item_Name = dr.Cells["item_name"].Value.ToString(),
                            SupplierCD = dr.Cells["supplier_cd"].Value.ToString(),
                            SupplierName = dr.Cells["supplier_name"].Value.ToString(),
                            Invoice = dr.Cells["supplier_invoice"].Value.ToString(),
                            Delivery_Date = (DateTime)dr.Cells["delivery_date"].Value,
                            Delivery_Qty = sizePerLot,
                            //OrderNo = dr.Cells["order_number"].Value.ToString(),
                            Remark = "P",
                            isRec = true,
                            Label_Qty = numberOfLot
                        });
                        if (sizePerLot * numberOfLot < deliveryQty)
                        {
                            qtymod = deliveryQty - (sizePerLot * numberOfLot);
                            printItem.ListPrintItem.Add(new PrintItem
                            {
                                Item_Number = dr.Cells["item_number"].Value.ToString(),
                                Item_Name = dr.Cells["item_name"].Value.ToString(),
                                SupplierCD = dr.Cells["supplier_cd"].Value.ToString(),
                                SupplierName = dr.Cells["supplier_name"].Value.ToString(),
                                Invoice = dr.Cells["supplier_invoice"].Value.ToString(),
                                Delivery_Date = (DateTime)dr.Cells["delivery_date"].Value,
                                Delivery_Qty = qtymod,
                                //OrderNo = dr.Cells["order_number"].Value.ToString(),
                                Remark = "P",
                                isRec = true,
                                Label_Qty = 1
                            });
                        }
                        dr.Cells["delivery_qty"].Value = 0;
                        dr.DefaultCellStyle.BackColor = Color.Lime;
                    }
                }
                if (rbtnOdd.Checked)
                {
                    qtymod = 0;
                    sizePerLot = double.Parse(txtCapacity.Text);
                    DataGridViewRow dr = dgvPreInput.SelectedRows[0];
                    double deliveryQty = (double)dr.Cells["delivery_qty"].Value;
                    if (deliveryQty <= 0)
                    {
                        CustomMessageBox.Notice("This lot is null");
                        return;
                    }
                    else
                    {
                        deliveryQty -= sizePerLot;
                        if (deliveryQty <= 0)
                        {
                            sizePerLot = (double)dr.Cells["delivery_qty"].Value;
                            dr.Cells["delivery_qty"].Value = 0;
                        }
                        else dr.Cells["delivery_qty"].Value = deliveryQty;
                    }
                    printItem.ListPrintItem.Add(new PrintItem
                    {
                        Item_Number = dr.Cells["item_number"].Value.ToString(),
                        Item_Name = dr.Cells["item_name"].Value.ToString(),
                        SupplierCD = dr.Cells["supplier_cd"].Value.ToString(),
                        SupplierName = dr.Cells["supplier_name"].Value.ToString(),
                        Invoice = dr.Cells["supplier_invoice"].Value.ToString(),
                        Delivery_Date = (DateTime)dr.Cells["delivery_date"].Value,
                        Delivery_Qty = sizePerLot,
                        //OrderNo = dr.Cells["order_number"].Value.ToString(),
                        Remark = "P",
                        isRec = true,
                        Label_Qty = 1
                    });
                    dr.DefaultCellStyle.BackColor = Color.Yellow;
                }
                UpdatePrintGrid();
                tc_Main.SelectedTab = tab_Print;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Print;
        }

        private void btnInspection_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Inspection;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingFrm = new SettingForm();
            settingFrm.ShowDialog();
        }

        private void btnMainClear_Click(object sender, EventArgs e)
        {
            txtPONo.Clear();
            txtOrderNo.Clear();
            txtCapacity.Clear();
            txtItemNum.Clear();
            txtIncharge.Clear();
            txtSupplierCode.Clear();
            txtSupplierInvoice.Clear();
            tsRow.Text = "None";
            tsTime.Text = "None";
            tsTotalQty.Text = "None";
            UpdatePremacGrid(false);
            dgvPreInput.DataSource = null;
        }

        private void rbtnEven_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEven.Checked) dgvPreInput.MultiSelect = true;
            if (rbtnOdd.Checked) dgvPreInput.MultiSelect = false;
        }
        #endregion

        #region SUB EVENT
        private void UpdatePremacGrid(bool isLock)
        {
            btnPremacImport.Enabled = !isLock;
            btnSearchPreInput.Enabled = !isLock;
            if (dgvPreInput.Columns.Contains("premac_id")) dgvPreInput.Columns.Remove("premac_id");
            if (dgvPreInput.Columns.Contains("po_number")) dgvPreInput.Columns.Remove("po_number");
            if (dgvPreInput.Columns.Contains("order_number")) dgvPreInput.Columns.Remove("order_number");

            //dgvPreInput.Columns["premac_id"].HeaderText = "ID";
            dgvPreInput.Columns["item_number"].HeaderText = "Item Number";
            dgvPreInput.Columns["item_name"].HeaderText = "Item Name";
            dgvPreInput.Columns["supplier_cd"].HeaderText = "Supplier Code";
            dgvPreInput.Columns["supplier_name"].HeaderText = "Supplier Name";
            dgvPreInput.Columns["supplier_invoice"].HeaderText = "Invoice";
            //dgvPreInput.Columns["po_number"].HeaderText = "PO";
            dgvPreInput.Columns["delivery_qty"].HeaderText = "Delivery Qty";
            dgvPreInput.Columns["delivery_date"].HeaderText = "Delivery Date";
            //dgvPreInput.Columns["order_number"].HeaderText = "Order Number";
            dgvPreInput.Columns["incharge"].HeaderText = "Incharge";
            dgvPrintList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            double total = dgvPreInput.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["delivery_qty"].Value));
            tsRow.Text = dgvPreInput.Rows.Count.ToString();
            tsTotalQty.Text = total.ToString();
        }

        private void SearchPremacFile()
        {
            try
            {
                //Search with item number
                if (!string.IsNullOrEmpty(txtItemNum.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.item_number == txtItemNum.Text
                                  select item).ToList();
                }
                //Search with supplier code
                if (!string.IsNullOrEmpty(txtSupplierCode.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.supplier_cd == txtSupplierCode.Text
                                  select item).ToList();
                }
                //Search with order number
                if (!string.IsNullOrEmpty(txtOrderNo.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.order_number == txtOrderNo.Text
                                  select item).ToList();
                }
                //Search with invoice
                if (!string.IsNullOrEmpty(txtSupplierInvoice.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.supplier_invoice == txtSupplierInvoice.Text
                                  select item).ToList();
                }
                //Search with incharge user
                if (!string.IsNullOrEmpty(txtIncharge.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.incharge == txtIncharge.Text
                                  select item).ToList();
                }
                //Search with PO
                if (!string.IsNullOrEmpty(txtPONo.Text))
                {
                    listPremac = (from item in listPremac
                                  where item.po_number == txtPONo.Text
                                  select item).ToList();
                }
                //Search with date
                if (cbCheckDate.Checked)
                {
                    listPremac = (from item in listPremac
                                  where (item.delivery_date >= dtpFromDate.Value && item.delivery_date <= dtpToDate.Value)
                                  select item).ToList();
                }
                dgvPreInput.DataSource = (from item in listPremac
                                          group item by new
                                          {
                                              item.item_number,
                                              item.item_name,
                                              item.supplier_cd,
                                              item.supplier_name,
                                              item.supplier_invoice,
                                              item.delivery_date,
                                              item.incharge
                                          } into g
                                          select new pre_649()
                                          {
                                              item_number = g.Key.item_number,
                                              item_name = g.Key.item_name,
                                              supplier_cd = g.Key.supplier_cd,
                                              supplier_name = g.Key.supplier_name,
                                              supplier_invoice = g.Key.supplier_invoice,
                                              delivery_qty = g.Sum(a => a.delivery_qty),
                                              delivery_date = g.Key.delivery_date,
                                              incharge = g.Key.incharge
                                          }).OrderBy(x => x.supplier_invoice).ToList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }
        #endregion

        #endregion

        #region PRINT TAB
        #region BUTTON EVENT
        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (printItem.CheckPrinterIsOffline(SettingItem.printerSName))
                {
                    CustomMessageBox.Notice("Printer is offline");
                    return;
                }
                listPrintItem.Clear();
                if (dgvPrintList.SelectedRows.Count <= 0)
                {
                    CustomMessageBox.Notice("Please choose item first!");
                    return;
                }
                foreach (DataGridViewRow dr in dgvPrintList.SelectedRows)
                {
                    listPrintItem.Add(dr.DataBoundItem as PrintItem);
                    dr.DefaultCellStyle.BackColor = Color.Lime;
                }
                if (printItem.PrintItems(listPrintItem, false))
                    CustomMessageBox.Notice("Print items are completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (printItem.CheckPrinterIsOffline(SettingItem.printerSName))
                {
                    CustomMessageBox.Notice("Printer is offline");
                    return;
                }
                listPrintItem.Clear();
                if (dgvPrintList.Rows.Count == 0)
                {
                    CustomMessageBox.Error("Don't have item to print!");
                    return;
                }
                foreach (DataGridViewRow dr in dgvPrintList.Rows)
                {
                    listPrintItem.Add(dr.DataBoundItem as PrintItem);
                    dr.DefaultCellStyle.BackColor = Color.Lime;
                }
                if (printItem.PrintItems(listPrintItem, false))
                    CustomMessageBox.Notice("Print items are completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnManualPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printItem.CheckPrinterIsOffline(SettingItem.printerSName))
                {
                    CustomMessageBox.Notice("Printer is offline");
                    return;
                }
                listPrintItem.Clear();
                if (dgvPrintList.SelectedRows.Count == 0)
                {
                    CustomMessageBox.Notice("Please choose item first!");
                    return;
                }
                foreach (DataGridViewRow dr in dgvPrintList.SelectedRows)
                {
                    listPrintItem.Add(dr.DataBoundItem as PrintItem);
                    dr.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (printItem.PrintItems(listPrintItem, true))
                    CustomMessageBox.Notice("Print items are completed!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void btnPrintClear_Click(object sender, EventArgs e)
        {
            listPrintItem.Clear();
            printItem.ListPrintItem.Clear();
            dgvPrintList.DataSource = null;
        }

        private void btnPrintBack_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Main;
        }
        #endregion

        #region SUB EVENT
        private void UpdatePrintGrid()
        {
            dgvPrintList.DataSource = printItem.ListPrintItem;
            dgvPrintList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            double total = dgvPrintList.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Delivery_Qty"].Value));
            tsTotalQty.Text = total.ToString();
            tsRow.Text = dgvPrintList.Rows.Count.ToString();
        }

        private void tab_Print_Paint(object sender, PaintEventArgs e)
        {
            UpdatePrintGrid();
        }
        #endregion
        #endregion

        #region INSPECTION TAB
        #region BUTTONS EVENT
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
            txtBarcode.Clear();
            txtBarcode.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Question("Are you sure register this list?") == DialogResult.No)
                    return;
                for (int i = 0; i < dgvInspection.Rows.Count; i++)
                {
                    //Register item into stock
                    try
                    {
                        if (stockItem.AddItem(dgvInspection.Rows[i].DataBoundItem as pts_stock) > 0)
                        {
                            listStockItem.Remove(dgvInspection.Rows[i].DataBoundItem as pts_stock);
                            i--;
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Error(ex.Message);
                        dgvInspection.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        continue;
                    }
                    //Export new item stock-in to csv for register PREMAC
                    if (listInputPremac.Count > 0)
                        premacData.ExportCSV(GroupByPremac());
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            if (listInputPremac.Count > 0)
                itemData.ListStockInUpdateValue(GroupByPremac());
            listInputPremac.Clear();
            UpdateInspectionGrid();
            txtBarcode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell dc in dgvInspection.SelectedCells)
                {
                    if (CustomMessageBox.Warring("Are you sure delete this item?") == DialogResult.Yes)
                    {
                        //Search item want to delete
                        stockItem = dgvInspection.Rows[dc.RowIndex].DataBoundItem as pts_stock;
                        var tempItem = (from x in listInputPremac
                                        where x.item_number == stockItem.item_cd &&
                                              x.supplier_cd == stockItem.supplier_cd &&
                                              x.supplier_invoice == stockItem.invoice &&
                                              x.delivery_date == stockItem.stockin_date &&
                                              x.delivery_qty == stockItem.stockin_qty
                                        select x);
                        //Delete item from list
                        listInputPremac.Remove(tempItem.FirstOrDefault());
                        listStockItem.Remove(stockItem);
                    }
                }
                dgvInspection.DataSource = listStockItem;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            UpdateInspectionGrid();
            txtBarcode.Focus();
        }

        private void btnInspectionClear_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Warring("This list is not register. Are you sure to clear all?") == DialogResult.No)
                return;
            txtBarcode.Clear();
            txtSupplierCD.Clear();
            listStockItem.Clear();
            listInputPremac.Clear();
            txtSupplierName.Text = "Supplier Name";
            errorProvider.SetError(txtSupplierCD, null);
            UpdateInspectionGrid();
            dgvInspection.DataSource = null;
            txtBarcode.Focus();
        }
        #endregion

        #region FIELDS EVENT
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNewItem();
                txtBarcode.Clear();
                txtBarcode.Focus();
            }
        }

        private void txtSupplierCD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Press F2 for add new supplier
                if (e.KeyCode == Keys.F2)
                {
                    supplierItem.AddSupplier(new pts_supplier
                    {
                        supplier_cd = txtSupplierCD.Text,
                        supplier_name = txtSupplierName.Text,
                        registration_user_cd = UserData.usercode,
                    });
                    CustomMessageBox.Notice("New supplier has been added with supplier code : " + txtSupplierCD.Text);
                    txtSupplierCD.Clear();
                    errorProvider.SetError(txtSupplierCD, null);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            txtBarcode.Focus();
        }

        private void tab_Inspection_Paint(object sender, PaintEventArgs e)
        {
            UpdateInspectionGrid();
            txtBarcode.Focus();
        }
        #endregion

        #region SUB EVENT
        /// <summary>
        /// Update datagridview
        /// </summary>
        private void UpdateInspectionGrid()
        {
            dgvInspection.DataSource = listStockItem;
            dgvInspection.Columns["stock_id"].HeaderText = "Stock ID";
            dgvInspection.Columns["packing_cd"].HeaderText = "Packing Code";
            dgvInspection.Columns["item_cd"].HeaderText = "Item Code";
            dgvInspection.Columns["supplier_cd"].HeaderText = "Supplier Code";
            dgvInspection.Columns["order_no"].HeaderText = "Order Number";
            dgvInspection.Columns["invoice"].HeaderText = "Invoice";
            dgvInspection.Columns["stockin_date"].HeaderText = "Stock In Date";
            dgvInspection.Columns["stockin_user_cd"].HeaderText = "Incharge";
            dgvInspection.Columns["stockin_qty"].HeaderText = "Stock In Qty";
            dgvInspection.Columns["packing_qty"].HeaderText = "Packing Qty";
            dgvInspection.Columns["registration_user_cd"].HeaderText = "Reg User";
            dgvInspection.Columns["registration_date_time"].HeaderText = "Reg Date";
            dgvInspection.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            double total = listStockItem.Sum(x => x.stockin_qty);
            tsRow.Text = dgvInspection.Rows.Count.ToString();
            tsTotalQty.Text = total.ToString();
        }

        /// <summary>
        /// Add new stock item into temp list
        /// </summary>
        private void AddNewItem()
        {
            try
            {
                int n = 0;
                int temp = 0;
                string invoice = "None";
                string remark = string.Empty;
                string suppliercd = string.Empty;
                string[] barcode = txtBarcode.Text.Split(';');
                txtSupplierCD.Clear();
                txtSupplierName.Clear();
                //Label of PREMAC 6-4-9 have more 2 fields
                if (barcode.Length > 7)
                {
                    if (!string.IsNullOrEmpty(barcode[6])) suppliercd = barcode[6];
                    if (!string.IsNullOrEmpty(barcode[7])) remark = barcode[7];
                }
                try
                {
                    itemData.GetItem(barcode[0]);
                }
                catch
                {
                    CustomMessageBox.Error("This item is not exisits! Please check and try again!");
                    return;
                }
                #region CHECK SUPPLIER & NOTICE FOR USER
                errorProvider.SetError(txtSupplierCD, null);
                txtSupplierName.Text = barcode[2];
                try
                {
                    //If don't have supplier code then search with supplier name and return supplier code
                    if (string.IsNullOrEmpty(suppliercd))
                    {
                        supplierItem = supplierItem.GetSupplier(new pts_supplier
                        {
                            supplier_id = 0,
                            supplier_name = txtSupplierName.Text
                        });
                        txtSupplierCD.Text = supplierItem.supplier_cd;
                    }
                    else
                    {
                        txtSupplierCD.Text = suppliercd;
                        //Searh with supplier code
                        supplierItem = supplierItem.GetSupplier(new pts_supplier
                        {
                            supplier_id = 0,
                            supplier_cd = txtSupplierCD.Text
                        });
                    }
                }
                catch (Exception ex)
                {
                    //If supplier is not exist, create a supplier with simple info
                    errorProvider.SetError(txtSupplierCD, "This supplier is not exist!" + Environment.NewLine + "Please fill supplier code and press F2 for add new supplier (" + ex.Message + ")");
                    return;
                }
                #endregion

                #region CHECK INVOICE AND CREATE PACKING CODE
                try
                {
                    //Search item in stock with invoice number
                    if (stockItem.SearchItem(new pts_stock { item_cd = barcode[0], invoice = barcode[3] }))
                    {
                        double totalStockIn = (from x in stockItem.listStockItems where x.item_cd == barcode[0] select x.stockin_qty).Sum();
                        double totalPacking = (from x in stockItem.listStockItems where x.item_cd == barcode[0] select x.packing_qty).Sum();
                        //If this item is exist, notice user
                        string mess = "Item code: " + barcode[0] + " and Invoice: " + barcode[3] + "is exist!" + Environment.NewLine;
                        mess += "Total stock-in: " + totalStockIn + Environment.NewLine + "Total packing: " + totalPacking + Environment.NewLine;
                        mess += "Are you sure add new packing with this Invoice?";
                        if (CustomMessageBox.Question(mess) == DialogResult.No) return;
                        else
                        {
                            //Get max number packing of this Invoice in database
                            foreach (pts_stock item in stockItem.listStockItems)
                            {
                                if (!string.IsNullOrEmpty(item.invoice))
                                    temp = int.Parse(item.packing_cd.Substring(item.invoice.Length + 1));
                                else
                                    temp = int.Parse(item.packing_cd.Substring(5));
                                if (temp > n) n = temp;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Error(ex.Message);
                }
                //Create new number of packing with Invoice number
                foreach (pts_stock item in listStockItem)
                {
                    if (item.invoice == barcode[3])
                    {
                        if (!string.IsNullOrEmpty(item.invoice))
                            temp = int.Parse(item.packing_cd.Substring(item.invoice.Length + 1));
                        else
                            temp = int.Parse(item.packing_cd.Substring(5));
                        if (temp > n) n = temp;
                    }
                }
                n++;
                if (!string.IsNullOrEmpty(barcode[3].Trim())) invoice = barcode[3];
                string packingcd = invoice + "-" + n.ToString("00");
                #endregion

                //Add new barcode item into list stock item
                listStockItem.Add(new pts_stock
                {
                    item_cd = barcode[0],
                    supplier_cd = txtSupplierCD.Text,
                    invoice = barcode[3],
                    stockin_date = DateTime.Parse(barcode[4]),
                    stockin_qty = double.Parse(barcode[5]),
                    stockin_user_cd = UserData.usercode,
                    //order_no = orderno,
                    packing_cd = packingcd,
                    packing_qty = double.Parse(barcode[5]),
                    registration_user_cd = UserData.usercode,
                });
                if (remark != "P")
                {
                    listInputPremac.Add(new pre_649
                    {
                        item_number = barcode[0],
                        item_name = barcode[1],
                        supplier_cd = txtSupplierCD.Text,
                        supplier_name = txtSupplierName.Text,
                        supplier_invoice = barcode[3],
                        delivery_date = DateTime.Parse(barcode[4]),
                        delivery_qty = double.Parse(barcode[5]),
                        incharge = UserData.usercode,
                        //order_number = orderno,
                    });
                }
                UpdateInspectionGrid();
            }
            catch (IndexOutOfRangeException)
            {
                CustomMessageBox.Error("Wrong format barcode!" + Environment.NewLine + "Please check barcode and try again!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private List<pre_649> GroupByPremac()
        {
            List<pre_649> list = new List<pre_649>();
            list = (from item in listInputPremac
                    group item by new
                    {
                        item.item_number,
                        item.item_name,
                        item.supplier_cd,
                        item.supplier_name,
                        item.supplier_invoice,
                        item.delivery_date,
                        item.incharge
                    } into g
                    select new pre_649()
                    {
                        item_number = g.Key.item_number,
                        item_name = g.Key.item_name,
                        supplier_cd = g.Key.supplier_cd,
                        supplier_name = g.Key.supplier_name,
                        supplier_invoice = g.Key.supplier_invoice,
                        delivery_qty = g.Sum(a => a.delivery_qty),
                        delivery_date = g.Key.delivery_date,
                        incharge = g.Key.incharge
                    }).OrderBy(x => x.supplier_invoice).ToList();
            return list;
        }
        #endregion

        #endregion
    }
}
