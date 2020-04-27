namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2020
{
    partial class AssetManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbInfo = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.chkNotPaste = new Com.Nidec.Mes.Framework.CheckBoxCommon();
            this.chkCantPaste = new Com.Nidec.Mes.Framework.CheckBoxCommon();
            this.chkPasted = new Com.Nidec.Mes.Framework.CheckBoxCommon();
            this.cmbLife = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cmbAssetType = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon6 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dtpDateTo = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dtpDateFrom = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetCode = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetName = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.grbButtons = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.btnExport = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnExit = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnClear = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnDelete = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnUpdate = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAdd = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnSearch = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.dgvAssetGrid = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.grbInfo.SuspendLayout();
            this.grbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.ControlId = null;
            this.grbInfo.Controls.Add(this.chkNotPaste);
            this.grbInfo.Controls.Add(this.chkCantPaste);
            this.grbInfo.Controls.Add(this.chkPasted);
            this.grbInfo.Controls.Add(this.cmbLife);
            this.grbInfo.Controls.Add(this.cmbAssetType);
            this.grbInfo.Controls.Add(this.labelCommon6);
            this.grbInfo.Controls.Add(this.dtpDateTo);
            this.grbInfo.Controls.Add(this.labelCommon5);
            this.grbInfo.Controls.Add(this.dtpDateFrom);
            this.grbInfo.Controls.Add(this.labelCommon4);
            this.grbInfo.Controls.Add(this.labelCommon3);
            this.grbInfo.Controls.Add(this.txtAssetCode);
            this.grbInfo.Controls.Add(this.labelCommon2);
            this.grbInfo.Controls.Add(this.labelCommon1);
            this.grbInfo.Controls.Add(this.txtAssetName);
            this.grbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(0, 107);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(822, 100);
            this.grbInfo.TabIndex = 11;
            this.grbInfo.TabStop = false;
            // 
            // chkNotPaste
            // 
            this.chkNotPaste.AutoSize = true;
            this.chkNotPaste.BackColor = System.Drawing.Color.Yellow;
            this.chkNotPaste.ControlId = null;
            this.chkNotPaste.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotPaste.Location = new System.Drawing.Point(708, 41);
            this.chkNotPaste.Name = "chkNotPaste";
            this.chkNotPaste.Size = new System.Drawing.Size(80, 19);
            this.chkNotPaste.TabIndex = 18;
            this.chkNotPaste.Text = "Not Paste";
            this.chkNotPaste.UseVisualStyleBackColor = false;
            // 
            // chkCantPaste
            // 
            this.chkCantPaste.AutoSize = true;
            this.chkCantPaste.BackColor = System.Drawing.Color.Red;
            this.chkCantPaste.ControlId = null;
            this.chkCantPaste.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCantPaste.Location = new System.Drawing.Point(708, 66);
            this.chkCantPaste.Name = "chkCantPaste";
            this.chkCantPaste.Size = new System.Drawing.Size(87, 19);
            this.chkCantPaste.TabIndex = 19;
            this.chkCantPaste.Text = "Cant Paste";
            this.chkCantPaste.UseVisualStyleBackColor = false;
            // 
            // chkPasted
            // 
            this.chkPasted.AutoSize = true;
            this.chkPasted.BackColor = System.Drawing.Color.Lime;
            this.chkPasted.ControlId = null;
            this.chkPasted.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPasted.Location = new System.Drawing.Point(708, 16);
            this.chkPasted.Name = "chkPasted";
            this.chkPasted.Size = new System.Drawing.Size(65, 19);
            this.chkPasted.TabIndex = 17;
            this.chkPasted.Text = "Pasted";
            this.chkPasted.UseVisualStyleBackColor = false;
            // 
            // cmbLife
            // 
            this.cmbLife.ControlId = null;
            this.cmbLife.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLife.FormattingEnabled = true;
            this.cmbLife.Location = new System.Drawing.Point(361, 60);
            this.cmbLife.Name = "cmbLife";
            this.cmbLife.Size = new System.Drawing.Size(130, 23);
            this.cmbLife.TabIndex = 14;
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.ControlId = null;
            this.cmbAssetType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(361, 14);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(130, 23);
            this.cmbAssetType.TabIndex = 13;
            // 
            // labelCommon6
            // 
            this.labelCommon6.AutoSize = true;
            this.labelCommon6.ControlId = null;
            this.labelCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon6.Location = new System.Drawing.Point(523, 63);
            this.labelCommon6.Name = "labelCommon6";
            this.labelCommon6.Size = new System.Drawing.Size(49, 15);
            this.labelCommon6.TabIndex = 11;
            this.labelCommon6.Text = "Date To";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDateTo.ControlId = null;
            this.dtpDateTo.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.dtpDateTo.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(578, 58);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(124, 21);
            this.dtpDateTo.TabIndex = 16;
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon5.Location = new System.Drawing.Point(507, 17);
            this.labelCommon5.Name = "labelCommon5";
            this.labelCommon5.Size = new System.Drawing.Size(65, 15);
            this.labelCommon5.TabIndex = 9;
            this.labelCommon5.Text = "Date From";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDateFrom.ControlId = null;
            this.dtpDateFrom.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.dtpDateFrom.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(578, 14);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(124, 21);
            this.dtpDateFrom.TabIndex = 15;
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon4.Location = new System.Drawing.Point(328, 63);
            this.labelCommon4.Name = "labelCommon4";
            this.labelCommon4.Size = new System.Drawing.Size(27, 15);
            this.labelCommon4.TabIndex = 7;
            this.labelCommon4.Text = "Life";
            // 
            // labelCommon3
            // 
            this.labelCommon3.AutoSize = true;
            this.labelCommon3.ControlId = null;
            this.labelCommon3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon3.Location = new System.Drawing.Point(289, 19);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(66, 15);
            this.labelCommon3.TabIndex = 5;
            this.labelCommon3.Text = "Asset Type";
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.ControlId = null;
            this.txtAssetCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetCode.Location = new System.Drawing.Point(87, 16);
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.Size = new System.Drawing.Size(187, 21);
            this.txtAssetCode.TabIndex = 11;
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon2.Location = new System.Drawing.Point(6, 63);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(75, 15);
            this.labelCommon2.TabIndex = 3;
            this.labelCommon2.Text = "Asset Name";
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(10, 19);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(71, 15);
            this.labelCommon1.TabIndex = 1;
            this.labelCommon1.Text = "Asset Code";
            // 
            // txtAssetName
            // 
            this.txtAssetName.ControlId = null;
            this.txtAssetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetName.Location = new System.Drawing.Point(87, 60);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(187, 21);
            this.txtAssetName.TabIndex = 12;
            // 
            // grbButtons
            // 
            this.grbButtons.ControlId = null;
            this.grbButtons.Controls.Add(this.btnExport);
            this.grbButtons.Controls.Add(this.btnExit);
            this.grbButtons.Controls.Add(this.btnClear);
            this.grbButtons.Controls.Add(this.btnDelete);
            this.grbButtons.Controls.Add(this.btnUpdate);
            this.grbButtons.Controls.Add(this.btnAdd);
            this.grbButtons.Controls.Add(this.btnSearch);
            this.grbButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbButtons.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbButtons.Location = new System.Drawing.Point(0, 207);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(822, 59);
            this.grbButtons.TabIndex = 21;
            this.grbButtons.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.ControlId = null;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExport.Location = new System.Drawing.Point(352, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 33);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ControlId = null;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExit.Location = new System.Drawing.Point(691, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 33);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ControlId = null;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClear.Location = new System.Drawing.Point(465, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ControlId = null;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDelete.Location = new System.Drawing.Point(578, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ControlId = null;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(239, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ControlId = null;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAdd.Location = new System.Drawing.Point(126, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 33);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ControlId = null;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSearch.Location = new System.Drawing.Point(10, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 40);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvAssetGrid
            // 
            this.dgvAssetGrid.AllowUserToAddRows = false;
            this.dgvAssetGrid.AllowUserToDeleteRows = false;
            this.dgvAssetGrid.AllowUserToOrderColumns = true;
            this.dgvAssetGrid.AllowUserToResizeRows = false;
            this.dgvAssetGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssetGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetGrid.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssetGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssetGrid.EnableHeadersVisualStyles = false;
            this.dgvAssetGrid.Location = new System.Drawing.Point(0, 266);
            this.dgvAssetGrid.MultiSelect = false;
            this.dgvAssetGrid.Name = "dgvAssetGrid";
            this.dgvAssetGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssetGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssetGrid.RowHeadersVisible = false;
            this.dgvAssetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssetGrid.Size = new System.Drawing.Size(822, 219);
            this.dgvAssetGrid.TabIndex = 29;
            // 
            // AssetManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.dgvAssetGrid);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbInfo);
            this.Name = "AssetManagementForm";
            this.Text = "Asset Management";
            this.TitleText = "FormCommon";
            this.Controls.SetChildIndex(this.grbInfo, 0);
            this.Controls.SetChildIndex(this.grbButtons, 0);
            this.Controls.SetChildIndex(this.dgvAssetGrid, 0);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.GroupBoxCommon grbInfo;
        private Framework.CheckBoxCommon chkNotPaste;
        private Framework.CheckBoxCommon chkCantPaste;
        private Framework.CheckBoxCommon chkPasted;
        private Framework.ComboBoxCommon cmbLife;
        private Framework.ComboBoxCommon cmbAssetType;
        private Framework.LabelCommon labelCommon6;
        private Framework.DateTimePickerCommon dtpDateTo;
        private Framework.LabelCommon labelCommon5;
        private Framework.DateTimePickerCommon dtpDateFrom;
        private Framework.LabelCommon labelCommon4;
        private Framework.LabelCommon labelCommon3;
        private Framework.TextBoxCommon txtAssetCode;
        private Framework.LabelCommon labelCommon2;
        private Framework.LabelCommon labelCommon1;
        private Framework.TextBoxCommon txtAssetName;
        private Framework.GroupBoxCommon grbButtons;
        private Framework.ButtonCommon btnExport;
        private Framework.ButtonCommon btnExit;
        private Framework.ButtonCommon btnClear;
        private Framework.ButtonCommon btnDelete;
        private Framework.ButtonCommon btnUpdate;
        private Framework.ButtonCommon btnAdd;
        private Framework.ButtonCommon btnSearch;
        internal Framework.DataGridViewCommon dgvAssetGrid;
    }
}