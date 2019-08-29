namespace Modules
{
    partial class BaseDice
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
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnDice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(3, 3);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(138, 138);
            this.picDice1.TabIndex = 0;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(147, 3);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(138, 138);
            this.picDice2.TabIndex = 1;
            this.picDice2.TabStop = false;
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(105, 147);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(75, 23);
            this.btnDice.TabIndex = 2;
            this.btnDice.Text = "Dice";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // BaseDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Name = "BaseDice";
            this.Size = new System.Drawing.Size(292, 179);
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnDice;
    }
}
