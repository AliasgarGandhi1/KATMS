namespace KATMS.GUI
{
    partial class New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbtHome = new System.Windows.Forms.PictureBox();
            this.btHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btNewEmployee = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.btExistingEmployee = new System.Windows.Forms.Button();
            this.btAddEmployee = new KATMS.Additional_Controls.RoundedButton();
            this.roundedPanel1 = new KATMS.Additional_Controls.RoundedPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPayperHour = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtHome)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btExistingEmployee);
            this.panel1.Controls.Add(this.pbtHome);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btNewEmployee);
            this.panel1.Controls.Add(this.btList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 853);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbtHome
            // 
            this.pbtHome.BackColor = System.Drawing.Color.Transparent;
            this.pbtHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbtHome.Image = ((System.Drawing.Image)(resources.GetObject("pbtHome.Image")));
            this.pbtHome.Location = new System.Drawing.Point(110, 759);
            this.pbtHome.Name = "pbtHome";
            this.pbtHome.Size = new System.Drawing.Size(82, 70);
            this.pbtHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtHome.TabIndex = 4;
            this.pbtHome.TabStop = false;
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
            this.btHome.Location = new System.Drawing.Point(1, 737);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(305, 114);
            this.btHome.TabIndex = 3;
            this.btHome.UseVisualStyleBackColor = false;
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
            this.panel2.Size = new System.Drawing.Size(1113, 837);
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
            this.button3.Location = new System.Drawing.Point(0, 920);
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
            this.btNewEmployee.Text = "New Employee";
            this.btNewEmployee.UseVisualStyleBackColor = false;
            // 
            // btList
            // 
            this.btList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
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
            this.btList.Text = "List";
            this.btList.UseVisualStyleBackColor = false;
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
            this.btExistingEmployee.Text = "Existing Employee";
            this.btExistingEmployee.UseVisualStyleBackColor = false;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAddEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAddEmployee.BorderColor = System.Drawing.Color.Black;
            this.btAddEmployee.BorderRadius = 50;
            this.btAddEmployee.BorderSize = 2;
            this.btAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddEmployee.FlatAppearance.BorderSize = 2;
            this.btAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btAddEmployee.Location = new System.Drawing.Point(728, 658);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(255, 135);
            this.btAddEmployee.TabIndex = 30;
            this.btAddEmployee.Text = "Add Employee";
            this.btAddEmployee.TextColor = System.Drawing.Color.White;
            this.btAddEmployee.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 1;
            this.roundedPanel1.Controls.Add(this.label10);
            this.roundedPanel1.Controls.Add(this.txtLastName);
            this.roundedPanel1.Controls.Add(this.txtAddress);
            this.roundedPanel1.Controls.Add(this.txtBankAccount);
            this.roundedPanel1.Controls.Add(this.label15);
            this.roundedPanel1.Controls.Add(this.txtPayperHour);
            this.roundedPanel1.Controls.Add(this.txtInsurance);
            this.roundedPanel1.Controls.Add(this.txtBloodGroup);
            this.roundedPanel1.Controls.Add(this.txtEmailID);
            this.roundedPanel1.Controls.Add(this.label9);
            this.roundedPanel1.Controls.Add(this.label8);
            this.roundedPanel1.Controls.Add(this.label7);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.txtPhoneNo);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.txtFirstName);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtEmpID);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(330, 26);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1129, 565);
            this.roundedPanel1.TabIndex = 31;
            this.roundedPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = " Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.Location = new System.Drawing.Point(274, 282);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(258, 34);
            this.txtLastName.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.Location = new System.Drawing.Point(274, 423);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 34);
            this.txtAddress.TabIndex = 26;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankAccount.Location = new System.Drawing.Point(848, 421);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(258, 34);
            this.txtBankAccount.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(635, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 32);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bank Account";
            // 
            // txtPayperHour
            // 
            this.txtPayperHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPayperHour.Location = new System.Drawing.Point(851, 352);
            this.txtPayperHour.Name = "txtPayperHour";
            this.txtPayperHour.Size = new System.Drawing.Size(258, 34);
            this.txtPayperHour.TabIndex = 22;
            // 
            // txtInsurance
            // 
            this.txtInsurance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInsurance.Location = new System.Drawing.Point(851, 280);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(258, 34);
            this.txtInsurance.TabIndex = 21;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBloodGroup.Location = new System.Drawing.Point(848, 208);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(258, 34);
            this.txtBloodGroup.TabIndex = 20;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmailID.Location = new System.Drawing.Point(848, 136);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(258, 34);
            this.txtEmailID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(635, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pay per Hour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(635, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Insurance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(635, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Blood Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(635, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email Address";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhoneNo.Location = new System.Drawing.Point(274, 354);
            this.txtPhoneNo.Mask = "(999) 000-0000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(258, 34);
            this.txtPhoneNo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(274, 209);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(258, 34);
            this.txtFirstName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = " First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(478, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Details";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmpID.Location = new System.Drawing.Point(274, 134);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(258, 34);
            this.txtEmpID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Emp ID";
            // 
            // New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Employee";
            this.Load += new System.EventHandler(this.New_Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbtHome)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbtHome;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btNewEmployee;
        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.Button btExistingEmployee;
        private Additional_Controls.RoundedButton btAddEmployee;
        private Additional_Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPayperHour;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label1;
    }
}