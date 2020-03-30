namespace ERP
{
    partial class PurchaseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.dataAll = new System.Windows.Forms.DataGridView();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.allItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSelected = new System.Windows.Forms.DataGridView();
            this.sItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelOrderShipDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbShippingZip = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbShippingState = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbShippingCity = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbShippingStreet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelected)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(353, 478);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataAll
            // 
            this.dataAll.AllowUserToAddRows = false;
            this.dataAll.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allItems,
            this.allDesc});
            this.dataAll.Location = new System.Drawing.Point(15, 157);
            this.dataAll.Name = "dataAll";
            this.dataAll.ReadOnly = true;
            this.dataAll.Size = new System.Drawing.Size(315, 290);
            this.dataAll.TabIndex = 3;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Enabled = false;
            this.tbTotalCost.Location = new System.Drawing.Point(629, 478);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCost.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(652, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Cost";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(353, 321);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(353, 377);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 8;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "All Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selected Items";
            // 
            // comboVendor
            // 
            this.comboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(59, 15);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(121, 21);
            this.comboVendor.TabIndex = 11;
            this.comboVendor.SelectedIndexChanged += new System.EventHandler(this.comboVendor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "The item must be created in the items tab before and assigned to the selected ven" +
    "dor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(526, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Subtotal";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(499, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // allItems
            // 
            this.allItems.HeaderText = "Item";
            this.allItems.Name = "allItems";
            this.allItems.ReadOnly = true;
            // 
            // allDesc
            // 
            this.allDesc.HeaderText = "Description";
            this.allDesc.Name = "allDesc";
            this.allDesc.ReadOnly = true;
            this.allDesc.Width = 170;
            // 
            // dataSelected
            // 
            this.dataSelected.AllowUserToAddRows = false;
            this.dataSelected.AllowUserToDeleteRows = false;
            this.dataSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sItem,
            this.sCost,
            this.sQuantity});
            this.dataSelected.Location = new System.Drawing.Point(448, 157);
            this.dataSelected.Name = "dataSelected";
            this.dataSelected.Size = new System.Drawing.Size(288, 290);
            this.dataSelected.TabIndex = 15;
            this.dataSelected.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSelected_CellEndEdit);
            // 
            // sItem
            // 
            this.sItem.HeaderText = "Item";
            this.sItem.Name = "sItem";
            // 
            // sCost
            // 
            this.sCost.HeaderText = "Cost";
            this.sCost.Name = "sCost";
            this.sCost.Width = 70;
            // 
            // sQuantity
            // 
            this.sQuantity.HeaderText = "Quantity";
            this.sQuantity.Name = "sQuantity";
            this.sQuantity.Width = 75;
            // 
            // vendorDatePicker
            // 
            this.vendorDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vendorDatePicker.Location = new System.Drawing.Point(620, 13);
            this.vendorDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.vendorDatePicker.Name = "vendorDatePicker";
            this.vendorDatePicker.Size = new System.Drawing.Size(98, 20);
            this.vendorDatePicker.TabIndex = 154;
            // 
            // labelOrderShipDate
            // 
            this.labelOrderShipDate.Location = new System.Drawing.Point(567, 7);
            this.labelOrderShipDate.Name = "labelOrderShipDate";
            this.labelOrderShipDate.Size = new System.Drawing.Size(57, 29);
            this.labelOrderShipDate.TabIndex = 153;
            this.labelOrderShipDate.Text = "Ship Date";
            this.labelOrderShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.tbShippingZip);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tbShippingState);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.tbShippingCity);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.tbShippingStreet);
            this.groupBox1.Location = new System.Drawing.Point(221, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 82);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Address";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(166, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 129;
            this.label26.Text = "Zip Code";
            // 
            // tbShippingZip
            // 
            this.tbShippingZip.Location = new System.Drawing.Point(220, 51);
            this.tbShippingZip.Name = "tbShippingZip";
            this.tbShippingZip.Size = new System.Drawing.Size(100, 20);
            this.tbShippingZip.TabIndex = 132;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(184, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 128;
            this.label27.Text = "State";
            // 
            // tbShippingState
            // 
            this.tbShippingState.Location = new System.Drawing.Point(220, 25);
            this.tbShippingState.Name = "tbShippingState";
            this.tbShippingState.Size = new System.Drawing.Size(100, 20);
            this.tbShippingState.TabIndex = 131;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 50);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 13);
            this.label28.TabIndex = 127;
            this.label28.Text = "City";
            // 
            // tbShippingCity
            // 
            this.tbShippingCity.Location = new System.Drawing.Point(51, 47);
            this.tbShippingCity.Name = "tbShippingCity";
            this.tbShippingCity.Size = new System.Drawing.Size(100, 20);
            this.tbShippingCity.TabIndex = 130;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 125;
            this.label29.Text = "Street";
            // 
            // tbShippingStreet
            // 
            this.tbShippingStreet.Location = new System.Drawing.Point(51, 21);
            this.tbShippingStreet.Name = "tbShippingStreet";
            this.tbShippingStreet.Size = new System.Drawing.Size(100, 20);
            this.tbShippingStreet.TabIndex = 126;
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendorDatePicker);
            this.Controls.Add(this.labelOrderShipDate);
            this.Controls.Add(this.dataSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.dataAll);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrders";
            this.Text = "PurchaseOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelected)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dataAll;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn allItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn allDesc;
        private System.Windows.Forms.DataGridView dataSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQuantity;
        private System.Windows.Forms.DateTimePicker vendorDatePicker;
        private System.Windows.Forms.Label labelOrderShipDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbShippingZip;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbShippingState;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbShippingCity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbShippingStreet;
    }
}