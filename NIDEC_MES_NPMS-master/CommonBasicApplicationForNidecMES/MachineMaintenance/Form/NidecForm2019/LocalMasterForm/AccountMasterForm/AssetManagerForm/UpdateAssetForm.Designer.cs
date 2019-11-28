namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    partial class UpdateAssetForm
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
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetCode = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.grUpdate = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.lbAssetPO = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon15 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetPO = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbInvoice = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon11 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetInvoice = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAssetModel = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon9 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetModel = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAssetSerial = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon7 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetSerial = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAssetName = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetName = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAssetNo = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAssetNo = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAssetCode = new Com.Nidec.Mes.Framework.LabelCommon();
            this.lbSupplier = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon13 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtSupplier = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbAcqCost = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon17 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtAcqCost = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.dtpAcqDate = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.lbAcqDate = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon19 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.txtFactory = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.lbFactory = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.rbtnPasted = new Com.Nidec.Mes.Framework.RadioButtonCommon();
            this.rbtnNotPaste = new Com.Nidec.Mes.Framework.RadioButtonCommon();
            this.rbtnCntPaste = new Com.Nidec.Mes.Framework.RadioButtonCommon();
            this.lbLife = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon6 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.numLife = new System.Windows.Forms.NumericUpDown();
            this.pnlButton = new Com.Nidec.Mes.Framework.PanelCommon();
            this.btnApply = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.btnCancel = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.grUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLife)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(6, 72);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(77, 15);
            this.labelCommon1.TabIndex = 2;
            this.labelCommon1.Text = "Asset Code :";
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.ControlId = null;
            this.txtAssetCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetCode.Location = new System.Drawing.Point(6, 90);
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.Size = new System.Drawing.Size(187, 21);
            this.txtAssetCode.TabIndex = 12;
            // 
            // grUpdate
            // 
            this.grUpdate.ControlId = null;
            this.grUpdate.Controls.Add(this.numLife);
            this.grUpdate.Controls.Add(this.lbLife);
            this.grUpdate.Controls.Add(this.labelCommon6);
            this.grUpdate.Controls.Add(this.rbtnCntPaste);
            this.grUpdate.Controls.Add(this.rbtnNotPaste);
            this.grUpdate.Controls.Add(this.rbtnPasted);
            this.grUpdate.Controls.Add(this.lbFactory);
            this.grUpdate.Controls.Add(this.labelCommon4);
            this.grUpdate.Controls.Add(this.txtFactory);
            this.grUpdate.Controls.Add(this.lbAcqDate);
            this.grUpdate.Controls.Add(this.labelCommon19);
            this.grUpdate.Controls.Add(this.dtpAcqDate);
            this.grUpdate.Controls.Add(this.lbAcqCost);
            this.grUpdate.Controls.Add(this.labelCommon17);
            this.grUpdate.Controls.Add(this.txtAcqCost);
            this.grUpdate.Controls.Add(this.lbSupplier);
            this.grUpdate.Controls.Add(this.lbAssetPO);
            this.grUpdate.Controls.Add(this.labelCommon13);
            this.grUpdate.Controls.Add(this.labelCommon15);
            this.grUpdate.Controls.Add(this.txtAssetPO);
            this.grUpdate.Controls.Add(this.txtSupplier);
            this.grUpdate.Controls.Add(this.lbInvoice);
            this.grUpdate.Controls.Add(this.labelCommon11);
            this.grUpdate.Controls.Add(this.txtAssetInvoice);
            this.grUpdate.Controls.Add(this.lbAssetName);
            this.grUpdate.Controls.Add(this.txtAssetName);
            this.grUpdate.Controls.Add(this.lbAssetModel);
            this.grUpdate.Controls.Add(this.labelCommon5);
            this.grUpdate.Controls.Add(this.labelCommon9);
            this.grUpdate.Controls.Add(this.txtAssetModel);
            this.grUpdate.Controls.Add(this.lbAssetSerial);
            this.grUpdate.Controls.Add(this.labelCommon7);
            this.grUpdate.Controls.Add(this.txtAssetSerial);
            this.grUpdate.Controls.Add(this.lbAssetNo);
            this.grUpdate.Controls.Add(this.labelCommon3);
            this.grUpdate.Controls.Add(this.txtAssetNo);
            this.grUpdate.Controls.Add(this.lbAssetCode);
            this.grUpdate.Controls.Add(this.labelCommon1);
            this.grUpdate.Controls.Add(this.txtAssetCode);
            this.grUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grUpdate.Location = new System.Drawing.Point(12, 113);
            this.grUpdate.Name = "grUpdate";
            this.grUpdate.Size = new System.Drawing.Size(397, 395);
            this.grUpdate.TabIndex = 10;
            this.grUpdate.TabStop = false;
            // 
            // lbAssetPO
            // 
            this.lbAssetPO.AutoSize = true;
            this.lbAssetPO.ControlId = null;
            this.lbAssetPO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetPO.Location = new System.Drawing.Point(235, 182);
            this.lbAssetPO.Name = "lbAssetPO";
            this.lbAssetPO.Size = new System.Drawing.Size(37, 15);
            this.lbAssetPO.TabIndex = 22;
            this.lbAssetPO.Text = "None";
            // 
            // labelCommon15
            // 
            this.labelCommon15.AutoSize = true;
            this.labelCommon15.ControlId = null;
            this.labelCommon15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon15.Location = new System.Drawing.Point(199, 182);
            this.labelCommon15.Name = "labelCommon15";
            this.labelCommon15.Size = new System.Drawing.Size(30, 15);
            this.labelCommon15.TabIndex = 20;
            this.labelCommon15.Text = "PO :";
            // 
            // txtAssetPO
            // 
            this.txtAssetPO.ControlId = null;
            this.txtAssetPO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetPO.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetPO.Location = new System.Drawing.Point(199, 200);
            this.txtAssetPO.Name = "txtAssetPO";
            this.txtAssetPO.Size = new System.Drawing.Size(187, 21);
            this.txtAssetPO.TabIndex = 18;
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.ControlId = null;
            this.lbInvoice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoice.Location = new System.Drawing.Point(91, 182);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(37, 15);
            this.lbInvoice.TabIndex = 19;
            this.lbInvoice.Text = "None";
            // 
            // labelCommon11
            // 
            this.labelCommon11.AutoSize = true;
            this.labelCommon11.ControlId = null;
            this.labelCommon11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon11.Location = new System.Drawing.Point(6, 182);
            this.labelCommon11.Name = "labelCommon11";
            this.labelCommon11.Size = new System.Drawing.Size(85, 15);
            this.labelCommon11.TabIndex = 17;
            this.labelCommon11.Text = "Asset Invoice :";
            // 
            // txtAssetInvoice
            // 
            this.txtAssetInvoice.ControlId = null;
            this.txtAssetInvoice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetInvoice.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetInvoice.Location = new System.Drawing.Point(6, 200);
            this.txtAssetInvoice.Name = "txtAssetInvoice";
            this.txtAssetInvoice.Size = new System.Drawing.Size(187, 21);
            this.txtAssetInvoice.TabIndex = 17;
            // 
            // lbAssetModel
            // 
            this.lbAssetModel.AutoSize = true;
            this.lbAssetModel.ControlId = null;
            this.lbAssetModel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetModel.Location = new System.Drawing.Point(284, 127);
            this.lbAssetModel.Name = "lbAssetModel";
            this.lbAssetModel.Size = new System.Drawing.Size(37, 15);
            this.lbAssetModel.TabIndex = 16;
            this.lbAssetModel.Text = "None";
            // 
            // labelCommon9
            // 
            this.labelCommon9.AutoSize = true;
            this.labelCommon9.ControlId = null;
            this.labelCommon9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon9.Location = new System.Drawing.Point(199, 127);
            this.labelCommon9.Name = "labelCommon9";
            this.labelCommon9.Size = new System.Drawing.Size(80, 15);
            this.labelCommon9.TabIndex = 14;
            this.labelCommon9.Text = "Asset Model :";
            // 
            // txtAssetModel
            // 
            this.txtAssetModel.ControlId = null;
            this.txtAssetModel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetModel.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetModel.Location = new System.Drawing.Point(199, 145);
            this.txtAssetModel.Name = "txtAssetModel";
            this.txtAssetModel.Size = new System.Drawing.Size(187, 21);
            this.txtAssetModel.TabIndex = 16;
            // 
            // lbAssetSerial
            // 
            this.lbAssetSerial.AutoSize = true;
            this.lbAssetSerial.ControlId = null;
            this.lbAssetSerial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetSerial.Location = new System.Drawing.Point(284, 72);
            this.lbAssetSerial.Name = "lbAssetSerial";
            this.lbAssetSerial.Size = new System.Drawing.Size(37, 15);
            this.lbAssetSerial.TabIndex = 13;
            this.lbAssetSerial.Text = "None";
            // 
            // labelCommon7
            // 
            this.labelCommon7.AutoSize = true;
            this.labelCommon7.ControlId = null;
            this.labelCommon7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon7.Location = new System.Drawing.Point(199, 72);
            this.labelCommon7.Name = "labelCommon7";
            this.labelCommon7.Size = new System.Drawing.Size(79, 15);
            this.labelCommon7.TabIndex = 11;
            this.labelCommon7.Text = "Asset Serial :";
            // 
            // txtAssetSerial
            // 
            this.txtAssetSerial.ControlId = null;
            this.txtAssetSerial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetSerial.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetSerial.Location = new System.Drawing.Point(199, 90);
            this.txtAssetSerial.Name = "txtAssetSerial";
            this.txtAssetSerial.Size = new System.Drawing.Size(187, 21);
            this.txtAssetSerial.TabIndex = 13;
            // 
            // lbAssetName
            // 
            this.lbAssetName.AutoSize = true;
            this.lbAssetName.ControlId = null;
            this.lbAssetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetName.Location = new System.Drawing.Point(91, 17);
            this.lbAssetName.Name = "lbAssetName";
            this.lbAssetName.Size = new System.Drawing.Size(37, 15);
            this.lbAssetName.TabIndex = 10;
            this.lbAssetName.Text = "None";
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon5.Location = new System.Drawing.Point(6, 17);
            this.labelCommon5.Name = "labelCommon5";
            this.labelCommon5.Size = new System.Drawing.Size(81, 15);
            this.labelCommon5.TabIndex = 8;
            this.labelCommon5.Text = "Asset Name :";
            // 
            // txtAssetName
            // 
            this.txtAssetName.ControlId = null;
            this.txtAssetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetName.Location = new System.Drawing.Point(6, 35);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(380, 21);
            this.txtAssetName.TabIndex = 11;
            // 
            // lbAssetNo
            // 
            this.lbAssetNo.AutoSize = true;
            this.lbAssetNo.ControlId = null;
            this.lbAssetNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetNo.Location = new System.Drawing.Point(41, 127);
            this.lbAssetNo.Name = "lbAssetNo";
            this.lbAssetNo.Size = new System.Drawing.Size(37, 15);
            this.lbAssetNo.TabIndex = 7;
            this.lbAssetNo.Text = "None";
            // 
            // labelCommon3
            // 
            this.labelCommon3.AutoSize = true;
            this.labelCommon3.ControlId = null;
            this.labelCommon3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon3.Location = new System.Drawing.Point(6, 127);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(29, 15);
            this.labelCommon3.TabIndex = 5;
            this.labelCommon3.Text = "No :";
            // 
            // txtAssetNo
            // 
            this.txtAssetNo.ControlId = null;
            this.txtAssetNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetNo.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAssetNo.Location = new System.Drawing.Point(6, 145);
            this.txtAssetNo.Name = "txtAssetNo";
            this.txtAssetNo.Size = new System.Drawing.Size(108, 21);
            this.txtAssetNo.TabIndex = 14;
            // 
            // lbAssetCode
            // 
            this.lbAssetCode.AutoSize = true;
            this.lbAssetCode.ControlId = null;
            this.lbAssetCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetCode.Location = new System.Drawing.Point(89, 72);
            this.lbAssetCode.Name = "lbAssetCode";
            this.lbAssetCode.Size = new System.Drawing.Size(37, 15);
            this.lbAssetCode.TabIndex = 4;
            this.lbAssetCode.Text = "None";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.ControlId = null;
            this.lbSupplier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.Location = new System.Drawing.Point(105, 347);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(37, 15);
            this.lbSupplier.TabIndex = 22;
            this.lbSupplier.Text = "None";
            // 
            // labelCommon13
            // 
            this.labelCommon13.AutoSize = true;
            this.labelCommon13.ControlId = null;
            this.labelCommon13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon13.Location = new System.Drawing.Point(6, 347);
            this.labelCommon13.Name = "labelCommon13";
            this.labelCommon13.Size = new System.Drawing.Size(93, 15);
            this.labelCommon13.TabIndex = 20;
            this.labelCommon13.Text = "Asset Supplier :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.ControlId = null;
            this.txtSupplier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtSupplier.Location = new System.Drawing.Point(6, 365);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSupplier.Size = new System.Drawing.Size(380, 21);
            this.txtSupplier.TabIndex = 25;
            // 
            // lbAcqCost
            // 
            this.lbAcqCost.AutoSize = true;
            this.lbAcqCost.ControlId = null;
            this.lbAcqCost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcqCost.Location = new System.Drawing.Point(113, 237);
            this.lbAcqCost.Name = "lbAcqCost";
            this.lbAcqCost.Size = new System.Drawing.Size(37, 15);
            this.lbAcqCost.TabIndex = 25;
            this.lbAcqCost.Text = "None";
            // 
            // labelCommon17
            // 
            this.labelCommon17.AutoSize = true;
            this.labelCommon17.ControlId = null;
            this.labelCommon17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon17.Location = new System.Drawing.Point(6, 237);
            this.labelCommon17.Name = "labelCommon17";
            this.labelCommon17.Size = new System.Drawing.Size(102, 15);
            this.labelCommon17.TabIndex = 23;
            this.labelCommon17.Text = "Acquisition Cost :";
            // 
            // txtAcqCost
            // 
            this.txtAcqCost.ControlId = null;
            this.txtAcqCost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcqCost.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtAcqCost.Location = new System.Drawing.Point(6, 255);
            this.txtAcqCost.Name = "txtAcqCost";
            this.txtAcqCost.Size = new System.Drawing.Size(187, 21);
            this.txtAcqCost.TabIndex = 19;
            // 
            // dtpAcqDate
            // 
            this.dtpAcqDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpAcqDate.ControlId = null;
            this.dtpAcqDate.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.dtpAcqDate.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpAcqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAcqDate.Location = new System.Drawing.Point(6, 310);
            this.dtpAcqDate.Name = "dtpAcqDate";
            this.dtpAcqDate.Size = new System.Drawing.Size(187, 21);
            this.dtpAcqDate.TabIndex = 21;
            // 
            // lbAcqDate
            // 
            this.lbAcqDate.AutoSize = true;
            this.lbAcqDate.ControlId = null;
            this.lbAcqDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcqDate.Location = new System.Drawing.Point(113, 292);
            this.lbAcqDate.Name = "lbAcqDate";
            this.lbAcqDate.Size = new System.Drawing.Size(37, 15);
            this.lbAcqDate.TabIndex = 28;
            this.lbAcqDate.Text = "None";
            // 
            // labelCommon19
            // 
            this.labelCommon19.AutoSize = true;
            this.labelCommon19.ControlId = null;
            this.labelCommon19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon19.Location = new System.Drawing.Point(6, 292);
            this.labelCommon19.Name = "labelCommon19";
            this.labelCommon19.Size = new System.Drawing.Size(102, 15);
            this.labelCommon19.TabIndex = 27;
            this.labelCommon19.Text = "Acquisition Date :";
            // 
            // txtFactory
            // 
            this.txtFactory.ControlId = null;
            this.txtFactory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactory.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.txtFactory.Location = new System.Drawing.Point(199, 255);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(187, 21);
            this.txtFactory.TabIndex = 20;
            // 
            // lbFactory
            // 
            this.lbFactory.AutoSize = true;
            this.lbFactory.ControlId = null;
            this.lbFactory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactory.Location = new System.Drawing.Point(257, 237);
            this.lbFactory.Name = "lbFactory";
            this.lbFactory.Size = new System.Drawing.Size(37, 15);
            this.lbFactory.TabIndex = 31;
            this.lbFactory.Text = "None";
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon4.Location = new System.Drawing.Point(199, 237);
            this.labelCommon4.Name = "labelCommon4";
            this.labelCommon4.Size = new System.Drawing.Size(52, 15);
            this.labelCommon4.TabIndex = 30;
            this.labelCommon4.Text = "Factory :";
            // 
            // rbtnPasted
            // 
            this.rbtnPasted.AutoSize = true;
            this.rbtnPasted.BackColor = System.Drawing.Color.Lime;
            this.rbtnPasted.ControlId = null;
            this.rbtnPasted.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPasted.Location = new System.Drawing.Point(202, 290);
            this.rbtnPasted.Name = "rbtnPasted";
            this.rbtnPasted.Size = new System.Drawing.Size(64, 19);
            this.rbtnPasted.TabIndex = 22;
            this.rbtnPasted.TabStop = true;
            this.rbtnPasted.Text = "Pasted";
            this.rbtnPasted.UseVisualStyleBackColor = false;
            // 
            // rbtnNotPaste
            // 
            this.rbtnNotPaste.AutoSize = true;
            this.rbtnNotPaste.BackColor = System.Drawing.Color.Yellow;
            this.rbtnNotPaste.ControlId = null;
            this.rbtnNotPaste.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNotPaste.Location = new System.Drawing.Point(308, 290);
            this.rbtnNotPaste.Name = "rbtnNotPaste";
            this.rbtnNotPaste.Size = new System.Drawing.Size(78, 19);
            this.rbtnNotPaste.TabIndex = 23;
            this.rbtnNotPaste.TabStop = true;
            this.rbtnNotPaste.Text = "Not paste";
            this.rbtnNotPaste.UseVisualStyleBackColor = false;
            // 
            // rbtnCntPaste
            // 
            this.rbtnCntPaste.AutoSize = true;
            this.rbtnCntPaste.BackColor = System.Drawing.Color.Red;
            this.rbtnCntPaste.ControlId = null;
            this.rbtnCntPaste.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCntPaste.Location = new System.Drawing.Point(238, 310);
            this.rbtnCntPaste.Name = "rbtnCntPaste";
            this.rbtnCntPaste.Size = new System.Drawing.Size(107, 19);
            this.rbtnCntPaste.TabIndex = 24;
            this.rbtnCntPaste.TabStop = true;
            this.rbtnCntPaste.Text = "Can\'t not paste";
            this.rbtnCntPaste.UseVisualStyleBackColor = false;
            // 
            // lbLife
            // 
            this.lbLife.AutoSize = true;
            this.lbLife.ControlId = null;
            this.lbLife.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLife.Location = new System.Drawing.Point(156, 127);
            this.lbLife.Name = "lbLife";
            this.lbLife.Size = new System.Drawing.Size(37, 15);
            this.lbLife.TabIndex = 37;
            this.lbLife.Text = "None";
            // 
            // labelCommon6
            // 
            this.labelCommon6.AutoSize = true;
            this.labelCommon6.ControlId = null;
            this.labelCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon6.Location = new System.Drawing.Point(117, 127);
            this.labelCommon6.Name = "labelCommon6";
            this.labelCommon6.Size = new System.Drawing.Size(33, 15);
            this.labelCommon6.TabIndex = 35;
            this.labelCommon6.Text = "Life :";
            // 
            // numLife
            // 
            this.numLife.Location = new System.Drawing.Point(117, 145);
            this.numLife.Name = "numLife";
            this.numLife.Size = new System.Drawing.Size(73, 21);
            this.numLife.TabIndex = 15;
            // 
            // pnlButton
            // 
            this.pnlButton.ControlId = null;
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnApply);
            this.pnlButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(12, 514);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(398, 45);
            this.pnlButton.TabIndex = 30;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Control;
            this.btnApply.ControlId = null;
            this.btnApply.Font = new System.Drawing.Font("Arial", 9F);
            this.btnApply.Location = new System.Drawing.Point(70, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 33);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.ControlId = null;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCancel.Location = new System.Drawing.Point(239, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 33);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // UpdateAssetForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 571);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.grUpdate);
            this.Name = "UpdateAssetForm";
            this.Text = "Update Asset 2019";
            this.TitleText = "Update Asset";
            this.Controls.SetChildIndex(this.grUpdate, 0);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.grUpdate.ResumeLayout(false);
            this.grUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLife)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.LabelCommon labelCommon1;
        private Framework.TextBoxCommon txtAssetCode;
        private Framework.GroupBoxCommon grUpdate;
        private Framework.LabelCommon lbAssetModel;
        private Framework.LabelCommon labelCommon9;
        private Framework.TextBoxCommon txtAssetModel;
        private Framework.LabelCommon lbAssetSerial;
        private Framework.LabelCommon labelCommon7;
        private Framework.TextBoxCommon txtAssetSerial;
        private Framework.LabelCommon lbAssetName;
        private Framework.LabelCommon labelCommon5;
        private Framework.TextBoxCommon txtAssetName;
        private Framework.LabelCommon lbAssetNo;
        private Framework.LabelCommon labelCommon3;
        private Framework.TextBoxCommon txtAssetNo;
        private Framework.LabelCommon lbAssetCode;
        private Framework.LabelCommon lbInvoice;
        private Framework.LabelCommon labelCommon11;
        private Framework.TextBoxCommon txtAssetInvoice;
        private Framework.LabelCommon lbSupplier;
        private Framework.LabelCommon labelCommon13;
        private Framework.TextBoxCommon txtSupplier;
        private Framework.LabelCommon lbAssetPO;
        private Framework.LabelCommon labelCommon15;
        private Framework.TextBoxCommon txtAssetPO;
        private Framework.LabelCommon lbAcqDate;
        private Framework.LabelCommon labelCommon19;
        private Framework.DateTimePickerCommon dtpAcqDate;
        private Framework.LabelCommon lbAcqCost;
        private Framework.LabelCommon labelCommon17;
        private Framework.TextBoxCommon txtAcqCost;
        private Framework.LabelCommon lbFactory;
        private Framework.LabelCommon labelCommon4;
        private Framework.TextBoxCommon txtFactory;
        private Framework.RadioButtonCommon rbtnCntPaste;
        private Framework.RadioButtonCommon rbtnNotPaste;
        private Framework.RadioButtonCommon rbtnPasted;
        private System.Windows.Forms.NumericUpDown numLife;
        private Framework.LabelCommon lbLife;
        private Framework.LabelCommon labelCommon6;
        private Framework.PanelCommon pnlButton;
        private Framework.ButtonCommon btnCancel;
        private Framework.ButtonCommon btnApply;
    }
}