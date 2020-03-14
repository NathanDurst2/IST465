namespace ERP
{
    partial class ManageItems
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
            this.dataAllItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSelectedItems = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sItemVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAllItems
            // 
            this.dataAllItems.AllowUserToAddRows = false;
            this.dataAllItems.AllowUserToDeleteRows = false;
            this.dataAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumber,
            this.itemDesc,
            this.itemVendor});
            this.dataAllItems.Location = new System.Drawing.Point(26, 31);
            this.dataAllItems.Name = "dataAllItems";
            this.dataAllItems.Size = new System.Drawing.Size(349, 438);
            this.dataAllItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Items";
            // 
            // dataSelectedItems
            // 
            this.dataSelectedItems.AllowUserToAddRows = false;
            this.dataSelectedItems.AllowUserToDeleteRows = false;
            this.dataSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sItemNumber,
            this.sItemDesc,
            this.sItemVendor});
            this.dataSelectedItems.Location = new System.Drawing.Point(553, 31);
            this.dataSelectedItems.Name = "dataSelectedItems";
            this.dataSelectedItems.Size = new System.Drawing.Size(349, 438);
            this.dataSelectedItems.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(393, 111);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(143, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(393, 182);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(143, 23);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(393, 424);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(143, 23);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // itemNumber
            // 
            this.itemNumber.HeaderText = "Item Number";
            this.itemNumber.Name = "itemNumber";
            // 
            // itemDesc
            // 
            this.itemDesc.HeaderText = "Description";
            this.itemDesc.Name = "itemDesc";
            // 
            // itemVendor
            // 
            this.itemVendor.HeaderText = "Vendor";
            this.itemVendor.Name = "itemVendor";
            // 
            // sItemNumber
            // 
            this.sItemNumber.HeaderText = "Item Number";
            this.sItemNumber.Name = "sItemNumber";
            // 
            // sItemDesc
            // 
            this.sItemDesc.HeaderText = "Description";
            this.sItemDesc.Name = "sItemDesc";
            // 
            // sItemVendor
            // 
            this.sItemVendor.HeaderText = "Vendor";
            this.sItemVendor.Name = "sItemVendor";
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 487);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataSelectedItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAllItems);
            this.Name = "ManageItems";
            this.Text = "ManageItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataAllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAllItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataSelectedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItemVendor;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSubmit;
    }
}