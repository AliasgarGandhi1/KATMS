namespace KATMS.GUI
{
    partial class ManagerMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCCMenu = new KATMS.Additional_Controls.RoundedButton();
            this.btEmployeeMenu = new KATMS.Additional_Controls.RoundedButton();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.btLogout = new KATMS.Additional_Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KATMS.Properties.Resources.pexels_torsten_dettlaff_70912;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1483, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btCCMenu
            // 
            this.btCCMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btCCMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btCCMenu.BorderColor = System.Drawing.Color.Black;
            this.btCCMenu.BorderRadius = 50;
            this.btCCMenu.BorderSize = 2;
            this.btCCMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCCMenu.FlatAppearance.BorderSize = 2;
            this.btCCMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCCMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btCCMenu.ForeColor = System.Drawing.Color.White;
            this.btCCMenu.Location = new System.Drawing.Point(317, 272);
            this.btCCMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCCMenu.Name = "btCCMenu";
            this.btCCMenu.Size = new System.Drawing.Size(331, 302);
            this.btCCMenu.TabIndex = 1;
            this.btCCMenu.Text = "&CUSTOMERS AND CARS";
            this.btCCMenu.TextColor = System.Drawing.Color.White;
            this.btCCMenu.UseVisualStyleBackColor = false;
            this.btCCMenu.Click += new System.EventHandler(this.btCCMenu_Click);
            // 
            // btEmployeeMenu
            // 
            this.btEmployeeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btEmployeeMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btEmployeeMenu.BorderColor = System.Drawing.Color.Black;
            this.btEmployeeMenu.BorderRadius = 50;
            this.btEmployeeMenu.BorderSize = 2;
            this.btEmployeeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmployeeMenu.FlatAppearance.BorderSize = 2;
            this.btEmployeeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployeeMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btEmployeeMenu.ForeColor = System.Drawing.Color.White;
            this.btEmployeeMenu.Location = new System.Drawing.Point(873, 272);
            this.btEmployeeMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEmployeeMenu.Name = "btEmployeeMenu";
            this.btEmployeeMenu.Size = new System.Drawing.Size(348, 302);
            this.btEmployeeMenu.TabIndex = 2;
            this.btEmployeeMenu.Text = "&EMPLOYEE";
            this.btEmployeeMenu.TextColor = System.Drawing.Color.White;
            this.btEmployeeMenu.UseVisualStyleBackColor = false;
            this.btEmployeeMenu.Click += new System.EventHandler(this.btEmployeeMenu_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.Crimson;
            this.lblLoginName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(12, 9);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(176, 46);
            this.lblLoginName.TabIndex = 28;
            this.lblLoginName.Text = "Welcome ";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btLogout.BorderColor = System.Drawing.Color.Black;
            this.btLogout.BorderRadius = 30;
            this.btLogout.BorderSize = 2;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatAppearance.BorderSize = 2;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = global::KATMS.Properties.Resources.icons8_export_96;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(1317, 12);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(153, 174);
            this.btLogout.TabIndex = 3;
            this.btLogout.TextColor = System.Drawing.Color.White;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 846);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btEmployeeMenu);
            this.Controls.Add(this.btCCMenu);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerMenu_FormClosing);
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Additional_Controls.RoundedButton btCCMenu;
        private Additional_Controls.RoundedButton btEmployeeMenu;
        private System.Windows.Forms.Label lblLoginName;
        private Additional_Controls.RoundedButton btLogout;
    }
}