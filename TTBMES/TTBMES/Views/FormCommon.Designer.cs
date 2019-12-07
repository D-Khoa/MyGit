namespace TTBMES.Views
{
    partial class FormCommon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommon));
            this.Title_pnl = new System.Windows.Forms.Panel();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.FactoryCode_lbl = new System.Windows.Forms.Label();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppName_lbl = new System.Windows.Forms.Label();
            this.Title_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_pnl
            // 
            this.Title_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Title_pnl.Controls.Add(this.LogOut_btn);
            this.Title_pnl.Controls.Add(this.UserName_lbl);
            this.Title_pnl.Controls.Add(this.FactoryCode_lbl);
            this.Title_pnl.Controls.Add(this.Title_lbl);
            resources.ApplyResources(this.Title_pnl, "Title_pnl");
            this.Title_pnl.Name = "Title_pnl";
            // 
            // LogOut_btn
            // 
            resources.ApplyResources(this.LogOut_btn, "LogOut_btn");
            this.LogOut_btn.BackColor = System.Drawing.Color.Transparent;
            this.LogOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.UseVisualStyleBackColor = false;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // UserName_lbl
            // 
            resources.ApplyResources(this.UserName_lbl, "UserName_lbl");
            this.UserName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserName_lbl.Name = "UserName_lbl";
            // 
            // FactoryCode_lbl
            // 
            resources.ApplyResources(this.FactoryCode_lbl, "FactoryCode_lbl");
            this.FactoryCode_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FactoryCode_lbl.Name = "FactoryCode_lbl";
            // 
            // Title_lbl
            // 
            resources.ApplyResources(this.Title_lbl, "Title_lbl");
            this.Title_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Title_lbl.Name = "Title_lbl";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AppName_lbl);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TTBMES.Properties.Resources.NIDEC_Logo_small;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // AppName_lbl
            // 
            this.AppName_lbl.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.AppName_lbl, "AppName_lbl");
            this.AppName_lbl.Name = "AppName_lbl";
            // 
            // FormCommon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.Title_pnl);
            this.Controls.Add(this.panel1);
            this.Name = "FormCommon";
            this.Load += new System.EventHandler(this.FormCommon_Load);
            this.Title_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Title_pnl;
        private System.Windows.Forms.Label UserName_lbl;
        private System.Windows.Forms.Label FactoryCode_lbl;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AppName_lbl;
        private System.Windows.Forms.Panel panel2;
    }
}