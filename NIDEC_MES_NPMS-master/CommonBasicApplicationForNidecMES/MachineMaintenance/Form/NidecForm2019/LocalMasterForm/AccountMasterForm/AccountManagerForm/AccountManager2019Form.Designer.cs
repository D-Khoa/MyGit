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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Inventory Time");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Valid");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Expired");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Net Value", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Factory");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Unit");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvDeprCalc = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.tab_TotalCost = new System.Windows.Forms.TabPage();
            this.dgvAccCounter = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.aquisition_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_depr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_depr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accum_depr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoried = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons1 = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnClear = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnExport = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnUpdate = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAdd = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnSearch = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.pnlButtons2 = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnRankDepr = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnTransferAsset = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAccDepr = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnClose = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.sttStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRowCounter = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).BeginInit();
            this.grt_Option.SuspendLayout();
            this.tab_Search.SuspendLayout();
            this.tab_depreciation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeprCalc)).BeginInit();
            this.tab_TotalCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccCounter)).BeginInit();
            this.pnlButtons1.SuspendLayout();
            this.pnlButtons2.SuspendLayout();
            this.sttStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountData
            // 
            this.dgvAccountData.AllowUserToAddRows = false;
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
            this.dgvAccountData.Location = new System.Drawing.Point(0, 355);
            this.dgvAccountData.Name = "dgvAccountData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccountData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvAccountData.Size = new System.Drawing.Size(835, 153);
            this.dgvAccountData.TabIndex = 21;
            this.dgvAccountData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountData_CellClick);
            this.dgvAccountData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccountData_CellFormatting);
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
            this.grt_Option.Location = new System.Drawing.Point(0, 110);
            this.grt_Option.Name = "grt_Option";
            this.grt_Option.SelectedIndex = 0;
            this.grt_Option.Size = new System.Drawing.Size(839, 187);
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
            this.tab_Search.Size = new System.Drawing.Size(831, 159);
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
            this.trvAsset.Size = new System.Drawing.Size(294, 153);
            this.trvAsset.TabIndex = 3;
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
            treeNode9.Text = "Inventory Time";
            treeNode10.Name = "valid";
            treeNode10.Text = "Valid";
            treeNode11.Name = "expired";
            treeNode11.Text = "Expired";
            treeNode12.Name = "net_value";
            treeNode12.Text = "Net Value";
            treeNode13.Name = "factory_cd";
            treeNode13.Text = "Factory";
            treeNode14.Name = "unit_cd";
            treeNode14.Text = "Unit";
            this.trvOther.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode14});
            this.trvOther.Size = new System.Drawing.Size(254, 153);
            this.trvOther.TabIndex = 4;
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
            this.txtAssetName.TabIndex = 2;
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
            this.tab_depreciation.Controls.Add(this.dgvDeprCalc);
            this.tab_depreciation.Location = new System.Drawing.Point(4, 24);
            this.tab_depreciation.Name = "tab_depreciation";
            this.tab_depreciation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_depreciation.Size = new System.Drawing.Size(831, 159);
            this.tab_depreciation.TabIndex = 1;
            this.tab_depreciation.Text = "Depreciation";
            // 
            // dgvDeprCalc
            // 
            this.dgvDeprCalc.AllowUserToAddRows = false;
            this.dgvDeprCalc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeprCalc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeprCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeprCalc.ControlId = null;
            this.dgvDeprCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeprCalc.Location = new System.Drawing.Point(3, 3);
            this.dgvDeprCalc.Name = "dgvDeprCalc";
            this.dgvDeprCalc.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeprCalc.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDeprCalc.Size = new System.Drawing.Size(825, 153);
            this.dgvDeprCalc.TabIndex = 0;
            // 
            // tab_TotalCost
            // 
            this.tab_TotalCost.Controls.Add(this.dgvAccCounter);
            this.tab_TotalCost.Location = new System.Drawing.Point(4, 24);
            this.tab_TotalCost.Name = "tab_TotalCost";
            this.tab_TotalCost.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TotalCost.Size = new System.Drawing.Size(831, 159);
            this.tab_TotalCost.TabIndex = 2;
            this.tab_TotalCost.Text = "Total Cost";
            this.tab_TotalCost.UseVisualStyleBackColor = true;
            // 
            // dgvAccCounter
            // 
            this.dgvAccCounter.AllowUserToAddRows = false;
            this.dgvAccCounter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvAccCounter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAccCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aquisition_cost,
            this.month_depr,
            this.curr_depr,
            this.accum_depr,
            this.net_value,
            this.inventoried,
            this.total_machine});
            this.dgvAccCounter.ControlId = null;
            this.dgvAccCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccCounter.Location = new System.Drawing.Point(3, 3);
            this.dgvAccCounter.Name = "dgvAccCounter";
            this.dgvAccCounter.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccCounter.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAccCounter.Size = new System.Drawing.Size(825, 153);
            this.dgvAccCounter.TabIndex = 0;
            // 
            // aquisition_cost
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = null;
            this.aquisition_cost.DefaultCellStyle = dataGridViewCellStyle8;
            this.aquisition_cost.HeaderText = "Aquisition Cost ($)";
            this.aquisition_cost.Name = "aquisition_cost";
            this.aquisition_cost.ReadOnly = true;
            // 
            // month_depr
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = null;
            this.month_depr.DefaultCellStyle = dataGridViewCellStyle9;
            this.month_depr.HeaderText = "Monthly Depreception ($)";
            this.month_depr.Name = "month_depr";
            this.month_depr.ReadOnly = true;
            // 
            // curr_depr
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = null;
            this.curr_depr.DefaultCellStyle = dataGridViewCellStyle10;
            this.curr_depr.HeaderText = "Current Depreception ($)";
            this.curr_depr.Name = "curr_depr";
            this.curr_depr.ReadOnly = true;
            // 
            // accum_depr
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = null;
            this.accum_depr.DefaultCellStyle = dataGridViewCellStyle11;
            this.accum_depr.HeaderText = "Accum Depreception ($)";
            this.accum_depr.Name = "accum_depr";
            this.accum_depr.ReadOnly = true;
            // 
            // net_value
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N3";
            dataGridViewCellStyle12.NullValue = null;
            this.net_value.DefaultCellStyle = dataGridViewCellStyle12;
            this.net_value.HeaderText = "Netbooks ($)";
            this.net_value.Name = "net_value";
            this.net_value.ReadOnly = true;
            // 
            // inventoried
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.inventoried.DefaultCellStyle = dataGridViewCellStyle13;
            this.inventoried.HeaderText = "Inventoried(Qty)";
            this.inventoried.Name = "inventoried";
            this.inventoried.ReadOnly = true;
            // 
            // total_machine
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_machine.DefaultCellStyle = dataGridViewCellStyle14;
            this.total_machine.HeaderText = "Total Machine(Qty)";
            this.total_machine.Name = "total_machine";
            this.total_machine.ReadOnly = true;
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
            this.pnlButtons1.Location = new System.Drawing.Point(4, 300);
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
            this.btnClear.TabIndex = 9;
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
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ControlId = null;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(187, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 40);
            this.btnUpdate.TabIndex = 7;
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
            this.btnAdd.TabIndex = 6;
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
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlButtons2
            // 
            this.pnlButtons2.ControlId = null;
            this.pnlButtons2.Controls.Add(this.btnRankDepr);
            this.pnlButtons2.Controls.Add(this.btnTransferAsset);
            this.pnlButtons2.Controls.Add(this.btnAccDepr);
            this.pnlButtons2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons2.Location = new System.Drawing.Point(475, 300);
            this.pnlButtons2.Name = "pnlButtons2";
            this.pnlButtons2.Size = new System.Drawing.Size(268, 49);
            this.pnlButtons2.TabIndex = 24;
            // 
            // btnRankDepr
            // 
            this.btnRankDepr.BackColor = System.Drawing.SystemColors.Control;
            this.btnRankDepr.ControlId = null;
            this.btnRankDepr.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRankDepr.Location = new System.Drawing.Point(91, 4);
            this.btnRankDepr.Name = "btnRankDepr";
            this.btnRankDepr.Size = new System.Drawing.Size(86, 40);
            this.btnRankDepr.TabIndex = 11;
            this.btnRankDepr.Text = "Rank Depr";
            this.btnRankDepr.UseVisualStyleBackColor = false;
            this.btnRankDepr.Click += new System.EventHandler(this.btnRankDepr_Click);
            // 
            // btnTransferAsset
            // 
            this.btnTransferAsset.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransferAsset.ControlId = null;
            this.btnTransferAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnTransferAsset.Location = new System.Drawing.Point(179, 3);
            this.btnTransferAsset.Name = "btnTransferAsset";
            this.btnTransferAsset.Size = new System.Drawing.Size(86, 40);
            this.btnTransferAsset.TabIndex = 12;
            this.btnTransferAsset.Text = "Transfer Asset";
            this.btnTransferAsset.UseVisualStyleBackColor = false;
            this.btnTransferAsset.Click += new System.EventHandler(this.btnTransferAsset_Click);
            // 
            // btnAccDepr
            // 
            this.btnAccDepr.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccDepr.ControlId = null;
            this.btnAccDepr.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAccDepr.Location = new System.Drawing.Point(3, 4);
            this.btnAccDepr.Name = "btnAccDepr";
            this.btnAccDepr.Size = new System.Drawing.Size(86, 40);
            this.btnAccDepr.TabIndex = 10;
            this.btnAccDepr.Text = "Account Depr";
            this.btnAccDepr.UseVisualStyleBackColor = false;
            this.btnAccDepr.Click += new System.EventHandler(this.btnAccDepr_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.ControlId = null;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClose.Location = new System.Drawing.Point(746, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 40);
            this.btnClose.TabIndex = 13;
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
            this.Controls.Add(this.dgvAccountData);
            this.Controls.Add(this.grt_Option);
            this.Name = "AccountManager2019Form";
            this.Text = "Account Manager";
            this.TitleText = "Account Manager";
            this.Load += new System.EventHandler(this.AccountManager2019Form_Load);
            this.Controls.SetChildIndex(this.grt_Option, 0);
            this.Controls.SetChildIndex(this.dgvAccountData, 0);
            this.Controls.SetChildIndex(this.pnlButtons1, 0);
            this.Controls.SetChildIndex(this.pnlButtons2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.sttStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountData)).EndInit();
            this.grt_Option.ResumeLayout(false);
            this.tab_Search.ResumeLayout(false);
            this.tab_Search.PerformLayout();
            this.tab_depreciation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeprCalc)).EndInit();
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
        private Framework.ButtonCommon btnAccDepr;
        private System.Windows.Forms.TabPage tab_TotalCost;
        private Framework.DataGridViewCommon dgvAccCounter;
        private Framework.ButtonCommon btnTransferAsset;
        private Framework.ButtonCommon btnClose;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsRowCounter;
        private Framework.TreeViewCommon trvOther;
        private Framework.DataGridViewCommon dgvDeprCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn aquisition_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_depr;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_depr;
        private System.Windows.Forms.DataGridViewTextBoxColumn accum_depr;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoried;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_machine;
        private Framework.ButtonCommon btnRankDepr;
    }
}