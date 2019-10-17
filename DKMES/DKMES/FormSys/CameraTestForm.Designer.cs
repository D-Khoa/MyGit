namespace DKMES.FormSys
{
    partial class CameraTestForm
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
            this.cmbListDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numOpt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackOpt = new System.Windows.Forms.TrackBar();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.trackR = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnHue = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnFrame = new System.Windows.Forms.Button();
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsSizeForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCap = new System.Windows.Forms.Button();
            this.pnPicBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbListDevice
            // 
            this.cmbListDevice.FormattingEnabled = true;
            this.cmbListDevice.Location = new System.Drawing.Point(55, 9);
            this.cmbListDevice.Name = "cmbListDevice";
            this.cmbListDevice.Size = new System.Drawing.Size(139, 21);
            this.cmbListDevice.TabIndex = 0;
            this.cmbListDevice.SelectedIndexChanged += new System.EventHandler(this.cmbListDevice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numOpt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackOpt);
            this.groupBox1.Controls.Add(this.numB);
            this.groupBox1.Controls.Add(this.numG);
            this.groupBox1.Controls.Add(this.numR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackB);
            this.groupBox1.Controls.Add(this.trackG);
            this.groupBox1.Controls.Add(this.trackR);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 221);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hue";
            // 
            // numOpt
            // 
            this.numOpt.Location = new System.Drawing.Point(145, 19);
            this.numOpt.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOpt.Name = "numOpt";
            this.numOpt.Size = new System.Drawing.Size(40, 20);
            this.numOpt.TabIndex = 26;
            this.numOpt.ValueChanged += new System.EventHandler(this.numOpt_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Opt";
            // 
            // trackOpt
            // 
            this.trackOpt.Location = new System.Drawing.Point(35, 17);
            this.trackOpt.Maximum = 255;
            this.trackOpt.Name = "trackOpt";
            this.trackOpt.Size = new System.Drawing.Size(104, 45);
            this.trackOpt.TabIndex = 24;
            this.trackOpt.ValueChanged += new System.EventHandler(this.trackOpt_Scroll);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(145, 172);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(40, 20);
            this.numB.TabIndex = 23;
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(145, 121);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(40, 20);
            this.numG.TabIndex = 22;
            this.numG.ValueChanged += new System.EventHandler(this.numG_ValueChanged);
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(145, 70);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(40, 20);
            this.numR.TabIndex = 21;
            this.numR.ValueChanged += new System.EventHandler(this.numR_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "R";
            // 
            // trackB
            // 
            this.trackB.Location = new System.Drawing.Point(35, 170);
            this.trackB.Maximum = 255;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(104, 45);
            this.trackB.TabIndex = 17;
            this.trackB.ValueChanged += new System.EventHandler(this.trackB_Scroll);
            // 
            // trackG
            // 
            this.trackG.Location = new System.Drawing.Point(35, 119);
            this.trackG.Maximum = 255;
            this.trackG.Name = "trackG";
            this.trackG.Size = new System.Drawing.Size(104, 45);
            this.trackG.TabIndex = 16;
            this.trackG.ValueChanged += new System.EventHandler(this.trackG_Scroll);
            // 
            // trackR
            // 
            this.trackR.Location = new System.Drawing.Point(35, 68);
            this.trackR.Maximum = 255;
            this.trackR.Name = "trackR";
            this.trackR.Size = new System.Drawing.Size(104, 45);
            this.trackR.TabIndex = 15;
            this.trackR.ValueChanged += new System.EventHandler(this.trackR_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Camera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNormal);
            this.groupBox2.Controls.Add(this.btnGreen);
            this.groupBox2.Controls.Add(this.btnBlue);
            this.groupBox2.Controls.Add(this.btnRed);
            this.groupBox2.Controls.Add(this.btnGrayscale);
            this.groupBox2.Controls.Add(this.btnHue);
            this.groupBox2.Location = new System.Drawing.Point(9, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Setting";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(17, 19);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 33);
            this.btnNormal.TabIndex = 21;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(110, 58);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 33);
            this.btnGreen.TabIndex = 20;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(110, 97);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 33);
            this.btnBlue.TabIndex = 19;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(110, 19);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 33);
            this.btnRed.TabIndex = 18;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(17, 97);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(75, 33);
            this.btnGrayscale.TabIndex = 17;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnHue
            // 
            this.btnHue.Location = new System.Drawing.Point(17, 58);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(75, 33);
            this.btnHue.TabIndex = 16;
            this.btnHue.Text = "Hue";
            this.btnHue.UseVisualStyleBackColor = true;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnRect);
            this.flowLayoutPanel1.Controls.Add(this.btnFrame);
            this.flowLayoutPanel1.Controls.Add(this.cmbSerial);
            this.flowLayoutPanel1.Controls.Add(this.btnConnect);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 424);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 66);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(3, 3);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(75, 23);
            this.btnRect.TabIndex = 0;
            this.btnRect.Text = "Rectance";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(84, 3);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(75, 23);
            this.btnFrame.TabIndex = 1;
            this.btnFrame.Text = "Frame";
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // cmbSerial
            // 
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Location = new System.Drawing.Point(3, 32);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(89, 21);
            this.cmbSerial.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(98, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSizeForm});
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsSizeForm
            // 
            this.tsSizeForm.Name = "tsSizeForm";
            this.tsSizeForm.Size = new System.Drawing.Size(854, 17);
            this.tsSizeForm.Spring = true;
            this.tsSizeForm.Text = "None";
            // 
            // btnCap
            // 
            this.btnCap.Location = new System.Drawing.Point(27, 36);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(75, 23);
            this.btnCap.TabIndex = 22;
            this.btnCap.Text = "Capture";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // pnPicBoxes
            // 
            this.pnPicBoxes.AutoScroll = true;
            this.pnPicBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPicBoxes.Location = new System.Drawing.Point(9, 496);
            this.pnPicBoxes.Name = "pnPicBoxes";
            this.pnPicBoxes.Size = new System.Drawing.Size(846, 185);
            this.pnPicBoxes.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // CameraTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 706);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnPicBoxes);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbListDevice);
            this.Name = "CameraTestForm";
            this.Text = "CameraTestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CameraTestForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CameraTestForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numOpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackOpt;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.TrackBar trackG;
        private System.Windows.Forms.TrackBar trackR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsSizeForm;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.FlowLayoutPanel pnPicBoxes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFrame;
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}