namespace PushDataToServer
{
    partial class MainFrm
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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnBFrom = new System.Windows.Forms.Button();
            this.btnBTo = new System.Windows.Forms.Button();
            this.btnBTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(51, 65);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(224, 20);
            this.txtFrom.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(51, 157);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(51, 95);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(224, 20);
            this.txtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temp";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(51, 121);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(224, 20);
            this.txtTemp.TabIndex = 5;
            // 
            // btnBFrom
            // 
            this.btnBFrom.Location = new System.Drawing.Point(281, 63);
            this.btnBFrom.Name = "btnBFrom";
            this.btnBFrom.Size = new System.Drawing.Size(75, 23);
            this.btnBFrom.TabIndex = 7;
            this.btnBFrom.Text = "Browser";
            this.btnBFrom.UseVisualStyleBackColor = true;
            this.btnBFrom.Click += new System.EventHandler(this.btnBFrom_Click);
            // 
            // btnBTo
            // 
            this.btnBTo.Location = new System.Drawing.Point(281, 92);
            this.btnBTo.Name = "btnBTo";
            this.btnBTo.Size = new System.Drawing.Size(75, 23);
            this.btnBTo.TabIndex = 8;
            this.btnBTo.Text = "Browser";
            this.btnBTo.UseVisualStyleBackColor = true;
            this.btnBTo.Click += new System.EventHandler(this.btnBTo_Click);
            // 
            // btnBTemp
            // 
            this.btnBTemp.Location = new System.Drawing.Point(281, 119);
            this.btnBTemp.Name = "btnBTemp";
            this.btnBTemp.Size = new System.Drawing.Size(75, 23);
            this.btnBTemp.TabIndex = 9;
            this.btnBTemp.Text = "Browser";
            this.btnBTemp.UseVisualStyleBackColor = true;
            this.btnBTemp.Click += new System.EventHandler(this.btnBTemp_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 211);
            this.Controls.Add(this.btnBTemp);
            this.Controls.Add(this.btnBTo);
            this.Controls.Add(this.btnBFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtFrom);
            this.Name = "MainFrm";
            this.Text = "Push Data To Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnBFrom;
        private System.Windows.Forms.Button btnBTo;
        private System.Windows.Forms.Button btnBTemp;
    }
}

