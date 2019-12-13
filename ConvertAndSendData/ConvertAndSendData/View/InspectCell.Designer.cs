namespace ConvertAndSendData.View
{
    partial class InspectCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbInspectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.lbYeild = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lbYeild);
            this.pnlInfo.Controls.Add(this.lbOutput);
            this.pnlInfo.Controls.Add(this.lbInput);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.lbInspectName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(183, 180);
            this.pnlInfo.TabIndex = 0;
            // 
            // lbInspectName
            // 
            this.lbInspectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInspectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInspectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInspectName.Location = new System.Drawing.Point(0, 0);
            this.lbInspectName.Name = "lbInspectName";
            this.lbInspectName.Size = new System.Drawing.Size(181, 42);
            this.lbInspectName.TabIndex = 0;
            this.lbInspectName.Text = "Inspect Name";
            this.lbInspectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeild :";
            // 
            // lbInput
            // 
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(84, 47);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(71, 33);
            this.lbInput.TabIndex = 4;
            this.lbInput.Text = "Input";
            this.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOutput
            // 
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Location = new System.Drawing.Point(84, 93);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(71, 33);
            this.lbOutput.TabIndex = 5;
            this.lbOutput.Text = "Output";
            this.lbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYeild
            // 
            this.lbYeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYeild.Location = new System.Drawing.Point(84, 139);
            this.lbYeild.Name = "lbYeild";
            this.lbYeild.Size = new System.Drawing.Size(71, 33);
            this.lbYeild.TabIndex = 6;
            this.lbYeild.Text = "Yeild";
            this.lbYeild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InspectCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfo);
            this.Name = "InspectCell";
            this.Size = new System.Drawing.Size(180, 180);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InspectCell_Paint);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbInspectName;
        private System.Windows.Forms.Label lbYeild;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
