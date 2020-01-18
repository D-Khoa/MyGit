namespace PC_QRCodeSystem.View
{
    partial class PCForm
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
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnStockDetail = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.request_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grt_Main = new System.Windows.Forms.TabControl();
            this.tab_Menu = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRequestLog = new System.Windows.Forms.Button();
            this.btnStockOutLog = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnIssueCode = new System.Windows.Forms.Button();
            this.tab_Request = new System.Windows.Forms.TabPage();
            this.pnlSetting.SuspendLayout();
            this.pnlRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.panel4.SuspendLayout();
            this.grt_Main.SuspendLayout();
            this.tab_Menu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tab_Request.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSetting.Controls.Add(this.btnStockDetail);
            this.pnlSetting.Controls.Add(this.btnStockOut);
            this.pnlSetting.Controls.Add(this.btnStockIn);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSetting.Location = new System.Drawing.Point(3, 3);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(240, 400);
            this.pnlSetting.TabIndex = 2;
            // 
            // btnStockDetail
            // 
            this.btnStockDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDetail.Location = new System.Drawing.Point(20, 280);
            this.btnStockDetail.Name = "btnStockDetail";
            this.btnStockDetail.Size = new System.Drawing.Size(200, 100);
            this.btnStockDetail.TabIndex = 2;
            this.btnStockDetail.Text = "Stock Detail";
            this.btnStockDetail.UseVisualStyleBackColor = true;
            this.btnStockDetail.Click += new System.EventHandler(this.btnStockDetail_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(20, 150);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(200, 100);
            this.btnStockOut.TabIndex = 1;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.Location = new System.Drawing.Point(20, 20);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(200, 100);
            this.btnStockIn.TabIndex = 0;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // pnlRequest
            // 
            this.pnlRequest.Controls.Add(this.dgvRequest);
            this.pnlRequest.Controls.Add(this.panel4);
            this.pnlRequest.Controls.Add(this.label1);
            this.pnlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRequest.Location = new System.Drawing.Point(3, 3);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(685, 400);
            this.pnlRequest.TabIndex = 3;
            // 
            // dgvRequest
            // 
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.request_time,
            this.user_name,
            this.user_dept,
            this.item,
            this.qty,
            this.confirm});
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(0, 38);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(685, 308);
            this.dgvRequest.TabIndex = 4;
            // 
            // request_time
            // 
            this.request_time.HeaderText = "Date Time";
            this.request_time.Name = "request_time";
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Name";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // user_dept
            // 
            this.user_dept.HeaderText = "Department";
            this.user_dept.Name = "user_dept";
            this.user_dept.ReadOnly = true;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // confirm
            // 
            this.confirm.HeaderText = "Confirm";
            this.confirm.Name = "confirm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAccept);
            this.panel4.Controls.Add(this.btnDeny);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 54);
            this.panel4.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.Location = new System.Drawing.Point(107, 8);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(96, 43);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeny.Location = new System.Drawing.Point(530, 8);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(96, 43);
            this.btnDeny.TabIndex = 3;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grt_Main
            // 
            this.grt_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.grt_Main.Controls.Add(this.tab_Menu);
            this.grt_Main.Controls.Add(this.tab_Request);
            this.grt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grt_Main.Location = new System.Drawing.Point(145, 69);
            this.grt_Main.Name = "grt_Main";
            this.grt_Main.SelectedIndex = 0;
            this.grt_Main.Size = new System.Drawing.Size(699, 435);
            this.grt_Main.TabIndex = 4;
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.panel5);
            this.tab_Menu.Controls.Add(this.pnlSetting);
            this.tab_Menu.Location = new System.Drawing.Point(4, 25);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Menu.Size = new System.Drawing.Size(691, 406);
            this.tab_Menu.TabIndex = 0;
            this.tab_Menu.Text = "Menu";
            this.tab_Menu.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(243, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 400);
            this.panel5.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnRequestLog);
            this.panel8.Controls.Add(this.btnStockOutLog);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(445, 80);
            this.panel8.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(445, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Log";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRequestLog
            // 
            this.btnRequestLog.Location = new System.Drawing.Point(20, 25);
            this.btnRequestLog.Name = "btnRequestLog";
            this.btnRequestLog.Size = new System.Drawing.Size(100, 50);
            this.btnRequestLog.TabIndex = 6;
            this.btnRequestLog.Text = "Request Log";
            this.btnRequestLog.UseVisualStyleBackColor = true;
            // 
            // btnStockOutLog
            // 
            this.btnStockOutLog.Location = new System.Drawing.Point(130, 25);
            this.btnStockOutLog.Name = "btnStockOutLog";
            this.btnStockOutLog.Size = new System.Drawing.Size(100, 50);
            this.btnStockOutLog.TabIndex = 5;
            this.btnStockOutLog.Text = "Stock Out Log";
            this.btnStockOutLog.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.btnSupplier);
            this.panel7.Controls.Add(this.btnDepartment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 80);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(445, 80);
            this.panel7.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Supplier And DepartMent";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(20, 25);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(100, 50);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(130, 25);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(100, 50);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnItem);
            this.panel6.Controls.Add(this.btnIssueCode);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(445, 80);
            this.panel6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Items And Issue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(20, 25);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(100, 50);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnIssueCode
            // 
            this.btnIssueCode.Location = new System.Drawing.Point(130, 26);
            this.btnIssueCode.Name = "btnIssueCode";
            this.btnIssueCode.Size = new System.Drawing.Size(100, 50);
            this.btnIssueCode.TabIndex = 3;
            this.btnIssueCode.Text = "Issue Code";
            this.btnIssueCode.UseVisualStyleBackColor = true;
            // 
            // tab_Request
            // 
            this.tab_Request.Controls.Add(this.pnlRequest);
            this.tab_Request.Location = new System.Drawing.Point(4, 25);
            this.tab_Request.Name = "tab_Request";
            this.tab_Request.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Request.Size = new System.Drawing.Size(691, 406);
            this.tab_Request.TabIndex = 1;
            this.tab_Request.Text = "Request";
            this.tab_Request.UseVisualStyleBackColor = true;
            // 
            // PCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 504);
            this.Controls.Add(this.grt_Main);
            this.dept = "";
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "PCForm";
            this.Text = "PC Management";
            this.tittle = "FormCommon";
            this.Controls.SetChildIndex(this.grt_Main, 0);
            this.pnlSetting.ResumeLayout(false);
            this.pnlRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.panel4.ResumeLayout(false);
            this.grt_Main.ResumeLayout(false);
            this.tab_Menu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tab_Request.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button btnStockDetail;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirm;
        private System.Windows.Forms.TabControl grt_Main;
        private System.Windows.Forms.TabPage tab_Menu;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnIssueCode;
        private System.Windows.Forms.Button btnStockOutLog;
        private System.Windows.Forms.Button btnRequestLog;
        private System.Windows.Forms.TabPage tab_Request;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}