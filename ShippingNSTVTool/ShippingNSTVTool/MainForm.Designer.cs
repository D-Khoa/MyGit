﻿namespace ShippingNSTVTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcodeasset = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCounter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtlinecode = new System.Windows.Forms.TextBox();
            this.grInfo.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.grSearch.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.pnlSetting);
            this.grInfo.Controls.Add(this.btnExport);
            this.grInfo.Controls.Add(this.btnApply);
            this.grInfo.Controls.Add(this.btnSetting);
            this.grInfo.Controls.Add(this.btnSearch);
            this.grInfo.Controls.Add(this.btnConfirm);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.txtBarcode);
            this.grInfo.Location = new System.Drawing.Point(11, 82);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(429, 266);
            this.grInfo.TabIndex = 1;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Information";
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.txtlinecode);
            this.pnlSetting.Controls.Add(this.label11);
            this.pnlSetting.Controls.Add(this.txtdate);
            this.pnlSetting.Controls.Add(this.label10);
            this.pnlSetting.Controls.Add(this.txtcodeasset);
            this.pnlSetting.Controls.Add(this.label8);
            this.pnlSetting.Controls.Add(this.txtcustomer);
            this.pnlSetting.Controls.Add(this.label5);
            this.pnlSetting.Controls.Add(this.txtLine);
            this.pnlSetting.Controls.Add(this.txtModel);
            this.pnlSetting.Controls.Add(this.txtCode);
            this.pnlSetting.Controls.Add(this.label9);
            this.pnlSetting.Controls.Add(this.txtLot);
            this.pnlSetting.Controls.Add(this.label2);
            this.pnlSetting.Controls.Add(this.label3);
            this.pnlSetting.Controls.Add(this.label4);
            this.pnlSetting.Enabled = false;
            this.pnlSetting.Location = new System.Drawing.Point(6, 45);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(408, 135);
            this.pnlSetting.TabIndex = 3;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(260, 61);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(101, 20);
            this.txtdate.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Date";
            // 
            // txtcodeasset
            // 
            this.txtcodeasset.Location = new System.Drawing.Point(260, 34);
            this.txtcodeasset.Name = "txtcodeasset";
            this.txtcodeasset.Size = new System.Drawing.Size(101, 20);
            this.txtcodeasset.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Code";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(260, 7);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(101, 20);
            this.txtcustomer.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Customer";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(59, 34);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(100, 20);
            this.txtLine.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(59, 7);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(58, 88);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(101, 20);
            this.txtCode.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Plan Code";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(58, 61);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(101, 20);
            this.txtLot.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Line";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(305, 195);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(62, 46);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(77, 205);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(53, 26);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::ShippingNSTVTool.Properties.Resources.settings;
            this.btnSetting.Location = new System.Drawing.Point(15, 205);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(38, 27);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(155, 195);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(62, 46);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(65, 26);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(339, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.label7);
            this.grSearch.Controls.Add(this.label6);
            this.grSearch.Controls.Add(this.dtpTo);
            this.grSearch.Controls.Add(this.dtpFrom);
            this.grSearch.Location = new System.Drawing.Point(461, 279);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(218, 83);
            this.grSearch.TabIndex = 11;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "From Date";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(73, 49);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowUpDown = true;
            this.dtpTo.Size = new System.Drawing.Size(139, 20);
            this.dtpTo.TabIndex = 13;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(73, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowUpDown = true;
            this.dtpFrom.Size = new System.Drawing.Size(139, 20);
            this.dtpFrom.TabIndex = 12;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lbStatus);
            this.pnlStatus.Location = new System.Drawing.Point(461, 82);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(242, 142);
            this.pnlStatus.TabIndex = 12;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(240, 140);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "None";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 362);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(693, 142);
            this.dgvData.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbCounter);
            this.groupBox2.Location = new System.Drawing.Point(461, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 49);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counter";
            // 
            // lbCounter
            // 
            this.lbCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounter.Location = new System.Drawing.Point(3, 16);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(236, 30);
            this.lbCounter.TabIndex = 0;
            this.lbCounter.Text = "0";
            this.lbCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Line Code";
            // 
            // txtlinecode
            // 
            this.txtlinecode.Location = new System.Drawing.Point(260, 88);
            this.txtlinecode.Name = "txtlinecode";
            this.txtlinecode.Size = new System.Drawing.Size(101, 20);
            this.txtlinecode.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.grInfo);
            this.Controls.Add(this.grSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NSTV Barcode Record Tool";
            this.TitleText = "NSTV Barcode Record Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Controls.SetChildIndex(this.grSearch, 0);
            this.Controls.SetChildIndex(this.grInfo, 0);
            this.Controls.SetChildIndex(this.pnlStatus, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcodeasset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlinecode;
        private System.Windows.Forms.Label label11;
    }
}

