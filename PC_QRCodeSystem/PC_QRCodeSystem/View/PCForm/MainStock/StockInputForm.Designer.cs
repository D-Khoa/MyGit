namespace PC_QRCodeSystem.View
{
    partial class StockInputForm
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
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnMainClear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbtnEven = new System.Windows.Forms.RadioButton();
            this.rbtnOdd = new System.Windows.Forms.RadioButton();
            this.btnAutoPacking = new System.Windows.Forms.Button();
            this.btnManualPacking = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.btnInspection = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPremacImport = new System.Windows.Forms.Button();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tab_Main = new System.Windows.Forms.TabPage();
            this.dgvPreInput = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbCheckDate = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIncharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierInvoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.btnSearchPreInput = new System.Windows.Forms.Button();
            this.tab_Inspection = new System.Windows.Forms.TabPage();
            this.dgvInspection = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInspectionClear = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.tab_Print = new System.Windows.Forms.TabPage();
            this.dgvPrintList = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPrintClear = new System.Windows.Forms.Button();
            this.btnManualPrint = new System.Windows.Forms.Button();
            this.btnPrintSelected = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnPrintBack = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTotalQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOrderCD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlOption.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tc_Main.SuspendLayout();
            this.tab_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreInput)).BeginInit();
            this.panel8.SuspendLayout();
            this.tab_Inspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).BeginInit();
            this.panel4.SuspendLayout();
            this.tab_Print.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintList)).BeginInit();
            this.panel7.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.btnMainClear);
            this.pnlOption.Controls.Add(this.panel6);
            this.pnlOption.Controls.Add(this.btnPrintList);
            this.pnlOption.Controls.Add(this.btnInspection);
            this.pnlOption.Controls.Add(this.btnSetting);
            this.pnlOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOption.Location = new System.Drawing.Point(4, 4);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(898, 60);
            this.pnlOption.TabIndex = 2;
            // 
            // btnMainClear
            // 
            this.btnMainClear.Location = new System.Drawing.Point(780, 5);
            this.btnMainClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainClear.Name = "btnMainClear";
            this.btnMainClear.Size = new System.Drawing.Size(100, 50);
            this.btnMainClear.TabIndex = 23;
            this.btnMainClear.Text = "Clear";
            this.btnMainClear.UseVisualStyleBackColor = true;
            this.btnMainClear.Click += new System.EventHandler(this.btnMainClear_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbtnEven);
            this.panel6.Controls.Add(this.rbtnOdd);
            this.panel6.Controls.Add(this.btnAutoPacking);
            this.panel6.Controls.Add(this.btnManualPacking);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtCapacity);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 60);
            this.panel6.TabIndex = 23;
            // 
            // rbtnEven
            // 
            this.rbtnEven.AutoSize = true;
            this.rbtnEven.BackColor = System.Drawing.Color.Lime;
            this.rbtnEven.Location = new System.Drawing.Point(230, 5);
            this.rbtnEven.Name = "rbtnEven";
            this.rbtnEven.Size = new System.Drawing.Size(58, 21);
            this.rbtnEven.TabIndex = 17;
            this.rbtnEven.TabStop = true;
            this.rbtnEven.Text = "Even";
            this.rbtnEven.UseVisualStyleBackColor = false;
            this.rbtnEven.CheckedChanged += new System.EventHandler(this.rbtnEven_CheckedChanged);
            // 
            // rbtnOdd
            // 
            this.rbtnOdd.AutoSize = true;
            this.rbtnOdd.BackColor = System.Drawing.Color.Yellow;
            this.rbtnOdd.Location = new System.Drawing.Point(230, 30);
            this.rbtnOdd.Name = "rbtnOdd";
            this.rbtnOdd.Size = new System.Drawing.Size(53, 21);
            this.rbtnOdd.TabIndex = 18;
            this.rbtnOdd.TabStop = true;
            this.rbtnOdd.Text = "Odd";
            this.rbtnOdd.UseVisualStyleBackColor = false;
            this.rbtnOdd.CheckedChanged += new System.EventHandler(this.rbtnEven_CheckedChanged);
            // 
            // btnAutoPacking
            // 
            this.btnAutoPacking.Location = new System.Drawing.Point(10, 5);
            this.btnAutoPacking.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoPacking.Name = "btnAutoPacking";
            this.btnAutoPacking.Size = new System.Drawing.Size(100, 50);
            this.btnAutoPacking.TabIndex = 15;
            this.btnAutoPacking.Text = "Auto Packing";
            this.btnAutoPacking.UseVisualStyleBackColor = true;
            this.btnAutoPacking.Click += new System.EventHandler(this.btnAutoPacking_Click);
            // 
            // btnManualPacking
            // 
            this.btnManualPacking.Location = new System.Drawing.Point(120, 5);
            this.btnManualPacking.Margin = new System.Windows.Forms.Padding(4);
            this.btnManualPacking.Name = "btnManualPacking";
            this.btnManualPacking.Size = new System.Drawing.Size(100, 50);
            this.btnManualPacking.TabIndex = 16;
            this.btnManualPacking.Text = "Manual Packing";
            this.btnManualPacking.UseVisualStyleBackColor = true;
            this.btnManualPacking.Click += new System.EventHandler(this.btnManualPacking_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(295, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Lot Size";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(298, 28);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(117, 23);
            this.txtCapacity.TabIndex = 19;
            this.txtCapacity.Text = "0";
            this.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPrintList
            // 
            this.btnPrintList.Location = new System.Drawing.Point(450, 4);
            this.btnPrintList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(100, 50);
            this.btnPrintList.TabIndex = 20;
            this.btnPrintList.Text = "Print List";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnInspection
            // 
            this.btnInspection.Location = new System.Drawing.Point(560, 5);
            this.btnInspection.Margin = new System.Windows.Forms.Padding(4);
            this.btnInspection.Name = "btnInspection";
            this.btnInspection.Size = new System.Drawing.Size(100, 50);
            this.btnInspection.TabIndex = 21;
            this.btnInspection.Text = "Inspection";
            this.btnInspection.UseVisualStyleBackColor = true;
            this.btnInspection.Click += new System.EventHandler(this.btnInspection_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(670, 5);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 50);
            this.btnSetting.TabIndex = 22;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPremacImport
            // 
            this.btnPremacImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremacImport.Location = new System.Drawing.Point(360, 99);
            this.btnPremacImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPremacImport.Name = "btnPremacImport";
            this.btnPremacImport.Size = new System.Drawing.Size(100, 50);
            this.btnPremacImport.TabIndex = 14;
            this.btnPremacImport.Text = "Search From Premac File";
            this.btnPremacImport.UseVisualStyleBackColor = true;
            this.btnPremacImport.Click += new System.EventHandler(this.btnPremacImport_Click);
            // 
            // tc_Main
            // 
            this.tc_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_Main.Controls.Add(this.tab_Main);
            this.tc_Main.Controls.Add(this.tab_Inspection);
            this.tc_Main.Controls.Add(this.tab_Print);
            this.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Main.Location = new System.Drawing.Point(150, 70);
            this.tc_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(914, 475);
            this.tc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Main.TabIndex = 3;
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.dgvPreInput);
            this.tab_Main.Controls.Add(this.panel8);
            this.tab_Main.Controls.Add(this.pnlOption);
            this.tab_Main.Location = new System.Drawing.Point(4, 28);
            this.tab_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Main.Size = new System.Drawing.Size(906, 443);
            this.tab_Main.TabIndex = 0;
            this.tab_Main.Text = "Main";
            this.tab_Main.UseVisualStyleBackColor = true;
            // 
            // dgvPreInput
            // 
            this.dgvPreInput.AllowUserToAddRows = false;
            this.dgvPreInput.AllowUserToDeleteRows = false;
            this.dgvPreInput.AllowUserToResizeRows = false;
            this.dgvPreInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreInput.Location = new System.Drawing.Point(4, 219);
            this.dgvPreInput.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPreInput.Name = "dgvPreInput";
            this.dgvPreInput.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreInput.RowHeadersVisible = false;
            this.dgvPreInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreInput.Size = new System.Drawing.Size(898, 220);
            this.dgvPreInput.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbCheckDate);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.dtpToDate);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.btnPremacImport);
            this.panel8.Controls.Add(this.dtpFromDate);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.txtIncharge);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.txtPONo);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txtOrderNo);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.txtSupplierInvoice);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.txtSupplierCode);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.txtItemNum);
            this.panel8.Controls.Add(this.btnSearchPreInput);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(4, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(898, 155);
            this.panel8.TabIndex = 1;
            // 
            // cbCheckDate
            // 
            this.cbCheckDate.AutoSize = true;
            this.cbCheckDate.Location = new System.Drawing.Point(490, 10);
            this.cbCheckDate.Name = "cbCheckDate";
            this.cbCheckDate.Size = new System.Drawing.Size(100, 21);
            this.cbCheckDate.TabIndex = 10;
            this.cbCheckDate.Text = "Check Date";
            this.cbCheckDate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(490, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "To Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(600, 70);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 23);
            this.dtpToDate.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(490, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "From Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(600, 40);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 23);
            this.dtpFromDate.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(250, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Incharge";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIncharge
            // 
            this.txtIncharge.Location = new System.Drawing.Point(360, 70);
            this.txtIncharge.Name = "txtIncharge";
            this.txtIncharge.Size = new System.Drawing.Size(120, 23);
            this.txtIncharge.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(250, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "PO Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(360, 40);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(120, 23);
            this.txtPONo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(250, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(360, 10);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(120, 23);
            this.txtOrderNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Invoice";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierInvoice
            // 
            this.txtSupplierInvoice.Location = new System.Drawing.Point(120, 70);
            this.txtSupplierInvoice.Name = "txtSupplierInvoice";
            this.txtSupplierInvoice.Size = new System.Drawing.Size(120, 23);
            this.txtSupplierInvoice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Supplier Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(120, 40);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(120, 23);
            this.txtSupplierCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemNum
            // 
            this.txtItemNum.Location = new System.Drawing.Point(120, 10);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(120, 23);
            this.txtItemNum.TabIndex = 4;
            // 
            // btnSearchPreInput
            // 
            this.btnSearchPreInput.Location = new System.Drawing.Point(120, 99);
            this.btnSearchPreInput.Name = "btnSearchPreInput";
            this.btnSearchPreInput.Size = new System.Drawing.Size(100, 50);
            this.btnSearchPreInput.TabIndex = 13;
            this.btnSearchPreInput.Text = "Search From Database";
            this.btnSearchPreInput.UseVisualStyleBackColor = true;
            this.btnSearchPreInput.Click += new System.EventHandler(this.btnSearchPreInput_Click);
            // 
            // tab_Inspection
            // 
            this.tab_Inspection.Controls.Add(this.dgvInspection);
            this.tab_Inspection.Controls.Add(this.panel4);
            this.tab_Inspection.Location = new System.Drawing.Point(4, 28);
            this.tab_Inspection.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Inspection.Name = "tab_Inspection";
            this.tab_Inspection.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Inspection.Size = new System.Drawing.Size(906, 443);
            this.tab_Inspection.TabIndex = 2;
            this.tab_Inspection.Text = "Inspection";
            this.tab_Inspection.UseVisualStyleBackColor = true;
            this.tab_Inspection.Paint += new System.Windows.Forms.PaintEventHandler(this.tab_Inspection_Paint);
            // 
            // dgvInspection
            // 
            this.dgvInspection.AllowUserToAddRows = false;
            this.dgvInspection.AllowUserToDeleteRows = false;
            this.dgvInspection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInspection.Location = new System.Drawing.Point(4, 134);
            this.dgvInspection.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInspection.Name = "dgvInspection";
            this.dgvInspection.ReadOnly = true;
            this.dgvInspection.Size = new System.Drawing.Size(898, 305);
            this.dgvInspection.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtOrderCD);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnInspectionClear);
            this.panel4.Controls.Add(this.txtSupplierName);
            this.panel4.Controls.Add(this.txtSupplierCD);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnInsBack);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnRegister);
            this.panel4.Controls.Add(this.txtBarcode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(898, 130);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Barcode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInspectionClear
            // 
            this.btnInspectionClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspectionClear.Location = new System.Drawing.Point(460, 70);
            this.btnInspectionClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnInspectionClear.Name = "btnInspectionClear";
            this.btnInspectionClear.Size = new System.Drawing.Size(80, 50);
            this.btnInspectionClear.TabIndex = 9;
            this.btnInspectionClear.Text = "Clear";
            this.btnInspectionClear.UseVisualStyleBackColor = true;
            this.btnInspectionClear.Click += new System.EventHandler(this.btnInspectionClear_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(250, 40);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(400, 23);
            this.txtSupplierName.TabIndex = 5;
            this.txtSupplierName.Text = "Supplier Name";
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSupplierCD
            // 
            this.txtSupplierCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCD.Location = new System.Drawing.Point(120, 40);
            this.txtSupplierCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierCD.Name = "txtSupplierCD";
            this.txtSupplierCD.Size = new System.Drawing.Size(120, 23);
            this.txtSupplierCD.TabIndex = 4;
            this.txtSupplierCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplierCD_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Supplier Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInsBack
            // 
            this.btnInsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsBack.Location = new System.Drawing.Point(570, 70);
            this.btnInsBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsBack.Name = "btnInsBack";
            this.btnInsBack.Size = new System.Drawing.Size(80, 50);
            this.btnInsBack.TabIndex = 10;
            this.btnInsBack.Text = "Back";
            this.btnInsBack.UseVisualStyleBackColor = true;
            this.btnInsBack.Click += new System.EventHandler(this.btnPrintBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(350, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 50);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(250, 70);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(120, 10);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(530, 23);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // tab_Print
            // 
            this.tab_Print.Controls.Add(this.dgvPrintList);
            this.tab_Print.Controls.Add(this.panel7);
            this.tab_Print.Location = new System.Drawing.Point(4, 28);
            this.tab_Print.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Print.Name = "tab_Print";
            this.tab_Print.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Print.Size = new System.Drawing.Size(906, 443);
            this.tab_Print.TabIndex = 3;
            this.tab_Print.Text = "Print";
            this.tab_Print.UseVisualStyleBackColor = true;
            this.tab_Print.Paint += new System.Windows.Forms.PaintEventHandler(this.tab_Print_Paint);
            // 
            // dgvPrintList
            // 
            this.dgvPrintList.AllowUserToAddRows = false;
            this.dgvPrintList.AllowUserToDeleteRows = false;
            this.dgvPrintList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintList.Location = new System.Drawing.Point(4, 64);
            this.dgvPrintList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrintList.Name = "dgvPrintList";
            this.dgvPrintList.ReadOnly = true;
            this.dgvPrintList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrintList.Size = new System.Drawing.Size(898, 375);
            this.dgvPrintList.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPrintClear);
            this.panel7.Controls.Add(this.btnManualPrint);
            this.panel7.Controls.Add(this.btnPrintSelected);
            this.panel7.Controls.Add(this.btnPrintAll);
            this.panel7.Controls.Add(this.btnPrintBack);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(898, 60);
            this.panel7.TabIndex = 1;
            // 
            // btnPrintClear
            // 
            this.btnPrintClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintClear.Location = new System.Drawing.Point(640, 5);
            this.btnPrintClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintClear.Name = "btnPrintClear";
            this.btnPrintClear.Size = new System.Drawing.Size(100, 50);
            this.btnPrintClear.TabIndex = 6;
            this.btnPrintClear.Text = "Clear";
            this.btnPrintClear.UseVisualStyleBackColor = true;
            this.btnPrintClear.Click += new System.EventHandler(this.btnPrintClear_Click);
            // 
            // btnManualPrint
            // 
            this.btnManualPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualPrint.Location = new System.Drawing.Point(230, 5);
            this.btnManualPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnManualPrint.Name = "btnManualPrint";
            this.btnManualPrint.Size = new System.Drawing.Size(100, 50);
            this.btnManualPrint.TabIndex = 5;
            this.btnManualPrint.Text = "Print One Label";
            this.btnManualPrint.UseVisualStyleBackColor = true;
            this.btnManualPrint.Click += new System.EventHandler(this.btnManualPrint_Click);
            // 
            // btnPrintSelected
            // 
            this.btnPrintSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSelected.Location = new System.Drawing.Point(10, 5);
            this.btnPrintSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintSelected.Name = "btnPrintSelected";
            this.btnPrintSelected.Size = new System.Drawing.Size(100, 50);
            this.btnPrintSelected.TabIndex = 3;
            this.btnPrintSelected.Text = "Print Selected";
            this.btnPrintSelected.UseVisualStyleBackColor = true;
            this.btnPrintSelected.Click += new System.EventHandler(this.btnPrintSelected_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.Location = new System.Drawing.Point(120, 5);
            this.btnPrintAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(100, 50);
            this.btnPrintAll.TabIndex = 4;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnPrintBack
            // 
            this.btnPrintBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBack.Location = new System.Drawing.Point(760, 5);
            this.btnPrintBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintBack.Name = "btnPrintBack";
            this.btnPrintBack.Size = new System.Drawing.Size(100, 50);
            this.btnPrintBack.TabIndex = 7;
            this.btnPrintBack.Text = "Back";
            this.btnPrintBack.UseVisualStyleBackColor = true;
            this.btnPrintBack.Click += new System.EventHandler(this.btnPrintBack_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.tsRow,
            this.tsTime,
            this.toolStripStatusLabel5,
            this.tsTotalQty});
            this.statusStrip2.Location = new System.Drawing.Point(150, 545);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(914, 24);
            this.statusStrip2.TabIndex = 27;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(40, 19);
            this.toolStripStatusLabel4.Text = "Row :";
            // 
            // tsRow
            // 
            this.tsRow.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsRow.Name = "tsRow";
            this.tsRow.Size = new System.Drawing.Size(40, 19);
            this.tsRow.Text = "None";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(714, 19);
            this.tsTime.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(69, 19);
            this.toolStripStatusLabel5.Text = "Total Q\'ty :";
            // 
            // tsTotalQty
            // 
            this.tsTotalQty.Name = "tsTotalQty";
            this.tsTotalQty.Size = new System.Drawing.Size(36, 19);
            this.tsTotalQty.Text = "None";
            // 
            // txtOrderCD
            // 
            this.txtOrderCD.Location = new System.Drawing.Point(120, 70);
            this.txtOrderCD.Name = "txtOrderCD";
            this.txtOrderCD.Size = new System.Drawing.Size(120, 23);
            this.txtOrderCD.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(10, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Order Number";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StockInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 569);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.statusStrip2);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.name = "";
            this.Name = "StockInputForm";
            this.position = "";
            this.Text = "Stock-In";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.StockInputForm_Load);
            this.Controls.SetChildIndex(this.statusStrip2, 0);
            this.Controls.SetChildIndex(this.tc_Main, 0);
            this.pnlOption.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tc_Main.ResumeLayout(false);
            this.tab_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreInput)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tab_Inspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_Print.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintList)).EndInit();
            this.panel7.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tab_Main;
        private System.Windows.Forms.TabPage tab_Inspection;
        private System.Windows.Forms.Button btnManualPacking;
        private System.Windows.Forms.Button btnPremacImport;
        private System.Windows.Forms.Button btnAutoPacking;
        private System.Windows.Forms.DataGridView dgvPreInput;
        private System.Windows.Forms.DataGridView dgvInspection;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnInspection;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tab_Print;
        private System.Windows.Forms.DataGridView dgvPrintList;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPrintBack;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Button btnPrintSelected;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnInsBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManualPrint;
        private System.Windows.Forms.Button btnMainClear;
        private System.Windows.Forms.Button btnInspectionClear;
        private System.Windows.Forms.Button btnPrintClear;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSearchPreInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsRow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsTotalQty;
        private System.Windows.Forms.RadioButton rbtnEven;
        private System.Windows.Forms.RadioButton rbtnOdd;
        private System.Windows.Forms.CheckBox cbCheckDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIncharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemNum;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrderCD;
    }
}