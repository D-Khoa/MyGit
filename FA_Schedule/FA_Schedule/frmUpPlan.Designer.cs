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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchName = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.cbFinish = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).BeginInit();
            this.SuspendLayout();
            // 
            // numStt
            // 
            this.numStt.Location = new System.Drawing.Point(84, 59);
            this.numStt.Name = "numStt";
            this.numStt.Size = new System.Drawing.Size(100, 20);
            this.numStt.TabIndex = 38;
            // 
            // dtAdj
            // 
            this.dtAdj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdj.Location = new System.Drawing.Point(84, 85);
            this.dtAdj.Name = "dtAdj";
            this.dtAdj.Size = new System.Drawing.Size(100, 20);
            this.dtAdj.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date Adjust";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(109, 228);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 33;
            this.btnCancle.Text = "Close";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comment";
            // 
            // txtCmt
            // 
            this.txtCmt.Location = new System.Drawing.Point(84, 134);
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(100, 88);
            this.txtCmt.TabIndex = 31;
            this.txtCmt.Text = "\'\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "PIC";
            // 
            // txtPIC
            // 
            this.txtPIC.Location = new System.Drawing.Point(84, 35);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(100, 20);
            this.txtPIC.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // txtSchName
            // 
            this.txtSchName.Location = new System.Drawing.Point(84, 11);
            this.txtSchName.Name = "txtSchName";
            this.txtSchName.Size = new System.Drawing.Size(100, 20);
            this.txtSchName.TabIndex = 24;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(17, 228);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 23;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // cbFinish
            // 
            this.cbFinish.AutoSize = true;
            this.cbFinish.Location = new System.Drawing.Point(84, 111);
            this.cbFinish.Name = "cbFinish";
            this.cbFinish.Size = new System.Drawing.Size(53, 17);
            this.cbFinish.TabIndex = 40;
            this.cbFinish.Text = "Finish";
            this.cbFinish.UseVisualStyleBackColor = true;
            this.cbFinish.CheckedChanged += new System.EventHandler(this.cbFinish_CheckedChanged);
            // 
            // frmUpPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 259);
            this.Controls.Add(this.cbFinish);
            this.Controls.Add(this.numStt);
            this.Controls.Add(this.dtAdj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSchName);
            this.Controls.Add(this.btnUp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUpPlan";
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStt;
        private System.Windows.Forms.DateTimePicker dtAdj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchName;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.CheckBox cbFinish;
    }
}