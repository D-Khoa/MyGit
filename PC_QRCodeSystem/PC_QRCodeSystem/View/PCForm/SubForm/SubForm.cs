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
    public partial class SubForm : FormCommon
    {
        #region VARIABLE
        bool editMode { get; set; }
        pts_item unitCbm { get; set; }
        pts_item ptsItem { get; set; }
        pts_item_type typeCbm { get; set; }
        pts_item_type ptsItemType { get; set; }
        pts_item_location locationCbm { get; set; }
        pts_item_location ptsItemLocation { get; set; }
        #endregion

        public SubForm()
        {
            InitializeComponent();
            #region SETUP CONTROLS
            ptsItem = new pts_item();
            unitCbm = new pts_item();
            typeCbm = new pts_item_type();
            ptsItemType = new pts_item_type();
            locationCbm = new pts_item_location();
            ptsItemLocation = new pts_item_location();
            editMode = false;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lbUnitCode.Visible = true;
            cmbUnitCode.Visible = true;
            rbtnItemCode.Checked = true;
            #endregion
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            #region GET COMBOBOX DATA
            typeCbm.GetListItemType();
            cmbItemType.DataSource = typeCbm.listItemType;
            cmbItemType.DisplayMember = "type_id";
            cmbItemType.ValueMember = "type_name";
            cmbItemType.Text = null;
            locationCbm.GetListItemLocation(string.Empty);
            cmbItemLocation.DataSource = locationCbm.listItemLocation;
            cmbItemLocation.DisplayMember = "item_location_no";
            cmbItemLocation.ValueMember = "item_location_name";
            cmbItemLocation.Text = null;
            cmbUnitCode.DataSource = unitCbm.GetListUnit();
            cmbUnitCode.DisplayMember = "unit_cd";
            cmbUnitCode.Text = null;
            #endregion
        }

        #region GET NAME OF ITEMS
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //Get item name and show it
                    if (!string.IsNullOrEmpty(txtItem.Text))
                        txtItemName.Text = ptsItem.GetItem(txtItem.Text).item_name;
                    else
                        txtItemName.Text = "Item Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbItemLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Show name of item location
                if (!string.IsNullOrEmpty(cmbItemLocation.Text))
                    txtLocationName.Text = cmbItemLocation.SelectedValue.ToString();
                else
                    txtLocationName.Text = "Item Location Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QUERY ITEM
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
            if (rbtnItemCode.Checked)
            {

            }
            if (rbtnItemType.Checked)
            {

            }
            if (rbtnItemLocation.Checked)
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                if (rbtnItemCode.Checked)
                {
                    CapacityForm capfrm = new CapacityForm();
                    capfrm.capacityNumber = ptsItem.unit_qty;
                    if (capfrm.ShowDialog() == DialogResult.OK)
                    {
                        if (editMode)
                            ptsItem.Update(ptsItem);
                        else
                        {
                            //CALL FUNCTION ADD NEW ITEM
                            n = ptsItem.AddItem(new pts_item
                            {
                                item_cd = txtItem.Text,
                                item_name = txtItemName.Text,
                                type_id = int.Parse(cmbItemType.Text),
                                unit_cd = cmbUnitCode.Text,
                                unit_qty = capfrm.capacityNumber,
                                stock_qty = 0,
                                item_location_no = cmbItemLocation.Text,
                                registration_user_cd = UserData.usercode
                            });
                        }
                    }
                    else return;
                    unitCbm.GetListUnit();
                }
                if (rbtnItemType.Checked)
                {
                    //if (editMode)
                    //ptsItemType;
                    //CALL FUNCTION ADD NEW ITEM TYPE
                    n = ptsItemType.AddItemType(new pts_item_type
                    {
                        type_id = int.Parse(cmbItemType.Text),
                        type_name = txtTypeName.Text,
                        registration_user_cd = UserData.usercode
                    });
                    typeCbm.GetListItemType();
                }
                if (rbtnItemLocation.Checked)
                {
                    //CALL FUNCTION ADD NEW ITEM LOCATION
                    n = ptsItemLocation.AddItemLocation(new pts_item_location
                    {
                        item_location_no = cmbItemLocation.Text,
                        item_location_name = txtLocationName.Text,
                        registration_user_cd = UserData.usercode
                    });
                    locationCbm.GetListItemLocation(string.Empty);
                }
                MessageBox.Show("Add " + n + " item complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LockAllNameTextbox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockAllNameTextbox();
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search and get items list
            if (rbtnItemCode.Checked)
            {
                ptsItem.GetListItems(txtItem.Text, cmbUnitCode.Text, cmbItemLocation.Text, int.Parse(cmbItemType.Text));
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItem.listItems;
            }
            //Search and get item type list
            if (rbtnItemType.Checked)
            {
                ptsItemType.GetListItemType();
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItemType.listItemType;
            }
            //Search and get item locaion list
            if (rbtnItemLocation.Checked)
            {
                ptsItemLocation.GetListItemLocation(string.Empty);
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItemLocation.listItemLocation;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbUnitCode.Text = null;
            cmbItemType.Text = null;
            cmbItemLocation.Text = null;
            txtItem.Text = string.Empty;
            ptsItem.listItems.Clear();
            ptsItemType.listItemType.Clear();
            ptsItemLocation.listItemLocation.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region SELECT RADIO ITEM CHANGE
        private void rbtnItemCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnItemCode.Checked)
            {
                txtItem.Enabled = true;
                cmbItemType.Enabled = true;
                cmbItemLocation.Enabled = true;
                lbUnitCode.Visible = true;
                cmbUnitCode.Visible = true;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItem.listItems;
            }
            if (rbtnItemType.Checked)
            {
                txtItem.Enabled = false;
                cmbItemType.Enabled = true;
                cmbItemLocation.Enabled = false;
                lbUnitCode.Visible = false;
                cmbUnitCode.Visible = false;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItemType.listItemType;
            }
            if (rbtnItemLocation.Checked)
            {
                txtItem.Enabled = false;
                cmbItemType.Enabled = false;
                cmbItemLocation.Enabled = true;
                lbUnitCode.Visible = false;
                cmbUnitCode.Visible = false;
                dgvData.DataSource = null;
                dgvData.DataSource = ptsItemLocation.listItemLocation;
            }
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
                txtItemName.ReadOnly = false;
                txtTypeName.ReadOnly = true;
                txtLocationName.ReadOnly = true;
                if (!edit) txtItemName.Text = string.Empty;
                cmbUnitCode.DropDownStyle = ComboBoxStyle.DropDown;
            }
            if (rbtnItemType.Checked)
            {
                txtItemName.ReadOnly = true;
                txtTypeName.ReadOnly = false;
                txtLocationName.ReadOnly = true;
                if (!edit) txtTypeName.Text = string.Empty;
                cmbItemType.DropDownStyle = ComboBoxStyle.DropDown;
            }
            if (rbtnItemLocation.Checked)
            {
                txtItemName.ReadOnly = true;
                txtTypeName.ReadOnly = true;
                txtLocationName.ReadOnly = false;
                if (!edit) txtLocationName.Text = string.Empty;
                cmbItemLocation.DropDownStyle = ComboBoxStyle.DropDown;
            }
            btnOK.Visible = true;
            btnCancel.Visible = true;
            pnlButtons.Enabled = false;
        }

        /// <summary>
        /// Lock all name textbox
        /// </summary>
        private void LockAllNameTextbox()
        {
            btnOK.Visible = false;
            btnCancel.Visible = false;
            pnlButtons.Enabled = true;
            txtItemName.ReadOnly = true;
            txtTypeName.ReadOnly = true;
            txtLocationName.ReadOnly = true;
            cmbUnitCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemLocation.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get data from datagrid to pts item
            if (rbtnItemCode.Checked)
            {
                ptsItem = dgvData.Rows[e.RowIndex].DataBoundItem as pts_item;
                txtItem.Text = ptsItem.item_cd;
                txtItemName.Text = ptsItem.item_name;
                cmbUnitCode.Text = ptsItem.unit_cd;
                cmbItemType.Text = ptsItem.type_id.ToString();
                cmbItemLocation.Text = ptsItem.item_location_no;
            }
            //Get data from datagrid to pts item type
            if (rbtnItemType.Checked)
            {
                ptsItemType = dgvData.Rows[e.RowIndex].DataBoundItem as pts_item_type;
                cmbItemType.Text = ptsItemType.type_id.ToString();
            }
            //Get data from datagrid to pts item location
            if (rbtnItemLocation.Checked)
            {
                ptsItemLocation = dgvData.Rows[e.RowIndex].DataBoundItem as pts_item_location;
                cmbItemLocation.Text = ptsItemLocation.item_location_no;
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void SubForm_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
