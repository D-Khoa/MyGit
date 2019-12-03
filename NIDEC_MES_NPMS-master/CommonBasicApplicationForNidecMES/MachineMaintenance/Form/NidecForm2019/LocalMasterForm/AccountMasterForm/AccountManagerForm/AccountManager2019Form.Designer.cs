namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    partial class AccountManager2019Form
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Asset Model");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Asset Type");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Invoice");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Label Status");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Account Code");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Rank");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Section");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Now Location");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Invertory Time");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Valid");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Expired");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Net Value", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Factory");
            this.dgvAccountData = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.grt_Search = new Com.Nidec.Mes.Framework.TabControlCommon();
            this.tab_Asset = new System.Windows.Forms.TabPage();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetName = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.trvAsset = new Com.Nidec.Mes.Framework.TreeViewCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetCode = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.tab_Account = new System.Windows.Forms.TabPage();
            this.tab_Counter = new System.Windows.Forms.TabPage();
            this.dgvAccCounter = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.pnlButtons1 = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnClear = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnExport = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnUpdate = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAdd = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnSearch = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.pnlButtons2 = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnTransferAsset = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnDepreciation = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnClose = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.sttStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRowCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.trvOther = new Com.Nidec.Mes.Framework.TreeViewCommon();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).BeginInit();
            this.grt_Search.SuspendLayout();
            this.tab_Asset.SuspendLayout();
            this.tab_Counter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccCounter)).BeginInit();
            this.pnlButtons1.SuspendLayout();
            this.pnlButtons2.SuspendLayout();
            this.sttStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountData.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccountData.Location = new System.Drawing.Point(0, 325);
            this.dgvAccountData.Name = "dgvAccountData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccountData.Size = new System.Drawing.Size(835, 196);
            this.dgvAccountData.TabIndex = 21;
            // 
            // grt_Search
            // 
            this.grt_Search.ControlId = null;
            this.grt_Search.Controls.Add(this.tab_Asset);
            this.grt_Search.Controls.Add(this.tab_Account);
            this.grt_Search.Controls.Add(this.tab_Counter);
            this.grt_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grt_Search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grt_Search.Location = new System.Drawing.Point(0, 107);
            this.grt_Search.Name = "grt_Search";
            this.grt_Search.SelectedIndex = 0;
            this.grt_Search.Size = new System.Drawing.Size(839, 143);
            this.grt_Search.TabIndex = 22;
            // 
            // tab_Asset
            // 
            this.tab_Asset.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Asset.Controls.Add(this.trvOther);
            this.tab_Asset.Controls.Add(this.labelCommon2);
            this.tab_Asset.Controls.Add(this.txtAssetName);
            this.tab_Asset.Controls.Add(this.trvAsset);
            this.tab_Asset.Controls.Add(this.labelCommon1);
            this.tab_Asset.Controls.Add(this.txtAssetCode);
            this.tab_Asset.Location = new System.Drawing.Point(4, 24);
            this.tab_Asset.Name = "tab_Asset";
            this.tab_Asset.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Asset.Size = new System.Drawing.Size(831, 115);
            this.tab_Asset.TabIndex = 0;
            this.tab_Asset.Text = "Asset";
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon2.Location = new System.Drawing.Point(6, 42);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(75, 15);
            this.labelCommon2.TabIndex = 9;
            this.labelCommon2.Text = "Asset Name";
            // 
            // txtAssetName
            // 
            this.txtAssetName.ControlId = null;
            this.txtAssetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetName.Location = new System.Drawing.Point(83, 39);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(187, 21);
            this.txtAssetName.TabIndex = 8;
            // 
            // trvAsset
            // 
            this.trvAsset.CheckBoxes = true;
            this.trvAsset.ControlId = null;
            this.trvAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvAsset.Location = new System.Drawing.Point(529, 6);
            this.trvAsset.Name = "trvAsset";
            treeNode10.Name = "asset_model";
            treeNode10.Text = "Asset Model";
            treeNode11.Name = "asset_type";
            treeNode11.Text = "Asset Type";
            treeNode12.Name = "asset_invoice";
            treeNode12.Text = "Invoice";
            treeNode13.Name = "label_status";
            treeNode13.Text = "Label Status";
            this.trvAsset.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.trvAsset.Size = new System.Drawing.Size(294, 97);
            this.trvAsset.TabIndex = 4;
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(6, 15);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(71, 15);
            this.labelCommon1.TabIndex = 2;
            this.labelCommon1.Text = "Asset Code";
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.ControlId = null;
            this.txtAssetCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetCode.Location = new System.Drawing.Point(83, 12);
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.Size = new System.Drawing.Size(187, 21);
            this.txtAssetCode.TabIndex = 1;
            this.txtAssetCode.TextChanged += new System.EventHandler(this.txtAssetCode_TextChanged);
            // 
            // tab_Account
            // 
            this.tab_Account.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Account.Location = new System.Drawing.Point(4, 24);
            this.tab_Account.Name = "tab_Account";
            this.tab_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Account.Size = new System.Drawing.Size(831, 115);
            this.tab_Account.TabIndex = 1;
            this.tab_Account.Text = "Account";
            // 
            // tab_Counter
            // 
            this.tab_Counter.Controls.Add(this.dgvAccCounter);
            this.tab_Counter.Location = new System.Drawing.Point(4, 24);
            this.tab_Counter.Name = "tab_Counter";
            this.tab_Counter.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Counter.Size = new System.Drawing.Size(831, 115);
            this.tab_Counter.TabIndex = 2;
            this.tab_Counter.Text = "Account Counter";
            this.tab_Counter.UseVisualStyleBackColor = true;
            // 
            // dgvAccCounter
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccCounter.ControlId = null;
            this.dgvAccCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccCounter.Location = new System.Drawing.Point(3, 3);
            this.dgvAccCounter.Name = "dgvAccCounter";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccCounter.Size = new System.Drawing.Size(825, 109);
            this.dgvAccCounter.TabIndex = 0;
            // 
            // pnlButtons1
            // 
            this.pnlButtons1.ControlId = null;
            this.pnlButtons1.Controls.Add(this.btnClear);
            this.pnlButtons1.Controls.Add(this.btnExport);
            this.pnlButtons1.Controls.Add(this.btnUpdate);
            this.pnlButtons1.Controls.Add(this.btnAdd);
            this.pnlButtons1.Controls.Add(this.btnSearch);
            this.pnlButtons1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons1.Location = new System.Drawing.Point(4, 252);
            this.pnlButtons1.Name = "pnlButtons1";
            this.pnlButtons1.Size = new System.Drawing.Size(490, 67);
            this.pnlButtons1.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ControlId = null;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClear.Location = new System.Drawing.Point(388, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.ControlId = null;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExport.Location = new System.Drawing.Point(293, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 40);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ControlId = null;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(198, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 40);
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
            this.btnAdd.Location = new System.Drawing.Point(103, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 40);
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
            this.btnSearch.Location = new System.Drawing.Point(8, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 40);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlButtons2
            // 
            this.pnlButtons2.ControlId = null;
            this.pnlButtons2.Controls.Add(this.btnTransferAsset);
            this.pnlButtons2.Controls.Add(this.btnDepreciation);
            this.pnlButtons2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons2.Location = new System.Drawing.Point(500, 252);
            this.pnlButtons2.Name = "pnlButtons2";
            this.pnlButtons2.Size = new System.Drawing.Size(209, 67);
            this.pnlButtons2.TabIndex = 24;
            // 
            // btnTransferAsset
            // 
            this.btnTransferAsset.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransferAsset.ControlId = null;
            this.btnTransferAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnTransferAsset.Location = new System.Drawing.Point(111, 18);
            this.btnTransferAsset.Name = "btnTransferAsset";
            this.btnTransferAsset.Size = new System.Drawing.Size(86, 40);
            this.btnTransferAsset.TabIndex = 2;
            this.btnTransferAsset.Text = "Transfer Asset";
            this.btnTransferAsset.UseVisualStyleBackColor = false;
            this.btnTransferAsset.Click += new System.EventHandler(this.btnTransferAsset_Click);
            // 
            // btnDepreciation
            // 
            this.btnDepreciation.BackColor = System.Drawing.SystemColors.Control;
            this.btnDepreciation.ControlId = null;
            this.btnDepreciation.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDepreciation.Location = new System.Drawing.Point(13, 18);
            this.btnDepreciation.Name = "btnDepreciation";
            this.btnDepreciation.Size = new System.Drawing.Size(86, 40);
            this.btnDepreciation.TabIndex = 0;
            this.btnDepreciation.Text = "Depreciation";
            this.btnDepreciation.UseVisualStyleBackColor = false;
            this.btnDepreciation.Click += new System.EventHandler(this.btnDepreciation_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.ControlId = null;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClose.Location = new System.Drawing.Point(730, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sttStrip
            // 
            this.sttStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsRowCounter});
            this.sttStrip.Location = new System.Drawing.Point(0, 511);
            this.sttStrip.Name = "sttStrip";
            this.sttStrip.Size = new System.Drawing.Size(839, 22);
            this.sttStrip.TabIndex = 26;
            this.sttStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(788, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tsRowCounter
            // 
            this.tsRowCounter.Name = "tsRowCounter";
            this.tsRowCounter.Size = new System.Drawing.Size(36, 17);
            this.tsRowCounter.Text = "None";
            // 
            // trvOther
            // 
            this.trvOther.CheckBoxes = true;
            this.trvOther.ControlId = null;
            this.trvOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvOther.Location = new System.Drawing.Point(322, 9);
            this.trvOther.Name = "trvOther";
            treeNode1.Name = "account_cd";
            treeNode1.Text = "Account Code";
            treeNode2.Name = "rank_cd";
            treeNode2.Text = "Rank";
            treeNode3.Name = "account_location_cd";
            treeNode3.Text = "Section";
            treeNode4.Name = "location_cd";
            treeNode4.Text = "Now Location";
            treeNode5.Name = "invertory_time";
            treeNode5.Text = "Invertory Time";
            treeNode6.Name = "valid";
            treeNode6.Text = "Valid";
            treeNode7.Name = "expired";
            treeNode7.Text = "Expired";
            treeNode8.Name = "net_value";
            treeNode8.Text = "Net Value";
            treeNode9.Name = "factory";
            treeNode9.Text = "Factory";
            this.trvOther.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode8,
            treeNode9});
            this.trvOther.Size = new System.Drawing.Size(186, 97);
            this.trvOther.TabIndex = 10;
            // 
            // AccountManager2019Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 533);
            this.Controls.Add(this.sttStrip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlButtons2);
            this.Controls.Add(this.pnlButtons1);
            this.Controls.Add(this.grt_Search);
            this.Controls.Add(this.dgvAccountData);
            this.Name = "AccountManager2019Form";
            this.Text = "Account Manager";
            this.TitleText = "Account Manager";
            this.Load += new System.EventHandler(this.AccountManager2019Form_Load);
            this.Controls.SetChildIndex(this.dgvAccountData, 0);
            this.Controls.SetChildIndex(this.grt_Search, 0);
            this.Controls.SetChildIndex(this.pnlButtons1, 0);
            this.Controls.SetChildIndex(this.pnlButtons2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.sttStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).EndInit();
            this.grt_Search.ResumeLayout(false);
            this.tab_Asset.ResumeLayout(false);
            this.tab_Asset.PerformLayout();
            this.tab_Counter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccCounter)).EndInit();
            this.pnlButtons1.ResumeLayout(false);
            this.pnlButtons2.ResumeLayout(false);
            this.sttStrip.ResumeLayout(false);
            this.sttStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.DataGridViewCommon dgvAccountData;
        private Framework.TabControlCommon grt_Search;
        private System.Windows.Forms.TabPage tab_Asset;
        private Framework.LabelCommon labelCommon2;
        private Framework.TextBoxCommon txtAssetName;
        private Framework.TreeViewCommon trvAsset;
        private Framework.LabelCommon labelCommon1;
        private Framework.TextBoxCommon txtAssetCode;
        private System.Windows.Forms.TabPage tab_Account;
        private Framework.PanelCommon pnlButtons1;
        private Framework.ButtonCommon btnClear;
        private Framework.ButtonCommon btnUpdate;
        private Framework.ButtonCommon btnAdd;
        private Framework.ButtonCommon btnSearch;
        private Framework.PanelCommon pnlButtons2;
        private Framework.ButtonCommon btnExport;
        private Framework.ButtonCommon btnDepreciation;
        private System.Windows.Forms.TabPage tab_Counter;
        private Framework.DataGridViewCommon dgvAccCounter;
        private Framework.ButtonCommon btnTransferAsset;
        private Framework.ButtonCommon btnClose;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsRowCounter;
        private Framework.TreeViewCommon trvOther;
    }
}