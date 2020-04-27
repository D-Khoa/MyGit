namespace PC_QRCodeSystem.View
{
    partial class SupplierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.dgvDataSupllier = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSupplierTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSubButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSupllier)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlSubButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Supplier Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(180, 20);
            this.cmbSupplierCode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(180, 24);
            this.cmbSupplierCode.TabIndex = 5;
            this.cmbSupplierCode.TextChanged += new System.EventHandler(this.cmbSupplierCode_TextChanged);
            // 
            // dgvDataSupllier
            // 
            this.dgvDataSupllier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSupllier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSupllier.Location = new System.Drawing.Point(150, 310);
            this.dgvDataSupllier.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDataSupllier.Name = "dgvDataSupllier";
            this.dgvDataSupllier.Size = new System.Drawing.Size(899, 254);
            this.dgvDataSupllier.TabIndex = 4;
            this.dgvDataSupllier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSupllier_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSupplierAddress);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtFaxNumber);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtSupplierTelephone);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSupplierName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbSupplierCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(150, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 120);
            this.panel4.TabIndex = 1;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(180, 80);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(640, 21);
            this.txtSupplierAddress.TabIndex = 9;
            this.txtSupplierAddress.Text = "Supplier Address";
            this.txtSupplierAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Supplier Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaxNumber.Location = new System.Drawing.Point(620, 50);
            this.txtFaxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.ReadOnly = true;
            this.txtFaxNumber.Size = new System.Drawing.Size(200, 21);
            this.txtFaxNumber.TabIndex = 8;
            this.txtFaxNumber.Text = "Fax Number";
            this.txtFaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Supplier Fax";
            // 
            // txtSupplierTelephone
            // 
            this.txtSupplierTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierTelephone.Location = new System.Drawing.Point(180, 50);
            this.txtSupplierTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierTelephone.Name = "txtSupplierTelephone";
            this.txtSupplierTelephone.ReadOnly = true;
            this.txtSupplierTelephone.Size = new System.Drawing.Size(200, 21);
            this.txtSupplierTelephone.TabIndex = 7;
            this.txtSupplierTelephone.Text = "Telephone";
            this.txtSupplierTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Supplier Telephone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(370, 20);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(450, 21);
            this.txtSupplierName.TabIndex = 6;
            this.txtSupplierName.Text = "Supplier Name";
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(202, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 50);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(546, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(150, 250);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(899, 60);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(30, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(374, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(546, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(202, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(718, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime,
            this.toolStripStatusLabel2,
            this.tsSupplierTotal});
            this.statusStrip1.Location = new System.Drawing.Point(150, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(899, 24);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(795, 19);
            this.tsTime.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel2.Text = "Total :";
            // 
            // tsSupplierTotal
            // 
            this.tsSupplierTotal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsSupplierTotal.Name = "tsSupplierTotal";
            this.tsSupplierTotal.Size = new System.Drawing.Size(40, 19);
            this.tsSupplierTotal.Text = "None";
            // 
            // pnlSubButtons
            // 
            this.pnlSubButtons.Controls.Add(this.btnOK);
            this.pnlSubButtons.Controls.Add(this.btnCancel);
            this.pnlSubButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubButtons.Location = new System.Drawing.Point(150, 190);
            this.pnlSubButtons.Name = "pnlSubButtons";
            this.pnlSubButtons.Size = new System.Drawing.Size(899, 60);
            this.pnlSubButtons.TabIndex = 2;
            // 
            // SupplierForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.dgvDataSupllier);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSubButtons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.dept = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.name = "";
            this.Name = "SupplierForm";
            this.position = "";
            this.Text = "SupplierForm";
            this.tittle = "FormCommon";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.pnlSubButtons, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.dgvDataSupllier, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSupllier)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSubButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSupplierCode;
        private System.Windows.Forms.DataGridView dgvDataSupllier;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplierTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsSupplierTotal;
        private System.Windows.Forms.Panel pnlSubButtons;
    }
}