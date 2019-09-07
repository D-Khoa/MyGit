namespace FA_Schedule
{
    partial class frmUpPlan
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
            this.numStt = new System.Windows.Forms.NumericUpDown();
            this.dtAdj = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.cbFinish = new System.Windows.Forms.CheckBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // numStt
            // 
            this.numStt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStt.Location = new System.Drawing.Point(113, 13);
            this.numStt.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numStt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStt.Name = "numStt";
            this.numStt.Size = new System.Drawing.Size(109, 20);
            this.numStt.TabIndex = 38;
            this.numStt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStt.ValueChanged += new System.EventHandler(this.numStt_ValueChanged);
            // 
            // dtAdj
            // 
            this.dtAdj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAdj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdj.Location = new System.Drawing.Point(113, 60);
            this.dtAdj.Name = "dtAdj";
            this.dtAdj.ShowCheckBox = true;
            this.dtAdj.Size = new System.Drawing.Size(109, 20);
            this.dtAdj.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date_Adjusted";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(159, 324);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 50);
            this.btnCancle.TabIndex = 33;
            this.btnCancle.Text = "Close";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comment";
            // 
            // txtCmt
            // 
            this.txtCmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmt.Location = new System.Drawing.Point(72, 195);
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(150, 88);
            this.txtCmt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status_ID";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(30, 324);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 50);
            this.btnUp.TabIndex = 23;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // cbFinish
            // 
            this.cbFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFinish.AutoSize = true;
            this.cbFinish.Location = new System.Drawing.Point(122, 171);
            this.cbFinish.Name = "cbFinish";
            this.cbFinish.Size = new System.Drawing.Size(53, 17);
            this.cbFinish.TabIndex = 40;
            this.cbFinish.Text = "Finish";
            this.cbFinish.UseVisualStyleBackColor = true;
            this.cbFinish.CheckedChanged += new System.EventHandler(this.cbFinish_CheckedChanged);
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.label5);
            this.pnlOption.Controls.Add(this.label3);
            this.pnlOption.Controls.Add(this.txtContent);
            this.pnlOption.Controls.Add(this.label2);
            this.pnlOption.Controls.Add(this.lbStt);
            this.pnlOption.Controls.Add(this.cbFinish);
            this.pnlOption.Controls.Add(this.label7);
            this.pnlOption.Controls.Add(this.txtCmt);
            this.pnlOption.Controls.Add(this.dtAdj);
            this.pnlOption.Controls.Add(this.numStt);
            this.pnlOption.Controls.Add(this.label6);
            this.pnlOption.Controls.Add(this.label4);
            this.pnlOption.Location = new System.Drawing.Point(12, 12);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(241, 306);
            this.pnlOption.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Result_Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(72, 87);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(150, 77);
            this.txtContent.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Status_Name";
            // 
            // lbStt
            // 
            this.lbStt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStt.AutoSize = true;
            this.lbStt.Location = new System.Drawing.Point(110, 40);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(35, 13);
            this.lbStt.TabIndex = 41;
            this.lbStt.Text = "status";
            // 
            // frmUpPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 382);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUpPlan";
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStt;
        private System.Windows.Forms.DateTimePicker dtAdj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.CheckBox cbFinish;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStt;
    }
}