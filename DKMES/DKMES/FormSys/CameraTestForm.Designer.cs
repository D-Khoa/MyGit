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
            this.trackR = new System.Windows.Forms.TrackBar();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numOpt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackOpt = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListDevice
            // 
            this.cmbListDevice.FormattingEnabled = true;
            this.cmbListDevice.Location = new System.Drawing.Point(27, 32);
            this.cmbListDevice.Name = "cmbListDevice";
            this.cmbListDevice.Size = new System.Drawing.Size(121, 21);
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
            this.pictureBox1.Size = new System.Drawing.Size(386, 352);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // trackR
            // 
            this.trackR.Location = new System.Drawing.Point(44, 153);
            this.trackR.Maximum = 255;
            this.trackR.Name = "trackR";
            this.trackR.Size = new System.Drawing.Size(104, 45);
            this.trackR.TabIndex = 3;
            this.trackR.Scroll += new System.EventHandler(this.trackR_Scroll);
            // 
            // trackG
            // 
            this.trackG.Location = new System.Drawing.Point(44, 204);
            this.trackG.Maximum = 255;
            this.trackG.Name = "trackG";
            this.trackG.Size = new System.Drawing.Size(104, 45);
            this.trackG.TabIndex = 4;
            this.trackG.Scroll += new System.EventHandler(this.trackG_Scroll);
            // 
            // trackB
            // 
            this.trackB.Location = new System.Drawing.Point(44, 255);
            this.trackB.Maximum = 255;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(104, 45);
            this.trackB.TabIndex = 5;
            this.trackB.Scroll += new System.EventHandler(this.trackB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(154, 151);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(40, 20);
            this.numR.TabIndex = 9;
            this.numR.ValueChanged += new System.EventHandler(this.numR_ValueChanged);
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(154, 202);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(40, 20);
            this.numG.TabIndex = 10;
            this.numG.ValueChanged += new System.EventHandler(this.numG_ValueChanged);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(154, 253);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(40, 20);
            this.numB.TabIndex = 11;
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // numOpt
            // 
            this.numOpt.Location = new System.Drawing.Point(154, 100);
            this.numOpt.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOpt.Name = "numOpt";
            this.numOpt.Size = new System.Drawing.Size(40, 20);
            this.numOpt.TabIndex = 14;
            this.numOpt.ValueChanged += new System.EventHandler(this.numOpt_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Opt";
            // 
            // trackOpt
            // 
            this.trackOpt.Location = new System.Drawing.Point(44, 102);
            this.trackOpt.Maximum = 255;
            this.trackOpt.Name = "trackOpt";
            this.trackOpt.Size = new System.Drawing.Size(104, 45);
            this.trackOpt.TabIndex = 12;
            this.trackOpt.Scroll += new System.EventHandler(this.trackOpt_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numOpt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackOpt);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackB);
            this.Controls.Add(this.trackG);
            this.Controls.Add(this.trackR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbListDevice);
            this.Name = "CameraTestForm";
            this.Text = "CameraTestForm";
            this.Load += new System.EventHandler(this.CameraTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackR;
        private System.Windows.Forms.TrackBar trackG;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numOpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackOpt;
        private System.Windows.Forms.Button button1;
    }
}