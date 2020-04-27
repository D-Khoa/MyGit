namespace PC_QRCodeSystem.View
{
    partial class PlanItemForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbSetNum = new System.Windows.Forms.Label();
            this.lbPlanCD = new System.Windows.Forms.Label();
            this.lbPlanQty = new System.Windows.Forms.Label();
            this.pnlMainButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlMainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(150, 290);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(700, 182);
            this.dgvData.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lbPlanQty);
            this.pnlMain.Controls.Add(this.lbPlanCD);
            this.pnlMain.Controls.Add(this.lbSetNum);
            this.pnlMain.Controls.Add(this.lbDestination);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.txtComment);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.lbUser);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.lbModelName);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(150, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(700, 160);
            this.pnlMain.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(330, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Plan Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Comment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(120, 100);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(520, 50);
            this.txtComment.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(330, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Qty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUser
            // 
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(120, 10);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(200, 20);
            this.lbUser.TabIndex = 10;
            this.lbUser.Text = "User";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "User Code";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModelName
            // 
            this.lbModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelName.Location = new System.Drawing.Point(120, 40);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(200, 20);
            this.lbModelName.TabIndex = 7;
            this.lbModelName.Text = "Model Name";
            this.lbModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Model";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(330, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Destination";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDestination
            // 
            this.lbDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestination.Location = new System.Drawing.Point(440, 40);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(200, 20);
            this.lbDestination.TabIndex = 26;
            this.lbDestination.Text = "Destination";
            this.lbDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSetNum
            // 
            this.lbSetNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetNum.Location = new System.Drawing.Point(120, 70);
            this.lbSetNum.Name = "lbSetNum";
            this.lbSetNum.Size = new System.Drawing.Size(200, 20);
            this.lbSetNum.TabIndex = 27;
            this.lbSetNum.Text = "Set Number";
            this.lbSetNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlanCD
            // 
            this.lbPlanCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlanCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanCD.Location = new System.Drawing.Point(440, 10);
            this.lbPlanCD.Name = "lbPlanCD";
            this.lbPlanCD.Size = new System.Drawing.Size(200, 20);
            this.lbPlanCD.TabIndex = 28;
            this.lbPlanCD.Text = "Plan Code";
            this.lbPlanCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlanQty
            // 
            this.lbPlanQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlanQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanQty.Location = new System.Drawing.Point(440, 70);
            this.lbPlanQty.Name = "lbPlanQty";
            this.lbPlanQty.Size = new System.Drawing.Size(200, 20);
            this.lbPlanQty.TabIndex = 29;
            this.lbPlanQty.Text = "Plan Qty";
            this.lbPlanQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainButtons
            // 
            this.pnlMainButtons.Controls.Add(this.btnExport);
            this.pnlMainButtons.Controls.Add(this.btnDelete);
            this.pnlMainButtons.Controls.Add(this.btnPrint);
            this.pnlMainButtons.Controls.Add(this.btnAddItem);
            this.pnlMainButtons.Controls.Add(this.btnRegister);
            this.pnlMainButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainButtons.Location = new System.Drawing.Point(150, 230);
            this.pnlMainButtons.Name = "pnlMainButtons";
            this.pnlMainButtons.Size = new System.Drawing.Size(700, 60);
            this.pnlMainButtons.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(435, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 50);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(185, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 50);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add New Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(60, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 50);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(560, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 50);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PlanItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 472);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlMainButtons);
            this.Controls.Add(this.pnlMain);
            this.dept = "";
            this.listper = null;
            this.logintime = new System.DateTime(((long)(0)));
            this.name = "";
            this.Name = "PlanItemForm";
            this.position = "";
            this.Text = "PlanItemForm";
            this.tittle = "FormCommon";
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlMainButtons, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlMainButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlanQty;
        private System.Windows.Forms.Label lbPlanCD;
        private System.Windows.Forms.Label lbSetNum;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Panel pnlMainButtons;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnPrint;
    }
}