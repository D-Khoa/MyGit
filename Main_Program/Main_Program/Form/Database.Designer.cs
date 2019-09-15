namespace Main_Program
{
    partial class Database
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
            this.tabDatabase = new System.Windows.Forms.TabControl();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.tabWeapon = new System.Windows.Forms.TabPage();
            this.tabArmors = new System.Windows.Forms.TabPage();
            this.tabAnimations = new System.Windows.Forms.TabPage();
            this.tabStates = new System.Windows.Forms.TabPage();
            this.tabEnemies = new System.Windows.Forms.TabPage();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grOption = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grGraphic = new System.Windows.Forms.GroupBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.grGeneral = new System.Windows.Forms.GroupBox();
            this.cmbMaxLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIniLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grActors = new System.Windows.Forms.GroupBox();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.grFeature = new System.Windows.Forms.GroupBox();
            this.dgvFeature = new System.Windows.Forms.DataGridView();
            this.tabDatabase.SuspendLayout();
            this.tabActors.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.grOption.SuspendLayout();
            this.grGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.grGeneral.SuspendLayout();
            this.grActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.grFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.tabActors);
            this.tabDatabase.Controls.Add(this.tabClasses);
            this.tabDatabase.Controls.Add(this.tabSkills);
            this.tabDatabase.Controls.Add(this.tabItem);
            this.tabDatabase.Controls.Add(this.tabWeapon);
            this.tabDatabase.Controls.Add(this.tabArmors);
            this.tabDatabase.Controls.Add(this.tabAnimations);
            this.tabDatabase.Controls.Add(this.tabStates);
            this.tabDatabase.Controls.Add(this.tabEnemies);
            this.tabDatabase.Controls.Add(this.tabSystem);
            this.tabDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDatabase.Location = new System.Drawing.Point(0, 0);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.SelectedIndex = 0;
            this.tabDatabase.Size = new System.Drawing.Size(607, 473);
            this.tabDatabase.TabIndex = 0;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.grOption);
            this.tabActors.Controls.Add(this.grGraphic);
            this.tabActors.Controls.Add(this.grGeneral);
            this.tabActors.Controls.Add(this.grActors);
            this.tabActors.Controls.Add(this.grFeature);
            this.tabActors.Location = new System.Drawing.Point(4, 22);
            this.tabActors.Name = "tabActors";
            this.tabActors.Padding = new System.Windows.Forms.Padding(3);
            this.tabActors.Size = new System.Drawing.Size(599, 447);
            this.tabActors.TabIndex = 0;
            this.tabActors.Text = "Actors";
            this.tabActors.UseVisualStyleBackColor = true;
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.flowLayoutPanel2);
            this.tabClasses.Controls.Add(this.flowLayoutPanel1);
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(599, 447);
            this.tabClasses.TabIndex = 1;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tabSkills
            // 
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(599, 447);
            this.tabSkills.TabIndex = 2;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabItem
            // 
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(599, 447);
            this.tabItem.TabIndex = 3;
            this.tabItem.Text = "Items";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // tabWeapon
            // 
            this.tabWeapon.Location = new System.Drawing.Point(4, 22);
            this.tabWeapon.Name = "tabWeapon";
            this.tabWeapon.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapon.Size = new System.Drawing.Size(599, 447);
            this.tabWeapon.TabIndex = 4;
            this.tabWeapon.Text = "Weapons";
            this.tabWeapon.UseVisualStyleBackColor = true;
            // 
            // tabArmors
            // 
            this.tabArmors.Location = new System.Drawing.Point(4, 22);
            this.tabArmors.Name = "tabArmors";
            this.tabArmors.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmors.Size = new System.Drawing.Size(599, 447);
            this.tabArmors.TabIndex = 5;
            this.tabArmors.Text = "Armors";
            this.tabArmors.UseVisualStyleBackColor = true;
            // 
            // tabAnimations
            // 
            this.tabAnimations.Location = new System.Drawing.Point(4, 22);
            this.tabAnimations.Name = "tabAnimations";
            this.tabAnimations.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimations.Size = new System.Drawing.Size(599, 447);
            this.tabAnimations.TabIndex = 6;
            this.tabAnimations.Text = "Animations";
            this.tabAnimations.UseVisualStyleBackColor = true;
            // 
            // tabStates
            // 
            this.tabStates.Location = new System.Drawing.Point(4, 22);
            this.tabStates.Name = "tabStates";
            this.tabStates.Padding = new System.Windows.Forms.Padding(3);
            this.tabStates.Size = new System.Drawing.Size(599, 447);
            this.tabStates.TabIndex = 7;
            this.tabStates.Text = "States";
            this.tabStates.UseVisualStyleBackColor = true;
            // 
            // tabEnemies
            // 
            this.tabEnemies.Location = new System.Drawing.Point(4, 22);
            this.tabEnemies.Name = "tabEnemies";
            this.tabEnemies.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnemies.Size = new System.Drawing.Size(599, 447);
            this.tabEnemies.TabIndex = 8;
            this.tabEnemies.Text = "Enemies";
            this.tabEnemies.UseVisualStyleBackColor = true;
            // 
            // tabSystem
            // 
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(599, 447);
            this.tabSystem.TabIndex = 11;
            this.tabSystem.Text = "System";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 441);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(203, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 441);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // grOption
            // 
            this.grOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grOption.Controls.Add(this.btnCancle);
            this.grOption.Controls.Add(this.btnDelete);
            this.grOption.Controls.Add(this.btnOK);
            this.grOption.Controls.Add(this.btnUpdate);
            this.grOption.Location = new System.Drawing.Point(165, 284);
            this.grOption.Name = "grOption";
            this.grOption.Size = new System.Drawing.Size(269, 135);
            this.grOption.TabIndex = 31;
            this.grOption.TabStop = false;
            this.grOption.Text = "Options";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(138, 83);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 39);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(138, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(30, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(30, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 39);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // grGraphic
            // 
            this.grGraphic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grGraphic.Controls.Add(this.picSprite);
            this.grGraphic.Controls.Add(this.picFace);
            this.grGraphic.Location = new System.Drawing.Point(165, 172);
            this.grGraphic.Name = "grGraphic";
            this.grGraphic.Size = new System.Drawing.Size(269, 112);
            this.grGraphic.TabIndex = 30;
            this.grGraphic.TabStop = false;
            this.grGraphic.Text = "Graphic";
            // 
            // picSprite
            // 
            this.picSprite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSprite.Location = new System.Drawing.Point(138, 19);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(100, 75);
            this.picSprite.TabIndex = 1;
            this.picSprite.TabStop = false;
            // 
            // picFace
            // 
            this.picFace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFace.Location = new System.Drawing.Point(30, 19);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(100, 75);
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            // 
            // grGeneral
            // 
            this.grGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grGeneral.Controls.Add(this.cmbMaxLevel);
            this.grGeneral.Controls.Add(this.label5);
            this.grGeneral.Controls.Add(this.cmbIniLevel);
            this.grGeneral.Controls.Add(this.label4);
            this.grGeneral.Controls.Add(this.cmbClass);
            this.grGeneral.Controls.Add(this.label3);
            this.grGeneral.Controls.Add(this.txtDescription);
            this.grGeneral.Controls.Add(this.label2);
            this.grGeneral.Controls.Add(this.txtName);
            this.grGeneral.Controls.Add(this.label1);
            this.grGeneral.Location = new System.Drawing.Point(165, 2);
            this.grGeneral.Name = "grGeneral";
            this.grGeneral.Size = new System.Drawing.Size(269, 170);
            this.grGeneral.TabIndex = 29;
            this.grGeneral.TabStop = false;
            this.grGeneral.Text = "General Setting";
            // 
            // cmbMaxLevel
            // 
            this.cmbMaxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaxLevel.FormattingEnabled = true;
            this.cmbMaxLevel.Location = new System.Drawing.Point(202, 71);
            this.cmbMaxLevel.Name = "cmbMaxLevel";
            this.cmbMaxLevel.Size = new System.Drawing.Size(57, 21);
            this.cmbMaxLevel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Level";
            // 
            // cmbIniLevel
            // 
            this.cmbIniLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIniLevel.FormattingEnabled = true;
            this.cmbIniLevel.Location = new System.Drawing.Point(138, 71);
            this.cmbIniLevel.Name = "cmbIniLevel";
            this.cmbIniLevel.Size = new System.Drawing.Size(57, 21);
            this.cmbIniLevel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initial Level";
            // 
            // cmbClass
            // 
            this.cmbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(9, 71);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(9, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 54);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(9, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // grActors
            // 
            this.grActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grActors.Controls.Add(this.dgvActors);
            this.grActors.Location = new System.Drawing.Point(2, 2);
            this.grActors.Name = "grActors";
            this.grActors.Size = new System.Drawing.Size(159, 417);
            this.grActors.TabIndex = 28;
            this.grActors.TabStop = false;
            this.grActors.Text = "Actors";
            this.grActors.Paint += new System.Windows.Forms.PaintEventHandler(this.grActors_Paint);
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActors.Location = new System.Drawing.Point(3, 16);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(153, 398);
            this.dgvActors.TabIndex = 0;
            // 
            // grFeature
            // 
            this.grFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grFeature.Controls.Add(this.dgvFeature);
            this.grFeature.Location = new System.Drawing.Point(438, 2);
            this.grFeature.Name = "grFeature";
            this.grFeature.Size = new System.Drawing.Size(159, 417);
            this.grFeature.TabIndex = 27;
            this.grFeature.TabStop = false;
            this.grFeature.Text = "Features";
            this.grFeature.Paint += new System.Windows.Forms.PaintEventHandler(this.grFeature_Paint);
            // 
            // dgvFeature
            // 
            this.dgvFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeature.Location = new System.Drawing.Point(3, 16);
            this.dgvFeature.Name = "dgvFeature";
            this.dgvFeature.Size = new System.Drawing.Size(153, 398);
            this.dgvFeature.TabIndex = 1;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 473);
            this.Controls.Add(this.tabDatabase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.tabDatabase.ResumeLayout(false);
            this.tabActors.ResumeLayout(false);
            this.tabClasses.ResumeLayout(false);
            this.grOption.ResumeLayout(false);
            this.grGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.grGeneral.ResumeLayout(false);
            this.grGeneral.PerformLayout();
            this.grActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.grFeature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDatabase;
        private System.Windows.Forms.TabPage tabActors;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabWeapon;
        private System.Windows.Forms.TabPage tabArmors;
        private System.Windows.Forms.TabPage tabAnimations;
        private System.Windows.Forms.TabPage tabStates;
        private System.Windows.Forms.TabPage tabEnemies;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grOption;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grGraphic;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.GroupBox grGeneral;
        private System.Windows.Forms.ComboBox cmbMaxLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIniLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grActors;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.GroupBox grFeature;
        private System.Windows.Forms.DataGridView dgvFeature;
    }
}