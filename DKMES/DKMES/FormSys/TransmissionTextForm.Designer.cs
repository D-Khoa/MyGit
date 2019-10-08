namespace DKMES.FormSys
{
    partial class TransmissionTextForm
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
            this.txtIPCLient = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortServer = new System.Windows.Forms.MaskedTextBox();
            this.txtPortClient = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIPSV = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsSVStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtChatBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIPCLient
            // 
            this.txtIPCLient.Location = new System.Drawing.Point(63, 82);
            this.txtIPCLient.Name = "txtIPCLient";
            this.txtIPCLient.Size = new System.Drawing.Size(91, 20);
            this.txtIPCLient.TabIndex = 1;
            this.txtIPCLient.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Client";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(121, 56);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(33, 20);
            this.txtPortServer.TabIndex = 4;
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(121, 108);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(33, 20);
            this.txtPortClient.TabIndex = 5;
            this.txtPortClient.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIPSV);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIPCLient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPortServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // lbIPSV
            // 
            this.lbIPSV.AutoSize = true;
            this.lbIPSV.Location = new System.Drawing.Point(63, 33);
            this.lbIPSV.Name = "lbIPSV";
            this.lbIPSV.Size = new System.Drawing.Size(88, 13);
            this.lbIPSV.TabIndex = 9;
            this.lbIPSV.Text = "000.000.000.000";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(40, 134);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(179, 123);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(223, 52);
            this.txtSend.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(408, 123);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 52);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSVStatus,
            this.tsCLStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 180);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(495, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsSVStatus
            // 
            this.tsSVStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsSVStatus.Name = "tsSVStatus";
            this.tsSVStatus.Size = new System.Drawing.Size(240, 19);
            this.tsSVStatus.Spring = true;
            this.tsSVStatus.Text = "None";
            // 
            // tsCLStatus
            // 
            this.tsCLStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsCLStatus.Name = "tsCLStatus";
            this.tsCLStatus.Size = new System.Drawing.Size(240, 19);
            this.tsCLStatus.Spring = true;
            this.tsCLStatus.Text = "None";
            // 
            // txtChatBox
            // 
            this.txtChatBox.AcceptsTab = true;
            this.txtChatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatBox.AutoWordSelection = true;
            this.txtChatBox.BulletIndent = 2;
            this.txtChatBox.Location = new System.Drawing.Point(179, 12);
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.ReadOnly = true;
            this.txtChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChatBox.Size = new System.Drawing.Size(304, 105);
            this.txtChatBox.TabIndex = 13;
            this.txtChatBox.Text = "";
            this.txtChatBox.TextChanged += new System.EventHandler(this.txtChatBox_TextChanged);
            // 
            // TransmissionTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 204);
            this.Controls.Add(this.txtChatBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransmissionTextForm";
            this.Text = "TransmissionTextForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtIPCLient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPortServer;
        private System.Windows.Forms.MaskedTextBox txtPortClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsSVStatus;
        private System.Windows.Forms.Label lbIPSV;
        private System.Windows.Forms.ToolStripStatusLabel tsCLStatus;
        private System.Windows.Forms.RichTextBox txtChatBox;
    }
}