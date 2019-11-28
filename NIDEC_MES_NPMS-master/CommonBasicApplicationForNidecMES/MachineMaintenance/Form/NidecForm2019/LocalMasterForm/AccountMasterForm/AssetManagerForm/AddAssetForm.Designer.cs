namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    partial class AddAssetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddAsset = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.pnlButton2 = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnImport = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnAdd = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnExit = new Com.Nidec.Mes.Framework.ButtonCommon();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAsset)).BeginInit();
            this.pnlButton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAddAsset
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddAsset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAsset.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddAsset.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddAsset.Location = new System.Drawing.Point(415, 113);
            this.dgvAddAsset.Name = "dgvAddAsset";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddAsset.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddAsset.Size = new System.Drawing.Size(344, 395);
            this.dgvAddAsset.TabIndex = 31;
            // 
            // pnlButton2
            // 
            this.pnlButton2.ControlId = null;
            this.pnlButton2.Controls.Add(this.btnExit);
            this.pnlButton2.Controls.Add(this.btnAdd);
            this.pnlButton2.Controls.Add(this.btnImport);
            this.pnlButton2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton2.Location = new System.Drawing.Point(416, 514);
            this.pnlButton2.Name = "pnlButton2";
            this.pnlButton2.Size = new System.Drawing.Size(343, 45);
            this.pnlButton2.TabIndex = 32;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.ControlId = null;
            this.btnImport.Font = new System.Drawing.Font("Arial", 9F);
            this.btnImport.Location = new System.Drawing.Point(32, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 33);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ControlId = null;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAdd.Location = new System.Drawing.Point(131, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ControlId = null;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExit.Location = new System.Drawing.Point(230, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // AddAssetForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(771, 571);
            this.Controls.Add(this.pnlButton2);
            this.Controls.Add(this.dgvAddAsset);
            this.Name = "AddAssetForm";
            this.Text = "AddAssetForm";
            this.TitleText = "Update Asset 2019";
            this.Controls.SetChildIndex(this.dgvAddAsset, 0);
            this.Controls.SetChildIndex(this.pnlButton2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAsset)).EndInit();
            this.pnlButton2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.DataGridViewCommon dgvAddAsset;
        private Framework.PanelCommon pnlButton2;
        private Framework.ButtonCommon btnExit;
        private Framework.ButtonCommon btnAdd;
        private Framework.ButtonCommon btnImport;
    }
}