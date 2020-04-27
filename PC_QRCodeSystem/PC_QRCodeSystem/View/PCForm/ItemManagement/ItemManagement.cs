using System;
using System.Diagnostics;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class ItemManagement : FormCommon
    {
        #region VARIABLE
        bool editMode { get; set; }
        pts_item unitCbm { get; set; }
        pts_item ptsItem { get; set; }
        pts_item locationCbm { get; set; }
        pts_item_type typeCbm { get; set; }
        pts_item_type ptsItemType { get; set; }
        Stopwatch stopWatch = new Stopwatch();
        ErrorProvider errorProvider = new ErrorProvider();

        #endregion

        #region FORM EVENT
        public ItemManagement()
        {
            InitializeComponent();
            #region SETUP CONTROLS
            ptsItem = new pts_item();
            unitCbm = new pts_item();
            locationCbm = new pts_item();
            typeCbm = new pts_item_type();
            ptsItemType = new pts_item_type();
            editMode = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            rbtnItemCode.Checked = true;
            pnlSubButton.Visible = false;
            #endregion
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            GetCmbData();
            txtItem.Focus();
        }
        #endregion

        #region FIELDS EVENT
        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text))
            {
                errorProvider.SetError(txtItem, null);
                txtItemName.Text = "Item Name";
                return;
            }
            try
            {
                ptsItem = ptsItem.GetItem(txtItem.Text);
                errorProvider.SetError(txtItem, null);
                txtItemName.Text = ptsItem.item_name;
                UpdateGrid(ptsItem);
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtItem, "Wrond item code!" + Environment.NewLine + ex.Message);
            }
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtItem.Text))
                {
                    errorProvider.SetError(txtItem, null);
                    txtItemName.Text = "Item Name";
                    return;
                }
                try
                {
                    ptsItem = ptsItem.GetItem(txtItem.Text);
                    errorProvider.SetError(txtItem, null);
                    txtItemName.Text = ptsItem.item_name;
                    cmbLocation.Text = ptsItem.item_location;
                    cmbUnitCode.Text = ptsItem.item_unit;
                    cmbItemType.Text = ptsItem.type_id.ToString();
                    UpdateGrid(ptsItem);
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txtItem, "Wrond item code!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Show name of item type
                if (!string.IsNullOrEmpty(cmbItemType.Text))
                    txtTypeName.Text = cmbItemType.SelectedValue.ToString();
                else
                    txtTypeName.Text = "Item Type Name";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtStockOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        #endregion

        #region MAIN BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                stopWatch.Restart();
                UpdateGrid(true);
                stopWatch.Stop();
                tsTime.Text = stopWatch.Elapsed.ToString("s\\.ff") + " s";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnlockFields(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnlockFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Warring("This action is not undo" + Environment.NewLine + "Are you sure delete this item?") == DialogResult.No)
                    return;
                int n = 0;
                if (rbtnItemCode.Checked)
                {
                    n = ptsItem.Delete(ptsItem.item_id);
                }
                if (rbtnItemType.Checked)
                {
                    n = ptsItemType.Delete(ptsItemType.type_id);
                }
                ClearFields();
                GetCmbData();
                UpdateGrid(true);
                CustomMessageBox.Notice("Delete " + n + " Item");
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

        #region QUERY BUTTON
        /// <summary>
        /// Get data fro combobox
        /// </summary>
        private void GetCmbData()
        {
            typeCbm.GetListItemType();
            cmbItemType.DataSource = typeCbm.listItemType;
            cmbItemType.DisplayMember = "type_id";
            cmbItemType.ValueMember = "type_name";
            cmbItemType.Text = null;
            unitCbm.GetListUnit();
            cmbUnitCode.DataSource = unitCbm.listItems;
            cmbUnitCode.DisplayMember = "item_unit";
            cmbUnitCode.Text = null;
            locationCbm.GetListLocation();
            cmbLocation.DataSource = locationCbm.listItems;
            cmbLocation.DisplayMember = "item_location";
            cmbLocation.Text = null;
        }

        /// <summary>
        /// Search and update grid
        /// </summary>
        private void UpdateGrid(bool isSearch)
        {
            try
            {
                dgvData.DataSource = null;
                //Search and get items list
                if (rbtnItemCode.Checked)
                {
                    if (isSearch)
                    {
                        ptsItem.listItems.Clear();
                        //Search with item type
                        if (!string.IsNullOrEmpty(cmbItemType.Text))
                            ptsItem.SearchItem(new pts_item
                            {
                                item_cd = txtItem.Text,
                                item_unit = cmbUnitCode.Text,
                                item_location = cmbLocation.Text,
                                type_id = int.Parse(cmbItemType.Text)
                            }, true);
                        else
                            //Search without item type
                            ptsItem.SearchItem(new pts_item
                            {
                                item_cd = txtItem.Text,
                                item_unit = cmbUnitCode.Text,
                                item_location = cmbLocation.Text,
                            }, false);
                    }
                    dgvData.DataSource = ptsItem.listItems;
                    dgvData.Columns["item_id"].HeaderText = "Item ID";
                    dgvData.Columns["type_id"].HeaderText = "Type ID";
                    dgvData.Columns["item_cd"].HeaderText = "Item Number";
                    dgvData.Columns["item_name"].HeaderText = "Item Name";
                    dgvData.Columns["item_location"].HeaderText = "Item Location";
                    dgvData.Columns["item_unit"].HeaderText = "Unit";
                    dgvData.Columns["lot_size"].HeaderText = "Lot Size";
                    dgvData.Columns["wh_qty"].HeaderText = "WH Qty";
                    dgvData.Columns["wip_qty"].HeaderText = "W.I.P Qty";
                    dgvData.Columns["repair_qty"].HeaderText = "Repair Qty";
                    dgvData.Columns["registration_user_cd"].HeaderText = "Registration User";
                    dgvData.Columns["registration_date_time"].HeaderText = "Registration Date";
                    if (dgvData.SelectedCells.Count > 0)
                        UpdateGrid(dgvData.Rows[0].DataBoundItem as pts_item);
                }
                //Search and get item type list
                if (rbtnItemType.Checked)
                {
                    if (isSearch)
                    {
                        ptsItemType.listItemType.Clear();
                        if (string.IsNullOrEmpty(cmbItemType.Text))
                            ptsItemType.GetListItemType();
                        else
                            ptsItemType.listItemType.Add(ptsItemType.GetItemType(int.Parse(cmbItemType.Text)));
                    }
                    dgvData.DataSource = ptsItemType.listItemType;
                    dgvData.Columns["type_id"].HeaderText = "Type ID";
                    dgvData.Columns["type_name"].HeaderText = "Type Name";
                    dgvData.Columns["registration_user_cd"].HeaderText = "Registration User";
                    dgvData.Columns["registration_date_time"].HeaderText = "Registration Date";
                }
                isSearch = false;
                if (dgvData.Rows.Count > 0)
                    tsNumberTotal.Text = dgvData.Rows.Count.ToString();
                dgvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
        }

        private void UpdateGrid(pts_item inItem)
        {
            dgvItemQty.Rows[0].Cells["lot_size"].Value = inItem.lot_size;
            dgvItemQty.Rows[0].Cells["wh_qty"].Value = inItem.wh_qty;
            dgvItemQty.Rows[0].Cells["wip_qty"].Value = inItem.wip_qty;
            dgvItemQty.Rows[0].Cells["repair_qty"].Value = inItem.repair_qty;
        }

        /// <summary>
        /// Clear all fields
        /// </summary>
        private void ClearFields()
        {
            txtItem.Clear();
            cmbLocation.Text = null;
            cmbUnitCode.Text = null;
            cmbItemType.Text = null;
            txtItemName.Text = "Item Name";
            dgvItemQty.Rows.Clear();
            dgvData.DataSource = null;
            ptsItem.listItems.Clear();
            ptsItemType.listItemType.Clear();
        }

        /// <summary>
        /// Unlock all fields of items
        /// </summary>
        /// <param name="edit">false: add item, true: update item</param>
        private void UnlockFields(bool edit)
        {
            editMode = edit;
            if (rbtnItemCode.Checked)
            {
                txtTypeName.ReadOnly = true;
                txtItemName.ReadOnly = false;
                dgvItemQty.ReadOnly = false;
                if (!edit)
                {
                    txtTypeName.Clear();
                    txtItemName.Clear();
                }
                cmbLocation.DropDownStyle = ComboBoxStyle.DropDown;
                cmbUnitCode.DropDownStyle = ComboBoxStyle.DropDown;
            }
            if (rbtnItemType.Checked)
            {
                txtItemName.ReadOnly = true;
                txtTypeName.ReadOnly = false;
                if (!edit) txtTypeName.Clear();
                cmbItemType.DropDownStyle = ComboBoxStyle.DropDown;
            }
            pnlButtons.Visible = false;
            pnlSubButton.Visible = true;
        }

        /// <summary>
        /// Lock all name textbox
        /// </summary>
        private void LockFields()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            pnlButtons.Visible = true;
            pnlSubButton.Visible = false;
            txtItemName.ReadOnly = true;
            txtTypeName.ReadOnly = true;
            dgvItemQty.ReadOnly = true;
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                string messstring = string.Empty;
                if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtTypeName.Text))
                {
                    CustomMessageBox.Notice("Item Name and Item Type is empty." + Environment.NewLine + "Please check and try again!");
                    return;
                }
                #region ADD & UPDATE ITEM
                if (rbtnItemCode.Checked)
                {
                    //Edit mode for update item
                    if (editMode)
                    {
                        n = ptsItem.Update(new pts_item
                        {
                            item_id = ptsItem.item_id,
                            item_cd = txtItem.Text,
                            item_name = txtItemName.Text,
                            type_id = int.Parse(cmbItemType.Text),
                            item_unit = cmbUnitCode.Text,
                            lot_size = double.Parse(dgvItemQty.Rows[0].Cells["lot_size"].Value.ToString()),
                            wh_qty = double.Parse(dgvItemQty.Rows[0].Cells["wh_qty"].Value.ToString()),
                            wip_qty = double.Parse(dgvItemQty.Rows[0].Cells["wip_qty"].Value.ToString()),
                            repair_qty = double.Parse(dgvItemQty.Rows[0].Cells["repair_qty"].Value.ToString()),
                            item_location = cmbLocation.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {
                        //CALL FUNCTION ADD NEW ITEM
                        n = ptsItem.AddItem(new pts_item
                        {
                            item_cd = txtItem.Text,
                            item_name = txtItemName.Text,
                            type_id = int.Parse(cmbItemType.Text),
                            item_location = cmbLocation.Text,
                            item_unit = cmbUnitCode.Text,
                            lot_size = double.Parse(dgvItemQty.Rows[0].Cells["lot_size"].Value.ToString()),
                            registration_user_cd = UserData.usercode
                        });
                    }
                    //unitCbm.GetListUnit();
                }
                #endregion

                #region ADD & UPDATE ITEM TYPE
                if (rbtnItemType.Checked)
                {
                    //Edit mode for update item
                    if (editMode)
                    {
                        n = ptsItemType.Update(new pts_item_type
                        {
                            type_id = int.Parse(cmbItemType.Text),
                            type_name = txtTypeName.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {
                        //CALL FUNCTION ADD NEW ITEM TYPE
                        n = ptsItemType.AddItemType(new pts_item_type
                        {
                            type_id = int.Parse(cmbItemType.Text),
                            type_name = txtTypeName.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    typeCbm.GetListItemType();
                }
                #endregion

                ClearFields();
                GetCmbData();
                UpdateGrid(true);
                if (editMode) messstring = "Update ";
                else messstring = "Add ";
                CustomMessageBox.Notice(messstring + n + " item complete!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            LockFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockFields();
        }
        #endregion

        #region SUB EVENT
        private void rbtnItemCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnItemCode.Checked)
            {
                txtItem.Enabled = true;
                lbUnitCode.Visible = true;
                lbLocation.Visible = true;
                cmbUnitCode.Visible = true;
                cmbLocation.Visible = true;
                dgvItemQty.Visible = true;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItem.listItems;
                txtItemName.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ActiveCaption);
                rbtnItemCode.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ActiveCaption);
                txtTypeName.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
                rbtnItemType.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
            }
            if (rbtnItemType.Checked)
            {
                lbUnitCode.Visible = false;
                lbLocation.Visible = false;
                txtItem.Enabled = false;
                cmbUnitCode.Visible = false;
                cmbLocation.Visible = false;
                dgvItemQty.Visible = false;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItemType.listItemType;
                txtTypeName.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ActiveCaption);
                rbtnItemType.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ActiveCaption);
                txtItemName.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
                rbtnItemCode.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
            }
            UpdateGrid(false);
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Get data from datagrid to pts item
                if (rbtnItemCode.Checked)
                {
                    ptsItem = dgvData.Rows[e.RowIndex].DataBoundItem as pts_item;
                    txtItem.Text = ptsItem.item_cd;
                    txtItemName.Text = ptsItem.item_name;
                    cmbLocation.Text = ptsItem.item_location;
                    cmbUnitCode.Text = ptsItem.item_unit;
                    cmbItemType.Text = ptsItem.type_id.ToString();
                    UpdateGrid(dgvData.Rows[e.RowIndex].DataBoundItem as pts_item);
                }
                //Get data from datagrid to pts item type
                if (rbtnItemType.Checked)
                {
                    ptsItemType = dgvData.Rows[e.RowIndex].DataBoundItem as pts_item_type;
                    cmbItemType.Text = ptsItemType.type_id.ToString();
                }
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnItemCode.Checked)
                {
                    if (dgvData.SelectedCells.Count > 0)
                        UpdateGrid(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].DataBoundItem as pts_item);
                }
            }
            catch { }
            LockFields();
        }

        private void SubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnOK.Visible)
            {
                if (CustomMessageBox.Question("You are in processing!" + Environment.NewLine + "Are you sure exit?") == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        #endregion
    }
}
