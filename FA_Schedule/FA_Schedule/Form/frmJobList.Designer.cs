namespace FA_Schedule
{
    partial class frmJobList
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
            this.btnCrePlan = new System.Windows.Forms.Button();
            this.btnUpPlan = new System.Windows.Forms.Button();
            this.btnCreItem = new System.Windows.Forms.Button();
            this.btnUpItem = new System.Windows.Forms.Button();
            this.userDetail1 = new FA_Schedule.UserDetail();
            this.SuspendLayout();
            // 
            // btnCrePlan
            // 
            this.btnCrePlan.Location = new System.Drawing.Point(43, 106);
            this.btnCrePlan.Name = "btnCrePlan";
            this.btnCrePlan.Size = new System.Drawing.Size(91, 23);
            this.btnCrePlan.TabIndex = 5;
            this.btnCrePlan.Text = "Tạo Plan";
            this.btnCrePlan.UseVisualStyleBackColor = true;
            this.btnCrePlan.Click += new System.EventHandler(this.btnCrePlan_Click);
            // 
            // btnUpPlan
            // 
            this.btnUpPlan.Location = new System.Drawing.Point(43, 145);
            this.btnUpPlan.Name = "btnUpPlan";
            this.btnUpPlan.Size = new System.Drawing.Size(91, 23);
            this.btnUpPlan.TabIndex = 6;
            this.btnUpPlan.Text = "Cập nhật plan";
            this.btnUpPlan.UseVisualStyleBackColor = true;
            this.btnUpPlan.Click += new System.EventHandler(this.btnUpPlan_Click);
            // 
            // btnCreItem
            // 
            this.btnCreItem.Location = new System.Drawing.Point(43, 183);
            this.btnCreItem.Name = "btnCreItem";
            this.btnCreItem.Size = new System.Drawing.Size(91, 23);
            this.btnCreItem.TabIndex = 7;
            this.btnCreItem.Text = "Tạo Item";
            this.btnCreItem.UseVisualStyleBackColor = true;
            // 
            // btnUpItem
            // 
            this.btnUpItem.Location = new System.Drawing.Point(43, 212);
            this.btnUpItem.Name = "btnUpItem";
            this.btnUpItem.Size = new System.Drawing.Size(91, 23);
            this.btnUpItem.TabIndex = 8;
            this.btnUpItem.Text = "Cập nhật Item";
            this.btnUpItem.UseVisualStyleBackColor = true;
            // 
            // userDetail1
            // 
            this.userDetail1.BackColor = System.Drawing.SystemColors.Control;
            this.userDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDetail1.Location = new System.Drawing.Point(0, 0);
            this.userDetail1.Name = "userDetail1";
            this.userDetail1.Size = new System.Drawing.Size(466, 73);
            this.userDetail1.TabIndex = 4;
            // 
            // frmJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 365);
            this.Controls.Add(this.btnUpItem);
            this.Controls.Add(this.btnCreItem);
            this.Controls.Add(this.btnUpPlan);
            this.Controls.Add(this.btnCrePlan);
            this.Controls.Add(this.userDetail1);
            this.Name = "frmJobList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FA Job";
            this.ResumeLayout(false);

        }

        #endregion
        private UserDetail userDetail1;
        private System.Windows.Forms.Button btnCrePlan;
        private System.Windows.Forms.Button btnUpPlan;
        private System.Windows.Forms.Button btnCreItem;
        private System.Windows.Forms.Button btnUpItem;
    }
}