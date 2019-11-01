namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.OvenBarcodeTTBForm
{
    partial class OvenBarcodeTTBForm
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
            this.cmbModel = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dgvDataOven = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.dpFromDate = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.dpToDate = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.cmbLine = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.cmbBarcode = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon6 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.cmbProcess = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon7 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon8 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon9 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.lbMaxTemp = new Com.Nidec.Mes.Framework.LabelCommon();
            this.lbMinTemp = new Com.Nidec.Mes.Framework.LabelCommon();
            this.lbTimerSet = new Com.Nidec.Mes.Framework.LabelCommon();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOven)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModel
            // 
            this.cmbModel.ControlId = null;
            this.cmbModel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(80, 117);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(124, 23);
            this.cmbModel.TabIndex = 2;
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(9, 120);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(40, 15);
            this.labelCommon1.TabIndex = 3;
            this.labelCommon1.Text = "Model";
            // 
            // dgvDataOven
            // 
            this.dgvDataOven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataOven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataOven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOven.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataOven.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataOven.Location = new System.Drawing.Point(12, 204);
            this.dgvDataOven.Name = "dgvDataOven";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataOven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataOven.Size = new System.Drawing.Size(667, 227);
            this.dgvDataOven.TabIndex = 4;
            // 
            // dpFromDate
            // 
            this.dpFromDate.BackColor = System.Drawing.SystemColors.Control;
            this.dpFromDate.ControlId = null;
            this.dpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dpFromDate.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.dpFromDate.Font = new System.Drawing.Font("Arial", 9F);
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(293, 144);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(124, 21);
            this.dpFromDate.TabIndex = 6;
            // 
            // dpToDate
            // 
            this.dpToDate.BackColor = System.Drawing.SystemColors.Control;
            this.dpToDate.ControlId = null;
            this.dpToDate.CustomFormat = "yyyy-MM-dd";
            this.dpToDate.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.dpToDate.Font = new System.Drawing.Font("Arial", 9F);
            this.dpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToDate.Location = new System.Drawing.Point(293, 173);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.Size = new System.Drawing.Size(124, 21);
            this.dpToDate.TabIndex = 7;
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon2.Location = new System.Drawing.Point(222, 149);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(65, 15);
            this.labelCommon2.TabIndex = 8;
            this.labelCommon2.Text = "From Date";
            // 
            // labelCommon3
            // 
            this.labelCommon3.AutoSize = true;
            this.labelCommon3.ControlId = null;
            this.labelCommon3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon3.Location = new System.Drawing.Point(222, 178);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(49, 15);
            this.labelCommon3.TabIndex = 9;
            this.labelCommon3.Text = "To Date";
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon4.Location = new System.Drawing.Point(9, 149);
            this.labelCommon4.Name = "labelCommon4";
            this.labelCommon4.Size = new System.Drawing.Size(31, 15);
            this.labelCommon4.TabIndex = 11;
            this.labelCommon4.Text = "Line";
            // 
            // cmbLine
            // 
            this.cmbLine.ControlId = null;
            this.cmbLine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(80, 146);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(124, 23);
            this.cmbLine.TabIndex = 10;
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon5.Location = new System.Drawing.Point(222, 120);
            this.labelCommon5.Name = "labelCommon5";
            this.labelCommon5.Size = new System.Drawing.Size(53, 15);
            this.labelCommon5.TabIndex = 13;
            this.labelCommon5.Text = "Barcode";
            // 
            // cmbBarcode
            // 
            this.cmbBarcode.ControlId = null;
            this.cmbBarcode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarcode.FormattingEnabled = true;
            this.cmbBarcode.Location = new System.Drawing.Point(293, 117);
            this.cmbBarcode.Name = "cmbBarcode";
            this.cmbBarcode.Size = new System.Drawing.Size(124, 23);
            this.cmbBarcode.TabIndex = 12;
            // 
            // labelCommon6
            // 
            this.labelCommon6.AutoSize = true;
            this.labelCommon6.ControlId = null;
            this.labelCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon6.Location = new System.Drawing.Point(9, 178);
            this.labelCommon6.Name = "labelCommon6";
            this.labelCommon6.Size = new System.Drawing.Size(53, 15);
            this.labelCommon6.TabIndex = 15;
            this.labelCommon6.Text = "Process";
            // 
            // cmbProcess
            // 
            this.cmbProcess.ControlId = null;
            this.cmbProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Location = new System.Drawing.Point(80, 175);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(124, 23);
            this.cmbProcess.TabIndex = 14;
            // 
            // labelCommon7
            // 
            this.labelCommon7.AutoSize = true;
            this.labelCommon7.ControlId = null;
            this.labelCommon7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon7.Location = new System.Drawing.Point(438, 120);
            this.labelCommon7.Name = "labelCommon7";
            this.labelCommon7.Size = new System.Drawing.Size(65, 15);
            this.labelCommon7.TabIndex = 16;
            this.labelCommon7.Text = "Max Temp.";
            // 
            // labelCommon8
            // 
            this.labelCommon8.AutoSize = true;
            this.labelCommon8.ControlId = null;
            this.labelCommon8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon8.Location = new System.Drawing.Point(438, 149);
            this.labelCommon8.Name = "labelCommon8";
            this.labelCommon8.Size = new System.Drawing.Size(63, 15);
            this.labelCommon8.TabIndex = 17;
            this.labelCommon8.Text = "Min Temp.";
            // 
            // labelCommon9
            // 
            this.labelCommon9.AutoSize = true;
            this.labelCommon9.ControlId = null;
            this.labelCommon9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon9.Location = new System.Drawing.Point(438, 178);
            this.labelCommon9.Name = "labelCommon9";
            this.labelCommon9.Size = new System.Drawing.Size(60, 15);
            this.labelCommon9.TabIndex = 18;
            this.labelCommon9.Text = "Timer Set";
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.AutoSize = true;
            this.lbMaxTemp.ControlId = null;
            this.lbMaxTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTemp.Location = new System.Drawing.Point(509, 120);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(37, 15);
            this.lbMaxTemp.TabIndex = 19;
            this.lbMaxTemp.Text = "None";
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.ControlId = null;
            this.lbMinTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinTemp.Location = new System.Drawing.Point(509, 149);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(37, 15);
            this.lbMinTemp.TabIndex = 20;
            this.lbMinTemp.Text = "None";
            // 
            // lbTimerSet
            // 
            this.lbTimerSet.AutoSize = true;
            this.lbTimerSet.ControlId = null;
            this.lbTimerSet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerSet.Location = new System.Drawing.Point(509, 178);
            this.lbTimerSet.Name = "lbTimerSet";
            this.lbTimerSet.Size = new System.Drawing.Size(37, 15);
            this.lbTimerSet.TabIndex = 21;
            this.lbTimerSet.Text = "None";
            // 
            // OvenBarcodeTTBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 443);
            this.Controls.Add(this.lbTimerSet);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.lbMaxTemp);
            this.Controls.Add(this.labelCommon9);
            this.Controls.Add(this.labelCommon8);
            this.Controls.Add(this.labelCommon7);
            this.Controls.Add(this.labelCommon6);
            this.Controls.Add(this.cmbProcess);
            this.Controls.Add(this.labelCommon5);
            this.Controls.Add(this.cmbBarcode);
            this.Controls.Add(this.labelCommon4);
            this.Controls.Add(this.cmbLine);
            this.Controls.Add(this.labelCommon3);
            this.Controls.Add(this.labelCommon2);
            this.Controls.Add(this.dpToDate);
            this.Controls.Add(this.dpFromDate);
            this.Controls.Add(this.dgvDataOven);
            this.Controls.Add(this.labelCommon1);
            this.Controls.Add(this.cmbModel);
            this.Name = "OvenBarcodeTTBForm";
            this.Text = "OvenBarcodeTTBForm";
            this.TitleText = "FormCommon";
            this.Controls.SetChildIndex(this.cmbModel, 0);
            this.Controls.SetChildIndex(this.labelCommon1, 0);
            this.Controls.SetChildIndex(this.dgvDataOven, 0);
            this.Controls.SetChildIndex(this.dpFromDate, 0);
            this.Controls.SetChildIndex(this.dpToDate, 0);
            this.Controls.SetChildIndex(this.labelCommon2, 0);
            this.Controls.SetChildIndex(this.labelCommon3, 0);
            this.Controls.SetChildIndex(this.cmbLine, 0);
            this.Controls.SetChildIndex(this.labelCommon4, 0);
            this.Controls.SetChildIndex(this.cmbBarcode, 0);
            this.Controls.SetChildIndex(this.labelCommon5, 0);
            this.Controls.SetChildIndex(this.cmbProcess, 0);
            this.Controls.SetChildIndex(this.labelCommon6, 0);
            this.Controls.SetChildIndex(this.labelCommon7, 0);
            this.Controls.SetChildIndex(this.labelCommon8, 0);
            this.Controls.SetChildIndex(this.labelCommon9, 0);
            this.Controls.SetChildIndex(this.lbMaxTemp, 0);
            this.Controls.SetChildIndex(this.lbMinTemp, 0);
            this.Controls.SetChildIndex(this.lbTimerSet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ComboBoxCommon cmbModel;
        private Framework.LabelCommon labelCommon1;
        private Framework.DataGridViewCommon dgvDataOven;
        private Framework.DateTimePickerCommon dpFromDate;
        private Framework.DateTimePickerCommon dpToDate;
        private Framework.LabelCommon labelCommon2;
        private Framework.LabelCommon labelCommon3;
        private Framework.LabelCommon labelCommon4;
        private Framework.ComboBoxCommon cmbLine;
        private Framework.LabelCommon labelCommon5;
        private Framework.ComboBoxCommon cmbBarcode;
        private Framework.LabelCommon labelCommon6;
        private Framework.ComboBoxCommon cmbProcess;
        private Framework.LabelCommon labelCommon7;
        private Framework.LabelCommon labelCommon8;
        private Framework.LabelCommon labelCommon9;
        private Framework.LabelCommon lbMaxTemp;
        private Framework.LabelCommon lbMinTemp;
        private Framework.LabelCommon lbTimerSet;
    }
}