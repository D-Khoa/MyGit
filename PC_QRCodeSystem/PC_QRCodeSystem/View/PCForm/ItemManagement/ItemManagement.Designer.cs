namespace PC_QRCodeSystem.View
{
    partial class ItemManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNumberTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItemQty = new System.Windows.Forms.DataGridView();
            this.lot_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wip_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repair_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbUnitCode = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cmbUnitCode = new System.Windows.Forms.ComboBox();
            this.rbtnItemType = new System.Windows.Forms.RadioButton();
            this.rbtnItemCode = new System.Windows.Forms.RadioButton();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSubButton = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemQty)).BeginInit();
            this.pnlSubButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime,
            this.toolStripStatusLabel2,
            this.tsNumberTotal});
            this.statusStrip1.Location = new System.Drawing.Point(150, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(542, 19);
            this.tsTime.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel2.Text = "Total :";
            // 
            // tsNumberTotal
            // 
            this.tsNumberTotal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsNumberTotal.Name = "tsNumberTotal";
            this.tsNumberTotal.Size = new System.Drawing.Size(40, 19);
            this.tsNumberTotal.Text = "None";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(150, 310);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(641, 130);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(150, 260);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(641, 50);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(40, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(260, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(370, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(150, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(480, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvItemQty);
            this.panel4.Controls.Add(this.cmbLocation);
            this.panel4.Controls.Add(this.lbLocation);
            this.panel4.Controls.Add(this.lbUnitCode);
            this.panel4.Controls.Add(this.txtTypeName);
            this.panel4.Controls.Add(this.txtItemName);
            this.panel4.Controls.Add(this.cmbUnitCode);
            this.panel4.Controls.Add(this.rbtnItemType);
            this.panel4.Controls.Add(this.rbtnItemCode);
            this.panel4.Controls.Add(this.cmbItemType);
            this.panel4.Controls.Add(this.txtItem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(150, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 140);
            this.panel4.TabIndex = 1;
            // 
            // dgvItemQty
            // 
            this.dgvItemQty.AllowUserToDeleteRows = false;
            this.dgvItemQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemQty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lot_size,
            this.wh_qty,
            this.wip_qty,
            this.repair_qty});
            this.dgvItemQty.Location = new System.Drawing.Point(280, 70);
            this.dgvItemQty.Name = "dgvItemQty";
            this.dgvItemQty.Size = new System.Drawing.Size(350, 70);
            this.dgvItemQty.TabIndex = 11;
            // 
            // lot_size
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.lot_size.DefaultCellStyle = dataGridViewCellStyle5;
            this.lot_size.HeaderText = "Lot Size";
            this.lot_size.Name = "lot_size";
            this.lot_size.Width = 70;
            // 
            // wh_qty
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.wh_qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.wh_qty.HeaderText = "WH Qty";
            this.wh_qty.Name = "wh_qty";
            this.wh_qty.Width = 70;
            // 
            // wip_qty
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.wip_qty.DefaultCellStyle = dataGridViewCellStyle7;
            this.wip_qty.HeaderText = "W.I.P Qty";
            this.wip_qty.Name = "wip_qty";
            this.wip_qty.Width = 78;
            // 
            // repair_qty
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.repair_qty.DefaultCellStyle = dataGridViewCellStyle8;
            this.repair_qty.HeaderText = "Repair Qty";
            this.repair_qty.Name = "repair_qty";
            this.repair_qty.Width = 82;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(140, 70);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(120, 23);
            this.cmbLocation.TabIndex = 7;
            // 
            // lbLocation
            // 
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(10, 70);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(110, 21);
            this.lbLocation.TabIndex = 18;
            this.lbLocation.Text = "Location";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUnitCode
            // 
            this.lbUnitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitCode.Location = new System.Drawing.Point(10, 100);
            this.lbUnitCode.Name = "lbUnitCode";
            this.lbUnitCode.Size = new System.Drawing.Size(110, 21);
            this.lbUnitCode.TabIndex = 14;
            this.lbUnitCode.Text = "Unit";
            this.lbUnitCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(280, 40);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(350, 21);
            this.txtTypeName.TabIndex = 8;
            this.txtTypeName.Text = "Item Type Name";
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(280, 10);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(350, 21);
            this.txtItemName.TabIndex = 7;
            this.txtItemName.Text = "Item Name";
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbUnitCode
            // 
            this.cmbUnitCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitCode.FormattingEnabled = true;
            this.cmbUnitCode.Location = new System.Drawing.Point(140, 100);
            this.cmbUnitCode.Name = "cmbUnitCode";
            this.cmbUnitCode.Size = new System.Drawing.Size(120, 23);
            this.cmbUnitCode.TabIndex = 8;
            // 
            // rbtnItemType
            // 
            this.rbtnItemType.AutoSize = true;
            this.rbtnItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemType.Location = new System.Drawing.Point(10, 40);
            this.rbtnItemType.Name = "rbtnItemType";
            this.rbtnItemType.Size = new System.Drawing.Size(88, 21);
            this.rbtnItemType.TabIndex = 10;
            this.rbtnItemType.TabStop = true;
            this.rbtnItemType.Text = "Item Type";
            this.rbtnItemType.UseVisualStyleBackColor = true;
            this.rbtnItemType.CheckedChanged += new System.EventHandler(this.rbtnItemCode_CheckedChanged);
            // 
            // rbtnItemCode
            // 
            this.rbtnItemCode.AutoSize = true;
            this.rbtnItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemCode.Location = new System.Drawing.Point(10, 10);
            this.rbtnItemCode.Name = "rbtnItemCode";
            this.rbtnItemCode.Size = new System.Drawing.Size(89, 21);
            this.rbtnItemCode.TabIndex = 9;
            this.rbtnItemCode.TabStop = true;
            this.rbtnItemCode.Text = "Item Code";
            this.rbtnItemCode.UseVisualStyleBackColor = true;
            this.rbtnItemCode.CheckedChanged += new System.EventHandler(this.rbtnItemCode_CheckedChanged);
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(140, 40);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(120, 23);
            this.cmbItemType.TabIndex = 6;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(140, 10);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(120, 21);
            this.txtItem.TabIndex = 5;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(150, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(370, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlSubButton
            // 
            this.pnlSubButton.Controls.Add(this.btnOK);
            this.pnlSubButton.Controls.Add(this.btnCancel);
            this.pnlSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubButton.Location = new System.Drawing.Point(150, 210);
            this.pnlSubButton.Name = "pnlSubButton";
            this.pnlSubButton.Size = new System.Drawing.Size(641, 50);
            this.pnlSubButton.TabIndex = 2;
            // 
            // ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSubButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.dept = "";
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "ItemManagement";
            this.position = "";
            this.Text = "Item Management";
            this.tittle = "FormCommon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubForm_FormClosing);
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.pnlSubButton, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemQty)).EndInit();
            this.pnlSubButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsNumberTotal;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnItemCode;
        private System.Windows.Forms.RadioButton rbtnItemType;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbUnitCode;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbUnitCode;
        private System.Windows.Forms.Panel pnlSubButton;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.DataGridView dgvItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn wip_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair_qty;
    }
}