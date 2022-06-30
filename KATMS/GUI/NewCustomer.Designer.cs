﻿namespace KATMS
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.pnlNewCust = new System.Windows.Forms.Panel();
            this.pnlCarDetails = new KATMS.Additional_Controls.RoundedPanel();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.brandtbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kATMSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kATMSdbDataSet = new KATMS.KATMSdbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btRepair = new KATMS.Additional_Controls.RoundedButton();
            this.pnlCustDetails = new KATMS.Additional_Controls.RoundedPanel();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btService = new KATMS.Additional_Controls.RoundedButton();
            this.btSaveCust = new KATMS.Additional_Controls.RoundedButton();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.btNewCust = new System.Windows.Forms.Button();
            this.btExixtingCust = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.brandtbTableAdapter = new KATMS.KATMSdbDataSetTableAdapters.BrandtbTableAdapter();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlNewCust.SuspendLayout();
            this.pnlCarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandtbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet)).BeginInit();
            this.pnlCustDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewCust
            // 
            this.pnlNewCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlNewCust.Controls.Add(this.pnlCarDetails);
            this.pnlNewCust.Controls.Add(this.btRepair);
            this.pnlNewCust.Controls.Add(this.pnlCustDetails);
            this.pnlNewCust.Controls.Add(this.btService);
            this.pnlNewCust.Controls.Add(this.btSaveCust);
            this.pnlNewCust.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNewCust.Location = new System.Drawing.Point(306, 0);
            this.pnlNewCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNewCust.Name = "pnlNewCust";
            this.pnlNewCust.Size = new System.Drawing.Size(1177, 846);
            this.pnlNewCust.TabIndex = 3;
            this.pnlNewCust.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewCust_Paint);
            // 
            // pnlCarDetails
            // 
            this.pnlCarDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlCarDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlCarDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pnlCarDetails.BorderRadius = 30;
            this.pnlCarDetails.BorderSize = 1;
            this.pnlCarDetails.Controls.Add(this.cbBrand);
            this.pnlCarDetails.Controls.Add(this.label6);
            this.pnlCarDetails.Controls.Add(this.txtModel);
            this.pnlCarDetails.Controls.Add(this.label7);
            this.pnlCarDetails.Controls.Add(this.txtCarNo);
            this.pnlCarDetails.Controls.Add(this.label8);
            this.pnlCarDetails.Controls.Add(this.label9);
            this.pnlCarDetails.Controls.Add(this.txtCarID);
            this.pnlCarDetails.Controls.Add(this.label10);
            this.pnlCarDetails.ForeColor = System.Drawing.Color.Black;
            this.pnlCarDetails.Location = new System.Drawing.Point(620, 85);
            this.pnlCarDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCarDetails.Name = "pnlCarDetails";
            this.pnlCarDetails.Size = new System.Drawing.Size(539, 487);
            this.pnlCarDetails.TabIndex = 4;
            this.pnlCarDetails.TextColor = System.Drawing.Color.Black;
            // 
            // cbBrand
            // 
            this.cbBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.brandtbBindingSource, "brandName", true));
            this.cbBrand.DataSource = this.brandtbBindingSource;
            this.cbBrand.DisplayMember = "brandName";
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(244, 298);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(255, 36);
            this.cbBrand.TabIndex = 6;
            this.cbBrand.ValueMember = "brandName";
            // 
            // brandtbBindingSource
            // 
            this.brandtbBindingSource.DataMember = "Brandtb";
            this.brandtbBindingSource.DataSource = this.kATMSdbDataSetBindingSource;
            // 
            // kATMSdbDataSetBindingSource
            // 
            this.kATMSdbDataSetBindingSource.DataSource = this.kATMSdbDataSet;
            this.kATMSdbDataSetBindingSource.Position = 0;
            // 
            // kATMSdbDataSet
            // 
            this.kATMSdbDataSet.DataSetName = "KATMSdbDataSet";
            this.kATMSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Brand";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtModel.Location = new System.Drawing.Point(241, 370);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(257, 34);
            this.txtModel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Model";
            // 
            // txtCarNo
            // 
            this.txtCarNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCarNo.Location = new System.Drawing.Point(241, 226);
            this.txtCarNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(257, 34);
            this.txtCarNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(45, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Car Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(201, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Car Details";
            // 
            // txtCarID
            // 
            this.txtCarID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCarID.Location = new System.Drawing.Point(241, 154);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.ReadOnly = true;
            this.txtCarID.Size = new System.Drawing.Size(257, 34);
            this.txtCarID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(45, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "Car ID";
            // 
            // btRepair
            // 
            this.btRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRepair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRepair.BorderColor = System.Drawing.Color.Black;
            this.btRepair.BorderRadius = 50;
            this.btRepair.BorderSize = 2;
            this.btRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRepair.FlatAppearance.BorderSize = 2;
            this.btRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRepair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btRepair.ForeColor = System.Drawing.Color.White;
            this.btRepair.Location = new System.Drawing.Point(845, 633);
            this.btRepair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRepair.Name = "btRepair";
            this.btRepair.Size = new System.Drawing.Size(255, 135);
            this.btRepair.TabIndex = 10;
            this.btRepair.Text = "Re&pair";
            this.btRepair.TextColor = System.Drawing.Color.White;
            this.btRepair.UseVisualStyleBackColor = false;
            this.btRepair.Click += new System.EventHandler(this.btRepair_Click);
            // 
            // pnlCustDetails
            // 
            this.pnlCustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlCustDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlCustDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pnlCustDetails.BorderRadius = 30;
            this.pnlCustDetails.BorderSize = 1;
            this.pnlCustDetails.Controls.Add(this.txtLastName);
            this.pnlCustDetails.Controls.Add(this.label11);
            this.pnlCustDetails.Controls.Add(this.txtPhoneNo);
            this.pnlCustDetails.Controls.Add(this.label5);
            this.pnlCustDetails.Controls.Add(this.txtEmail);
            this.pnlCustDetails.Controls.Add(this.label4);
            this.pnlCustDetails.Controls.Add(this.txtFname);
            this.pnlCustDetails.Controls.Add(this.label3);
            this.pnlCustDetails.Controls.Add(this.label2);
            this.pnlCustDetails.Controls.Add(this.txtCustomerID);
            this.pnlCustDetails.Controls.Add(this.label1);
            this.pnlCustDetails.ForeColor = System.Drawing.Color.Black;
            this.pnlCustDetails.Location = new System.Drawing.Point(15, 85);
            this.pnlCustDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCustDetails.Name = "pnlCustDetails";
            this.pnlCustDetails.Size = new System.Drawing.Size(561, 487);
            this.pnlCustDetails.TabIndex = 3;
            this.pnlCustDetails.TextColor = System.Drawing.Color.Black;
            this.pnlCustDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustDetails_Paint);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhoneNo.Location = new System.Drawing.Point(248, 331);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNo.Mask = "(999) 000-0000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(257, 34);
            this.txtPhoneNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(248, 403);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email ID";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFname.Location = new System.Drawing.Point(248, 194);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(257, 34);
            this.txtFname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(147, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Details";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCustomerID.Location = new System.Drawing.Point(248, 122);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(257, 34);
            this.txtCustomerID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID";
            // 
            // btService
            // 
            this.btService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btService.BorderColor = System.Drawing.Color.Black;
            this.btService.BorderRadius = 50;
            this.btService.BorderSize = 2;
            this.btService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btService.FlatAppearance.BorderSize = 2;
            this.btService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btService.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btService.ForeColor = System.Drawing.Color.White;
            this.btService.Location = new System.Drawing.Point(459, 633);
            this.btService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(255, 135);
            this.btService.TabIndex = 9;
            this.btService.Text = "Se&rvice";
            this.btService.TextColor = System.Drawing.Color.White;
            this.btService.UseVisualStyleBackColor = false;
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // btSaveCust
            // 
            this.btSaveCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSaveCust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSaveCust.BorderColor = System.Drawing.Color.Black;
            this.btSaveCust.BorderRadius = 50;
            this.btSaveCust.BorderSize = 2;
            this.btSaveCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSaveCust.FlatAppearance.BorderSize = 2;
            this.btSaveCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveCust.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btSaveCust.ForeColor = System.Drawing.Color.White;
            this.btSaveCust.Location = new System.Drawing.Point(69, 633);
            this.btSaveCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveCust.Name = "btSaveCust";
            this.btSaveCust.Size = new System.Drawing.Size(255, 135);
            this.btSaveCust.TabIndex = 8;
            this.btSaveCust.Text = "&Save";
            this.btSaveCust.TextColor = System.Drawing.Color.White;
            this.btSaveCust.UseVisualStyleBackColor = false;
            this.btSaveCust.Click += new System.EventHandler(this.btSaveCust_Click);
            // 
            // pnlDefault
            // 
            this.pnlDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlDefault.Location = new System.Drawing.Point(305, 2);
            this.pnlDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(1680, 853);
            this.pnlDefault.TabIndex = 4;
            this.pnlDefault.Visible = false;
            // 
            // btNewCust
            // 
            this.btNewCust.BackColor = System.Drawing.Color.Maroon;
            this.btNewCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNewCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btNewCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewCust.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNewCust.Location = new System.Drawing.Point(0, 0);
            this.btNewCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNewCust.Name = "btNewCust";
            this.btNewCust.Size = new System.Drawing.Size(305, 114);
            this.btNewCust.TabIndex = 0;
            this.btNewCust.Text = "&New Customer";
            this.btNewCust.UseVisualStyleBackColor = false;
            // 
            // btExixtingCust
            // 
            this.btExixtingCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btExixtingCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btExixtingCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExixtingCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btExixtingCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btExixtingCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExixtingCust.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btExixtingCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExixtingCust.Location = new System.Drawing.Point(0, 114);
            this.btExixtingCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExixtingCust.Name = "btExixtingCust";
            this.btExixtingCust.Size = new System.Drawing.Size(305, 114);
            this.btExixtingCust.TabIndex = 1;
            this.btExixtingCust.Text = "E&xisting Customer";
            this.btExixtingCust.UseVisualStyleBackColor = false;
            this.btExixtingCust.Click += new System.EventHandler(this.btExixtingCust_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btExixtingCust);
            this.panel1.Controls.Add(this.btNewCust);
            this.panel1.Controls.Add(this.pnlDefault);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 846);
            this.panel1.TabIndex = 0;
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
            this.btHome.TabIndex = 5;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click_1);
            // 
            // brandtbTableAdapter
            // 
            this.brandtbTableAdapter.ClearBeforeFill = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.Location = new System.Drawing.Point(248, 263);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 34);
            this.txtLastName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(36, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "Last Name";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1483, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNewCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer & Car Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCustomer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNewCust.ResumeLayout(false);
            this.pnlCarDetails.ResumeLayout(false);
            this.pnlCarDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandtbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATMSdbDataSet)).EndInit();
            this.pnlCustDetails.ResumeLayout(false);
            this.pnlCustDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        System.Windows.Forms.Panel pnlNewCust;
        private Additional_Controls.RoundedButton btSaveCust;
        private Additional_Controls.RoundedButton btRepair;
        private Additional_Controls.RoundedButton btService;
        private System.Windows.Forms.Button btNewCust;
        private System.Windows.Forms.Button btExixtingCust;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDefault;
        private Additional_Controls.RoundedPanel pnlCarDetails;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label10;
        private Additional_Controls.RoundedPanel pnlCustDetails;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kATMSdbDataSetBindingSource;
        private KATMSdbDataSet kATMSdbDataSet;
        private System.Windows.Forms.BindingSource brandtbBindingSource;
        private KATMSdbDataSetTableAdapters.BrandtbTableAdapter brandtbTableAdapter;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label11;
    }
}

