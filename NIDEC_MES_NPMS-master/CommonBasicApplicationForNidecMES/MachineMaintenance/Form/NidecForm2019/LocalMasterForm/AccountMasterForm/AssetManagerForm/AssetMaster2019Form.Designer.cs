namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    partial class AssetMaster2019Form
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
            this.grButtons = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.btnExport = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnExit = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnClear = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnDelete = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnUpdate = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAdd = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnSearch = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.txtAssetCode = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetName = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.groupBoxCommon1 = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.cmbLife = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cmbAssetType = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon6 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dtpDateTo = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dtpDateFrom = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNumberOfRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvAssetGrid = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.grButtons.SuspendLayout();
            this.groupBoxCommon1.SuspendLayout();
            this.sStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grButtons
            // 
            this.grButtons.ControlId = null;
            this.grButtons.Controls.Add(this.btnExport);
            this.grButtons.Controls.Add(this.btnExit);
            this.grButtons.Controls.Add(this.btnClear);
            this.grButtons.Controls.Add(this.btnDelete);
            this.grButtons.Controls.Add(this.btnUpdate);
            this.grButtons.Controls.Add(this.btnAdd);
            this.grButtons.Controls.Add(this.btnSearch);
            this.grButtons.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grButtons.Location = new System.Drawing.Point(12, 200);
            this.grButtons.Name = "grButtons";
            this.grButtons.Size = new System.Drawing.Size(701, 62);
            this.grButtons.TabIndex = 2;
            this.grButtons.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.ControlId = null;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExport.Location = new System.Drawing.Point(303, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 33);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ControlId = null;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExit.Location = new System.Drawing.Point(600, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ControlId = null;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClear.Location = new System.Drawing.Point(402, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ControlId = null;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDelete.Location = new System.Drawing.Point(501, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ControlId = null;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(204, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ControlId = null;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAdd.Location = new System.Drawing.Point(105, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ControlId = null;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSearch.Location = new System.Drawing.Point(6, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.ControlId = null;
            this.txtAssetCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetCode.Location = new System.Drawing.Point(87, 18);
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.Size = new System.Drawing.Size(187, 21);
            this.txtAssetCode.TabIndex = 0;
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(10, 23);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(71, 15);
            this.labelCommon1.TabIndex = 1;
            this.labelCommon1.Text = "Asset Code";
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon2.Location = new System.Drawing.Point(6, 50);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(75, 15);
            this.labelCommon2.TabIndex = 3;
            this.labelCommon2.Text = "Asset Name";
            // 
            // txtAssetName
            // 
            this.txtAssetName.ControlId = null;
            this.txtAssetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetName.Location = new System.Drawing.Point(87, 45);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(187, 21);
            this.txtAssetName.TabIndex = 2;
            // 
            // groupBoxCommon1
            // 
            this.groupBoxCommon1.ControlId = null;
            this.groupBoxCommon1.Controls.Add(this.cmbLife);
            this.groupBoxCommon1.Controls.Add(this.cmbAssetType);
            this.groupBoxCommon1.Controls.Add(this.labelCommon6);
            this.groupBoxCommon1.Controls.Add(this.dtpDateTo);
            this.groupBoxCommon1.Controls.Add(this.labelCommon5);
            this.groupBoxCommon1.Controls.Add(this.dtpDateFrom);
            this.groupBoxCommon1.Controls.Add(this.labelCommon4);
            this.groupBoxCommon1.Controls.Add(this.labelCommon3);
            this.groupBoxCommon1.Controls.Add(this.txtAssetCode);
            this.groupBoxCommon1.Controls.Add(this.labelCommon2);
            this.groupBoxCommon1.Controls.Add(this.labelCommon1);
            this.groupBoxCommon1.Controls.Add(this.txtAssetName);
            this.groupBoxCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCommon1.Location = new System.Drawing.Point(12, 113);
            this.groupBoxCommon1.Name = "groupBoxCommon1";
            this.groupBoxCommon1.Size = new System.Drawing.Size(701, 81);
            this.groupBoxCommon1.TabIndex = 3;
            this.groupBoxCommon1.TabStop = false;
            // 
            // cmbLife
            // 
            this.cmbLife.ControlId = null;
            this.cmbLife.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLife.FormattingEnabled = true;
            this.cmbLife.Location = new System.Drawing.Point(357, 45);
            this.cmbLife.Name = "cmbLife";
            this.cmbLife.Size = new System.Drawing.Size(130, 23);
            this.cmbLife.TabIndex = 13;
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.ControlId = null;
            this.cmbAssetType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(357, 18);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(130, 23);
            this.cmbAssetType.TabIndex = 12;
            // 
            // labelCommon6
            // 
            this.labelCommon6.AutoSize = true;
            this.labelCommon6.ControlId = null;
            this.labelCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon6.Location = new System.Drawing.Point(509, 52);
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
            this.dtpDateTo.Location = new System.Drawing.Point(564, 47);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(124, 21);
            this.dtpDateTo.TabIndex = 10;
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon5.Location = new System.Drawing.Point(493, 25);
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
            this.dtpDateFrom.Location = new System.Drawing.Point(564, 20);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(124, 21);
            this.dtpDateFrom.TabIndex = 8;
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon4.Location = new System.Drawing.Point(324, 50);
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
            this.labelCommon3.Location = new System.Drawing.Point(285, 22);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(66, 15);
            this.labelCommon3.TabIndex = 5;
            this.labelCommon3.Text = "Asset Type";
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpacer,
            this.tsNumberOfRow});
            this.sStrip.Location = new System.Drawing.Point(0, 456);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(720, 22);
            this.sStrip.TabIndex = 5;
            this.sStrip.Text = "statusStrip1";
            // 
            // tsSpacer
            // 
            this.tsSpacer.Name = "tsSpacer";
            this.tsSpacer.Size = new System.Drawing.Size(669, 17);
            this.tsSpacer.Spring = true;
            // 
            // tsNumberOfRow
            // 
            this.tsNumberOfRow.Name = "tsNumberOfRow";
            this.tsNumberOfRow.Size = new System.Drawing.Size(36, 17);
            this.tsNumberOfRow.Text = "None";
            // 
            // dgvAssetGrid
            // 
            this.dgvAssetGrid.AllowUserToAddRows = false;
            this.dgvAssetGrid.AllowUserToDeleteRows = false;
            this.dgvAssetGrid.AllowUserToOrderColumns = true;
            this.dgvAssetGrid.AllowUserToResizeRows = false;
            this.dgvAssetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvAssetGrid.EnableHeadersVisualStyles = false;
            this.dgvAssetGrid.Location = new System.Drawing.Point(12, 268);
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
            this.dgvAssetGrid.Size = new System.Drawing.Size(701, 185);
            this.dgvAssetGrid.TabIndex = 6;
            this.dgvAssetGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetGrid_CellClick);
            this.dgvAssetGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetGrid_CellDoubleClick);
            // 
            // AssetMaster2019Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 478);
            this.Controls.Add(this.dgvAssetGrid);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.groupBoxCommon1);
            this.Controls.Add(this.grButtons);
            this.Name = "AssetMaster2019Form";
            this.Text = "Asset Manager 2019";
            this.TitleText = "Asset Manager";
            this.Load += new System.EventHandler(this.AssetMaster2019Form_Load);
            this.Controls.SetChildIndex(this.grButtons, 0);
            this.Controls.SetChildIndex(this.groupBoxCommon1, 0);
            this.Controls.SetChildIndex(this.sStrip, 0);
            this.Controls.SetChildIndex(this.dgvAssetGrid, 0);
            this.grButtons.ResumeLayout(false);
            this.groupBoxCommon1.ResumeLayout(false);
            this.groupBoxCommon1.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.GroupBoxCommon grButtons;
        private Framework.ButtonCommon btnExport;
        private Framework.ButtonCommon btnExit;
        private Framework.ButtonCommon btnClear;
        private Framework.ButtonCommon btnDelete;
        private Framework.ButtonCommon btnUpdate;
        private Framework.ButtonCommon btnAdd;
        private Framework.ButtonCommon btnSearch;
        private Framework.TextBoxCommon txtAssetCode;
        private Framework.LabelCommon labelCommon1;
        private Framework.LabelCommon labelCommon2;
        private Framework.TextBoxCommon txtAssetName;
        private Framework.GroupBoxCommon groupBoxCommon1;
        private Framework.LabelCommon labelCommon6;
        private Framework.DateTimePickerCommon dtpDateTo;
        private Framework.LabelCommon labelCommon5;
        private Framework.DateTimePickerCommon dtpDateFrom;
        private Framework.LabelCommon labelCommon4;
        private Framework.LabelCommon labelCommon3;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsSpacer;
        private System.Windows.Forms.ToolStripStatusLabel tsNumberOfRow;
        private Framework.ComboBoxCommon cmbLife;
        private Framework.ComboBoxCommon cmbAssetType;
        internal Framework.DataGridViewCommon dgvAssetGrid;
    }
}