namespace PC_QRCodeSystem.View
{
    partial class StockDetailForm
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
            this.tc_MainStockDetail = new System.Windows.Forms.TabControl();
            this.tab_StockDetail = new System.Windows.Forms.TabPage();
            this.dgvStockDetail = new System.Windows.Forms.DataGridView();
            this.dgvItemInfo = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPackingQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStockInQty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPackingCD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbItemTypeName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierCD = new System.Windows.Forms.TextBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSearchDate = new System.Windows.Forms.CheckBox();
            this.lbSupplierName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbInchagre = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.txtInCharge = new System.Windows.Forms.TextBox();
            this.txtItemCD = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_LogDetail = new System.Windows.Forms.TabPage();
            this.dgvLogDetail = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.smenuStockDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuLogDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStockDetailRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.tc_MainStockDetail.SuspendLayout();
            this.tab_StockDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_LogDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogDetail)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_MainStockDetail
            // 
            this.tc_MainStockDetail.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_MainStockDetail.Controls.Add(this.tab_StockDetail);
            this.tc_MainStockDetail.Controls.Add(this.tab_LogDetail);
            this.tc_MainStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_MainStockDetail.Location = new System.Drawing.Point(150, 70);
            this.tc_MainStockDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tc_MainStockDetail.Name = "tc_MainStockDetail";
            this.tc_MainStockDetail.SelectedIndex = 0;
            this.tc_MainStockDetail.Size = new System.Drawing.Size(834, 468);
            this.tc_MainStockDetail.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_MainStockDetail.TabIndex = 2;
            // 
            // tab_StockDetail
            // 
            this.tab_StockDetail.Controls.Add(this.dgvStockDetail);
            this.tab_StockDetail.Controls.Add(this.dgvItemInfo);
            this.tab_StockDetail.Controls.Add(this.panel5);
            this.tab_StockDetail.Controls.Add(this.panel4);
            this.tab_StockDetail.Location = new System.Drawing.Point(4, 28);
            this.tab_StockDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tab_StockDetail.Name = "tab_StockDetail";
            this.tab_StockDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tab_StockDetail.Size = new System.Drawing.Size(826, 436);
            this.tab_StockDetail.TabIndex = 0;
            this.tab_StockDetail.Text = "Stock Detail";
            this.tab_StockDetail.UseVisualStyleBackColor = true;
            // 
            // dgvStockDetail
            // 
            this.dgvStockDetail.AllowUserToAddRows = false;
            this.dgvStockDetail.AllowUserToDeleteRows = false;
            this.dgvStockDetail.AllowUserToResizeRows = false;
            this.dgvStockDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockDetail.Location = new System.Drawing.Point(4, 334);
            this.dgvStockDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStockDetail.MultiSelect = false;
            this.dgvStockDetail.Name = "dgvStockDetail";
            this.dgvStockDetail.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStockDetail.Size = new System.Drawing.Size(818, 98);
            this.dgvStockDetail.TabIndex = 3;
            this.dgvStockDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockDetail_CellClick);
            this.dgvStockDetail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStockDetail_DataBindingComplete);
            // 
            // dgvItemInfo
            // 
            this.dgvItemInfo.AllowUserToAddRows = false;
            this.dgvItemInfo.AllowUserToDeleteRows = false;
            this.dgvItemInfo.AllowUserToResizeRows = false;
            this.dgvItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvItemInfo.Location = new System.Drawing.Point(4, 264);
            this.dgvItemInfo.MultiSelect = false;
            this.dgvItemInfo.Name = "dgvItemInfo";
            this.dgvItemInfo.ReadOnly = true;
            this.dgvItemInfo.RowHeadersVisible = false;
            this.dgvItemInfo.Size = new System.Drawing.Size(818, 70);
            this.dgvItemInfo.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnPrintPreview);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.btnExport);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 204);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 60);
            this.panel5.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(140, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(250, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(580, 5);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(100, 50);
            this.btnPrintPreview.TabIndex = 22;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(470, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 50);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(690, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(30, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(360, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 50);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPackingQty);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtStockInQty);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtPackingCD);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lbItemTypeName);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtSupplierCD);
            this.panel4.Controls.Add(this.txtOrderNo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbSearchDate);
            this.panel4.Controls.Add(this.lbSupplierName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lbInchagre);
            this.panel4.Controls.Add(this.txtInvoice);
            this.panel4.Controls.Add(this.txtInCharge);
            this.panel4.Controls.Add(this.txtItemCD);
            this.panel4.Controls.Add(this.dtpToDate);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.dtpFromDate);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbItemName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(818, 200);
            this.panel4.TabIndex = 0;
            // 
            // txtPackingQty
            // 
            this.txtPackingQty.Location = new System.Drawing.Point(370, 160);
            this.txtPackingQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackingQty.Name = "txtPackingQty";
            this.txtPackingQty.Size = new System.Drawing.Size(150, 22);
            this.txtPackingQty.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(260, 160);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 25);
            this.label16.TabIndex = 45;
            this.label16.Text = "Packing Q\'ty";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockInQty
            // 
            this.txtStockInQty.Location = new System.Drawing.Point(120, 160);
            this.txtStockInQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockInQty.Name = "txtStockInQty";
            this.txtStockInQty.Size = new System.Drawing.Size(120, 22);
            this.txtStockInQty.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 25);
            this.label15.TabIndex = 43;
            this.label15.Text = "Stock-In Q\'ty";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPackingCD
            // 
            this.txtPackingCD.Location = new System.Drawing.Point(370, 130);
            this.txtPackingCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackingCD.Name = "txtPackingCD";
            this.txtPackingCD.Size = new System.Drawing.Size(150, 22);
            this.txtPackingCD.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(280, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = "Packing";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "User Code";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbItemTypeName
            // 
            this.lbItemTypeName.BackColor = System.Drawing.SystemColors.Control;
            this.lbItemTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemTypeName.Location = new System.Drawing.Point(370, 100);
            this.lbItemTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemTypeName.Name = "lbItemTypeName";
            this.lbItemTypeName.Size = new System.Drawing.Size(150, 25);
            this.lbItemTypeName.TabIndex = 39;
            this.lbItemTypeName.Text = "Item Type Name";
            this.lbItemTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(280, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Item Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierCD
            // 
            this.txtSupplierCD.Location = new System.Drawing.Point(120, 40);
            this.txtSupplierCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierCD.Name = "txtSupplierCD";
            this.txtSupplierCD.Size = new System.Drawing.Size(150, 22);
            this.txtSupplierCD.TabIndex = 6;
            this.txtSupplierCD.TextChanged += new System.EventHandler(this.txtSupplierCD_TextChanged);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(120, 130);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(150, 22);
            this.txtOrderNo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Order No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSearchDate
            // 
            this.cbSearchDate.Location = new System.Drawing.Point(530, 130);
            this.cbSearchDate.Name = "cbSearchDate";
            this.cbSearchDate.Size = new System.Drawing.Size(110, 20);
            this.cbSearchDate.TabIndex = 13;
            this.cbSearchDate.Text = "Stock-In Date";
            this.cbSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSearchDate.UseVisualStyleBackColor = true;
            // 
            // lbSupplierName
            // 
            this.lbSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.lbSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplierName.Location = new System.Drawing.Point(300, 40);
            this.lbSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSupplierName.Name = "lbSupplierName";
            this.lbSupplierName.Size = new System.Drawing.Size(470, 25);
            this.lbSupplierName.TabIndex = 33;
            this.lbSupplierName.Text = "Supplier Name";
            this.lbSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Invoice";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbInchagre
            // 
            this.lbInchagre.BackColor = System.Drawing.SystemColors.Control;
            this.lbInchagre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInchagre.Location = new System.Drawing.Point(300, 70);
            this.lbInchagre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInchagre.Name = "lbInchagre";
            this.lbInchagre.Size = new System.Drawing.Size(470, 25);
            this.lbInchagre.TabIndex = 29;
            this.lbInchagre.Text = "User In Charge";
            this.lbInchagre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(120, 100);
            this.txtInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(150, 22);
            this.txtInvoice.TabIndex = 8;
            // 
            // txtInCharge
            // 
            this.txtInCharge.Location = new System.Drawing.Point(120, 70);
            this.txtInCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtInCharge.Name = "txtInCharge";
            this.txtInCharge.Size = new System.Drawing.Size(150, 22);
            this.txtInCharge.TabIndex = 7;
            this.txtInCharge.TextChanged += new System.EventHandler(this.txtInCharge_TextChanged);
            // 
            // txtItemCD
            // 
            this.txtItemCD.Location = new System.Drawing.Point(120, 10);
            this.txtItemCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCD.Name = "txtItemCD";
            this.txtItemCD.Size = new System.Drawing.Size(150, 22);
            this.txtItemCD.TabIndex = 5;
            this.txtItemCD.TextChanged += new System.EventHandler(this.txtItemCD_TextChanged);
            this.txtItemCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCD_KeyDown);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(650, 160);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 22);
            this.dtpToDate.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(530, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "To Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(650, 130);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 22);
            this.dtpFromDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Supplier Code";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbItemName
            // 
            this.lbItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.Location = new System.Drawing.Point(300, 10);
            this.lbItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(470, 25);
            this.lbItemName.TabIndex = 5;
            this.lbItemName.Text = "Item Name";
            this.lbItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_LogDetail
            // 
            this.tab_LogDetail.Controls.Add(this.dgvLogDetail);
            this.tab_LogDetail.Location = new System.Drawing.Point(4, 28);
            this.tab_LogDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tab_LogDetail.Name = "tab_LogDetail";
            this.tab_LogDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tab_LogDetail.Size = new System.Drawing.Size(826, 436);
            this.tab_LogDetail.TabIndex = 1;
            this.tab_LogDetail.Text = "Logs Detail";
            this.tab_LogDetail.UseVisualStyleBackColor = true;
            // 
            // dgvLogDetail
            // 
            this.dgvLogDetail.AllowUserToAddRows = false;
            this.dgvLogDetail.AllowUserToDeleteRows = false;
            this.dgvLogDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogDetail.Location = new System.Drawing.Point(4, 4);
            this.dgvLogDetail.Name = "dgvLogDetail";
            this.dgvLogDetail.ReadOnly = true;
            this.dgvLogDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLogDetail.Size = new System.Drawing.Size(818, 428);
            this.dgvLogDetail.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "User Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "In Charge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tsStockDetailRows});
            this.statusStrip1.Location = new System.Drawing.Point(150, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 24);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuStockDetail,
            this.smenuLogDetail});
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(51, 22);
            this.tsMenu.Text = "Menu";
            // 
            // smenuStockDetail
            // 
            this.smenuStockDetail.Name = "smenuStockDetail";
            this.smenuStockDetail.Size = new System.Drawing.Size(136, 22);
            this.smenuStockDetail.Text = "Stock Detail";
            this.smenuStockDetail.Click += new System.EventHandler(this.smenuStockDetail_Click);
            // 
            // smenuLogDetail
            // 
            this.smenuLogDetail.Name = "smenuLogDetail";
            this.smenuLogDetail.Size = new System.Drawing.Size(136, 22);
            this.smenuLogDetail.Text = "Logs Detail";
            this.smenuLogDetail.Click += new System.EventHandler(this.smenuLogDetail_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(687, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel2.Text = "Rows :";
            // 
            // tsStockDetailRows
            // 
            this.tsStockDetailRows.Name = "tsStockDetailRows";
            this.tsStockDetailRows.Size = new System.Drawing.Size(36, 19);
            this.tsStockDetailRows.Text = "None";
            // 
            // StockDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tc_MainStockDetail);
            this.Controls.Add(this.statusStrip1);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.name = "";
            this.Name = "StockDetailForm";
            this.position = "";
            this.Text = "StockDetailForm";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.StockDetailForm_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.tc_MainStockDetail, 0);
            this.tc_MainStockDetail.ResumeLayout(false);
            this.tab_StockDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_LogDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogDetail)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_MainStockDetail;
        private System.Windows.Forms.TabPage tab_StockDetail;
        private System.Windows.Forms.TabPage tab_LogDetail;
        private System.Windows.Forms.DataGridView dgvStockDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbInchagre;
        private System.Windows.Forms.TextBox txtInCharge;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.TextBox txtItemCD;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSupplierName;
        private System.Windows.Forms.CheckBox cbSearchDate;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplierCD;
        private System.Windows.Forms.DataGridView dgvItemInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Label lbItemTypeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPackingCD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPackingQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStockInQty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsStockDetailRows;
        private System.Windows.Forms.DataGridView dgvLogDetail;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem smenuStockDetail;
        private System.Windows.Forms.ToolStripMenuItem smenuLogDetail;
    }
}