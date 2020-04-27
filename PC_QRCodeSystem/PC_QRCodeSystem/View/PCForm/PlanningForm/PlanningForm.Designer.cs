namespace PC_QRCodeSystem.View
{
    partial class PlanningForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtPlanCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.rbtnNoCheckDate = new System.Windows.Forms.RadioButton();
            this.txtModelCD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDeliveryToDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPlanToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPlanDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rbtnPlanDate = new System.Windows.Forms.RadioButton();
            this.txtPlanQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUserCD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDestinationCD = new System.Windows.Forms.ComboBox();
            this.txtSetNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPlanData = new System.Windows.Forms.DataGridView();
            this.pnlMainButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenPlan = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tc_PlanManagement = new System.Windows.Forms.TabControl();
            this.tab_Main = new System.Windows.Forms.TabPage();
            this.pnlMainTop = new System.Windows.Forms.Panel();
            this.tab_PlanItem = new System.Windows.Forms.TabPage();
            this.dgvPlanItem = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanData)).BeginInit();
            this.pnlMainButtons.SuspendLayout();
            this.tc_PlanManagement.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.pnlMainTop.SuspendLayout();
            this.tab_PlanItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanItem)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtPlanCD);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.txtComment);
            this.pnlMain.Controls.Add(this.rbtnNoCheckDate);
            this.pnlMain.Controls.Add(this.txtModelCD);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.dtpDeliveryToDate);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.dtpPlanToDate);
            this.pnlMain.Controls.Add(this.dtpDeliveryDate);
            this.pnlMain.Controls.Add(this.dtpPlanDate);
            this.pnlMain.Controls.Add(this.rbtnDeliveryDate);
            this.pnlMain.Controls.Add(this.rbtnPlanDate);
            this.pnlMain.Controls.Add(this.txtPlanQty);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.lbUserName);
            this.pnlMain.Controls.Add(this.txtUserCD);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.lbModelName);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cmbDestinationCD);
            this.pnlMain.Controls.Add(this.txtSetNumber);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(680, 230);
            this.pnlMain.TabIndex = 2;
            // 
            // txtPlanCD
            // 
            this.txtPlanCD.Location = new System.Drawing.Point(320, 130);
            this.txtPlanCD.Name = "txtPlanCD";
            this.txtPlanCD.Size = new System.Drawing.Size(140, 22);
            this.txtPlanCD.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(220, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Plan Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(470, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Comment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(470, 40);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(200, 170);
            this.txtComment.TabIndex = 23;
            // 
            // rbtnNoCheckDate
            // 
            this.rbtnNoCheckDate.AutoSize = true;
            this.rbtnNoCheckDate.Location = new System.Drawing.Point(10, 130);
            this.rbtnNoCheckDate.Name = "rbtnNoCheckDate";
            this.rbtnNoCheckDate.Size = new System.Drawing.Size(117, 20);
            this.rbtnNoCheckDate.TabIndex = 22;
            this.rbtnNoCheckDate.TabStop = true;
            this.rbtnNoCheckDate.Text = "No Check Date";
            this.rbtnNoCheckDate.UseVisualStyleBackColor = true;
            // 
            // txtModelCD
            // 
            this.txtModelCD.Location = new System.Drawing.Point(120, 40);
            this.txtModelCD.Name = "txtModelCD";
            this.txtModelCD.Size = new System.Drawing.Size(120, 22);
            this.txtModelCD.TabIndex = 21;
            this.txtModelCD.TextChanged += new System.EventHandler(this.txtModelCD_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(250, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "To Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDeliveryToDate
            // 
            this.dtpDeliveryToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryToDate.Location = new System.Drawing.Point(340, 190);
            this.dtpDeliveryToDate.Name = "dtpDeliveryToDate";
            this.dtpDeliveryToDate.Size = new System.Drawing.Size(120, 22);
            this.dtpDeliveryToDate.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(250, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "To Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpPlanToDate
            // 
            this.dtpPlanToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanToDate.Location = new System.Drawing.Point(340, 160);
            this.dtpPlanToDate.Name = "dtpPlanToDate";
            this.dtpPlanToDate.Size = new System.Drawing.Size(120, 22);
            this.dtpPlanToDate.TabIndex = 17;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(120, 190);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(120, 22);
            this.dtpDeliveryDate.TabIndex = 16;
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(120, 160);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(120, 22);
            this.dtpPlanDate.TabIndex = 15;
            // 
            // rbtnDeliveryDate
            // 
            this.rbtnDeliveryDate.AutoSize = true;
            this.rbtnDeliveryDate.Location = new System.Drawing.Point(10, 190);
            this.rbtnDeliveryDate.Name = "rbtnDeliveryDate";
            this.rbtnDeliveryDate.Size = new System.Drawing.Size(108, 20);
            this.rbtnDeliveryDate.TabIndex = 14;
            this.rbtnDeliveryDate.TabStop = true;
            this.rbtnDeliveryDate.Text = "Delivery Date";
            this.rbtnDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbtnPlanDate
            // 
            this.rbtnPlanDate.AutoSize = true;
            this.rbtnPlanDate.Location = new System.Drawing.Point(10, 160);
            this.rbtnPlanDate.Name = "rbtnPlanDate";
            this.rbtnPlanDate.Size = new System.Drawing.Size(85, 20);
            this.rbtnPlanDate.TabIndex = 13;
            this.rbtnPlanDate.TabStop = true;
            this.rbtnPlanDate.Text = "Plan Date";
            this.rbtnPlanDate.UseVisualStyleBackColor = true;
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.Location = new System.Drawing.Point(320, 100);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(140, 22);
            this.txtPlanQty.TabIndex = 12;
            this.txtPlanQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanQty_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(250, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Qty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUserName
            // 
            this.lbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(260, 10);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(200, 20);
            this.lbUserName.TabIndex = 10;
            this.lbUserName.Text = "User Name";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserCD
            // 
            this.txtUserCD.Location = new System.Drawing.Point(120, 10);
            this.txtUserCD.Name = "txtUserCD";
            this.txtUserCD.Size = new System.Drawing.Size(120, 22);
            this.txtUserCD.TabIndex = 9;
            this.txtUserCD.TextChanged += new System.EventHandler(this.txtUserCD_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "User Code";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModelName
            // 
            this.lbModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelName.Location = new System.Drawing.Point(260, 40);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(200, 20);
            this.lbModelName.TabIndex = 7;
            this.lbModelName.Text = "Model Name";
            this.lbModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Model";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Destination";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDestinationCD
            // 
            this.cmbDestinationCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinationCD.FormattingEnabled = true;
            this.cmbDestinationCD.Location = new System.Drawing.Point(120, 70);
            this.cmbDestinationCD.Name = "cmbDestinationCD";
            this.cmbDestinationCD.Size = new System.Drawing.Size(340, 24);
            this.cmbDestinationCD.TabIndex = 2;
            this.cmbDestinationCD.SelectedIndexChanged += new System.EventHandler(this.cmbDestinationCD_SelectedIndexChanged);
            this.cmbDestinationCD.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbDestinationCD_Format);
            // 
            // txtSetNumber
            // 
            this.txtSetNumber.Location = new System.Drawing.Point(120, 100);
            this.txtSetNumber.Name = "txtSetNumber";
            this.txtSetNumber.Size = new System.Drawing.Size(120, 22);
            this.txtSetNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPlanData
            // 
            this.dgvPlanData.AllowUserToAddRows = false;
            this.dgvPlanData.AllowUserToDeleteRows = false;
            this.dgvPlanData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlanData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanData.Location = new System.Drawing.Point(3, 293);
            this.dgvPlanData.Name = "dgvPlanData";
            this.dgvPlanData.ReadOnly = true;
            this.dgvPlanData.Size = new System.Drawing.Size(680, 110);
            this.dgvPlanData.TabIndex = 3;
            this.dgvPlanData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanData_CellClick);
            this.dgvPlanData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanData_CellDoubleClick);
            // 
            // pnlMainButtons
            // 
            this.pnlMainButtons.Controls.Add(this.btnExport);
            this.pnlMainButtons.Controls.Add(this.btnClear);
            this.pnlMainButtons.Controls.Add(this.btnOpenPlan);
            this.pnlMainButtons.Controls.Add(this.btnDelete);
            this.pnlMainButtons.Controls.Add(this.btnUpdate);
            this.pnlMainButtons.Controls.Add(this.btnAdd);
            this.pnlMainButtons.Controls.Add(this.btnSearch);
            this.pnlMainButtons.Location = new System.Drawing.Point(0, 230);
            this.pnlMainButtons.Name = "pnlMainButtons";
            this.pnlMainButtons.Size = new System.Drawing.Size(680, 60);
            this.pnlMainButtons.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(485, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 50);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(578, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenPlan
            // 
            this.btnOpenPlan.Location = new System.Drawing.Point(20, 5);
            this.btnOpenPlan.Name = "btnOpenPlan";
            this.btnOpenPlan.Size = new System.Drawing.Size(80, 50);
            this.btnOpenPlan.TabIndex = 4;
            this.btnOpenPlan.Text = "Open Plan";
            this.btnOpenPlan.UseVisualStyleBackColor = true;
            this.btnOpenPlan.Click += new System.EventHandler(this.btnOpenPlan_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(299, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(113, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tc_PlanManagement
            // 
            this.tc_PlanManagement.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_PlanManagement.Controls.Add(this.tab_Main);
            this.tc_PlanManagement.Controls.Add(this.tab_PlanItem);
            this.tc_PlanManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_PlanManagement.Location = new System.Drawing.Point(150, 70);
            this.tc_PlanManagement.Name = "tc_PlanManagement";
            this.tc_PlanManagement.SelectedIndex = 0;
            this.tc_PlanManagement.Size = new System.Drawing.Size(694, 438);
            this.tc_PlanManagement.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_PlanManagement.TabIndex = 5;
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.dgvPlanData);
            this.tab_Main.Controls.Add(this.pnlMainTop);
            this.tab_Main.Location = new System.Drawing.Point(4, 28);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Main.Size = new System.Drawing.Size(686, 406);
            this.tab_Main.TabIndex = 0;
            this.tab_Main.Text = "Main";
            this.tab_Main.UseVisualStyleBackColor = true;
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.Controls.Add(this.pnlMainButtons);
            this.pnlMainTop.Controls.Add(this.pnlMain);
            this.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTop.Location = new System.Drawing.Point(3, 3);
            this.pnlMainTop.Name = "pnlMainTop";
            this.pnlMainTop.Size = new System.Drawing.Size(680, 290);
            this.pnlMainTop.TabIndex = 5;
            this.pnlMainTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainTop_Paint);
            // 
            // tab_PlanItem
            // 
            this.tab_PlanItem.Controls.Add(this.dgvPlanItem);
            this.tab_PlanItem.Controls.Add(this.panel6);
            this.tab_PlanItem.Location = new System.Drawing.Point(4, 28);
            this.tab_PlanItem.Name = "tab_PlanItem";
            this.tab_PlanItem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PlanItem.Size = new System.Drawing.Size(686, 406);
            this.tab_PlanItem.TabIndex = 1;
            this.tab_PlanItem.Text = "Item";
            this.tab_PlanItem.UseVisualStyleBackColor = true;
            // 
            // dgvPlanItem
            // 
            this.dgvPlanItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanItem.Location = new System.Drawing.Point(3, 63);
            this.dgvPlanItem.Name = "dgvPlanItem";
            this.dgvPlanItem.Size = new System.Drawing.Size(680, 340);
            this.dgvPlanItem.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(680, 60);
            this.panel6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 50);
            this.button7.TabIndex = 0;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // PlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 508);
            this.Controls.Add(this.tc_PlanManagement);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "PlanningForm";
            this.position = "";
            this.Text = "PlanningForm";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.PlanningForm_Load);
            this.Controls.SetChildIndex(this.tc_PlanManagement, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanData)).EndInit();
            this.pnlMainButtons.ResumeLayout(false);
            this.tc_PlanManagement.ResumeLayout(false);
            this.tab_Main.ResumeLayout(false);
            this.pnlMainTop.ResumeLayout(false);
            this.tab_PlanItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanItem)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvPlanData;
        private System.Windows.Forms.Panel pnlMainButtons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestinationCD;
        private System.Windows.Forms.TextBox txtSetNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUserCD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlanQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpPlanDate;
        private System.Windows.Forms.RadioButton rbtnDeliveryDate;
        private System.Windows.Forms.RadioButton rbtnPlanDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDeliveryToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPlanToDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenPlan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tc_PlanManagement;
        private System.Windows.Forms.TabPage tab_Main;
        private System.Windows.Forms.TabPage tab_PlanItem;
        private System.Windows.Forms.DataGridView dgvPlanItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtModelCD;
        private System.Windows.Forms.RadioButton rbtnNoCheckDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Panel pnlMainTop;
        private System.Windows.Forms.TextBox txtPlanCD;
        private System.Windows.Forms.Label label1;
    }
}