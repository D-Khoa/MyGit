namespace PC_QRCodeSystem.View
{
    partial class RequestForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnApproved = new System.Windows.Forms.RadioButton();
            this.rbtnWaitConfirm = new System.Windows.Forms.RadioButton();
            this.rbtnConfirmed = new System.Windows.Forms.RadioButton();
            this.rbtnAllRequest = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpUseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestinationName = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.txtModelCode = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnConfirm);
            this.panel4.Controls.Add(this.txtComment);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtQty);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtpUseDate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtDestinationName);
            this.panel4.Controls.Add(this.txtModelName);
            this.panel4.Controls.Add(this.txtItemName);
            this.panel4.Controls.Add(this.cmbDestination);
            this.panel4.Controls.Add(this.txtModelCode);
            this.panel4.Controls.Add(this.txtItemCode);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(150, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 246);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Item Code";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnApproved);
            this.groupBox1.Controls.Add(this.rbtnWaitConfirm);
            this.groupBox1.Controls.Add(this.rbtnConfirmed);
            this.groupBox1.Controls.Add(this.rbtnAllRequest);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(613, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(173, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // rbtnApproved
            // 
            this.rbtnApproved.AutoSize = true;
            this.rbtnApproved.Location = new System.Drawing.Point(27, 98);
            this.rbtnApproved.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnApproved.Name = "rbtnApproved";
            this.rbtnApproved.Size = new System.Drawing.Size(87, 21);
            this.rbtnApproved.TabIndex = 3;
            this.rbtnApproved.TabStop = true;
            this.rbtnApproved.Text = "Approved";
            this.rbtnApproved.UseVisualStyleBackColor = true;
            // 
            // rbtnWaitConfirm
            // 
            this.rbtnWaitConfirm.AutoSize = true;
            this.rbtnWaitConfirm.Location = new System.Drawing.Point(27, 49);
            this.rbtnWaitConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWaitConfirm.Name = "rbtnWaitConfirm";
            this.rbtnWaitConfirm.Size = new System.Drawing.Size(106, 21);
            this.rbtnWaitConfirm.TabIndex = 2;
            this.rbtnWaitConfirm.TabStop = true;
            this.rbtnWaitConfirm.Text = "Wait Confirm";
            this.rbtnWaitConfirm.UseVisualStyleBackColor = true;
            // 
            // rbtnConfirmed
            // 
            this.rbtnConfirmed.AutoSize = true;
            this.rbtnConfirmed.Location = new System.Drawing.Point(27, 74);
            this.rbtnConfirmed.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnConfirmed.Name = "rbtnConfirmed";
            this.rbtnConfirmed.Size = new System.Drawing.Size(90, 21);
            this.rbtnConfirmed.TabIndex = 1;
            this.rbtnConfirmed.TabStop = true;
            this.rbtnConfirmed.Text = "Confirmed";
            this.rbtnConfirmed.UseVisualStyleBackColor = true;
            // 
            // rbtnAllRequest
            // 
            this.rbtnAllRequest.AutoSize = true;
            this.rbtnAllRequest.Location = new System.Drawing.Point(27, 25);
            this.rbtnAllRequest.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAllRequest.Name = "rbtnAllRequest";
            this.rbtnAllRequest.Size = new System.Drawing.Size(41, 21);
            this.rbtnAllRequest.TabIndex = 0;
            this.rbtnAllRequest.TabStop = true;
            this.rbtnAllRequest.Text = "All";
            this.rbtnAllRequest.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(647, 160);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 62);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Tag = "";
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.Paint += new System.Windows.Forms.PaintEventHandler(this.btnConfirm_Paint);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(160, 160);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(439, 61);
            this.txtComment.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Comment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(480, 123);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(119, 23);
            this.txtQty.TabIndex = 12;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Q\'ty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpUseDate
            // 
            this.dtpUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUseDate.Location = new System.Drawing.Point(160, 123);
            this.dtpUseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUseDate.Name = "dtpUseDate";
            this.dtpUseDate.Size = new System.Drawing.Size(159, 23);
            this.dtpUseDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Use Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDestinationName
            // 
            this.txtDestinationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationName.Location = new System.Drawing.Point(333, 86);
            this.txtDestinationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.ReadOnly = true;
            this.txtDestinationName.Size = new System.Drawing.Size(265, 23);
            this.txtDestinationName.TabIndex = 8;
            this.txtDestinationName.Text = "Destination Name";
            this.txtDestinationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModelName
            // 
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(333, 50);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(265, 23);
            this.txtModelName.TabIndex = 7;
            this.txtModelName.Text = "Model Name";
            this.txtModelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(333, 12);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(265, 23);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.Text = "Item Name";
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(160, 86);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(159, 24);
            this.cmbDestination.TabIndex = 5;
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            // 
            // txtModelCode
            // 
            this.txtModelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelCode.Location = new System.Drawing.Point(160, 49);
            this.txtModelCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelCode.Name = "txtModelCode";
            this.txtModelCode.Size = new System.Drawing.Size(159, 23);
            this.txtModelCode.TabIndex = 4;
            this.txtModelCode.TextChanged += new System.EventHandler(this.txtModelCode_TextChanged);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(160, 12);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(159, 23);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Destination Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(150, 315);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(853, 62);
            this.panel5.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(667, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(507, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(347, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 49);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(187, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(27, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(150, 377);
            this.dgvRequest.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.Size = new System.Drawing.Size(853, 241);
            this.dgvRequest.TabIndex = 4;
            this.dgvRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellContentClick);
            this.dgvRequest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellDoubleClick);
            this.dgvRequest.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRequest_CellFormatting);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 618);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintime = new System.DateTime(((long)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.name = "";
            this.Name = "RequestForm";
            this.position = "";
            this.Text = "Production Request";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.dgvRequest, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.TextBox txtModelCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtDestinationName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpUseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnApproved;
        private System.Windows.Forms.RadioButton rbtnWaitConfirm;
        private System.Windows.Forms.RadioButton rbtnConfirmed;
        private System.Windows.Forms.RadioButton rbtnAllRequest;
        private System.Windows.Forms.Label label10;
    }
}