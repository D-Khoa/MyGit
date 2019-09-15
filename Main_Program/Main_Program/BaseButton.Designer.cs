namespace Main_Program
{
    partial class BaseButton
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
            this.btnBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(37, 53);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(75, 23);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "Button";
            this.btnBase.UseVisualStyleBackColor = true;
            // 
            // BaseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBase);
            this.Name = "BaseButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
    }
}
