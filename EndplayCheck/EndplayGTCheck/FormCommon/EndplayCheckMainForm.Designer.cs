namespace EndplayGTCheck.FormCommon
{
    partial class EndplayCheckMainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMeas = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.TimerConnect = new System.Windows.Forms.Timer(this.components);
            this.GTPort = new System.IO.Ports.SerialPort(this.components);
            this.CodePort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMeas = new System.Windows.Forms.TabPage();
            this.pnMeas = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLine = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFact = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.tabSet = new System.Windows.Forms.TabPage();
            this.pnSet = new System.Windows.Forms.Panel();
            this.btnLock = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGTst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnectGT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudrateGT = new System.Windows.Forms.ComboBox();
            this.cmbGTCom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCodest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnectCode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudrateCode = new System.Windows.Forms.ComboBox();
            this.cmbCodeCom = new System.Windows.Forms.ComboBox();
            this.ofServer = new System.Windows.Forms.OpenFileDialog();
            this.bkwSendData = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMeas.SuspendLayout();
            this.pnMeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabSet.SuspendLayout();
            this.pnSet.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tsStatus,
            this.toolStripStatusLabel1,
            this.tsTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 19);
            this.toolStripStatusLabel3.Text = "Status :";
            // 
            // tsStatus
            // 
            this.tsStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(473, 19);
            this.tsStatus.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel1.Text = "Time :";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(21, 19);
            this.tsTime.Text = "0 s";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMeas);
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 316);
            this.panel2.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(31, 200);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 44);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(31, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMeas
            // 
            this.btnMeas.Location = new System.Drawing.Point(31, 14);
            this.btnMeas.Name = "btnMeas";
            this.btnMeas.Size = new System.Drawing.Size(89, 44);
            this.btnMeas.TabIndex = 1;
            this.btnMeas.Text = "Measurement";
            this.btnMeas.UseVisualStyleBackColor = true;
            this.btnMeas.Click += new System.EventHandler(this.btnMeas_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(31, 76);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(89, 44);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Setting";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // TimerConnect
            // 
            this.TimerConnect.Interval = 1000;
            this.TimerConnect.Tick += new System.EventHandler(this.TimerConnect_Tick);
            // 
            // GTPort
            // 
            this.GTPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.GTPort_DataReceived);
            // 
            // CodePort
            // 
            this.CodePort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CodePort_DataReceived);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabMeas);
            this.tabControl1.Controls.Add(this.tabSet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(162, 75);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 316);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            // 
            // tabMeas
            // 
            this.tabMeas.Controls.Add(this.pnMeas);
            this.tabMeas.Location = new System.Drawing.Point(4, 5);
            this.tabMeas.Name = "tabMeas";
            this.tabMeas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeas.Size = new System.Drawing.Size(432, 307);
            this.tabMeas.TabIndex = 0;
            this.tabMeas.Text = "Measurement";
            this.tabMeas.UseVisualStyleBackColor = true;
            // 
            // pnMeas
            // 
            this.pnMeas.Controls.Add(this.dgvData);
            this.pnMeas.Controls.Add(this.groupBox5);
            this.pnMeas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMeas.Location = new System.Drawing.Point(3, 3);
            this.pnMeas.Name = "pnMeas";
            this.pnMeas.Size = new System.Drawing.Size(426, 301);
            this.pnMeas.TabIndex = 4;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(4, 120);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(419, 178);
            this.dgvData.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtLot);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cmbProc);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cmbLine);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cmbFact);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cmbSite);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cmbModel);
            this.groupBox5.Location = new System.Drawing.Point(4, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(419, 108);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Information";
            // 
            // txtLot
            // 
            this.txtLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLot.Location = new System.Drawing.Point(251, 74);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(121, 20);
            this.txtLot.TabIndex = 12;
            this.txtLot.TextChanged += new System.EventHandler(this.txtLot_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Lot";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Process";
            // 
            // cmbProc
            // 
            this.cmbProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProc.FormattingEnabled = true;
            this.cmbProc.Location = new System.Drawing.Point(251, 47);
            this.cmbProc.Name = "cmbProc";
            this.cmbProc.Size = new System.Drawing.Size(121, 21);
            this.cmbProc.TabIndex = 8;
            this.cmbProc.SelectedIndexChanged += new System.EventHandler(this.cmbProc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Line";
            // 
            // cmbLine
            // 
            this.cmbLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(251, 20);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(121, 21);
            this.cmbLine.TabIndex = 6;
            this.cmbLine.SelectedIndexChanged += new System.EventHandler(this.cmbLine_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Factory";
            // 
            // cmbFact
            // 
            this.cmbFact.FormattingEnabled = true;
            this.cmbFact.Location = new System.Drawing.Point(54, 74);
            this.cmbFact.Name = "cmbFact";
            this.cmbFact.Size = new System.Drawing.Size(121, 21);
            this.cmbFact.TabIndex = 4;
            this.cmbFact.SelectedIndexChanged += new System.EventHandler(this.cmbFact_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Site";
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(54, 47);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 2;
            this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(54, 19);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 0;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // tabSet
            // 
            this.tabSet.Controls.Add(this.pnSet);
            this.tabSet.Location = new System.Drawing.Point(4, 5);
            this.tabSet.Name = "tabSet";
            this.tabSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabSet.Size = new System.Drawing.Size(432, 307);
            this.tabSet.TabIndex = 1;
            this.tabSet.Text = "Setting";
            this.tabSet.UseVisualStyleBackColor = true;
            // 
            // pnSet
            // 
            this.pnSet.Controls.Add(this.btnLock);
            this.pnSet.Controls.Add(this.groupBox6);
            this.pnSet.Controls.Add(this.groupBox4);
            this.pnSet.Controls.Add(this.groupBox3);
            this.pnSet.Controls.Add(this.groupBox1);
            this.pnSet.Controls.Add(this.groupBox2);
            this.pnSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSet.Location = new System.Drawing.Point(3, 3);
            this.pnSet.Name = "pnSet";
            this.pnSet.Size = new System.Drawing.Size(426, 301);
            this.pnSet.TabIndex = 7;
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.Location = new System.Drawing.Point(315, 235);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(89, 44);
            this.btnLock.TabIndex = 11;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numMax);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.numMin);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(3, 216);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(199, 71);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spec";
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Location = new System.Drawing.Point(135, 33);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(58, 20);
            this.numMax.TabIndex = 9;
            this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Max";
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Location = new System.Drawing.Point(36, 33);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(58, 20);
            this.numMin.TabIndex = 7;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Min";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtURL);
            this.groupBox4.Controls.Add(this.btnBrowser);
            this.groupBox4.Location = new System.Drawing.Point(3, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 71);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server URL";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(9, 32);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(273, 20);
            this.txtURL.TabIndex = 8;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(312, 19);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(89, 44);
            this.btnBrowser.TabIndex = 7;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numTimer);
            this.groupBox3.Location = new System.Drawing.Point(208, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(77, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(9, 33);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(58, 20);
            this.numTimer.TabIndex = 6;
            this.numTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGTst);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnConnectGT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBaudrateGT);
            this.groupBox1.Controls.Add(this.cmbGTCom);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect GT2 Sensor";
            // 
            // lbGTst
            // 
            this.lbGTst.AutoSize = true;
            this.lbGTst.BackColor = System.Drawing.Color.Red;
            this.lbGTst.ForeColor = System.Drawing.Color.Yellow;
            this.lbGTst.Location = new System.Drawing.Point(6, 89);
            this.lbGTst.Name = "lbGTst";
            this.lbGTst.Size = new System.Drawing.Size(61, 13);
            this.lbGTst.TabIndex = 6;
            this.lbGTst.Text = "Disconnect";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status :";
            // 
            // btnConnectGT
            // 
            this.btnConnectGT.Location = new System.Drawing.Point(97, 73);
            this.btnConnectGT.Name = "btnConnectGT";
            this.btnConnectGT.Size = new System.Drawing.Size(89, 44);
            this.btnConnectGT.TabIndex = 4;
            this.btnConnectGT.Text = "Connect";
            this.btnConnectGT.UseVisualStyleBackColor = true;
            this.btnConnectGT.Click += new System.EventHandler(this.btnConnectGT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // cmbBaudrateGT
            // 
            this.cmbBaudrateGT.FormattingEnabled = true;
            this.cmbBaudrateGT.Location = new System.Drawing.Point(65, 46);
            this.cmbBaudrateGT.Name = "cmbBaudrateGT";
            this.cmbBaudrateGT.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudrateGT.TabIndex = 1;
            // 
            // cmbGTCom
            // 
            this.cmbGTCom.FormattingEnabled = true;
            this.cmbGTCom.Location = new System.Drawing.Point(65, 19);
            this.cmbGTCom.Name = "cmbGTCom";
            this.cmbGTCom.Size = new System.Drawing.Size(121, 21);
            this.cmbGTCom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbCodest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnConnectCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBaudrateCode);
            this.groupBox2.Controls.Add(this.cmbCodeCom);
            this.groupBox2.Location = new System.Drawing.Point(218, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect Barcode Reader";
            // 
            // lbCodest
            // 
            this.lbCodest.AutoSize = true;
            this.lbCodest.BackColor = System.Drawing.Color.Red;
            this.lbCodest.ForeColor = System.Drawing.Color.Yellow;
            this.lbCodest.Location = new System.Drawing.Point(6, 89);
            this.lbCodest.Name = "lbCodest";
            this.lbCodest.Size = new System.Drawing.Size(61, 13);
            this.lbCodest.TabIndex = 7;
            this.lbCodest.Text = "Disconnect";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status :";
            // 
            // btnConnectCode
            // 
            this.btnConnectCode.Location = new System.Drawing.Point(97, 73);
            this.btnConnectCode.Name = "btnConnectCode";
            this.btnConnectCode.Size = new System.Drawing.Size(89, 44);
            this.btnConnectCode.TabIndex = 5;
            this.btnConnectCode.Text = "Connect";
            this.btnConnectCode.UseVisualStyleBackColor = true;
            this.btnConnectCode.Click += new System.EventHandler(this.btnConnectCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Baud rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM Port";
            // 
            // cmbBaudrateCode
            // 
            this.cmbBaudrateCode.FormattingEnabled = true;
            this.cmbBaudrateCode.Location = new System.Drawing.Point(65, 46);
            this.cmbBaudrateCode.Name = "cmbBaudrateCode";
            this.cmbBaudrateCode.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudrateCode.TabIndex = 2;
            // 
            // cmbCodeCom
            // 
            this.cmbCodeCom.FormattingEnabled = true;
            this.cmbCodeCom.Location = new System.Drawing.Point(65, 19);
            this.cmbCodeCom.Name = "cmbCodeCom";
            this.cmbCodeCom.Size = new System.Drawing.Size(121, 21);
            this.cmbCodeCom.TabIndex = 1;
            // 
            // ofServer
            // 
            this.ofServer.AddExtension = false;
            this.ofServer.CheckFileExists = false;
            this.ofServer.CheckPathExists = false;
            this.ofServer.FileName = "Select folder";
            this.ofServer.RestoreDirectory = true;
            this.ofServer.ShowReadOnly = true;
            this.ofServer.Title = "Send Data To...";
            // 
            // bkwSendData
            // 
            this.bkwSendData.WorkerReportsProgress = true;
            this.bkwSendData.WorkerSupportsCancellation = true;
            this.bkwSendData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwSendData_DoWork);
            this.bkwSendData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwSendData_ProgressChanged);
            this.bkwSendData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwSendData_RunWorkerCompleted);
            // 
            // EndplayCheckMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EndplayCheckMainForm";
            this.Text = "Endplay Check";
            this.TitleText = "Endplay Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndplayCheckMainForm_FormClosing);
            this.Load += new System.EventHandler(this.EndplayCheckMainForm_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabMeas.ResumeLayout(false);
            this.pnMeas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabSet.ResumeLayout(false);
            this.pnSet.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMeas;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Timer TimerConnect;
        private System.IO.Ports.SerialPort GTPort;
        private System.IO.Ports.SerialPort CodePort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMeas;
        private System.Windows.Forms.Panel pnMeas;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TabPage tabSet;
        private System.Windows.Forms.Panel pnSet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGTst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnectGT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaudrateGT;
        private System.Windows.Forms.ComboBox cmbGTCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCodest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnectCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudrateCode;
        private System.Windows.Forms.ComboBox cmbCodeCom;
        private System.Windows.Forms.OpenFileDialog ofServer;
        private System.ComponentModel.BackgroundWorker bkwSendData;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.Button btnLock;
    }
}

