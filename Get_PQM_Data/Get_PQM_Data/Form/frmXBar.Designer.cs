namespace Get_PQM_Data
{
    partial class frmXBar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDatet = new System.Windows.Forms.DateTimePicker();
            this.cmbMint = new System.Windows.Forms.ComboBox();
            this.cmbHourst = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDatef = new System.Windows.Forms.DateTimePicker();
            this.cmbMinf = new System.Windows.Forms.ComboBox();
            this.cmbHoursf = new System.Windows.Forms.ComboBox();
            this.grOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInsp = new System.Windows.Forms.ComboBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.cmbProc = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProcessing = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbNumline = new System.Windows.Forms.Label();
            this.txtSerno = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChOption = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbJudge = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grOption.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtDatet);
            this.groupBox3.Controls.Add(this.cmbMint);
            this.groupBox3.Controls.Add(this.cmbHourst);
            this.groupBox3.Location = new System.Drawing.Point(338, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 51);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To date";
            // 
            // dtDatet
            // 
            this.dtDatet.CustomFormat = "yyyy-MM-dd";
            this.dtDatet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatet.Location = new System.Drawing.Point(6, 19);
            this.dtDatet.Name = "dtDatet";
            this.dtDatet.Size = new System.Drawing.Size(106, 20);
            this.dtDatet.TabIndex = 19;
            // 
            // cmbMint
            // 
            this.cmbMint.FormattingEnabled = true;
            this.cmbMint.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMint.Location = new System.Drawing.Point(177, 18);
            this.cmbMint.Name = "cmbMint";
            this.cmbMint.Size = new System.Drawing.Size(53, 21);
            this.cmbMint.TabIndex = 18;
            this.cmbMint.Text = "59";
            // 
            // cmbHourst
            // 
            this.cmbHourst.FormattingEnabled = true;
            this.cmbHourst.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHourst.Location = new System.Drawing.Point(118, 18);
            this.cmbHourst.Name = "cmbHourst";
            this.cmbHourst.Size = new System.Drawing.Size(53, 21);
            this.cmbHourst.TabIndex = 17;
            this.cmbHourst.Text = "23";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDatef);
            this.groupBox2.Controls.Add(this.cmbMinf);
            this.groupBox2.Controls.Add(this.cmbHoursf);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 51);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From date";
            // 
            // dtDatef
            // 
            this.dtDatef.CustomFormat = "yyyy-MM-dd";
            this.dtDatef.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatef.Location = new System.Drawing.Point(6, 21);
            this.dtDatef.Name = "dtDatef";
            this.dtDatef.Size = new System.Drawing.Size(106, 20);
            this.dtDatef.TabIndex = 0;
            // 
            // cmbMinf
            // 
            this.cmbMinf.FormattingEnabled = true;
            this.cmbMinf.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinf.Location = new System.Drawing.Point(177, 20);
            this.cmbMinf.Name = "cmbMinf";
            this.cmbMinf.Size = new System.Drawing.Size(53, 21);
            this.cmbMinf.TabIndex = 18;
            this.cmbMinf.Text = "00";
            // 
            // cmbHoursf
            // 
            this.cmbHoursf.FormattingEnabled = true;
            this.cmbHoursf.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHoursf.Location = new System.Drawing.Point(118, 20);
            this.cmbHoursf.Name = "cmbHoursf";
            this.cmbHoursf.Size = new System.Drawing.Size(53, 21);
            this.cmbHoursf.TabIndex = 17;
            this.cmbHoursf.Text = "00";
            // 
            // grOption
            // 
            this.grOption.Controls.Add(this.label1);
            this.grOption.Controls.Add(this.cmbInsp);
            this.grOption.Controls.Add(this.cmbSite);
            this.grOption.Controls.Add(this.label7);
            this.grOption.Controls.Add(this.label6);
            this.grOption.Controls.Add(this.label5);
            this.grOption.Controls.Add(this.cmbLine);
            this.grOption.Controls.Add(this.label4);
            this.grOption.Controls.Add(this.cmbFac);
            this.grOption.Controls.Add(this.cmbProc);
            this.grOption.Enabled = false;
            this.grOption.Location = new System.Drawing.Point(4, 65);
            this.grOption.Name = "grOption";
            this.grOption.Size = new System.Drawing.Size(202, 149);
            this.grOption.TabIndex = 19;
            this.grOption.TabStop = false;
            this.grOption.Text = "Option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Inspect Item";
            // 
            // cmbInsp
            // 
            this.cmbInsp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInsp.FormattingEnabled = true;
            this.cmbInsp.Location = new System.Drawing.Point(77, 120);
            this.cmbInsp.Name = "cmbInsp";
            this.cmbInsp.Size = new System.Drawing.Size(119, 21);
            this.cmbInsp.TabIndex = 35;
            this.cmbInsp.Text = "-----Select Inspect-----";
            // 
            // cmbSite
            // 
            this.cmbSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(77, 16);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(119, 21);
            this.cmbSite.TabIndex = 34;
            this.cmbSite.Text = "-----Select Site-----";
            this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Factory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Site";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Line";
            // 
            // cmbLine
            // 
            this.cmbLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(77, 68);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(119, 21);
            this.cmbLine.TabIndex = 15;
            this.cmbLine.Text = "-----Select Line-----";
            this.cmbLine.SelectedIndexChanged += new System.EventHandler(this.cmbLine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Process";
            // 
            // cmbFac
            // 
            this.cmbFac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Location = new System.Drawing.Point(77, 42);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(119, 21);
            this.cmbFac.TabIndex = 13;
            this.cmbFac.Text = "-----Select Factory-----";
            this.cmbFac.SelectedIndexChanged += new System.EventHandler(this.cmbFac_SelectedIndexChanged);
            // 
            // cmbProc
            // 
            this.cmbProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProc.FormattingEnabled = true;
            this.cmbProc.Location = new System.Drawing.Point(77, 94);
            this.cmbProc.Name = "cmbProc";
            this.cmbProc.Size = new System.Drawing.Size(119, 21);
            this.cmbProc.TabIndex = 11;
            this.cmbProc.Text = "-----Select Process-----";
            this.cmbProc.SelectedIndexChanged += new System.EventHandler(this.cmbProc_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrower);
            this.groupBox4.Controls.Add(this.txtURL);
            this.groupBox4.Location = new System.Drawing.Point(338, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 45);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Load Serial From CSV";
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(189, 19);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(41, 20);
            this.btnBrower.TabIndex = 26;
            this.btnBrower.Text = "...";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(6, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(177, 20);
            this.txtURL.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProcessing,
            this.tsSpace,
            this.tsTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 24);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProcessing
            // 
            this.tsProcessing.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsProcessing.Name = "tsProcessing";
            this.tsProcessing.Size = new System.Drawing.Size(40, 19);
            this.tsProcessing.Text = "None";
            // 
            // tsSpace
            // 
            this.tsSpace.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsSpace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSpace.Name = "tsSpace";
            this.tsSpace.Size = new System.Drawing.Size(508, 19);
            this.tsSpace.Spring = true;
            this.tsSpace.Text = "None";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsTime.Name = "tsTime";
            this.tsTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsTime.Size = new System.Drawing.Size(25, 19);
            this.tsTime.Text = "0 s";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbNumline);
            this.groupBox5.Controls.Add(this.txtSerno);
            this.groupBox5.Location = new System.Drawing.Point(209, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 202);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serial Input";
            // 
            // lbNumline
            // 
            this.lbNumline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumline.AutoSize = true;
            this.lbNumline.Location = new System.Drawing.Point(85, 176);
            this.lbNumline.Name = "lbNumline";
            this.lbNumline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNumline.Size = new System.Drawing.Size(32, 13);
            this.lbNumline.TabIndex = 9;
            this.lbNumline.Text = "0 line";
            this.lbNumline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerno
            // 
            this.txtSerno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerno.Location = new System.Drawing.Point(3, 16);
            this.txtSerno.Multiline = true;
            this.txtSerno.Name = "txtSerno";
            this.txtSerno.Size = new System.Drawing.Size(117, 152);
            this.txtSerno.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbModel);
            this.groupBox6.Location = new System.Drawing.Point(4, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(132, 47);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(9, 16);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(117, 21);
            this.cmbModel.TabIndex = 10;
            this.cmbModel.Text = "-----Select Model-----";
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnLoad);
            this.groupBox9.Controls.Add(this.btnCSV);
            this.groupBox9.Controls.Add(this.btnView);
            this.groupBox9.Controls.Add(this.btnExit);
            this.groupBox9.Controls.Add(this.btnChOption);
            this.groupBox9.Location = new System.Drawing.Point(4, 214);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(573, 60);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(369, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load CSV";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(249, 19);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "Export CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(129, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(489, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChOption
            // 
            this.btnChOption.Location = new System.Drawing.Point(9, 19);
            this.btnChOption.Name = "btnChOption";
            this.btnChOption.Size = new System.Drawing.Size(75, 23);
            this.btnChOption.TabIndex = 0;
            this.btnChOption.Text = "Chart Option";
            this.btnChOption.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmbJudge);
            this.groupBox8.Location = new System.Drawing.Point(338, 168);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(112, 46);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Judgment";
            // 
            // cmbJudge
            // 
            this.cmbJudge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbJudge.FormattingEnabled = true;
            this.cmbJudge.Items.AddRange(new object[] {
            "All",
            "OK",
            "NG"});
            this.cmbJudge.Location = new System.Drawing.Point(6, 19);
            this.cmbJudge.Name = "cmbJudge";
            this.cmbJudge.Size = new System.Drawing.Size(100, 21);
            this.cmbJudge.TabIndex = 33;
            this.cmbJudge.Text = "All";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtLot);
            this.groupBox7.Location = new System.Drawing.Point(456, 168);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 46);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lot";
            // 
            // txtLot
            // 
            this.txtLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLot.Location = new System.Drawing.Point(6, 20);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(109, 20);
            this.txtLot.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmXBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 301);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grOption);
            this.Name = "frmXBar";
            this.Text = "XBar-R Chart";
            this.Load += new System.EventHandler(this.frmXBar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grOption.ResumeLayout(false);
            this.grOption.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtDatet;
        private System.Windows.Forms.ComboBox cmbMint;
        private System.Windows.Forms.ComboBox cmbHourst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDatef;
        private System.Windows.Forms.ComboBox cmbMinf;
        private System.Windows.Forms.ComboBox cmbHoursf;
        private System.Windows.Forms.GroupBox grOption;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsProcessing;
        private System.Windows.Forms.ToolStripStatusLabel tsSpace;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInsp;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.ComboBox cmbProc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSerno;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChOption;
        private System.Windows.Forms.Label lbNumline;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cmbJudge;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Timer timer1;
    }
}