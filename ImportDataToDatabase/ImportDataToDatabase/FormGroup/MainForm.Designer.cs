namespace ImportDataToDatabase.FormGroup
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumCSV = new System.Windows.Forms.Label();
            this.txtFolderSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFSource = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFolderSave = new System.Windows.Forms.TextBox();
            this.btnFSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.bwSendData = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNumCSV);
            this.groupBox1.Controls.Add(this.txtFolderSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Source";
            // 
            // lbNumCSV
            // 
            this.lbNumCSV.AutoSize = true;
            this.lbNumCSV.Location = new System.Drawing.Point(127, 55);
            this.lbNumCSV.Name = "lbNumCSV";
            this.lbNumCSV.Size = new System.Drawing.Size(13, 13);
            this.lbNumCSV.TabIndex = 4;
            this.lbNumCSV.Text = "0";
            // 
            // txtFolderSource
            // 
            this.txtFolderSource.Location = new System.Drawing.Point(6, 19);
            this.txtFolderSource.Name = "txtFolderSource";
            this.txtFolderSource.Size = new System.Drawing.Size(167, 20);
            this.txtFolderSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numbers of file .csv :";
            // 
            // btnFSource
            // 
            this.btnFSource.Location = new System.Drawing.Point(179, 17);
            this.btnFSource.Name = "btnFSource";
            this.btnFSource.Size = new System.Drawing.Size(75, 23);
            this.btnFSource.TabIndex = 2;
            this.btnFSource.Text = "Browser";
            this.btnFSource.UseVisualStyleBackColor = true;
            this.btnFSource.Click += new System.EventHandler(this.btnFSource_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFolderSave);
            this.groupBox3.Controls.Add(this.btnFSave);
            this.groupBox3.Location = new System.Drawing.Point(12, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wrong Format Folder";
            // 
            // txtFolderSave
            // 
            this.txtFolderSave.Location = new System.Drawing.Point(6, 19);
            this.txtFolderSave.Name = "txtFolderSave";
            this.txtFolderSave.Size = new System.Drawing.Size(167, 20);
            this.txtFolderSave.TabIndex = 9;
            // 
            // btnFSave
            // 
            this.btnFSave.Location = new System.Drawing.Point(179, 17);
            this.btnFSave.Name = "btnFSave";
            this.btnFSave.Size = new System.Drawing.Size(75, 23);
            this.btnFSave.TabIndex = 2;
            this.btnFSave.Text = "Browser";
            this.btnFSave.UseVisualStyleBackColor = true;
            this.btnFSave.Click += new System.EventHandler(this.btnFSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tsStatus,
            this.toolStripStatusLabel1,
            this.tsTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(281, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 19);
            this.toolStripStatusLabel2.Text = "Status :";
            // 
            // tsStatus
            // 
            this.tsStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(145, 19);
            this.tsStatus.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 19);
            this.toolStripStatusLabel1.Text = "Timer :";
            // 
            // tsTimer
            // 
            this.tsTimer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsTimer.Name = "tsTimer";
            this.tsTimer.Size = new System.Drawing.Size(25, 19);
            this.tsTimer.Text = "0 s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.numTimer);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Timer set :";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(87, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(87, 19);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(75, 20);
            this.numTimer.TabIndex = 7;
            this.numTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bwSendData
            // 
            this.bwSendData.WorkerReportsProgress = true;
            this.bwSendData.WorkerSupportsCancellation = true;
            this.bwSendData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSendData_DoWork);
            this.bwSendData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSendData_ProgressChanged);
            this.bwSendData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSendData_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 272);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Import Data To DB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFSource;
        private System.Windows.Forms.TextBox txtFolderSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker bwSendData;
        private System.Windows.Forms.Label lbNumCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolderSave;
    }
}

