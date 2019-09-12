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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPStt = new System.Windows.Forms.Button();
            this.btnIStt = new System.Windows.Forms.Button();
            this.btnUpItem = new System.Windows.Forms.Button();
            this.btnCreItem = new System.Windows.Forms.Button();
            this.btnUpPlan = new System.Windows.Forms.Button();
            this.btnCrePlan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUpLog = new System.Windows.Forms.DataGridView();
            this.pnlFin = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpLog)).BeginInit();
            this.pnlFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LimeGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 60);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FA_Schedule.Properties.Resources.LogoNidec;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 54);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAN SCHEDULE MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 118);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPStt);
            this.splitContainer1.Panel1.Controls.Add(this.btnIStt);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpItem);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreItem);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpPlan);
            this.splitContainer1.Panel1.Controls.Add(this.btnCrePlan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.pnlFin);
            this.splitContainer1.Size = new System.Drawing.Size(691, 364);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 21;
            // 
            // btnPStt
            // 
            this.btnPStt.Location = new System.Drawing.Point(11, 132);
            this.btnPStt.Name = "btnPStt";
            this.btnPStt.Size = new System.Drawing.Size(91, 23);
            this.btnPStt.TabIndex = 37;
            this.btnPStt.Text = "Plan Status";
            this.btnPStt.UseVisualStyleBackColor = true;
            this.btnPStt.Click += new System.EventHandler(this.btnPStt_Click);
            // 
            // btnIStt
            // 
            this.btnIStt.Location = new System.Drawing.Point(11, 161);
            this.btnIStt.Name = "btnIStt";
            this.btnIStt.Size = new System.Drawing.Size(91, 23);
            this.btnIStt.TabIndex = 36;
            this.btnIStt.Text = "Item Status";
            this.btnIStt.UseVisualStyleBackColor = true;
            this.btnIStt.Click += new System.EventHandler(this.btnIStt_Click);
            // 
            // btnUpItem
            // 
            this.btnUpItem.Location = new System.Drawing.Point(11, 103);
            this.btnUpItem.Name = "btnUpItem";
            this.btnUpItem.Size = new System.Drawing.Size(91, 23);
            this.btnUpItem.TabIndex = 34;
            this.btnUpItem.Text = "Cập nhật Item";
            this.btnUpItem.UseVisualStyleBackColor = true;
            // 
            // btnCreItem
            // 
            this.btnCreItem.Location = new System.Drawing.Point(11, 74);
            this.btnCreItem.Name = "btnCreItem";
            this.btnCreItem.Size = new System.Drawing.Size(91, 23);
            this.btnCreItem.TabIndex = 33;
            this.btnCreItem.Text = "Tạo Item";
            this.btnCreItem.UseVisualStyleBackColor = true;
            // 
            // btnUpPlan
            // 
            this.btnUpPlan.Location = new System.Drawing.Point(11, 45);
            this.btnUpPlan.Name = "btnUpPlan";
            this.btnUpPlan.Size = new System.Drawing.Size(91, 23);
            this.btnUpPlan.TabIndex = 32;
            this.btnUpPlan.Text = "Cập nhật plan";
            this.btnUpPlan.UseVisualStyleBackColor = true;
            this.btnUpPlan.Click += new System.EventHandler(this.btnUpPlan_Click);
            // 
            // btnCrePlan
            // 
            this.btnCrePlan.Location = new System.Drawing.Point(11, 16);
            this.btnCrePlan.Name = "btnCrePlan";
            this.btnCrePlan.Size = new System.Drawing.Size(91, 23);
            this.btnCrePlan.TabIndex = 31;
            this.btnCrePlan.Text = "Tạo Plan";
            this.btnCrePlan.UseVisualStyleBackColor = true;
            this.btnCrePlan.Click += new System.EventHandler(this.btnCrePlan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 321);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan Created";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // dgvPlan
            // 
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(3, 3);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.Size = new System.Drawing.Size(560, 289);
            this.dgvPlan.TabIndex = 46;
            this.dgvPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUpLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dgvUpLog
            // 
            this.dgvUpLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpLog.Location = new System.Drawing.Point(3, 3);
            this.dgvUpLog.Name = "dgvUpLog";
            this.dgvUpLog.Size = new System.Drawing.Size(560, 289);
            this.dgvUpLog.TabIndex = 0;
            // 
            // pnlFin
            // 
            this.pnlFin.Controls.Add(this.btnClear);
            this.pnlFin.Controls.Add(this.btnFind);
            this.pnlFin.Controls.Add(this.label8);
            this.pnlFin.Controls.Add(this.txtPID);
            this.pnlFin.Controls.Add(this.label2);
            this.pnlFin.Controls.Add(this.txtPName);
            this.pnlFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFin.Location = new System.Drawing.Point(0, 0);
            this.pnlFin.Name = "pnlFin";
            this.pnlFin.Size = new System.Drawing.Size(580, 39);
            this.pnlFin.TabIndex = 43;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(414, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(495, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 29);
            this.btnFind.TabIndex = 44;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Plan_ID";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(65, 10);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 20);
            this.txtPID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Plan_Name";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(283, 10);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(100, 20);
            this.txtPName.TabIndex = 27;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 60);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnLogOut);
            this.splitContainer2.Panel2.Controls.Add(this.lbID);
            this.splitContainer2.Panel2.Controls.Add(this.lbName);
            this.splitContainer2.Size = new System.Drawing.Size(694, 52);
            this.splitContainer2.SplitterDistance = 399;
            this.splitContainer2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(213, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 26);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(46, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Username: ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 484);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmJobList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FA Job";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpLog)).EndInit();
            this.pnlFin.ResumeLayout(false);
            this.pnlFin.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUpItem;
        private System.Windows.Forms.Button btnCreItem;
        private System.Windows.Forms.Button btnUpPlan;
        private System.Windows.Forms.Button btnCrePlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnlFin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvUpLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPStt;
        private System.Windows.Forms.Button btnIStt;
    }
}