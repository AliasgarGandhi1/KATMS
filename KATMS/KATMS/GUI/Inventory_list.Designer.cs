namespace KATMS.GUI
{
    partial class Inventory_list
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
            this.InventoryList = new System.Windows.Forms.DataGridView();
            this.roundedPanel1 = new KATMS.Additional_Controls.RoundedPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
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
            this.btList.BackColor = System.Drawing.Color.Maroon;
            this.btList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btList.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
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
            // InventoryList
            // 
            this.InventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryList.Location = new System.Drawing.Point(48, 64);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.RowHeadersWidth = 51;
            this.InventoryList.RowTemplate.Height = 24;
            this.InventoryList.Size = new System.Drawing.Size(861, 639);
            this.InventoryList.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 1;
            this.roundedPanel1.Controls.Add(this.InventoryList);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(360, 48);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(968, 764);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // Inventory_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Inventory_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_list";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.DataGridView InventoryList;
        private Additional_Controls.RoundedPanel roundedPanel1;
    }
}