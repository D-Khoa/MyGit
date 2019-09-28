namespace EndplayGTCheck.FormCommon
{
    partial class CommonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 75);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Green;
            this.splitContainer1.Panel1.BackgroundImage = global::EndplayGTCheck.Properties.Resources.NIDEC_Logo_small_1;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.CausesValidation = false;
            this.splitContainer1.Panel1.Enabled = false;
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "";
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Green;
            this.splitContainer1.Panel2.CausesValidation = false;
            this.splitContainer1.Panel2.Controls.Add(this.lbTitle);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(633, 75);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Enabled = false;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(485, 75);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Name";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 461);
            this.Controls.Add(this.panel1);
            this.Name = "CommonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbTitle;
    }
}