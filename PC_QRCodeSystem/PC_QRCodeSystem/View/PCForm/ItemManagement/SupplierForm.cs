using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class SupplierForm : FormCommon
    {
        #region VARIABLE
        bool editMode { get; set; }
        Stopwatch stopWatch = new Stopwatch();
        private pts_supplier suppliercbm { get; set; }
        private pts_supplier ptssupllier { get; set; }
        private pts_supplier supplierData { get; set; }

        #endregion

        #region FORM EVENT
        public SupplierForm()
        {
            InitializeComponent();
            suppliercbm = new pts_supplier();
            ptssupllier = new pts_supplier();
            supplierData = new pts_supplier();
            editMode = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            pnlButtons.Visible = true;
            pnlSubButtons.Visible = false;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            Getcmbdata();
        }

        private void cmbSupplierCode_TextChanged(object sender, EventArgs e)
        {
            txtSupplierName.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            if (string.IsNullOrEmpty(cmbSupplierCode.Text))
            {
                txtFaxNumber.Text = "Fax Number";
                txtSupplierName.Text = "Supplier Name";
                txtSupplierTelephone.Text = "Telephone";
                txtSupplierAddress.Text = "Supplier Address";
                return;
            }
            try
            {
                ptssupllier = supplierData.GetSupplier(new pts_supplier
                {
                    supplier_id = 0,
                    supplier_cd = cmbSupplierCode.Text,
                });
                txtSupplierName.Text = ptssupllier.supplier_name;
                txtFaxNumber.Text = ptssupllier.supplier_fax;
                txtSupplierTelephone.Text = ptssupllier.supplier_tel;
                txtSupplierAddress.Text = ptssupllier.supplier_address;
                txtSupplierName.BackColor = Color.Lime;
            }
            catch
            {
                txtSupplierName.Clear();
                txtSupplierName.BackColor = Color.FromKnownColor(KnownColor.Yellow);
            }
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
            editMode = false;
            UnlockFields(true);
            txtFaxNumber.Clear();
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierTelephone.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            editMode = true;
            UnlockFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Warring("This action is not undo" + Environment.NewLine + "Are you sure delete this supplier?") == DialogResult.No)
                return;
            int n = 0;
            n = ptssupllier.Delete();
            ClearOK();
            Getcmbdata();
            UpdateGrid(true);
            CustomMessageBox.Notice("Delete " + n + " Supplier");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOK();
            UnlockFields(false);
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                string messstring = string.Empty;
                #region Add And Update Supplier
                {
                    if (editMode)
                    {  //CALL FUNTION UPDATE SUPPLIER
                        n = ptssupllier.UpdateSuplier(new pts_supplier
                        {
                            supplier_cd = cmbSupplierCode.Text,
                            supplier_name = txtSupplierName.Text,
                            supplier_tel = txtSupplierTelephone.Text,
                            supplier_fax = txtFaxNumber.Text,
                            supplier_address = txtSupplierAddress.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                    else
                    {  //CALL FUNCTION ADD NEW SUPPLIER
                        n = ptssupllier.AddSupplier(new pts_supplier
                        {
                            supplier_cd = cmbSupplierCode.Text,
                            supplier_name = txtSupplierName.Text,
                            supplier_tel = txtSupplierTelephone.Text,
                            supplier_fax = txtFaxNumber.Text,
                            supplier_address = txtSupplierAddress.Text,
                            registration_user_cd = UserData.usercode
                        });
                    }
                }
                #endregion
                ClearOK();
                Getcmbdata();
                UpdateGrid(true);
                cmbSupplierCode.Text = null;
                if (editMode) messstring = "Update ";
                else messstring = "Add ";
                CustomMessageBox.Notice(messstring + n + " Supplier Complete!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error(ex.Message);
            }
            UnlockFields(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearOK();
            UnlockFields(false);
        }
        #endregion

        #region SUB PROGRAM
        private void UpdateGrid(bool iSSearch)
        {
            if (iSSearch)
                ptssupllier.GetListSupplier(cmbSupplierCode.Text);
            dgvDataSupllier.DataSource = ptssupllier.listSupplier;
            dgvDataSupllier.Columns["supplier_id"].HeaderText = "Supplier ID";
            dgvDataSupllier.Columns["supplier_cd"].HeaderText = "Supplier Code";
            dgvDataSupllier.Columns["supplier_name"].HeaderText = "Supplier Name";
            dgvDataSupllier.Columns["supplier_tel"].HeaderText = "Telephone";
            dgvDataSupllier.Columns["supplier_fax"].HeaderText = "Fax";
            dgvDataSupllier.Columns["supplier_address"].HeaderText = "Address";
            dgvDataSupllier.Columns["registration_user_cd"].HeaderText = "Registration User";
            dgvDataSupllier.Columns["registration_date_time"].HeaderText = "Registration Date";
            if (dgvDataSupllier.Rows.Count > 0)
                tsSupplierTotal.Text = dgvDataSupllier.Rows.Count.ToString();
        }

        private void Getcmbdata()
        {
            suppliercbm.GetListSupplier(string.Empty);
            cmbSupplierCode.DataSource = suppliercbm.listSupplier;
            cmbSupplierCode.DisplayMember = "supplier_cd";
            cmbSupplierCode.ValueMember = "supplier_name";
            cmbSupplierCode.Text = null;
        }

        private void ClearOK()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbSupplierCode.Text = null;
            ptssupllier.listSupplier.Clear();
            dgvDataSupllier.DataSource = null;
            txtFaxNumber.Text = "Fax Number";
            txtSupplierName.Text = "Supplier Name";
            txtSupplierTelephone.Text = "Telephone";
            txtSupplierAddress.Text = "Supplier Address";
        }

        /// <summary>
        /// Unlock all fields of items
        /// </summary>
        /// <param name="edit">true: unlock, false: lock</param>
        private void UnlockFields(bool edit)
        {
            pnlButtons.Visible = !edit;
            pnlSubButtons.Visible = edit;
            txtFaxNumber.ReadOnly = !edit;
            txtSupplierName.ReadOnly = !edit;
            txtSupplierAddress.ReadOnly = !edit;
            txtSupplierTelephone.ReadOnly = !edit;
            if (edit) cmbSupplierCode.DropDownStyle = ComboBoxStyle.DropDown;
            else cmbSupplierCode.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region DATAGRIDVIEW
        private void dgvDataSupllier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ptssupllier = dgvDataSupllier.Rows[e.RowIndex].DataBoundItem as pts_supplier;
            txtSupplierAddress.Text = ptssupllier.supplier_address;
            txtSupplierTelephone.Text = ptssupllier.supplier_tel;
            txtSupplierName.Text = ptssupllier.supplier_name;
            cmbSupplierCode.Text = ptssupllier.supplier_cd;
            txtFaxNumber.Text = ptssupllier.supplier_fax;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion
    }
}
