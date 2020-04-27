namespace PC_QRCodeSystem.View
{
    partial class StockOutLogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessCD = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbSearchDate = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.txtItemCD = new System.Windows.Forms.TextBox();
            this.cmbIssueCD = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUserCD = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtProcessCD);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.cbSearchDate);
            this.panel6.Controls.Add(this.btnExport);
            this.panel6.Controls.Add(this.dtpToDate);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.dtpFromDate);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtSetNumber);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtInvoice);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lbItemName);
            this.panel6.Controls.Add(this.txtItemCD);
            this.panel6.Controls.Add(this.cmbIssueCD);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.lbUserName);
            this.panel6.Controls.Add(this.txtUserCD);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.cmbDestination);
            this.panel6.Controls.Add(this.txtBarcode);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(150, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 220);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(480, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Process Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessCD
            // 
            this.txtProcessCD.Location = new System.Drawing.Point(580, 130);
            this.txtProcessCD.Name = "txtProcessCD";
            this.txtProcessCD.Size = new System.Drawing.Size(120, 22);
            this.txtProcessCD.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbSearchDate
            // 
            this.cbSearchDate.Location = new System.Drawing.Point(480, 70);
            this.cbSearchDate.Name = "cbSearchDate";
            this.cbSearchDate.Size = new System.Drawing.Size(90, 20);
            this.cbSearchDate.TabIndex = 41;
            this.cbSearchDate.Text = "From Date";
            this.cbSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSearchDate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(220, 160);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 50);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(580, 100);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 22);
            this.dtpToDate.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(120, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "To Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(580, 70);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 22);
            this.dtpFromDate.TabIndex = 43;
            this.dtpFromDate.Value = new System.DateTime(2020, 3, 4, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(480, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Set Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSetNumber
            // 
            this.txtSetNumber.Location = new System.Drawing.Point(580, 10);
            this.txtSetNumber.Name = "txtSetNumber";
            this.txtSetNumber.Size = new System.Drawing.Size(120, 22);
            this.txtSetNumber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(480, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Invoice";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(580, 40);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(120, 22);
            this.txtInvoice.TabIndex = 35;
            this.txtInvoice.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbItemName
            // 
            this.lbItemName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.Location = new System.Drawing.Point(270, 40);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(200, 20);
            this.lbItemName.TabIndex = 31;
            this.lbItemName.Text = "Item Name";
            this.lbItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemCD
            // 
            this.txtItemCD.Location = new System.Drawing.Point(120, 40);
            this.txtItemCD.Name = "txtItemCD";
            this.txtItemCD.Size = new System.Drawing.Size(120, 22);
            this.txtItemCD.TabIndex = 30;
            this.txtItemCD.TabStop = false;
            this.txtItemCD.TextChanged += new System.EventHandler(this.txtItemCD_TextChanged);
            // 
            // cmbIssueCD
            // 
            this.cmbIssueCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIssueCD.FormattingEnabled = true;
            this.cmbIssueCD.Location = new System.Drawing.Point(120, 70);
            this.cmbIssueCD.Name = "cmbIssueCD";
            this.cmbIssueCD.Size = new System.Drawing.Size(350, 24);
            this.cmbIssueCD.TabIndex = 5;
            this.cmbIssueCD.SelectedIndexChanged += new System.EventHandler(this.cmbIssueCD_SelectedIndexChanged);
            this.cmbIssueCD.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbIssueCD_Format);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "User Code";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Barcode";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(270, 130);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(200, 20);
            this.lbUserName.TabIndex = 10;
            this.lbUserName.Text = "User Name";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserCD
            // 
            this.txtUserCD.Location = new System.Drawing.Point(120, 130);
            this.txtUserCD.Name = "txtUserCD";
            this.txtUserCD.Size = new System.Drawing.Size(120, 22);
            this.txtUserCD.TabIndex = 7;
            this.txtUserCD.TextChanged += new System.EventHandler(this.txtUserCD_TextChanged);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(10, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "Issue Code";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(120, 100);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(350, 24);
            this.cmbDestination.TabIndex = 6;
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            this.cmbDestination.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbDestination_Format);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(120, 10);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(350, 22);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(10, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Destination";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(150, 364);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvData.Size = new System.Drawing.Size(734, 108);
            this.dgvData.TabIndex = 4;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProcess.Location = new System.Drawing.Point(150, 290);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.RowHeadersVisible = false;
            this.dgvProcess.Size = new System.Drawing.Size(734, 74);
            this.dgvProcess.TabIndex = 5;
            // 
            // StockOutLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 472);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dgvProcess);
            this.Controls.Add(this.panel6);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "StockOutLogForm";
            this.position = "";
            this.Text = "StockOutLogForm";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.StockOutLogForm_Load);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.dgvProcess, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.TextBox txtItemCD;
        private System.Windows.Forms.ComboBox cmbIssueCD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUserCD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.CheckBox cbSearchDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessCD;
        private System.Windows.Forms.DataGridView dgvProcess;
    }
}