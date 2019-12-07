namespace TTBMES.Views
{
    partial class MainForm
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
            this.FinalCheck_btn = new System.Windows.Forms.Button();
            this.Statistic_btn = new System.Windows.Forms.Button();
            this.Shipping_btn = new System.Windows.Forms.Button();
            this.Dataview_btn = new System.Windows.Forms.Button();
            this.Tracking_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinalCheck_btn
            // 
            this.FinalCheck_btn.Location = new System.Drawing.Point(25, 169);
            this.FinalCheck_btn.Name = "FinalCheck_btn";
            this.FinalCheck_btn.Size = new System.Drawing.Size(110, 44);
            this.FinalCheck_btn.TabIndex = 3;
            this.FinalCheck_btn.Text = "Final Check";
            this.FinalCheck_btn.UseVisualStyleBackColor = true;
            this.FinalCheck_btn.Click += new System.EventHandler(this.FinalCheck_btn_Click);
            // 
            // Statistic_btn
            // 
            this.Statistic_btn.Location = new System.Drawing.Point(25, 110);
            this.Statistic_btn.Name = "Statistic_btn";
            this.Statistic_btn.Size = new System.Drawing.Size(110, 44);
            this.Statistic_btn.TabIndex = 4;
            this.Statistic_btn.Text = "Data statistics";
            this.Statistic_btn.UseVisualStyleBackColor = true;
            this.Statistic_btn.Click += new System.EventHandler(this.Statistic_btn_Click);
            // 
            // Shipping_btn
            // 
            this.Shipping_btn.Location = new System.Drawing.Point(188, 169);
            this.Shipping_btn.Name = "Shipping_btn";
            this.Shipping_btn.Size = new System.Drawing.Size(110, 44);
            this.Shipping_btn.TabIndex = 5;
            this.Shipping_btn.Text = "Shipment Tool";
            this.Shipping_btn.UseVisualStyleBackColor = true;
            this.Shipping_btn.Click += new System.EventHandler(this.Shipping_btn_Click);
            // 
            // Dataview_btn
            // 
            this.Dataview_btn.Location = new System.Drawing.Point(351, 110);
            this.Dataview_btn.Name = "Dataview_btn";
            this.Dataview_btn.Size = new System.Drawing.Size(110, 44);
            this.Dataview_btn.TabIndex = 6;
            this.Dataview_btn.Text = "PQM Dataview";
            this.Dataview_btn.UseVisualStyleBackColor = true;
            this.Dataview_btn.Click += new System.EventHandler(this.Dataview_btn_Click);
            // 
            // Tracking_btn
            // 
            this.Tracking_btn.Location = new System.Drawing.Point(188, 110);
            this.Tracking_btn.Name = "Tracking_btn";
            this.Tracking_btn.Size = new System.Drawing.Size(110, 44);
            this.Tracking_btn.TabIndex = 7;
            this.Tracking_btn.Text = "Production Tracking";
            this.Tracking_btn.UseVisualStyleBackColor = true;
            this.Tracking_btn.Click += new System.EventHandler(this.Tracking_btn_Click);
            // 
            // MainForm
            // 
            this.AppName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 232);
            this.Controls.Add(this.Tracking_btn);
            this.Controls.Add(this.Dataview_btn);
            this.Controls.Add(this.Shipping_btn);
            this.Controls.Add(this.Statistic_btn);
            this.Controls.Add(this.FinalCheck_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TitleText = "FormCommon";
            this.Controls.SetChildIndex(this.FinalCheck_btn, 0);
            this.Controls.SetChildIndex(this.Statistic_btn, 0);
            this.Controls.SetChildIndex(this.Shipping_btn, 0);
            this.Controls.SetChildIndex(this.Dataview_btn, 0);
            this.Controls.SetChildIndex(this.Tracking_btn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FinalCheck_btn;
        private System.Windows.Forms.Button Statistic_btn;
        private System.Windows.Forms.Button Shipping_btn;
        private System.Windows.Forms.Button Dataview_btn;
        private System.Windows.Forms.Button Tracking_btn;
    }
}