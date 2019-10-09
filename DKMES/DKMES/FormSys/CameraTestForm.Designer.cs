namespace DKMES.FormSys
{
    partial class CameraTestForm
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
            this.cmbListDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbListDevice
            // 
            this.cmbListDevice.FormattingEnabled = true;
            this.cmbListDevice.Location = new System.Drawing.Point(27, 32);
            this.cmbListDevice.Name = "cmbListDevice";
            this.cmbListDevice.Size = new System.Drawing.Size(121, 21);
            this.cmbListDevice.TabIndex = 0;
            // 
            // CameraTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbListDevice);
            this.Name = "CameraTestForm";
            this.Text = "CameraTestForm";
            this.Load += new System.EventHandler(this.CameraTestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListDevice;
    }
}