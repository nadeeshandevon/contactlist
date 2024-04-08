namespace WinFormsApp1
{
    partial class frmAddEdit
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            cmbTitle = new ComboBox();
            label3 = new Label();
            txtMiddleIntial = new TextBox();
            label4 = new Label();
            txtHomePhone = new TextBox();
            label5 = new Label();
            txtCellPhone = new TextBox();
            label6 = new Label();
            txtOfficeExt = new TextBox();
            label7 = new Label();
            txtIrdNo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            cmbStaffType = new ComboBox();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            optStatusPending = new RadioButton();
            optStatusInactive = new RadioButton();
            optStatusActive = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            label10 = new Label();
            cmbManager = new ComboBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 102);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(160, 102);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(518, 31);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(160, 139);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(518, 31);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 139);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // cmbTitle
            // 
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(160, 63);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(182, 33);
            cmbTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 66);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 5;
            label3.Text = "Title";
            // 
            // txtMiddleIntial
            // 
            txtMiddleIntial.Location = new Point(160, 176);
            txtMiddleIntial.Name = "txtMiddleIntial";
            txtMiddleIntial.Size = new Size(518, 31);
            txtMiddleIntial.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 176);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 6;
            label4.Text = "Middle Initial";
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(160, 213);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(256, 31);
            txtHomePhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 213);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 8;
            label5.Text = "Home Phone";
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(160, 250);
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(256, 31);
            txtCellPhone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 250);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 10;
            label6.Text = "Cell Phone";
            // 
            // txtOfficeExt
            // 
            txtOfficeExt.Location = new Point(160, 287);
            txtOfficeExt.Name = "txtOfficeExt";
            txtOfficeExt.Size = new Size(256, 31);
            txtOfficeExt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 287);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 12;
            label7.Text = "Office Extension";
            // 
            // txtIrdNo
            // 
            txtIrdNo.Location = new Point(160, 324);
            txtIrdNo.Name = "txtIrdNo";
            txtIrdNo.Size = new Size(256, 31);
            txtIrdNo.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 324);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 14;
            label8.Text = "IRD Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 373);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 19;
            label9.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 27);
            label11.Name = "label11";
            label11.Size = new Size(90, 25);
            label11.TabIndex = 23;
            label11.Text = "Staff Type";
            // 
            // cmbStaffType
            // 
            cmbStaffType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffType.FormattingEnabled = true;
            cmbStaffType.Location = new Point(160, 24);
            cmbStaffType.Name = "cmbStaffType";
            cmbStaffType.Size = new Size(182, 33);
            cmbStaffType.TabIndex = 22;
            cmbStaffType.SelectedIndexChanged += cmbStaffType_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(713, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optStatusPending);
            groupBox1.Controls.Add(optStatusInactive);
            groupBox1.Controls.Add(optStatusActive);
            groupBox1.Location = new Point(160, 350);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 57);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // optStatusPending
            // 
            optStatusPending.AutoSize = true;
            optStatusPending.Location = new Point(197, 23);
            optStatusPending.Name = "optStatusPending";
            optStatusPending.Size = new Size(101, 29);
            optStatusPending.TabIndex = 21;
            optStatusPending.Text = "Pending";
            optStatusPending.UseVisualStyleBackColor = true;
            // 
            // optStatusInactive
            // 
            optStatusInactive.AutoSize = true;
            optStatusInactive.Location = new Point(94, 23);
            optStatusInactive.Name = "optStatusInactive";
            optStatusInactive.Size = new Size(97, 29);
            optStatusInactive.TabIndex = 20;
            optStatusInactive.Text = "Inactive";
            optStatusInactive.UseVisualStyleBackColor = true;
            // 
            // optStatusActive
            // 
            optStatusActive.AutoSize = true;
            optStatusActive.Checked = true;
            optStatusActive.Location = new Point(2, 23);
            optStatusActive.Name = "optStatusActive";
            optStatusActive.Size = new Size(85, 29);
            optStatusActive.TabIndex = 19;
            optStatusActive.TabStop = true;
            optStatusActive.Text = "Active";
            optStatusActive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmbManager);
            panel1.Location = new Point(31, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 48);
            panel1.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 6);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 25;
            label10.Text = "Manager";
            // 
            // cmbManager
            // 
            cmbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManager.FormattingEnabled = true;
            cmbManager.Items.AddRange(new object[] { "--Select manager --" });
            cmbManager.Location = new Point(124, 3);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(261, 33);
            cmbManager.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(584, 538);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 27;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAddEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 594);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(cmbStaffType);
            Controls.Add(label9);
            Controls.Add(txtIrdNo);
            Controls.Add(label8);
            Controls.Add(txtOfficeExt);
            Controls.Add(label7);
            Controls.Add(txtCellPhone);
            Controls.Add(label6);
            Controls.Add(txtHomePhone);
            Controls.Add(label5);
            Controls.Add(txtMiddleIntial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbTitle);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Employee";
            FormClosing += frmAddEdit_FormClosing;
            Load += frmAddEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private ComboBox cmbTitle;
        private Label label3;
        private TextBox txtMiddleIntial;
        private Label label4;
        private TextBox txtHomePhone;
        private Label label5;
        private TextBox txtCellPhone;
        private Label label6;
        private TextBox txtOfficeExt;
        private Label label7;
        private TextBox txtIrdNo;
        private Label label8;
        private Label label9;
        private Label label11;
        private ComboBox cmbStaffType;
        private Button btnSave;
        private GroupBox groupBox1;
        private RadioButton optStatusPending;
        private RadioButton optStatusInactive;
        private RadioButton optStatusActive;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Label label10;
        private ComboBox cmbManager;
        private Button button1;
    }
}