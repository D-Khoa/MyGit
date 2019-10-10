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
            this.cmbListDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHue = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cmbListDevice
            // 
            this.cmbListDevice.FormattingEnabled = true;
            this.cmbListDevice.Location = new System.Drawing.Point(55, 32);
            this.cmbListDevice.Name = "cmbListDevice";
            this.cmbListDevice.Size = new System.Drawing.Size(139, 21);
            this.cmbListDevice.TabIndex = 0;
            this.cmbListDevice.SelectedIndexChanged += new System.EventHandler(this.cmbListDevice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 447);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnHue
            // 
            this.btnHue.Location = new System.Drawing.Point(9, 294);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(75, 23);
            this.btnHue.TabIndex = 15;
            this.btnHue.Text = "Hue";
            this.btnHue.UseVisualStyleBackColor = true;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
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
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hue";
            // 
            // numOpt
            // 
            this.numOpt.Location = new System.Drawing.Point(145, 17);
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
            this.trackOpt.Location = new System.Drawing.Point(35, 19);
            this.trackOpt.Maximum = 255;
            this.trackOpt.Name = "trackOpt";
            this.trackOpt.Size = new System.Drawing.Size(104, 45);
            this.trackOpt.TabIndex = 24;
            this.trackOpt.Scroll += new System.EventHandler(this.trackOpt_Scroll);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(145, 170);
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
            this.numG.Location = new System.Drawing.Point(145, 119);
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
            this.numR.Location = new System.Drawing.Point(145, 68);
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
            this.trackB.Location = new System.Drawing.Point(35, 172);
            this.trackB.Maximum = 255;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(104, 45);
            this.trackB.TabIndex = 17;
            this.trackB.Scroll += new System.EventHandler(this.trackB_Scroll);
            // 
            // trackG
            // 
            this.trackG.Location = new System.Drawing.Point(35, 121);
            this.trackG.Maximum = 255;
            this.trackG.Name = "trackG";
            this.trackG.Size = new System.Drawing.Size(104, 45);
            this.trackG.TabIndex = 16;
            this.trackG.Scroll += new System.EventHandler(this.trackG_Scroll);
            // 
            // trackR
            // 
            this.trackR.Location = new System.Drawing.Point(35, 70);
            this.trackR.Maximum = 255;
            this.trackR.Name = "trackR";
            this.trackR.Size = new System.Drawing.Size(104, 45);
            this.trackR.TabIndex = 15;
            this.trackR.Scroll += new System.EventHandler(this.trackR_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Camera";
            // 
            // CameraTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbListDevice);
            this.Name = "CameraTestForm";
            this.Text = "CameraTestForm";
            this.Load += new System.EventHandler(this.CameraTestForm_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHue;
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
    }
}