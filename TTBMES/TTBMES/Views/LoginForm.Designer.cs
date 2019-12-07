namespace TTBMES.Views
{
    partial class LoginForm
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
            this.AppName_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.AppName_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 72);
            this.panel1.TabIndex = 0;
            // 
            // AppName_lbl
            // 
            this.AppName_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName_lbl.Location = new System.Drawing.Point(151, 0);
            this.AppName_lbl.Name = "AppName_lbl";
            this.AppName_lbl.Size = new System.Drawing.Size(190, 72);
            this.AppName_lbl.TabIndex = 1;
            this.AppName_lbl.Text = "MANAGEMENT SYSTEM";
            this.AppName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TTBMES.Properties.Resources.NIDEC_Logo_small;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 72);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(119, 127);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(153, 20);
            this.Password_txt.TabIndex = 2;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(55, 166);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(75, 35);
            this.LogIn_btn.TabIndex = 3;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_btn.Location = new System.Drawing.Point(197, 166);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 35);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(119, 87);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(153, 20);
            this.Username_txt.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LogIn_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_btn;
            this.ClientSize = new System.Drawing.Size(341, 234);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppName_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox Username_txt;
    }
}