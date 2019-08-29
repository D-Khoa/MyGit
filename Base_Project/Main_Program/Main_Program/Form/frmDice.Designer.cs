namespace Main_Program
{
    partial class frmDice
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
            this.baseDice1 = new Modules.BaseDice();
            this.SuspendLayout();
            // 
            // baseDice1
            // 
            this.baseDice1.BackColor = System.Drawing.Color.Transparent;
            this.baseDice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDice1.Location = new System.Drawing.Point(0, 0);
            this.baseDice1.Name = "baseDice1";
            this.baseDice1.Size = new System.Drawing.Size(290, 170);
            this.baseDice1.TabIndex = 0;
            // 
            // frmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 170);
            this.Controls.Add(this.baseDice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDice";
            this.ResumeLayout(false);

        }

        #endregion

        private Modules.BaseDice baseDice1;
    }
}