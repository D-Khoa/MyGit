namespace Main_Program
{
    partial class frmGamePlay
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
            this.baseCellPanel1 = new Modules.BaseCellPanel();
            this.SuspendLayout();
            // 
            // baseCellPanel1
            // 
            this.baseCellPanel1.Cell_name = "An Nam";
            this.baseCellPanel1.Cell_price = "3000";
            this.baseCellPanel1.ForeColor = System.Drawing.Color.Red;
            this.baseCellPanel1.Location = new System.Drawing.Point(122, 94);
            this.baseCellPanel1.Name = "baseCellPanel1";
            this.baseCellPanel1.Size = new System.Drawing.Size(72, 96);
            this.baseCellPanel1.TabIndex = 0;
            // 
            // frmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 437);
            this.Controls.Add(this.baseCellPanel1);
            this.Name = "frmGamePlay";
            this.Text = "frmGamePlay";
            this.Load += new System.EventHandler(this.frmGamePlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Modules.BaseCellPanel baseCellPanel1;
    }
}