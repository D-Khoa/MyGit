namespace PC_QRCodeSystem.View
{
    partial class PCForm
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
            this.pnlMainStock = new System.Windows.Forms.Panel();
            this.btnStockDetail = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rbtnWaitApprove = new System.Windows.Forms.RadioButton();
            this.rbtnReject = new System.Windows.Forms.RadioButton();
            this.rbtnApproved = new System.Windows.Forms.RadioButton();
            this.rbtnAllRequest = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grt_Main = new System.Windows.Forms.TabControl();
            this.tab_Menu = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlAdminManagement = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUserPosition = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.pnlDataLogs = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnRequestLog = new System.Windows.Forms.Button();
            this.btnStockOutLog = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlPCManagement = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssueCode = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.tab_Request = new System.Windows.Forms.TabPage();
            this.pnlMainStock.SuspendLayout();
            this.pnlRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grt_Main.SuspendLayout();
            this.tab_Menu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlAdminManagement.SuspendLayout();
            this.pnlDataLogs.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.pnlPCManagement.SuspendLayout();
            this.tab_Request.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainStock
            // 
            this.pnlMainStock.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMainStock.Controls.Add(this.btnStockDetail);
            this.pnlMainStock.Controls.Add(this.btnStockOut);
            this.pnlMainStock.Controls.Add(this.btnStockIn);
            this.pnlMainStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainStock.Location = new System.Drawing.Point(3, 3);
            this.pnlMainStock.Name = "pnlMainStock";
            this.pnlMainStock.Size = new System.Drawing.Size(240, 399);
            this.pnlMainStock.TabIndex = 2;
            this.pnlMainStock.Tag = "pcmp001";
            // 
            // btnStockDetail
            // 
            this.btnStockDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDetail.Location = new System.Drawing.Point(20, 280);
            this.btnStockDetail.Name = "btnStockDetail";
            this.btnStockDetail.Size = new System.Drawing.Size(200, 100);
            this.btnStockDetail.TabIndex = 2;
            this.btnStockDetail.Text = "Stock Detail";
            this.btnStockDetail.UseVisualStyleBackColor = true;
            this.btnStockDetail.Click += new System.EventHandler(this.btnStockDetail_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(20, 150);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(200, 100);
            this.btnStockOut.TabIndex = 1;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.Location = new System.Drawing.Point(20, 20);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(200, 100);
            this.btnStockIn.TabIndex = 0;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // pnlRequest
            // 
            this.pnlRequest.Controls.Add(this.dgvRequest);
            this.pnlRequest.Controls.Add(this.panel10);
            this.pnlRequest.Controls.Add(this.panel4);
            this.pnlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRequest.Location = new System.Drawing.Point(3, 3);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(680, 399);
            this.pnlRequest.TabIndex = 3;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(0, 50);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.Size = new System.Drawing.Size(680, 295);
            this.dgvRequest.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.rbtnWaitApprove);
            this.panel10.Controls.Add(this.rbtnReject);
            this.panel10.Controls.Add(this.rbtnApproved);
            this.panel10.Controls.Add(this.rbtnAllRequest);
            this.panel10.Controls.Add(this.btnSearch);
            this.panel10.Controls.Add(this.btnBack);
            this.panel10.Controls.Add(this.btnCheck);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(680, 50);
            this.panel10.TabIndex = 6;
            // 
            // rbtnWaitApprove
            // 
            this.rbtnWaitApprove.AutoSize = true;
            this.rbtnWaitApprove.Location = new System.Drawing.Point(154, 15);
            this.rbtnWaitApprove.Name = "rbtnWaitApprove";
            this.rbtnWaitApprove.Size = new System.Drawing.Size(111, 21);
            this.rbtnWaitApprove.TabIndex = 6;
            this.rbtnWaitApprove.TabStop = true;
            this.rbtnWaitApprove.Text = "Wait Approve";
            this.rbtnWaitApprove.UseVisualStyleBackColor = true;
            // 
            // rbtnReject
            // 
            this.rbtnReject.AutoSize = true;
            this.rbtnReject.Location = new System.Drawing.Point(364, 15);
            this.rbtnReject.Name = "rbtnReject";
            this.rbtnReject.Size = new System.Drawing.Size(82, 21);
            this.rbtnReject.TabIndex = 5;
            this.rbtnReject.TabStop = true;
            this.rbtnReject.Text = "Rejected";
            this.rbtnReject.UseVisualStyleBackColor = true;
            // 
            // rbtnApproved
            // 
            this.rbtnApproved.AutoSize = true;
            this.rbtnApproved.Location = new System.Drawing.Point(271, 15);
            this.rbtnApproved.Name = "rbtnApproved";
            this.rbtnApproved.Size = new System.Drawing.Size(87, 21);
            this.rbtnApproved.TabIndex = 4;
            this.rbtnApproved.TabStop = true;
            this.rbtnApproved.Text = "Approved";
            this.rbtnApproved.UseVisualStyleBackColor = true;
            // 
            // rbtnAllRequest
            // 
            this.rbtnAllRequest.AutoSize = true;
            this.rbtnAllRequest.Location = new System.Drawing.Point(107, 15);
            this.rbtnAllRequest.Name = "rbtnAllRequest";
            this.rbtnAllRequest.Size = new System.Drawing.Size(41, 21);
            this.rbtnAllRequest.TabIndex = 3;
            this.rbtnAllRequest.TabStop = true;
            this.rbtnAllRequest.Text = "All";
            this.rbtnAllRequest.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(580, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(480, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 40);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAccept);
            this.panel4.Controls.Add(this.btnDeny);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 54);
            this.panel4.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.Location = new System.Drawing.Point(107, 8);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(96, 43);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeny.Location = new System.Drawing.Point(525, 8);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(96, 43);
            this.btnDeny.TabIndex = 3;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grt_Main
            // 
            this.grt_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.grt_Main.Controls.Add(this.tab_Menu);
            this.grt_Main.Controls.Add(this.tab_Request);
            this.grt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grt_Main.Location = new System.Drawing.Point(150, 70);
            this.grt_Main.Name = "grt_Main";
            this.grt_Main.SelectedIndex = 0;
            this.grt_Main.Size = new System.Drawing.Size(694, 434);
            this.grt_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.grt_Main.TabIndex = 4;
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.panel5);
            this.tab_Menu.Controls.Add(this.pnlMainStock);
            this.tab_Menu.Location = new System.Drawing.Point(4, 25);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Menu.Size = new System.Drawing.Size(686, 405);
            this.tab_Menu.TabIndex = 0;
            this.tab_Menu.Text = "Menu";
            this.tab_Menu.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlAdminManagement);
            this.panel5.Controls.Add(this.pnlDataLogs);
            this.panel5.Controls.Add(this.pnlSetting);
            this.panel5.Controls.Add(this.pnlPCManagement);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(243, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 399);
            this.panel5.TabIndex = 9;
            // 
            // pnlAdminManagement
            // 
            this.pnlAdminManagement.Controls.Add(this.label5);
            this.pnlAdminManagement.Controls.Add(this.btnUserPosition);
            this.pnlAdminManagement.Controls.Add(this.btnDepartment);
            this.pnlAdminManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminManagement.Location = new System.Drawing.Point(0, 160);
            this.pnlAdminManagement.Name = "pnlAdminManagement";
            this.pnlAdminManagement.Size = new System.Drawing.Size(440, 80);
            this.pnlAdminManagement.TabIndex = 8;
            this.pnlAdminManagement.Tag = "admp001";
            this.pnlAdminManagement.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Admin-Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUserPosition
            // 
            this.btnUserPosition.Location = new System.Drawing.Point(20, 24);
            this.btnUserPosition.Name = "btnUserPosition";
            this.btnUserPosition.Size = new System.Drawing.Size(100, 50);
            this.btnUserPosition.TabIndex = 6;
            this.btnUserPosition.Text = "User Position";
            this.btnUserPosition.UseVisualStyleBackColor = true;
            this.btnUserPosition.Click += new System.EventHandler(this.btnUserPosition_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(130, 24);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(100, 50);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // pnlDataLogs
            // 
            this.pnlDataLogs.Controls.Add(this.label7);
            this.pnlDataLogs.Controls.Add(this.btnPlanning);
            this.pnlDataLogs.Controls.Add(this.btnRequestLog);
            this.pnlDataLogs.Controls.Add(this.btnStockOutLog);
            this.pnlDataLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataLogs.Location = new System.Drawing.Point(0, 80);
            this.pnlDataLogs.Name = "pnlDataLogs";
            this.pnlDataLogs.Size = new System.Drawing.Size(440, 80);
            this.pnlDataLogs.TabIndex = 9;
            this.pnlDataLogs.Tag = "pcmp003";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(440, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Log";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlanning
            // 
            this.btnPlanning.Location = new System.Drawing.Point(240, 25);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(100, 50);
            this.btnPlanning.TabIndex = 13;
            this.btnPlanning.Text = "Planning";
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnRequestLog
            // 
            this.btnRequestLog.Location = new System.Drawing.Point(130, 25);
            this.btnRequestLog.Name = "btnRequestLog";
            this.btnRequestLog.Size = new System.Drawing.Size(100, 50);
            this.btnRequestLog.TabIndex = 6;
            this.btnRequestLog.Text = "Request Log";
            this.btnRequestLog.UseVisualStyleBackColor = true;
            this.btnRequestLog.Click += new System.EventHandler(this.btnRequestLog_Click);
            // 
            // btnStockOutLog
            // 
            this.btnStockOutLog.Location = new System.Drawing.Point(20, 25);
            this.btnStockOutLog.Name = "btnStockOutLog";
            this.btnStockOutLog.Size = new System.Drawing.Size(100, 50);
            this.btnStockOutLog.TabIndex = 5;
            this.btnStockOutLog.Text = "Stock Out Log";
            this.btnStockOutLog.UseVisualStyleBackColor = true;
            this.btnStockOutLog.Click += new System.EventHandler(this.btnStockOutLog_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.btnSetting);
            this.pnlSetting.Controls.Add(this.label8);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetting.Location = new System.Drawing.Point(0, 319);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(440, 80);
            this.pnlSetting.TabIndex = 10;
            this.pnlSetting.Tag = "pcmp004";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(20, 25);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 50);
            this.btnSetting.TabIndex = 13;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Setting";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPCManagement
            // 
            this.pnlPCManagement.Controls.Add(this.label2);
            this.pnlPCManagement.Controls.Add(this.btnIssueCode);
            this.pnlPCManagement.Controls.Add(this.btnSupplier);
            this.pnlPCManagement.Controls.Add(this.btnItem);
            this.pnlPCManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPCManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlPCManagement.Name = "pnlPCManagement";
            this.pnlPCManagement.Size = new System.Drawing.Size(440, 80);
            this.pnlPCManagement.TabIndex = 7;
            this.pnlPCManagement.Tag = "pcmp002";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "PC-Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIssueCode
            // 
            this.btnIssueCode.Location = new System.Drawing.Point(240, 24);
            this.btnIssueCode.Name = "btnIssueCode";
            this.btnIssueCode.Size = new System.Drawing.Size(100, 50);
            this.btnIssueCode.TabIndex = 3;
            this.btnIssueCode.Text = "Issue Code";
            this.btnIssueCode.UseVisualStyleBackColor = true;
            this.btnIssueCode.Click += new System.EventHandler(this.btnIssueCode_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(130, 25);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(100, 50);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(20, 25);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(100, 50);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "Item Management";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // tab_Request
            // 
            this.tab_Request.Controls.Add(this.pnlRequest);
            this.tab_Request.Location = new System.Drawing.Point(4, 25);
            this.tab_Request.Name = "tab_Request";
            this.tab_Request.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Request.Size = new System.Drawing.Size(686, 405);
            this.tab_Request.TabIndex = 1;
            this.tab_Request.Text = "Request";
            this.tab_Request.UseVisualStyleBackColor = true;
            // 
            // PCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 504);
            this.Controls.Add(this.grt_Main);
            this.dept = "";
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "PCForm";
            this.position = "";
            this.Text = "PC Management";
            this.tittle = "FormCommon";
            this.Controls.SetChildIndex(this.grt_Main, 0);
            this.pnlMainStock.ResumeLayout(false);
            this.pnlRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.grt_Main.ResumeLayout(false);
            this.tab_Menu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlAdminManagement.ResumeLayout(false);
            this.pnlDataLogs.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.pnlPCManagement.ResumeLayout(false);
            this.tab_Request.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainStock;
        private System.Windows.Forms.Button btnStockDetail;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl grt_Main;
        private System.Windows.Forms.TabPage tab_Menu;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnIssueCode;
        private System.Windows.Forms.Button btnStockOutLog;
        private System.Windows.Forms.Button btnRequestLog;
        private System.Windows.Forms.TabPage tab_Request;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlDataLogs;
        private System.Windows.Forms.Panel pnlAdminManagement;
        private System.Windows.Forms.Panel pnlPCManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUserPosition;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton rbtnWaitApprove;
        private System.Windows.Forms.RadioButton rbtnReject;
        private System.Windows.Forms.RadioButton rbtnApproved;
        private System.Windows.Forms.RadioButton rbtnAllRequest;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnSetting;
    }
}