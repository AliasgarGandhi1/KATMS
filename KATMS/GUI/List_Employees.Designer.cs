namespace KATMS.GUI
{
    partial class List_Employees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.btExistingEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btNewEmployee = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.roundedPanel1 = new KATMS.Additional_Controls.RoundedPanel();
            this.dataEmployeeList = new System.Windows.Forms.DataGridView();
            this.employeetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kATMSdbDataSet = new KATMS.KATMSdbDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.employeetbTableAdapter = new KATMS.KATMSdbDataSetTableAdapters.EmployeetbTableAdapter();
            this.kATMSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeetbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kATMSdbDataSet1 = new KATMS.KATMSdbDataSet1();
            this.employeetbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeetbTableAdapter1 = new KATMS.KATMSdbDataSet1TableAdapters.EmployeetbTableAdapter();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btExistingEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btNewEmployee);
            this.panel1.Controls.Add(this.btList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 846);
            this.panel1.TabIndex = 2;
            // 
            // btHome
            // 
            this.btHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.Location = new System.Drawing.Point(0, 674);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(305, 176);
            this.btHome.TabIndex = 6;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btExistingEmployee
            // 
            this.btExistingEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btExistingEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExistingEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btExistingEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btExistingEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExistingEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExistingEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExistingEmployee.Location = new System.Drawing.Point(1, 228);
            this.btExistingEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExistingEmployee.Name = "btExistingEmployee";
            this.btExistingEmployee.Size = new System.Drawing.Size(305, 116);
            this.btExistingEmployee.TabIndex = 5;
            this.btExistingEmployee.Text = "E&xisting Employee";
            this.btExistingEmployee.UseVisualStyleBackColor = false;
            this.btExistingEmployee.Click += new System.EventHandler(this.btExistingEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 830);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 921);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 114);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btNewEmployee
            // 
            this.btNewEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNewEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btNewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btNewEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNewEmployee.Location = new System.Drawing.Point(0, 114);
            this.btNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNewEmployee.Name = "btNewEmployee";
            this.btNewEmployee.Size = new System.Drawing.Size(305, 114);
            this.btNewEmployee.TabIndex = 1;
            this.btNewEmployee.Text = "&New Employee";
            this.btNewEmployee.UseVisualStyleBackColor = false;
            this.btNewEmployee.Click += new System.EventHandler(this.btNewEmployee_Click);
            // 
            // btList
            // 
            this.btList.BackColor = System.Drawing.Color.Maroon;
            this.btList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btList.Location = new System.Drawing.Point(0, 0);
            this.btList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(305, 116);
            this.btList.TabIndex = 0;
            this.btList.Text = "&List";
            this.btList.UseVisualStyleBackColor = false;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 1;
            this.roundedPanel1.Controls.Add(this.dataEmployeeList);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(339, 30);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1108, 770);
            this.roundedPanel1.TabIndex = 11;
            this.roundedPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // dataEmployeeList
            // 
            this.dataEmployeeList.AutoGenerateColumns = false;
            this.dataEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.insuranceNumberDataGridViewTextBoxColumn,
            this.payPerHourDataGridViewTextBoxColumn,
            this.bankAccountNumberDataGridViewTextBoxColumn});
            this.dataEmployeeList.DataSource = this.employeetbBindingSource2;
            this.dataEmployeeList.Location = new System.Drawing.Point(27, 134);
            this.dataEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEmployeeList.Name = "dataEmployeeList";
            this.dataEmployeeList.RowHeadersWidth = 51;
            this.dataEmployeeList.RowTemplate.Height = 24;
            this.dataEmployeeList.Size = new System.Drawing.Size(1053, 594);
            this.dataEmployeeList.TabIndex = 9;
            // 
            // employeetbBindingSource
            // 
            this.employeetbBindingSource.DataMember = "Employeetb";
            this.employeetbBindingSource.DataSource = this.kATMSdbDataSet;
            // 
            // kATMSdbDataSet
            // 
            this.kATMSdbDataSet.DataSetName = "KATMSdbDataSet";
            this.kATMSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(477, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee List";
            // 
            // employeetbTableAdapter
            // 
            this.employeetbTableAdapter.ClearBeforeFill = true;
            // 
            // kATMSdbDataSetBindingSource
            // 
            this.kATMSdbDataSetBindingSource.DataSource = this.kATMSdbDataSet;
            this.kATMSdbDataSetBindingSource.Position = 0;
            // 
            // employeetbBindingSource1
            // 
            this.employeetbBindingSource1.DataMember = "Employeetb";
            this.employeetbBindingSource1.DataSource = this.kATMSdbDataSetBindingSource;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "emailID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "emailID";
            this.emailIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // insuranceNumberDataGridViewTextBoxColumn
            // 
            this.insuranceNumberDataGridViewTextBoxColumn.DataPropertyName = "insuranceNumber";
            this.insuranceNumberDataGridViewTextBoxColumn.HeaderText = "insuranceNumber";
            this.insuranceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insuranceNumberDataGridViewTextBoxColumn.Name = "insuranceNumberDataGridViewTextBoxColumn";
            this.insuranceNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // payPerHourDataGridViewTextBoxColumn
            // 
            this.payPerHourDataGridViewTextBoxColumn.DataPropertyName = "payPerHour";
            this.payPerHourDataGridViewTextBoxColumn.HeaderText = "payPerHour";
            this.payPerHourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payPerHourDataGridViewTextBoxColumn.Name = "payPerHourDataGridViewTextBoxColumn";
            this.payPerHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // bankAccountNumberDataGridViewTextBoxColumn
            // 
            this.bankAccountNumberDataGridViewTextBoxColumn.DataPropertyName = "bankAccountNumber";
            this.bankAccountNumberDataGridViewTextBoxColumn.HeaderText = "bankAccountNumber";
            this.bankAccountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bankAccountNumberDataGridViewTextBoxColumn.Name = "bankAccountNumberDataGridViewTextBoxColumn";
            this.bankAccountNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // kATMSdbDataSet1
            // 
            this.kATMSdbDataSet1.DataSetName = "KATMSdbDataSet1";
            this.kATMSdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeetbBindingSource2
            // 
            this.employeetbBindingSource2.DataMember = "Employeetb";
            this.employeetbBindingSource2.DataSource = this.kATMSdbDataSet1;
            // 
            // employeetbTableAdapter1
            // 
            this.employeetbTableAdapter1.ClearBeforeFill = true;
            // 
            // List_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 846);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "List_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.List_Employees_FormClosing);
            this.Load += new System.EventHandler(this.List_Employees_Load);
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetbBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExistingEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btNewEmployee;
        private System.Windows.Forms.Button btList;
        private Additional_Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.DataGridView dataEmployeeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHome;
        private KATMSdbDataSet kATMSdbDataSet;
        private System.Windows.Forms.BindingSource employeetbBindingSource;
        private KATMSdbDataSetTableAdapters.EmployeetbTableAdapter employeetbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPerHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeetbBindingSource1;
        private System.Windows.Forms.BindingSource kATMSdbDataSetBindingSource;
        private KATMSdbDataSet1 kATMSdbDataSet1;
        private System.Windows.Forms.BindingSource employeetbBindingSource2;
        private KATMSdbDataSet1TableAdapters.EmployeetbTableAdapter employeetbTableAdapter1;
    }
}