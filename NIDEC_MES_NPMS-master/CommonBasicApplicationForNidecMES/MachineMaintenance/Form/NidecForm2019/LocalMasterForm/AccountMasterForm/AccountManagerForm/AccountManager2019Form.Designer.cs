namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    partial class AccountManager2019Form
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Type");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Section");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Label");
            this.groupBoxCommon1 = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.textBoxCommon1 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.treeViewCommon1 = new Com.Nidec.Mes.Framework.TreeViewCommon();
            this.comboBoxCommon1 = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon2 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon3 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon4 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon6 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon5 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon7 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon6 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon8 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.textBoxCommon7 = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.groupBoxCommon1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCommon1
            // 
            this.groupBoxCommon1.ControlId = null;
            this.groupBoxCommon1.Controls.Add(this.labelCommon8);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon7);
            this.groupBoxCommon1.Controls.Add(this.labelCommon6);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon5);
            this.groupBoxCommon1.Controls.Add(this.labelCommon7);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon6);
            this.groupBoxCommon1.Controls.Add(this.labelCommon5);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon4);
            this.groupBoxCommon1.Controls.Add(this.labelCommon4);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon3);
            this.groupBoxCommon1.Controls.Add(this.labelCommon3);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon2);
            this.groupBoxCommon1.Controls.Add(this.labelCommon2);
            this.groupBoxCommon1.Controls.Add(this.comboBoxCommon1);
            this.groupBoxCommon1.Controls.Add(this.treeViewCommon1);
            this.groupBoxCommon1.Controls.Add(this.labelCommon1);
            this.groupBoxCommon1.Controls.Add(this.textBoxCommon1);
            this.groupBoxCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCommon1.Location = new System.Drawing.Point(0, 113);
            this.groupBoxCommon1.Name = "groupBoxCommon1";
            this.groupBoxCommon1.Size = new System.Drawing.Size(682, 209);
            this.groupBoxCommon1.TabIndex = 2;
            this.groupBoxCommon1.TabStop = false;
            // 
            // textBoxCommon1
            // 
            this.textBoxCommon1.ControlId = null;
            this.textBoxCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon1.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon1.Location = new System.Drawing.Point(95, 14);
            this.textBoxCommon1.Name = "textBoxCommon1";
            this.textBoxCommon1.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon1.TabIndex = 0;
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon1.Location = new System.Drawing.Point(6, 17);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(71, 15);
            this.labelCommon1.TabIndex = 1;
            this.labelCommon1.Text = "Asset Code";
            // 
            // treeViewCommon1
            // 
            this.treeViewCommon1.ControlId = null;
            this.treeViewCommon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCommon1.Location = new System.Drawing.Point(396, 100);
            this.treeViewCommon1.Name = "treeViewCommon1";
            treeNode1.Name = "asset_type";
            treeNode1.Text = "Type";
            treeNode2.Name = "account_section";
            treeNode2.Text = "Section";
            treeNode3.Name = "label_status";
            treeNode3.Text = "Label";
            this.treeViewCommon1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeViewCommon1.Size = new System.Drawing.Size(121, 97);
            this.treeViewCommon1.TabIndex = 3;
            // 
            // comboBoxCommon1
            // 
            this.comboBoxCommon1.ControlId = null;
            this.comboBoxCommon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCommon1.FormattingEnabled = true;
            this.comboBoxCommon1.Location = new System.Drawing.Point(95, 41);
            this.comboBoxCommon1.Name = "comboBoxCommon1";
            this.comboBoxCommon1.Size = new System.Drawing.Size(187, 23);
            this.comboBoxCommon1.TabIndex = 4;
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon2.Location = new System.Drawing.Point(6, 44);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(57, 15);
            this.labelCommon2.TabIndex = 5;
            this.labelCommon2.Text = "Asset No";
            // 
            // labelCommon3
            // 
            this.labelCommon3.AutoSize = true;
            this.labelCommon3.ControlId = null;
            this.labelCommon3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon3.Location = new System.Drawing.Point(6, 73);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(73, 15);
            this.labelCommon3.TabIndex = 7;
            this.labelCommon3.Text = "Asset Serial";
            // 
            // textBoxCommon2
            // 
            this.textBoxCommon2.ControlId = null;
            this.textBoxCommon2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon2.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon2.Location = new System.Drawing.Point(95, 70);
            this.textBoxCommon2.Name = "textBoxCommon2";
            this.textBoxCommon2.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon2.TabIndex = 6;
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon4.Location = new System.Drawing.Point(6, 100);
            this.labelCommon4.Name = "labelCommon4";
            this.labelCommon4.Size = new System.Drawing.Size(74, 15);
            this.labelCommon4.TabIndex = 9;
            this.labelCommon4.Text = "Asset Model";
            // 
            // textBoxCommon3
            // 
            this.textBoxCommon3.ControlId = null;
            this.textBoxCommon3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon3.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon3.Location = new System.Drawing.Point(95, 97);
            this.textBoxCommon3.Name = "textBoxCommon3";
            this.textBoxCommon3.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon3.TabIndex = 8;
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon5.Location = new System.Drawing.Point(289, 17);
            this.labelCommon5.Name = "labelCommon5";
            this.labelCommon5.Size = new System.Drawing.Size(83, 15);
            this.labelCommon5.TabIndex = 11;
            this.labelCommon5.Text = "Account Code";
            // 
            // textBoxCommon4
            // 
            this.textBoxCommon4.ControlId = null;
            this.textBoxCommon4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon4.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon4.Location = new System.Drawing.Point(378, 14);
            this.textBoxCommon4.Name = "textBoxCommon4";
            this.textBoxCommon4.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon4.TabIndex = 10;
            // 
            // labelCommon6
            // 
            this.labelCommon6.AutoSize = true;
            this.labelCommon6.ControlId = null;
            this.labelCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon6.Location = new System.Drawing.Point(289, 71);
            this.labelCommon6.Name = "labelCommon6";
            this.labelCommon6.Size = new System.Drawing.Size(24, 15);
            this.labelCommon6.TabIndex = 15;
            this.labelCommon6.Text = "PO";
            // 
            // textBoxCommon5
            // 
            this.textBoxCommon5.ControlId = null;
            this.textBoxCommon5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon5.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon5.Location = new System.Drawing.Point(378, 68);
            this.textBoxCommon5.Name = "textBoxCommon5";
            this.textBoxCommon5.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon5.TabIndex = 14;
            // 
            // labelCommon7
            // 
            this.labelCommon7.AutoSize = true;
            this.labelCommon7.ControlId = null;
            this.labelCommon7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon7.Location = new System.Drawing.Point(289, 44);
            this.labelCommon7.Name = "labelCommon7";
            this.labelCommon7.Size = new System.Drawing.Size(45, 15);
            this.labelCommon7.TabIndex = 13;
            this.labelCommon7.Text = "Invoice";
            // 
            // textBoxCommon6
            // 
            this.textBoxCommon6.ControlId = null;
            this.textBoxCommon6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon6.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon6.Location = new System.Drawing.Point(378, 41);
            this.textBoxCommon6.Name = "textBoxCommon6";
            this.textBoxCommon6.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon6.TabIndex = 12;
            // 
            // labelCommon8
            // 
            this.labelCommon8.AutoSize = true;
            this.labelCommon8.ControlId = null;
            this.labelCommon8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommon8.Location = new System.Drawing.Point(6, 127);
            this.labelCommon8.Name = "labelCommon8";
            this.labelCommon8.Size = new System.Drawing.Size(74, 15);
            this.labelCommon8.TabIndex = 17;
            this.labelCommon8.Text = "Asset Model";
            // 
            // textBoxCommon7
            // 
            this.textBoxCommon7.ControlId = null;
            this.textBoxCommon7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommon7.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.textBoxCommon7.Location = new System.Drawing.Point(95, 124);
            this.textBoxCommon7.Name = "textBoxCommon7";
            this.textBoxCommon7.Size = new System.Drawing.Size(187, 21);
            this.textBoxCommon7.TabIndex = 16;
            // 
            // AccountManager2019Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 533);
            this.Controls.Add(this.groupBoxCommon1);
            this.Name = "AccountManager2019Form";
            this.Text = "Account Manager";
            this.TitleText = "Account Manager";
            this.Controls.SetChildIndex(this.groupBoxCommon1, 0);
            this.groupBoxCommon1.ResumeLayout(false);
            this.groupBoxCommon1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.GroupBoxCommon groupBoxCommon1;
        private Framework.TreeViewCommon treeViewCommon1;
        private Framework.LabelCommon labelCommon1;
        private Framework.TextBoxCommon textBoxCommon1;
        private Framework.ComboBoxCommon comboBoxCommon1;
        private Framework.LabelCommon labelCommon2;
        private Framework.LabelCommon labelCommon3;
        private Framework.TextBoxCommon textBoxCommon2;
        private Framework.LabelCommon labelCommon5;
        private Framework.TextBoxCommon textBoxCommon4;
        private Framework.LabelCommon labelCommon4;
        private Framework.TextBoxCommon textBoxCommon3;
        private Framework.LabelCommon labelCommon6;
        private Framework.TextBoxCommon textBoxCommon5;
        private Framework.LabelCommon labelCommon7;
        private Framework.TextBoxCommon textBoxCommon6;
        private Framework.LabelCommon labelCommon8;
        private Framework.TextBoxCommon textBoxCommon7;
    }
}