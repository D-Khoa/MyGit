namespace FA_Schedule
{
    partial class frmStt
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
            this.dgvStt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStt
            // 
            this.dgvStt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStt.Location = new System.Drawing.Point(0, 0);
            this.dgvStt.Name = "dgvStt";
            this.dgvStt.Size = new System.Drawing.Size(208, 259);
            this.dgvStt.TabIndex = 0;
            // 
            // frmStt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 259);
            this.Controls.Add(this.dgvStt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStt";
            this.ShowIcon = false;
            this.Text = "List Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStt;
    }
}