namespace KATMS.GUI
{
    partial class ServiceHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceHistory));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBackSH = new KATMS.Additional_Controls.RoundedButton();
            this.btFDetails = new KATMS.Additional_Controls.RoundedButton();
            this.roundedPanel1 = new KATMS.Additional_Controls.RoundedPanel();
            this.dataGridViewSHistory = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxPNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCNumber = new System.Windows.Forms.TextBox();
            this.btService = new System.Windows.Forms.Button();
            this.btRepair = new System.Windows.Forms.Button();
            this.btSHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(305, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 846);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btBackSH);
            this.panel2.Controls.Add(this.btFDetails);
            this.panel2.Controls.Add(this.roundedPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 846);
            this.panel2.TabIndex = 16;
            // 
            // btBackSH
            // 
            this.btBackSH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btBackSH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btBackSH.BorderColor = System.Drawing.Color.Black;
            this.btBackSH.BorderRadius = 50;
            this.btBackSH.BorderSize = 2;
            this.btBackSH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackSH.FlatAppearance.BorderSize = 2;
            this.btBackSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackSH.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btBackSH.ForeColor = System.Drawing.Color.White;
            this.btBackSH.Location = new System.Drawing.Point(868, 695);
            this.btBackSH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBackSH.Name = "btBackSH";
            this.btBackSH.Size = new System.Drawing.Size(255, 135);
            this.btBackSH.TabIndex = 4;
            this.btBackSH.Text = "&Back";
            this.btBackSH.TextColor = System.Drawing.Color.White;
            this.btBackSH.UseVisualStyleBackColor = false;
            this.btBackSH.Click += new System.EventHandler(this.btBackSH_Click);
            // 
            // btFDetails
            // 
            this.btFDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btFDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btFDetails.BorderColor = System.Drawing.Color.Black;
            this.btFDetails.BorderRadius = 50;
            this.btFDetails.BorderSize = 2;
            this.btFDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFDetails.FlatAppearance.BorderSize = 2;
            this.btFDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFDetails.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btFDetails.ForeColor = System.Drawing.Color.White;
            this.btFDetails.Location = new System.Drawing.Point(59, 695);
            this.btFDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFDetails.Name = "btFDetails";
            this.btFDetails.Size = new System.Drawing.Size(255, 135);
            this.btFDetails.TabIndex = 3;
            this.btFDetails.Text = "&Find Details";
            this.btFDetails.TextColor = System.Drawing.Color.White;
            this.btFDetails.UseVisualStyleBackColor = false;
            this.btFDetails.Click += new System.EventHandler(this.btFDetails_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.dataGridViewSHistory);
            this.roundedPanel1.Controls.Add(this.maskedTextBoxPNumber);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.textBoxCNumber);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(59, 62);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1065, 572);
            this.roundedPanel1.TabIndex = 18;
            this.roundedPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // dataGridViewSHistory
            // 
            this.dataGridViewSHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSHistory.Location = new System.Drawing.Point(172, 214);
            this.dataGridViewSHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSHistory.Name = "dataGridViewSHistory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSHistory.RowTemplate.Height = 24;
            this.dataGridViewSHistory.Size = new System.Drawing.Size(750, 319);
            this.dataGridViewSHistory.TabIndex = 14;
            // 
            // maskedTextBoxPNumber
            // 
            this.maskedTextBoxPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBoxPNumber.Location = new System.Drawing.Point(299, 122);
            this.maskedTextBoxPNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPNumber.Name = "maskedTextBoxPNumber";
            this.maskedTextBoxPNumber.Size = new System.Drawing.Size(211, 30);
            this.maskedTextBoxPNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(555, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Car Number";
            // 
            // textBoxCNumber
            // 
            this.textBoxCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNumber.Location = new System.Drawing.Point(781, 123);
            this.textBoxCNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCNumber.Name = "textBoxCNumber";
            this.textBoxCNumber.Size = new System.Drawing.Size(217, 30);
            this.textBoxCNumber.TabIndex = 2;
            this.textBoxCNumber.TextChanged += new System.EventHandler(this.textBoxFuel_TextChanged);
            // 
            // btService
            // 
            this.btService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btService.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btService.Location = new System.Drawing.Point(0, 0);
            this.btService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(305, 114);
            this.btService.TabIndex = 7;
            this.btService.Text = "&Service";
            this.btService.UseVisualStyleBackColor = false;
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // btRepair
            // 
            this.btRepair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRepair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRepair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRepair.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btRepair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRepair.Location = new System.Drawing.Point(0, 114);
            this.btRepair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRepair.Name = "btRepair";
            this.btRepair.Size = new System.Drawing.Size(305, 114);
            this.btRepair.TabIndex = 8;
            this.btRepair.Text = "&Repair";
            this.btRepair.UseVisualStyleBackColor = false;
            // 
            // btSHistory
            // 
            this.btSHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSHistory.BackColor = System.Drawing.Color.Maroon;
            this.btSHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btSHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSHistory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btSHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSHistory.Location = new System.Drawing.Point(0, 227);
            this.btSHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSHistory.Name = "btSHistory";
            this.btSHistory.Size = new System.Drawing.Size(305, 114);
            this.btSHistory.TabIndex = 9;
            this.btSHistory.Text = "Service &History";
            this.btSHistory.UseVisualStyleBackColor = false;
            this.btSHistory.Click += new System.EventHandler(this.btSHistory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btSHistory);
            this.panel1.Controls.Add(this.btRepair);
            this.panel1.Controls.Add(this.btService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 846);
            this.panel1.TabIndex = 10;
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
            this.btHome.Location = new System.Drawing.Point(3, 674);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(305, 176);
            this.btHome.TabIndex = 10;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // ServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 846);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ServiceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceHistory_FormClosing);
            this.Load += new System.EventHandler(this.ServiceHistory_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCNumber;
        private Additional_Controls.RoundedButton btBackSH;
        private Additional_Controls.RoundedButton btFDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Additional_Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.DataGridView dataGridViewSHistory;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPNumber;
        private System.Windows.Forms.Button btService;
        private System.Windows.Forms.Button btRepair;
        private System.Windows.Forms.Button btSHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHome;
    }
}