namespace KATMS.GUI
{
    partial class Inventory_search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.roundedPanel2 = new KATMS.Additional_Controls.RoundedPanel();
            this.roundedBtSearch = new KATMS.Additional_Controls.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.roundedBtDelete = new KATMS.Additional_Controls.RoundedButton();
            this.roundedPanel1 = new KATMS.Additional_Controls.RoundedPanel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedBtUpdate = new KATMS.Additional_Controls.RoundedButton();
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btList);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 853);
            this.panel1.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Maroon;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(3, 224);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(305, 116);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(3, 112);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(305, 116);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btList
            // 
            this.btList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btList.ForeColor = System.Drawing.Color.White;
            this.btList.Location = new System.Drawing.Point(3, 0);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(305, 116);
            this.btList.TabIndex = 0;
            this.btList.Text = "List";
            this.btList.UseVisualStyleBackColor = false;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel2.BorderRadius = 50;
            this.roundedPanel2.BorderSize = 1;
            this.roundedPanel2.Controls.Add(this.roundedBtSearch);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.txtPartID);
            this.roundedPanel2.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel2.Location = new System.Drawing.Point(401, 61);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(985, 182);
            this.roundedPanel2.TabIndex = 11;
            this.roundedPanel2.TextColor = System.Drawing.Color.Black;
            // 
            // roundedBtSearch
            // 
            this.roundedBtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtSearch.BorderColor = System.Drawing.Color.Black;
            this.roundedBtSearch.BorderRadius = 40;
            this.roundedBtSearch.BorderSize = 2;
            this.roundedBtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedBtSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundedBtSearch.FlatAppearance.BorderSize = 2;
            this.roundedBtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedBtSearch.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedBtSearch.ForeColor = System.Drawing.Color.White;
            this.roundedBtSearch.Location = new System.Drawing.Point(672, 42);
            this.roundedBtSearch.Name = "roundedBtSearch";
            this.roundedBtSearch.Size = new System.Drawing.Size(238, 91);
            this.roundedBtSearch.TabIndex = 8;
            this.roundedBtSearch.Text = "Search";
            this.roundedBtSearch.TextColor = System.Drawing.Color.White;
            this.roundedBtSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part ID";
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(284, 81);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(258, 34);
            this.txtPartID.TabIndex = 0;
            // 
            // roundedBtDelete
            // 
            this.roundedBtDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtDelete.BorderColor = System.Drawing.Color.Black;
            this.roundedBtDelete.BorderRadius = 50;
            this.roundedBtDelete.BorderSize = 2;
            this.roundedBtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedBtDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundedBtDelete.FlatAppearance.BorderSize = 2;
            this.roundedBtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedBtDelete.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedBtDelete.ForeColor = System.Drawing.Color.White;
            this.roundedBtDelete.Location = new System.Drawing.Point(999, 706);
            this.roundedBtDelete.Name = "roundedBtDelete";
            this.roundedBtDelete.Size = new System.Drawing.Size(255, 135);
            this.roundedBtDelete.TabIndex = 10;
            this.roundedBtDelete.Text = "Delete";
            this.roundedBtDelete.TextColor = System.Drawing.Color.White;
            this.roundedBtDelete.UseVisualStyleBackColor = false;
            this.roundedBtDelete.Click += new System.EventHandler(this.roundedBtDelete_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 1;
            this.roundedPanel1.Controls.Add(this.txtPrice);
            this.roundedPanel1.Controls.Add(this.txtPartName);
            this.roundedPanel1.Controls.Add(this.txtQuantity);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(401, 291);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(985, 377);
            this.roundedPanel1.TabIndex = 1;
            this.roundedPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(503, 247);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 34);
            this.txtPrice.TabIndex = 3;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(503, 41);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(258, 34);
            this.txtPartName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(503, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(258, 34);
            this.txtQuantity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Part Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // roundedBtUpdate
            // 
            this.roundedBtUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedBtUpdate.BorderColor = System.Drawing.Color.Black;
            this.roundedBtUpdate.BorderRadius = 50;
            this.roundedBtUpdate.BorderSize = 2;
            this.roundedBtUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedBtUpdate.FlatAppearance.BorderSize = 2;
            this.roundedBtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedBtUpdate.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedBtUpdate.ForeColor = System.Drawing.Color.White;
            this.roundedBtUpdate.Location = new System.Drawing.Point(553, 706);
            this.roundedBtUpdate.Name = "roundedBtUpdate";
            this.roundedBtUpdate.Size = new System.Drawing.Size(255, 135);
            this.roundedBtUpdate.TabIndex = 9;
            this.roundedBtUpdate.Text = "Update";
            this.roundedBtUpdate.TextColor = System.Drawing.Color.White;
            this.roundedBtUpdate.UseVisualStyleBackColor = false;
            // 
            // Inventory_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedBtDelete);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedBtUpdate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Inventory_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_search";
            this.panel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btList;
        private Additional_Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPartID;
        private Additional_Controls.RoundedButton roundedBtSearch;
        private Additional_Controls.RoundedButton roundedBtDelete;
        private Additional_Controls.RoundedButton roundedBtUpdate;
        private Additional_Controls.RoundedPanel roundedPanel2;
    }
}