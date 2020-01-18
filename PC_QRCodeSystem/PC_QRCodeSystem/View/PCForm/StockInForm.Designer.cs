namespace PC_QRCodeSystem.View
{
    partial class StockInForm
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
            this.grt_StockIn = new System.Windows.Forms.TabControl();
            this.tab_StockIn = new System.Windows.Forms.TabPage();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlPacking = new System.Windows.Forms.Panel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAutoPacking = new System.Windows.Forms.Button();
            this.btnManualPacking = new System.Windows.Forms.Button();
            this.pnlAddItems = new System.Windows.Forms.Panel();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnAddPremacItems = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.tab_Setting = new System.Windows.Forms.TabPage();
            this.lbStatusPrinter = new System.Windows.Forms.Label();
            this.btnPrintCheck = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPrinterName = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSettingBack = new System.Windows.Forms.Button();
            this.btnUnitManager = new System.Windows.Forms.Button();
            this.btnSettingApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPremacFileBrowser = new System.Windows.Forms.Button();
            this.txtPremacURL = new System.Windows.Forms.TextBox();
            this.tab_Unit = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.txtQtyUnit = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUnitBack = new System.Windows.Forms.Button();
            this.btnDeleteUnitItem = new System.Windows.Forms.Button();
            this.btnUpdateUnitItem = new System.Windows.Forms.Button();
            this.btnAddUnitItem = new System.Windows.Forms.Button();
            this.tab_printer = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPrinterRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvprinter = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRegisterItems = new System.Windows.Forms.Button();
            this.btnPrinterBack = new System.Windows.Forms.Button();
            this.tab_Packing = new System.Windows.Forms.TabPage();
            this.dgvPacking = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlPrinter = new System.Windows.Forms.Panel();
            this.btnPrintedList = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.btnPackingBack = new System.Windows.Forms.Button();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPackingRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.grt_StockIn.SuspendLayout();
            this.tab_StockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlPacking.SuspendLayout();
            this.pnlAddItems.SuspendLayout();
            this.tab_Setting.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tab_Unit.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.panel5.SuspendLayout();
            this.tab_printer.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprinter)).BeginInit();
            this.panel11.SuspendLayout();
            this.tab_Packing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacking)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlPrinter.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grt_StockIn
            // 
            this.grt_StockIn.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.grt_StockIn.Controls.Add(this.tab_StockIn);
            this.grt_StockIn.Controls.Add(this.tab_Setting);
            this.grt_StockIn.Controls.Add(this.tab_Unit);
            this.grt_StockIn.Controls.Add(this.tab_printer);
            this.grt_StockIn.Controls.Add(this.tab_Packing);
            this.grt_StockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grt_StockIn.Location = new System.Drawing.Point(145, 69);
            this.grt_StockIn.Name = "grt_StockIn";
            this.grt_StockIn.SelectedIndex = 0;
            this.grt_StockIn.Size = new System.Drawing.Size(774, 472);
            this.grt_StockIn.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.grt_StockIn.TabIndex = 2;
            // 
            // tab_StockIn
            // 
            this.tab_StockIn.Controls.Add(this.dgvStockIn);
            this.tab_StockIn.Controls.Add(this.statusStrip1);
            this.tab_StockIn.Controls.Add(this.panel4);
            this.tab_StockIn.Location = new System.Drawing.Point(4, 25);
            this.tab_StockIn.Name = "tab_StockIn";
            this.tab_StockIn.Padding = new System.Windows.Forms.Padding(3);
            this.tab_StockIn.Size = new System.Drawing.Size(766, 443);
            this.tab_StockIn.TabIndex = 0;
            this.tab_StockIn.Text = "Stock In";
            this.tab_StockIn.UseVisualStyleBackColor = true;
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AllowUserToAddRows = false;
            this.dgvStockIn.AllowUserToDeleteRows = false;
            this.dgvStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockIn.Location = new System.Drawing.Point(3, 53);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.ReadOnly = true;
            this.dgvStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIn.Size = new System.Drawing.Size(760, 363);
            this.dgvStockIn.TabIndex = 0;
            this.dgvStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockIn_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.tsRows});
            this.statusStrip1.Location = new System.Drawing.Point(3, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(660, 19);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel1.Text = "Rows :";
            // 
            // tsRows
            // 
            this.tsRows.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsRows.Name = "tsRows";
            this.tsRows.Size = new System.Drawing.Size(40, 19);
            this.tsRows.Text = "None";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlPacking);
            this.panel4.Controls.Add(this.pnlAddItems);
            this.panel4.Controls.Add(this.btnSetting);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 50);
            this.panel4.TabIndex = 2;
            // 
            // pnlPacking
            // 
            this.pnlPacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlPacking.Controls.Add(this.txtCapacity);
            this.pnlPacking.Controls.Add(this.label10);
            this.pnlPacking.Controls.Add(this.btnAutoPacking);
            this.pnlPacking.Controls.Add(this.btnManualPacking);
            this.pnlPacking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPacking.Location = new System.Drawing.Point(280, 0);
            this.pnlPacking.Name = "pnlPacking";
            this.pnlPacking.Size = new System.Drawing.Size(340, 50);
            this.pnlPacking.TabIndex = 3;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(250, 15);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(80, 20);
            this.txtCapacity.TabIndex = 0;
            this.txtCapacity.Text = "0";
            this.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(190, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Capacity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoPacking
            // 
            this.btnAutoPacking.Location = new System.Drawing.Point(10, 5);
            this.btnAutoPacking.Name = "btnAutoPacking";
            this.btnAutoPacking.Size = new System.Drawing.Size(80, 40);
            this.btnAutoPacking.TabIndex = 2;
            this.btnAutoPacking.Text = "Auto Packing";
            this.btnAutoPacking.UseVisualStyleBackColor = true;
            this.btnAutoPacking.Click += new System.EventHandler(this.btnAutoPacking_Click);
            // 
            // btnManualPacking
            // 
            this.btnManualPacking.Location = new System.Drawing.Point(100, 5);
            this.btnManualPacking.Name = "btnManualPacking";
            this.btnManualPacking.Size = new System.Drawing.Size(80, 40);
            this.btnManualPacking.TabIndex = 3;
            this.btnManualPacking.Text = "Manual Packing";
            this.btnManualPacking.UseVisualStyleBackColor = true;
            this.btnManualPacking.Click += new System.EventHandler(this.btnManualPacking_Click);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.BackColor = System.Drawing.Color.Lime;
            this.pnlAddItems.Controls.Add(this.btnImportExcel);
            this.pnlAddItems.Controls.Add(this.btnAddPremacItems);
            this.pnlAddItems.Controls.Add(this.btnAddItem);
            this.pnlAddItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddItems.Location = new System.Drawing.Point(0, 0);
            this.pnlAddItems.Name = "pnlAddItems";
            this.pnlAddItems.Size = new System.Drawing.Size(280, 50);
            this.pnlAddItems.TabIndex = 3;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(100, 5);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(80, 40);
            this.btnImportExcel.TabIndex = 6;
            this.btnImportExcel.Text = "Get Items From Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnAddPremacItems
            // 
            this.btnAddPremacItems.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPremacItems.Location = new System.Drawing.Point(10, 5);
            this.btnAddPremacItems.Name = "btnAddPremacItems";
            this.btnAddPremacItems.Size = new System.Drawing.Size(80, 40);
            this.btnAddPremacItems.TabIndex = 1;
            this.btnAddPremacItems.Text = "Get Items From Premac";
            this.btnAddPremacItems.UseVisualStyleBackColor = true;
            this.btnAddPremacItems.Click += new System.EventHandler(this.btnAddPremacItems_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(190, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 40);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item Manual";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetting.Location = new System.Drawing.Point(670, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(80, 40);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tab_Setting
            // 
            this.tab_Setting.Controls.Add(this.lbStatusPrinter);
            this.tab_Setting.Controls.Add(this.btnPrintCheck);
            this.tab_Setting.Controls.Add(this.label9);
            this.tab_Setting.Controls.Add(this.cmbPrinterName);
            this.tab_Setting.Controls.Add(this.panel10);
            this.tab_Setting.Controls.Add(this.label2);
            this.tab_Setting.Controls.Add(this.btnPremacFileBrowser);
            this.tab_Setting.Controls.Add(this.txtPremacURL);
            this.tab_Setting.Location = new System.Drawing.Point(4, 25);
            this.tab_Setting.Name = "tab_Setting";
            this.tab_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Setting.Size = new System.Drawing.Size(766, 443);
            this.tab_Setting.TabIndex = 1;
            this.tab_Setting.Text = "Setting";
            this.tab_Setting.UseVisualStyleBackColor = true;
            // 
            // lbStatusPrinter
            // 
            this.lbStatusPrinter.AutoSize = true;
            this.lbStatusPrinter.Location = new System.Drawing.Point(228, 125);
            this.lbStatusPrinter.Name = "lbStatusPrinter";
            this.lbStatusPrinter.Size = new System.Drawing.Size(33, 13);
            this.lbStatusPrinter.TabIndex = 11;
            this.lbStatusPrinter.Text = "None";
            // 
            // btnPrintCheck
            // 
            this.btnPrintCheck.Location = new System.Drawing.Point(285, 122);
            this.btnPrintCheck.Name = "btnPrintCheck";
            this.btnPrintCheck.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCheck.TabIndex = 10;
            this.btnPrintCheck.Text = "Check";
            this.btnPrintCheck.UseVisualStyleBackColor = true;
            this.btnPrintCheck.Click += new System.EventHandler(this.btnPrintCheck_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Choose printer for use :";
            // 
            // cmbPrinterName
            // 
            this.cmbPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterName.FormattingEnabled = true;
            this.cmbPrinterName.Location = new System.Drawing.Point(11, 122);
            this.cmbPrinterName.Name = "cmbPrinterName";
            this.cmbPrinterName.Size = new System.Drawing.Size(211, 21);
            this.cmbPrinterName.TabIndex = 8;
            this.cmbPrinterName.SelectedIndexChanged += new System.EventHandler(this.cmbPrinterName_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSettingBack);
            this.panel10.Controls.Add(this.btnUnitManager);
            this.panel10.Controls.Add(this.btnSettingApply);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(760, 50);
            this.panel10.TabIndex = 7;
            // 
            // btnSettingBack
            // 
            this.btnSettingBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingBack.Location = new System.Drawing.Point(670, 5);
            this.btnSettingBack.Name = "btnSettingBack";
            this.btnSettingBack.Size = new System.Drawing.Size(80, 40);
            this.btnSettingBack.TabIndex = 6;
            this.btnSettingBack.Text = "Back";
            this.btnSettingBack.UseVisualStyleBackColor = true;
            this.btnSettingBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUnitManager
            // 
            this.btnUnitManager.Location = new System.Drawing.Point(10, 5);
            this.btnUnitManager.Name = "btnUnitManager";
            this.btnUnitManager.Size = new System.Drawing.Size(80, 40);
            this.btnUnitManager.TabIndex = 5;
            this.btnUnitManager.Text = "Unit Manager";
            this.btnUnitManager.UseVisualStyleBackColor = true;
            this.btnUnitManager.Click += new System.EventHandler(this.btnUnitManager_Click);
            // 
            // btnSettingApply
            // 
            this.btnSettingApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingApply.Location = new System.Drawing.Point(580, 5);
            this.btnSettingApply.Name = "btnSettingApply";
            this.btnSettingApply.Size = new System.Drawing.Size(80, 40);
            this.btnSettingApply.TabIndex = 4;
            this.btnSettingApply.Text = "Apply";
            this.btnSettingApply.UseVisualStyleBackColor = true;
            this.btnSettingApply.Click += new System.EventHandler(this.btnSettingApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose folder contains Premac file :";
            // 
            // btnPremacFileBrowser
            // 
            this.btnPremacFileBrowser.Location = new System.Drawing.Point(285, 81);
            this.btnPremacFileBrowser.Name = "btnPremacFileBrowser";
            this.btnPremacFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnPremacFileBrowser.TabIndex = 2;
            this.btnPremacFileBrowser.Text = "Browser";
            this.btnPremacFileBrowser.UseVisualStyleBackColor = true;
            this.btnPremacFileBrowser.Click += new System.EventHandler(this.btnPremacFileBrowser_Click);
            // 
            // txtPremacURL
            // 
            this.txtPremacURL.Location = new System.Drawing.Point(11, 83);
            this.txtPremacURL.Name = "txtPremacURL";
            this.txtPremacURL.Size = new System.Drawing.Size(268, 20);
            this.txtPremacURL.TabIndex = 1;
            // 
            // tab_Unit
            // 
            this.tab_Unit.Controls.Add(this.panel6);
            this.tab_Unit.Controls.Add(this.dgvUnit);
            this.tab_Unit.Controls.Add(this.panel5);
            this.tab_Unit.Location = new System.Drawing.Point(4, 25);
            this.tab_Unit.Name = "tab_Unit";
            this.tab_Unit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Unit.Size = new System.Drawing.Size(766, 443);
            this.tab_Unit.TabIndex = 2;
            this.tab_Unit.Text = "Unit";
            this.tab_Unit.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtUnitType);
            this.panel6.Controls.Add(this.txtQtyUnit);
            this.panel6.Controls.Add(this.txtItemName);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtItemNo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 387);
            this.panel6.TabIndex = 7;
            // 
            // txtUnitType
            // 
            this.txtUnitType.Location = new System.Drawing.Point(80, 110);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.Size = new System.Drawing.Size(121, 20);
            this.txtUnitType.TabIndex = 15;
            // 
            // txtQtyUnit
            // 
            this.txtQtyUnit.Location = new System.Drawing.Point(80, 80);
            this.txtQtyUnit.Name = "txtQtyUnit";
            this.txtQtyUnit.Size = new System.Drawing.Size(121, 20);
            this.txtQtyUnit.TabIndex = 14;
            this.txtQtyUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyUnit_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(80, 50);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(121, 20);
            this.txtItemName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Unit Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Qty per Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Number";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(80, 20);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(121, 20);
            this.txtItemNo.TabIndex = 5;
            // 
            // dgvUnit
            // 
            this.dgvUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(231, 53);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(532, 384);
            this.dgvUnit.TabIndex = 3;
            this.dgvUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUnitBack);
            this.panel5.Controls.Add(this.btnDeleteUnitItem);
            this.panel5.Controls.Add(this.btnUpdateUnitItem);
            this.panel5.Controls.Add(this.btnAddUnitItem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 50);
            this.panel5.TabIndex = 4;
            // 
            // btnUnitBack
            // 
            this.btnUnitBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnitBack.Location = new System.Drawing.Point(670, 5);
            this.btnUnitBack.Name = "btnUnitBack";
            this.btnUnitBack.Size = new System.Drawing.Size(80, 40);
            this.btnUnitBack.TabIndex = 5;
            this.btnUnitBack.Text = "Back";
            this.btnUnitBack.UseVisualStyleBackColor = true;
            this.btnUnitBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteUnitItem
            // 
            this.btnDeleteUnitItem.Enabled = false;
            this.btnDeleteUnitItem.Location = new System.Drawing.Point(190, 5);
            this.btnDeleteUnitItem.Name = "btnDeleteUnitItem";
            this.btnDeleteUnitItem.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteUnitItem.TabIndex = 4;
            this.btnDeleteUnitItem.Text = "Delete";
            this.btnDeleteUnitItem.UseVisualStyleBackColor = true;
            this.btnDeleteUnitItem.Click += new System.EventHandler(this.btnDeleteUnitItem_Click);
            // 
            // btnUpdateUnitItem
            // 
            this.btnUpdateUnitItem.Enabled = false;
            this.btnUpdateUnitItem.Location = new System.Drawing.Point(100, 5);
            this.btnUpdateUnitItem.Name = "btnUpdateUnitItem";
            this.btnUpdateUnitItem.Size = new System.Drawing.Size(80, 40);
            this.btnUpdateUnitItem.TabIndex = 3;
            this.btnUpdateUnitItem.Text = "Update Item";
            this.btnUpdateUnitItem.UseVisualStyleBackColor = true;
            this.btnUpdateUnitItem.Click += new System.EventHandler(this.btnUpdateUnitItem_Click);
            // 
            // btnAddUnitItem
            // 
            this.btnAddUnitItem.Location = new System.Drawing.Point(10, 5);
            this.btnAddUnitItem.Name = "btnAddUnitItem";
            this.btnAddUnitItem.Size = new System.Drawing.Size(80, 40);
            this.btnAddUnitItem.TabIndex = 2;
            this.btnAddUnitItem.Text = "Add Item";
            this.btnAddUnitItem.UseVisualStyleBackColor = true;
            this.btnAddUnitItem.Click += new System.EventHandler(this.btnAddUnitItem_Click);
            // 
            // tab_printer
            // 
            this.tab_printer.Controls.Add(this.statusStrip2);
            this.tab_printer.Controls.Add(this.dgvprinter);
            this.tab_printer.Controls.Add(this.panel11);
            this.tab_printer.Location = new System.Drawing.Point(4, 25);
            this.tab_printer.Name = "tab_printer";
            this.tab_printer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_printer.Size = new System.Drawing.Size(766, 443);
            this.tab_printer.TabIndex = 3;
            this.tab_printer.Text = "Printer";
            this.tab_printer.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tsPrinterRows});
            this.statusStrip2.Location = new System.Drawing.Point(3, 416);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(760, 24);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(660, 19);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel4.Text = "Rows :";
            // 
            // tsPrinterRows
            // 
            this.tsPrinterRows.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsPrinterRows.Name = "tsPrinterRows";
            this.tsPrinterRows.Size = new System.Drawing.Size(40, 19);
            this.tsPrinterRows.Text = "None";
            // 
            // dgvprinter
            // 
            this.dgvprinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvprinter.Location = new System.Drawing.Point(3, 53);
            this.dgvprinter.Name = "dgvprinter";
            this.dgvprinter.ReadOnly = true;
            this.dgvprinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprinter.Size = new System.Drawing.Size(760, 387);
            this.dgvprinter.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnRegisterItems);
            this.panel11.Controls.Add(this.btnPrinterBack);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(760, 50);
            this.panel11.TabIndex = 0;
            // 
            // btnRegisterItems
            // 
            this.btnRegisterItems.Location = new System.Drawing.Point(10, 5);
            this.btnRegisterItems.Name = "btnRegisterItems";
            this.btnRegisterItems.Size = new System.Drawing.Size(80, 40);
            this.btnRegisterItems.TabIndex = 1;
            this.btnRegisterItems.Text = "Register Items";
            this.btnRegisterItems.UseVisualStyleBackColor = true;
            this.btnRegisterItems.Click += new System.EventHandler(this.btnRegisterItems_Click);
            // 
            // btnPrinterBack
            // 
            this.btnPrinterBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrinterBack.Location = new System.Drawing.Point(670, 5);
            this.btnPrinterBack.Name = "btnPrinterBack";
            this.btnPrinterBack.Size = new System.Drawing.Size(80, 40);
            this.btnPrinterBack.TabIndex = 0;
            this.btnPrinterBack.Text = "Back";
            this.btnPrinterBack.UseVisualStyleBackColor = true;
            this.btnPrinterBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tab_Packing
            // 
            this.tab_Packing.Controls.Add(this.dgvPacking);
            this.tab_Packing.Controls.Add(this.panel7);
            this.tab_Packing.Controls.Add(this.statusStrip3);
            this.tab_Packing.Location = new System.Drawing.Point(4, 25);
            this.tab_Packing.Name = "tab_Packing";
            this.tab_Packing.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Packing.Size = new System.Drawing.Size(766, 443);
            this.tab_Packing.TabIndex = 4;
            this.tab_Packing.Text = "Packing";
            this.tab_Packing.UseVisualStyleBackColor = true;
            // 
            // dgvPacking
            // 
            this.dgvPacking.AllowUserToAddRows = false;
            this.dgvPacking.AllowUserToDeleteRows = false;
            this.dgvPacking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacking.Location = new System.Drawing.Point(3, 53);
            this.dgvPacking.Name = "dgvPacking";
            this.dgvPacking.ReadOnly = true;
            this.dgvPacking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacking.Size = new System.Drawing.Size(760, 363);
            this.dgvPacking.TabIndex = 2;
            this.dgvPacking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacking_CellClick);
            this.dgvPacking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacking_CellDoubleClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlPrinter);
            this.panel7.Controls.Add(this.btnPackingBack);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 50);
            this.panel7.TabIndex = 1;
            // 
            // pnlPrinter
            // 
            this.pnlPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlPrinter.Controls.Add(this.btnPrintedList);
            this.pnlPrinter.Controls.Add(this.btnPrinter);
            this.pnlPrinter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrinter.Location = new System.Drawing.Point(0, 0);
            this.pnlPrinter.Name = "pnlPrinter";
            this.pnlPrinter.Size = new System.Drawing.Size(190, 50);
            this.pnlPrinter.TabIndex = 4;
            // 
            // btnPrintedList
            // 
            this.btnPrintedList.Location = new System.Drawing.Point(100, 5);
            this.btnPrintedList.Name = "btnPrintedList";
            this.btnPrintedList.Size = new System.Drawing.Size(80, 40);
            this.btnPrintedList.TabIndex = 9;
            this.btnPrintedList.Text = "Printed List";
            this.btnPrintedList.UseVisualStyleBackColor = true;
            this.btnPrintedList.Click += new System.EventHandler(this.btnPrintedList_Click);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(10, 5);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(80, 40);
            this.btnPrinter.TabIndex = 8;
            this.btnPrinter.Text = "Printer Label";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnPackingBack
            // 
            this.btnPackingBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPackingBack.Location = new System.Drawing.Point(670, 5);
            this.btnPackingBack.Name = "btnPackingBack";
            this.btnPackingBack.Size = new System.Drawing.Size(80, 40);
            this.btnPackingBack.TabIndex = 0;
            this.btnPackingBack.Text = "Back";
            this.btnPackingBack.UseVisualStyleBackColor = true;
            this.btnPackingBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.tsPackingRows});
            this.statusStrip3.Location = new System.Drawing.Point(3, 416);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(760, 24);
            this.statusStrip3.TabIndex = 0;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(660, 19);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel6.Text = "Rows :";
            // 
            // tsPackingRows
            // 
            this.tsPackingRows.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsPackingRows.Name = "tsPackingRows";
            this.tsPackingRows.Size = new System.Drawing.Size(40, 19);
            this.tsPackingRows.Text = "None";
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 541);
            this.Controls.Add(this.grt_StockIn);
            this.dept = "";
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "StockInForm";
            this.Text = "Input Stock";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            this.Controls.SetChildIndex(this.grt_StockIn, 0);
            this.grt_StockIn.ResumeLayout(false);
            this.tab_StockIn.ResumeLayout(false);
            this.tab_StockIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlPacking.ResumeLayout(false);
            this.pnlPacking.PerformLayout();
            this.pnlAddItems.ResumeLayout(false);
            this.tab_Setting.ResumeLayout(false);
            this.tab_Setting.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.tab_Unit.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tab_printer.ResumeLayout(false);
            this.tab_printer.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprinter)).EndInit();
            this.panel11.ResumeLayout(false);
            this.tab_Packing.ResumeLayout(false);
            this.tab_Packing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacking)).EndInit();
            this.panel7.ResumeLayout(false);
            this.pnlPrinter.ResumeLayout(false);
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl grt_StockIn;
        private System.Windows.Forms.TabPage tab_StockIn;
        private System.Windows.Forms.TabPage tab_Setting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPremacFileBrowser;
        private System.Windows.Forms.TextBox txtPremacURL;
        private System.Windows.Forms.Button btnSettingApply;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.Button btnAddPremacItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnManualPacking;
        private System.Windows.Forms.Button btnAutoPacking;
        private System.Windows.Forms.TabPage tab_Unit;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeleteUnitItem;
        private System.Windows.Forms.Button btnUpdateUnitItem;
        private System.Windows.Forms.Button btnAddUnitItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtQtyUnit;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.Panel pnlPacking;
        private System.Windows.Forms.Panel pnlAddItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsRows;
        private System.Windows.Forms.Button btnUnitManager;
        private System.Windows.Forms.Button btnUnitBack;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSettingBack;
        private System.Windows.Forms.TabPage tab_printer;
        private System.Windows.Forms.DataGridView dgvprinter;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPrinterBack;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsPrinterRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPrinterName;
        private System.Windows.Forms.Button btnPrintCheck;
        private System.Windows.Forms.Label lbStatusPrinter;
        private System.Windows.Forms.Button btnRegisterItems;
        private System.Windows.Forms.TabPage tab_Packing;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tsPackingRows;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPackingBack;
        private System.Windows.Forms.DataGridView dgvPacking;
        private System.Windows.Forms.Panel pnlPrinter;
        private System.Windows.Forms.Button btnPrintedList;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCapacity;
    }
}