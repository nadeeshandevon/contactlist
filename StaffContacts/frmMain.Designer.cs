namespace WinFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            dtGridEmployees = new DataGridView();
            EmployeeId = new DataGridViewTextBoxColumn();
            StaffTypeName = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            MiddleInitial = new DataGridViewTextBoxColumn();
            HomePhone = new DataGridViewTextBoxColumn();
            CellPhone = new DataGridViewTextBoxColumn();
            OfficeExt = new DataGridViewTextBoxColumn();
            TaxNumber = new DataGridViewTextBoxColumn();
            ManagerName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnRefresh = new Button();
            btnEditEmployee = new Button();
            btnCsv = new Button();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dtGridEmployees).BeginInit();
            SuspendLayout();
            // 
            // dtGridEmployees
            // 
            dtGridEmployees.AllowUserToAddRows = false;
            dtGridEmployees.AllowUserToDeleteRows = false;
            dtGridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridEmployees.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, StaffTypeName, Title, FirstName, LastName, MiddleInitial, HomePhone, CellPhone, OfficeExt, TaxNumber, ManagerName, Status });
            dtGridEmployees.Location = new Point(12, 12);
            dtGridEmployees.Name = "dtGridEmployees";
            dtGridEmployees.ReadOnly = true;
            dtGridEmployees.RowHeadersWidth = 62;
            dtGridEmployees.RowTemplate.Height = 33;
            dtGridEmployees.Size = new Size(1896, 616);
            dtGridEmployees.TabIndex = 0;
            dtGridEmployees.DoubleClick += dtGridEmployees_DoubleClick;
            // 
            // EmployeeId
            // 
            EmployeeId.DataPropertyName = "EmployeeId";
            EmployeeId.HeaderText = "EmployeeId";
            EmployeeId.MinimumWidth = 8;
            EmployeeId.Name = "EmployeeId";
            EmployeeId.ReadOnly = true;
            EmployeeId.Visible = false;
            EmployeeId.Width = 150;
            // 
            // StaffTypeName
            // 
            StaffTypeName.DataPropertyName = "StaffTypeName";
            StaffTypeName.HeaderText = "Staff Type";
            StaffTypeName.MinimumWidth = 8;
            StaffTypeName.Name = "StaffTypeName";
            StaffTypeName.ReadOnly = true;
            StaffTypeName.Width = 150;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 150;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 200;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 200;
            // 
            // MiddleInitial
            // 
            MiddleInitial.DataPropertyName = "MiddleInitial";
            MiddleInitial.HeaderText = "Middle Initial";
            MiddleInitial.MinimumWidth = 8;
            MiddleInitial.Name = "MiddleInitial";
            MiddleInitial.ReadOnly = true;
            MiddleInitial.Width = 150;
            // 
            // HomePhone
            // 
            HomePhone.DataPropertyName = "HomePhone";
            HomePhone.HeaderText = "Home Phone";
            HomePhone.MinimumWidth = 8;
            HomePhone.Name = "HomePhone";
            HomePhone.ReadOnly = true;
            HomePhone.Width = 150;
            // 
            // CellPhone
            // 
            CellPhone.DataPropertyName = "CellPhone";
            CellPhone.HeaderText = "Cell Phone";
            CellPhone.MinimumWidth = 8;
            CellPhone.Name = "CellPhone";
            CellPhone.ReadOnly = true;
            CellPhone.Width = 150;
            // 
            // OfficeExt
            // 
            OfficeExt.DataPropertyName = "OfficeExt";
            OfficeExt.HeaderText = "Office Ext";
            OfficeExt.MinimumWidth = 8;
            OfficeExt.Name = "OfficeExt";
            OfficeExt.ReadOnly = true;
            OfficeExt.Width = 150;
            // 
            // TaxNumber
            // 
            TaxNumber.DataPropertyName = "TaxNumber";
            TaxNumber.HeaderText = "Tax Number";
            TaxNumber.MinimumWidth = 8;
            TaxNumber.Name = "TaxNumber";
            TaxNumber.ReadOnly = true;
            TaxNumber.Width = 150;
            // 
            // ManagerName
            // 
            ManagerName.DataPropertyName = "ManagerName";
            ManagerName.HeaderText = "Manager";
            ManagerName.MinimumWidth = 8;
            ManagerName.Name = "ManagerName";
            ManagerName.ReadOnly = true;
            ManagerName.Resizable = DataGridViewTriState.True;
            ManagerName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ManagerName.Width = 150;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1765, 645);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1118, 645);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(1607, 645);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(143, 34);
            btnEditEmployee.TabIndex = 3;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnCsv
            // 
            btnCsv.Location = new Point(1446, 644);
            btnCsv.Name = "btnCsv";
            btnCsv.Size = new Size(143, 34);
            btnCsv.TabIndex = 4;
            btnCsv.Text = "Export to CSV";
            btnCsv.UseVisualStyleBackColor = true;
            btnCsv.Click += btnCsv_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1281, 645);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(143, 34);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2264, 805);
            Controls.Add(btnPrint);
            Controls.Add(btnCsv);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(dtGridEmployees);
            Name = "frmMain";
            Text = "Contact List";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridEmployees;
        private Button btnAdd;
        private Button btnRefresh;
        private Button btnEditEmployee;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn StaffTypeName;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn MiddleInitial;
        private DataGridViewTextBoxColumn HomePhone;
        private DataGridViewTextBoxColumn CellPhone;
        private DataGridViewTextBoxColumn OfficeExt;
        private DataGridViewTextBoxColumn TaxNumber;
        private DataGridViewTextBoxColumn ManagerName;
        private DataGridViewTextBoxColumn Status;
        private Button btnCsv;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}