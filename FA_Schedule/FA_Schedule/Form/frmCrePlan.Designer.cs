namespace FA_Schedule
{
    partial class frmCrePlan
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
            this.btnCre = new System.Windows.Forms.Button();
            this.txtSchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCre = new System.Windows.Forms.DateTimePicker();
            this.dtOri = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numStt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCre
            // 
            this.btnCre.Location = new System.Drawing.Point(16, 308);
            this.btnCre.Name = "btnCre";
            this.btnCre.Size = new System.Drawing.Size(75, 23);
            this.btnCre.TabIndex = 0;
            this.btnCre.Text = "Create";
            this.btnCre.UseVisualStyleBackColor = true;
            this.btnCre.Click += new System.EventHandler(this.btnCre_Click);
            // 
            // txtSchName
            // 
            this.txtSchName.Location = new System.Drawing.Point(83, 58);
            this.txtSchName.Name = "txtSchName";
            this.txtSchName.Size = new System.Drawing.Size(100, 20);
            this.txtSchName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(83, 84);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PIC";
            // 
            // txtPIC
            // 
            this.txtPIC.Location = new System.Drawing.Point(83, 110);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(100, 20);
            this.txtPIC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(108, 308);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "Close";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date Create";
            // 
            // dtCre
            // 
            this.dtCre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCre.Location = new System.Drawing.Point(83, 162);
            this.dtCre.Name = "dtCre";
            this.dtCre.Size = new System.Drawing.Size(100, 20);
            this.dtCre.TabIndex = 19;
            // 
            // dtOri
            // 
            this.dtOri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOri.Location = new System.Drawing.Point(83, 188);
            this.dtOri.Name = "dtOri";
            this.dtOri.Size = new System.Drawing.Size(100, 20);
            this.dtOri.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date Original";
            // 
            // txtCmt
            // 
            this.txtCmt.Location = new System.Drawing.Point(83, 214);
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(100, 88);
            this.txtCmt.TabIndex = 13;
            this.txtCmt.Text = "\'\'";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comment";
            // 
            // numStt
            // 
            this.numStt.Location = new System.Drawing.Point(83, 136);
            this.numStt.Name = "numStt";
            this.numStt.Size = new System.Drawing.Size(100, 20);
            this.numStt.TabIndex = 22;
            // 
            // frmCrePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 342);
            this.Controls.Add(this.numStt);
            this.Controls.Add(this.dtOri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtCre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSchName);
            this.Controls.Add(this.btnCre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrePlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCrePlan";
            ((System.ComponentModel.ISupportInitialize)(this.numStt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCre;
        private System.Windows.Forms.TextBox txtSchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCre;
        private System.Windows.Forms.DateTimePicker dtOri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numStt;
    }
}