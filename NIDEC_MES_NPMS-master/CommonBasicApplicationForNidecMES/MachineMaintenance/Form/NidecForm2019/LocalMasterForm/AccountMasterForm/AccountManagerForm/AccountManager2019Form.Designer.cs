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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Asset Model");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Asset Type");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Invoice");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Label Status");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Account Code");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Rank");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Section");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Now Location");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Invertory Time");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Valid");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Expired");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Net Value", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Factory");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccountData = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.grt_Option = new Com.Nidec.Mes.Framework.TabControlCommon();
            this.tab_Search = new System.Windows.Forms.TabPage();
            this.trvAsset = new Com.Nidec.Mes.Framework.TreeViewCommon();
            this.trvOther = new Com.Nidec.Mes.Framework.TreeViewCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetName = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetCode = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.tab_depreciation = new System.Windows.Forms.TabPage();
            this.dgvAccountDep = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.dgvRankDep = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.tab_TotalCost = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).BeginInit();
            this.grt_Option.SuspendLayout();
            this.tab_Search.SuspendLayout();
            this.tab_depreciation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankDep)).BeginInit();
            this.tab_TotalCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccCounter)).BeginInit();
            this.pnlButtons1.SuspendLayout();
            this.pnlButtons2.SuspendLayout();
            this.sttStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountData
            // 
            this.dgvAccountData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // grt_Option
            // 
            this.grt_Option.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grt_Option.ControlId = null;
            this.grt_Option.Controls.Add(this.tab_Search);
            this.grt_Option.Controls.Add(this.tab_depreciation);
            this.grt_Option.Controls.Add(this.tab_TotalCost);
            this.grt_Option.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grt_Option.Location = new System.Drawing.Point(0, 107);
            this.grt_Option.Name = "grt_Option";
            this.grt_Option.SelectedIndex = 0;
            this.grt_Option.Size = new System.Drawing.Size(839, 160);
            this.grt_Option.TabIndex = 22;
            // 
            // tab_Search
            // 
            this.tab_Search.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Search.Controls.Add(this.trvAsset);
            this.tab_Search.Controls.Add(this.trvOther);
            this.tab_Search.Controls.Add(this.labelCommon2);
            this.tab_Search.Controls.Add(this.txtAssetName);
            this.tab_Search.Controls.Add(this.labelCommon1);
            this.tab_Search.Controls.Add(this.txtAssetCode);
            this.tab_Search.Location = new System.Drawing.Point(4, 24);
            this.tab_Search.Name = "tab_Search";
            this.tab_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Search.Size = new System.Drawing.Size(831, 132);
            this.tab_Search.TabIndex = 0;
            this.tab_Search.Text = "Search";
            // 
            // trvAsset
            // 
            this.trvAsset.CheckBoxes = true;
            this.trvAsset.ControlId = null;
            this.trvAsset.Dock = System.Windows.Forms.DockStyle.Right;
            this.trvAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvAsset.Location = new System.Drawing.Point(280, 3);
            this.trvAsset.Name = "trvAsset";
            treeNode1.Name = "asset_model";
            treeNode1.Text = "Asset Model";
            treeNode2.Name = "asset_type";
            treeNode2.Text = "Asset Type";
            treeNode3.Name = "asset_invoice";
            treeNode3.Text = "Invoice";
            treeNode4.Name = "label_status";
            treeNode4.Text = "Label Status";
            this.trvAsset.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvAsset.Size = new System.Drawing.Size(294, 126);
            this.trvAsset.TabIndex = 4;
            this.trvAsset.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvAsset_AfterCheck);
            // 
            // trvOther
            // 
            this.trvOther.CheckBoxes = true;
            this.trvOther.ControlId = null;
            this.trvOther.Dock = System.Windows.Forms.DockStyle.Right;
            this.trvOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvOther.Location = new System.Drawing.Point(574, 3);
            this.trvOther.Name = "trvOther";
            treeNode5.Name = "account_cd";
            treeNode5.Text = "Account Code";
            treeNode6.Name = "rank_cd";
            treeNode6.Text = "Rank";
            treeNode7.Name = "account_location_cd";
            treeNode7.Text = "Section";
            treeNode8.Name = "location_cd";
            treeNode8.Text = "Now Location";
            treeNode9.Name = "invertory_time_cd";
            treeNode9.Text = "Invertory Time";
            treeNode10.Name = "valid";
            treeNode10.Text = "Valid";
            treeNode11.Name = "expired";
            treeNode11.Text = "Expired";
            treeNode12.Name = "net_value";
            treeNode12.Text = "Net Value";
            treeNode13.Name = "factory_cd";
            treeNode13.Text = "Factory";
            this.trvOther.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode12,
            treeNode13});
            this.trvOther.Size = new System.Drawing.Size(254, 126);
            this.trvOther.TabIndex = 10;
            this.trvOther.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvOther_AfterCheck);
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
            // tab_depreciation
            // 
            this.tab_depreciation.BackColor = System.Drawing.SystemColors.Control;
            this.tab_depreciation.Controls.Add(this.dgvAccountDep);
            this.tab_depreciation.Controls.Add(this.dgvRankDep);
            this.tab_depreciation.Location = new System.Drawing.Point(4, 24);
            this.tab_depreciation.Name = "tab_depreciation";
            this.tab_depreciation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_depreciation.Size = new System.Drawing.Size(831, 132);
            this.tab_depreciation.TabIndex = 1;
            this.tab_depreciation.Text = "Depreciation";
            // 
            // dgvAccountDep
            // 
            this.dgvAccountDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccountDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDep.ControlId = null;
            this.dgvAccountDep.Location = new System.Drawing.Point(413, 0);
            this.dgvAccountDep.Name = "dgvAccountDep";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountDep.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccountDep.Size = new System.Drawing.Size(418, 132);
            this.dgvAccountDep.TabIndex = 1;
            // 
            // dgvRankDep
            // 
            this.dgvRankDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRankDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRankDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankDep.ControlId = null;
            this.dgvRankDep.Location = new System.Drawing.Point(0, 0);
            this.dgvRankDep.Name = "dgvRankDep";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRankDep.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRankDep.Size = new System.Drawing.Size(407, 132);
            this.dgvRankDep.TabIndex = 0;
            // 
            // tab_TotalCost
            // 
            this.tab_TotalCost.Controls.Add(this.dgvAccCounter);
            this.tab_TotalCost.Location = new System.Drawing.Point(4, 24);
            this.tab_TotalCost.Name = "tab_TotalCost";
            this.tab_TotalCost.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TotalCost.Size = new System.Drawing.Size(831, 132);
            this.tab_TotalCost.TabIndex = 2;
            this.tab_TotalCost.Text = "Total Cost";
            this.tab_TotalCost.UseVisualStyleBackColor = true;
            // 
            // dgvAccCounter
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAccCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccCounter.ControlId = null;
            this.dgvAccCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccCounter.Location = new System.Drawing.Point(3, 3);
            this.dgvAccCounter.Name = "dgvAccCounter";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAccCounter.Size = new System.Drawing.Size(825, 126);
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
            this.pnlButtons1.Location = new System.Drawing.Point(4, 270);
            this.pnlButtons1.Name = "pnlButtons1";
            this.pnlButtons1.Size = new System.Drawing.Size(465, 49);
            this.pnlButtons1.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ControlId = null;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClear.Location = new System.Drawing.Point(372, 3);
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
            this.btnExport.Location = new System.Drawing.Point(280, 3);
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
            this.btnUpdate.Location = new System.Drawing.Point(187, 3);
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
            this.btnAdd.Location = new System.Drawing.Point(95, 3);
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
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
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
            this.pnlButtons2.Location = new System.Drawing.Point(475, 270);
            this.pnlButtons2.Name = "pnlButtons2";
            this.pnlButtons2.Size = new System.Drawing.Size(187, 49);
            this.pnlButtons2.TabIndex = 24;
            // 
            // btnTransferAsset
            // 
            this.btnTransferAsset.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransferAsset.ControlId = null;
            this.btnTransferAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnTransferAsset.Location = new System.Drawing.Point(95, 3);
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
            this.btnDepreciation.Location = new System.Drawing.Point(3, 4);
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
            this.btnClose.Location = new System.Drawing.Point(668, 274);
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
            // AccountManager2019Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 533);
            this.Controls.Add(this.sttStrip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlButtons2);
            this.Controls.Add(this.pnlButtons1);
            this.Controls.Add(this.grt_Option);
            this.Controls.Add(this.dgvAccountData);
            this.Name = "AccountManager2019Form";
            this.Text = "Account Manager";
            this.TitleText = "Account Manager";
            this.Load += new System.EventHandler(this.AccountManager2019Form_Load);
            this.Controls.SetChildIndex(this.dgvAccountData, 0);
            this.Controls.SetChildIndex(this.grt_Option, 0);
            this.Controls.SetChildIndex(this.pnlButtons1, 0);
            this.Controls.SetChildIndex(this.pnlButtons2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.sttStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).EndInit();
            this.grt_Option.ResumeLayout(false);
            this.tab_Search.ResumeLayout(false);
            this.tab_Search.PerformLayout();
            this.tab_depreciation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankDep)).EndInit();
            this.tab_TotalCost.ResumeLayout(false);
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
        private Framework.TabControlCommon grt_Option;
        private System.Windows.Forms.TabPage tab_Search;
        private Framework.LabelCommon labelCommon2;
        private Framework.TextBoxCommon txtAssetName;
        private Framework.TreeViewCommon trvAsset;
        private Framework.LabelCommon labelCommon1;
        private Framework.TextBoxCommon txtAssetCode;
        private System.Windows.Forms.TabPage tab_depreciation;
        private Framework.PanelCommon pnlButtons1;
        private Framework.ButtonCommon btnClear;
        private Framework.ButtonCommon btnUpdate;
        private Framework.ButtonCommon btnAdd;
        private Framework.ButtonCommon btnSearch;
        private Framework.PanelCommon pnlButtons2;
        private Framework.ButtonCommon btnExport;
        private Framework.ButtonCommon btnDepreciation;
        private System.Windows.Forms.TabPage tab_TotalCost;
        private Framework.DataGridViewCommon dgvAccCounter;
        private Framework.ButtonCommon btnTransferAsset;
        private Framework.ButtonCommon btnClose;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsRowCounter;
        private Framework.TreeViewCommon trvOther;
        private Framework.DataGridViewCommon dgvAccountDep;
        private Framework.DataGridViewCommon dgvRankDep;
    }
}