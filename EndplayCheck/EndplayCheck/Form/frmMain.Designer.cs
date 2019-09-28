namespace EndplayCheck
{
    partial class frmMain
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
            this.srGTComp = new System.IO.Ports.SerialPort(this.components);
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbST = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGTInput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbST2 = new System.Windows.Forms.Label();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCOM2 = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate2 = new System.Windows.Forms.ComboBox();
            this.srBarcode = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbProc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbLine = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFact = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numCounter = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.bkgSendTo = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // srGTComp
            // 
            this.srGTComp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srGTComp_DataReceived);
            // 
            // cmbCOM
            // 
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(73, 31);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(92, 21);
            this.cmbCOM.TabIndex = 0;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(73, 58);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(92, 21);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status :";
            // 
            // lbST
            // 
            this.lbST.AutoSize = true;
            this.lbST.BackColor = System.Drawing.Color.Red;
            this.lbST.Location = new System.Drawing.Point(70, 82);
            this.lbST.Name = "lbST";
            this.lbST.Size = new System.Drawing.Size(61, 13);
            this.lbST.TabIndex = 5;
            this.lbST.Text = "Disconnect";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(171, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 48);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGTInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbST);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCOM);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect GT2 Sensor";
            // 
            // lbGTInput
            // 
            this.lbGTInput.AutoSize = true;
            this.lbGTInput.Location = new System.Drawing.Point(70, 108);
            this.lbGTInput.Name = "lbGTInput";
            this.lbGTInput.Size = new System.Drawing.Size(13, 13);
            this.lbGTInput.TabIndex = 13;
            this.lbGTInput.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input :";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBarcode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbST2);
            this.groupBox2.Controls.Add(this.btnConnect2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCOM2);
            this.groupBox2.Controls.Add(this.cmbBaudRate2);
            this.groupBox2.Location = new System.Drawing.Point(273, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect Barcode Reader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "COM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Barcode : ";
            // 
            // lbST2
            // 
            this.lbST2.AutoSize = true;
            this.lbST2.BackColor = System.Drawing.Color.Red;
            this.lbST2.Location = new System.Drawing.Point(70, 82);
            this.lbST2.Name = "lbST2";
            this.lbST2.Size = new System.Drawing.Size(61, 13);
            this.lbST2.TabIndex = 5;
            this.lbST2.Text = "Disconnect";
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(171, 31);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(75, 48);
            this.btnConnect2.TabIndex = 6;
            this.btnConnect2.Text = "Connect";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Baud rate :";
            // 
            // cmbCOM2
            // 
            this.cmbCOM2.FormattingEnabled = true;
            this.cmbCOM2.Location = new System.Drawing.Point(73, 31);
            this.cmbCOM2.Name = "cmbCOM2";
            this.cmbCOM2.Size = new System.Drawing.Size(92, 21);
            this.cmbCOM2.TabIndex = 0;
            // 
            // cmbBaudRate2
            // 
            this.cmbBaudRate2.FormattingEnabled = true;
            this.cmbBaudRate2.Location = new System.Drawing.Point(73, 58);
            this.cmbBaudRate2.Name = "cmbBaudRate2";
            this.cmbBaudRate2.Size = new System.Drawing.Size(92, 21);
            this.cmbBaudRate2.TabIndex = 1;
            // 
            // srBarcode
            // 
            this.srBarcode.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srBarcode_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLot);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbProc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbLine);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbFact);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbSite);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbModel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 183);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(65, 156);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(121, 20);
            this.txtLot.TabIndex = 33;
            this.txtLot.TextChanged += new System.EventHandler(this.txtLot_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Lot";
            // 
            // cmbProc
            // 
            this.cmbProc.FormattingEnabled = true;
            this.cmbProc.Location = new System.Drawing.Point(65, 129);
            this.cmbProc.Name = "cmbProc";
            this.cmbProc.Size = new System.Drawing.Size(121, 21);
            this.cmbProc.TabIndex = 31;
            this.cmbProc.SelectedIndexChanged += new System.EventHandler(this.cmbProc_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Process";
            // 
            // cmbLine
            // 
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(65, 102);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(121, 21);
            this.cmbLine.TabIndex = 29;
            this.cmbLine.SelectedIndexChanged += new System.EventHandler(this.cmbLine_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Line";
            // 
            // cmbFact
            // 
            this.cmbFact.FormattingEnabled = true;
            this.cmbFact.Location = new System.Drawing.Point(65, 75);
            this.cmbFact.Name = "cmbFact";
            this.cmbFact.Size = new System.Drawing.Size(121, 21);
            this.cmbFact.TabIndex = 27;
            this.cmbFact.SelectedIndexChanged += new System.EventHandler(this.cmbFact_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Factory";
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(65, 48);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 25;
            this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Site";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(65, 21);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 23;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Model";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(216, 151);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(310, 183);
            this.dgvData.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numCounter);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.btnBrowser);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtURL);
            this.groupBox4.Location = new System.Drawing.Point(12, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(514, 55);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "URL Server";
            // 
            // numCounter
            // 
            this.numCounter.Location = new System.Drawing.Point(300, 20);
            this.numCounter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCounter.Name = "numCounter";
            this.numCounter.Size = new System.Drawing.Size(45, 20);
            this.numCounter.TabIndex = 39;
            this.numCounter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(432, 17);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 38;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(192, 17);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 36;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Send to";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(65, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(121, 20);
            this.txtURL.TabIndex = 34;
            // 
            // bkgSendTo
            // 
            this.bkgSendTo.WorkerReportsProgress = true;
            this.bkgSendTo.WorkerSupportsCancellation = true;
            this.bkgSendTo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgSendTo_DoWork);
            this.bkgSendTo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgSendTo_ProgressChanged);
            this.bkgSendTo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgSendTo_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.tsTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 24);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(40, 19);
            this.tsStatus.Text = "None";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(414, 19);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel1.Text = "Time :";
            // 
            // tsTimer
            // 
            this.tsTimer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsTimer.Name = "tsTimer";
            this.tsTimer.Size = new System.Drawing.Size(25, 19);
            this.tsTimer.Text = "0 s";
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Location = new System.Drawing.Point(70, 105);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(0, 13);
            this.lbBarcode.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 418);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Endplay Check";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort srGTComp;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbST;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbST2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCOM2;
        private System.Windows.Forms.ComboBox cmbBaudRate2;
        private System.IO.Ports.SerialPort srBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbGTInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbProc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLine;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtURL;
        private System.ComponentModel.BackgroundWorker bkgSendTo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTimer;
        private System.Windows.Forms.NumericUpDown numCounter;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label lbBarcode;
    }
}

