namespace ERP
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.cbCustSalesRep = new System.Windows.Forms.ComboBox();
            this.btCustSave = new System.Windows.Forms.Button();
            this.btCustEdit = new System.Windows.Forms.Button();
            this.btCustRemove = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCustZip = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCustState = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCustCity = new System.Windows.Forms.TextBox();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSales_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btCustClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.btCustAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCustStreet = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.Employee = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.EmpSummary = new System.Windows.Forms.TabPage();
            this.EmpEntry = new System.Windows.Forms.TabPage();
            this.emp_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEmpClear = new System.Windows.Forms.Button();
            this.btEmpAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.empTB_Supervisor = new System.Windows.Forms.TextBox();
            this.empTB_Email = new System.Windows.Forms.TextBox();
            this.empTB_Phone = new System.Windows.Forms.TextBox();
            this.empTB_Address = new System.Windows.Forms.TextBox();
            this.empTB_LastName = new System.Windows.Forms.TextBox();
            this.empTB_FirstName = new System.Windows.Forms.TextBox();
            this.Items = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabPage();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbOrderShippingZip = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbOrderShippingState = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbOrderShippingCity = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbOrderShippingStreet = new System.Windows.Forms.TextBox();
            this.checkShippingBilling = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbOrderBillingZip = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbOrderBillingState = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbOrderBillingCity = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbOrderBillingStreet = new System.Windows.Forms.TextBox();
            this.cbOrderCustomer = new System.Windows.Forms.ComboBox();
            this.btOrderSave = new System.Windows.Forms.Button();
            this.btOrderEdit = new System.Windows.Forms.Button();
            this.btOrderRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btOrderClear = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btOrderAdd = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btItemSave = new System.Windows.Forms.Button();
            this.btItemEdit = new System.Windows.Forms.Button();
            this.btItemRemove = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btItemClear = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btItemAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Employee.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.EmpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_GridView)).BeginInit();
            this.Items.SuspendLayout();
            this.Order.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Employee);
            this.tabControl1.Controls.Add(this.Items);
            this.tabControl1.Controls.Add(this.Order);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.cbCustSalesRep);
            this.Customers.Controls.Add(this.btCustSave);
            this.Customers.Controls.Add(this.btCustEdit);
            this.Customers.Controls.Add(this.btCustRemove);
            this.Customers.Controls.Add(this.label17);
            this.Customers.Controls.Add(this.tbCustZip);
            this.Customers.Controls.Add(this.label16);
            this.Customers.Controls.Add(this.tbCustState);
            this.Customers.Controls.Add(this.label15);
            this.Customers.Controls.Add(this.tbCustCity);
            this.Customers.Controls.Add(this.dataCustomer);
            this.Customers.Controls.Add(this.dataGridView2);
            this.Customers.Controls.Add(this.btCustClear);
            this.Customers.Controls.Add(this.label13);
            this.Customers.Controls.Add(this.tbCustID);
            this.Customers.Controls.Add(this.btCustAdd);
            this.Customers.Controls.Add(this.label6);
            this.Customers.Controls.Add(this.label5);
            this.Customers.Controls.Add(this.label4);
            this.Customers.Controls.Add(this.label3);
            this.Customers.Controls.Add(this.label2);
            this.Customers.Controls.Add(this.label1);
            this.Customers.Controls.Add(this.tbEmail);
            this.Customers.Controls.Add(this.tbPhone);
            this.Customers.Controls.Add(this.tbCustStreet);
            this.Customers.Controls.Add(this.tbLastName);
            this.Customers.Controls.Add(this.tbFirstName);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1065, 585);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // cbCustSalesRep
            // 
            this.cbCustSalesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustSalesRep.FormattingEnabled = true;
            this.cbCustSalesRep.Location = new System.Drawing.Point(261, 78);
            this.cbCustSalesRep.Name = "cbCustSalesRep";
            this.cbCustSalesRep.Size = new System.Drawing.Size(100, 21);
            this.cbCustSalesRep.TabIndex = 103;
            this.cbCustSalesRep.Click += new System.EventHandler(this.CbCustSalesRep_Click);
            // 
            // btCustSave
            // 
            this.btCustSave.Location = new System.Drawing.Point(43, 220);
            this.btCustSave.Name = "btCustSave";
            this.btCustSave.Size = new System.Drawing.Size(75, 23);
            this.btCustSave.TabIndex = 102;
            this.btCustSave.Text = "Save";
            this.btCustSave.UseVisualStyleBackColor = true;
            this.btCustSave.Visible = false;
            this.btCustSave.Click += new System.EventHandler(this.BtCustSave_Click);
            // 
            // btCustEdit
            // 
            this.btCustEdit.Location = new System.Drawing.Point(354, 247);
            this.btCustEdit.Name = "btCustEdit";
            this.btCustEdit.Size = new System.Drawing.Size(75, 23);
            this.btCustEdit.TabIndex = 101;
            this.btCustEdit.TabStop = false;
            this.btCustEdit.Text = "Edit";
            this.btCustEdit.UseVisualStyleBackColor = true;
            this.btCustEdit.Click += new System.EventHandler(this.BtCustEdit_Click);
            // 
            // btCustRemove
            // 
            this.btCustRemove.Location = new System.Drawing.Point(435, 247);
            this.btCustRemove.Name = "btCustRemove";
            this.btCustRemove.Size = new System.Drawing.Size(75, 23);
            this.btCustRemove.TabIndex = 44;
            this.btCustRemove.TabStop = false;
            this.btCustRemove.Text = "Remove";
            this.btCustRemove.UseVisualStyleBackColor = true;
            this.btCustRemove.Click += new System.EventHandler(this.BtCustRemove_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Zip Code";
            // 
            // tbCustZip
            // 
            this.tbCustZip.Location = new System.Drawing.Point(90, 192);
            this.tbCustZip.Name = "tbCustZip";
            this.tbCustZip.Size = new System.Drawing.Size(100, 20);
            this.tbCustZip.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "State";
            // 
            // tbCustState
            // 
            this.tbCustState.Location = new System.Drawing.Point(90, 166);
            this.tbCustState.Name = "tbCustState";
            this.tbCustState.Size = new System.Drawing.Size(100, 20);
            this.tbCustState.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "City";
            // 
            // tbCustCity
            // 
            this.tbCustCity.Location = new System.Drawing.Point(90, 140);
            this.tbCustCity.Name = "tbCustCity";
            this.tbCustCity.Size = new System.Drawing.Size(100, 20);
            this.tbCustCity.TabIndex = 44;
            // 
            // dataCustomer
            // 
            this.dataCustomer.AllowUserToAddRows = false;
            this.dataCustomer.AllowUserToDeleteRows = false;
            this.dataCustomer.AllowUserToOrderColumns = true;
            this.dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust_ID,
            this.cFirstName,
            this.cLastName,
            this.cStreet,
            this.cCity,
            this.cState,
            this.cZip,
            this.cPhone,
            this.cEmail,
            this.cSales_Rep});
            this.dataCustomer.Location = new System.Drawing.Point(20, 276);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.Size = new System.Drawing.Size(1025, 313);
            this.dataCustomer.TabIndex = 37;
            this.dataCustomer.TabStop = false;
            // 
            // Cust_ID
            // 
            this.Cust_ID.HeaderText = "ID";
            this.Cust_ID.MinimumWidth = 6;
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.ReadOnly = true;
            this.Cust_ID.Width = 125;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "First Name";
            this.cFirstName.MinimumWidth = 6;
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.ReadOnly = true;
            this.cFirstName.Width = 125;
            // 
            // cLastName
            // 
            this.cLastName.HeaderText = "Last Name";
            this.cLastName.MinimumWidth = 6;
            this.cLastName.Name = "cLastName";
            this.cLastName.ReadOnly = true;
            this.cLastName.Width = 125;
            // 
            // cStreet
            // 
            this.cStreet.HeaderText = "Street";
            this.cStreet.MinimumWidth = 6;
            this.cStreet.Name = "cStreet";
            this.cStreet.ReadOnly = true;
            this.cStreet.Width = 125;
            // 
            // cCity
            // 
            this.cCity.HeaderText = "City";
            this.cCity.Name = "cCity";
            // 
            // cState
            // 
            this.cState.HeaderText = "State";
            this.cState.Name = "cState";
            // 
            // cZip
            // 
            this.cZip.HeaderText = "Zip Code";
            this.cZip.Name = "cZip";
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            this.cPhone.Width = 125;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Width = 125;
            // 
            // cSales_Rep
            // 
            this.cSales_Rep.HeaderText = "Sales Rep";
            this.cSales_Rep.MinimumWidth = 6;
            this.cSales_Rep.Name = "cSales_Rep";
            this.cSales_Rep.ReadOnly = true;
            this.cSales_Rep.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(516, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 215);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.TabStop = false;
            // 
            // btCustClear
            // 
            this.btCustClear.Location = new System.Drawing.Point(124, 220);
            this.btCustClear.Name = "btCustClear";
            this.btCustClear.Size = new System.Drawing.Size(75, 23);
            this.btCustClear.TabIndex = 35;
            this.btCustClear.TabStop = false;
            this.btCustClear.Text = "Clear";
            this.btCustClear.UseVisualStyleBackColor = true;
            this.btCustClear.Click += new System.EventHandler(this.BtCustClear_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Id";
            // 
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(90, 23);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(32, 20);
            this.tbCustID.TabIndex = 33;
            this.tbCustID.TabStop = false;
            // 
            // btCustAdd
            // 
            this.btCustAdd.Location = new System.Drawing.Point(43, 220);
            this.btCustAdd.Name = "btCustAdd";
            this.btCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btCustAdd.TabIndex = 100;
            this.btCustAdd.Text = "Add";
            this.btCustAdd.UseVisualStyleBackColor = true;
            this.btCustAdd.Click += new System.EventHandler(this.BtCustAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sales Rep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(261, 52);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 88;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(261, 26);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 77;
            // 
            // tbCustStreet
            // 
            this.tbCustStreet.Location = new System.Drawing.Point(90, 114);
            this.tbCustStreet.Name = "tbCustStreet";
            this.tbCustStreet.Size = new System.Drawing.Size(100, 20);
            this.tbCustStreet.TabIndex = 33;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(90, 75);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 22;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(90, 49);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 11;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.tabControl3);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(1065, 585);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.EmpSummary);
            this.tabControl3.Controls.Add(this.EmpEntry);
            this.tabControl3.Location = new System.Drawing.Point(-2, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1069, 584);
            this.tabControl3.TabIndex = 1;
            // 
            // EmpSummary
            // 
            this.EmpSummary.Location = new System.Drawing.Point(4, 22);
            this.EmpSummary.Name = "EmpSummary";
            this.EmpSummary.Padding = new System.Windows.Forms.Padding(3);
            this.EmpSummary.Size = new System.Drawing.Size(1061, 558);
            this.EmpSummary.TabIndex = 1;
            this.EmpSummary.Text = "Summary";
            this.EmpSummary.UseVisualStyleBackColor = true;
            // 
            // EmpEntry
            // 
            this.EmpEntry.Controls.Add(this.emp_GridView);
            this.EmpEntry.Controls.Add(this.comboBox1);
            this.EmpEntry.Controls.Add(this.btEmpClear);
            this.EmpEntry.Controls.Add(this.btEmpAdd);
            this.EmpEntry.Controls.Add(this.label14);
            this.EmpEntry.Controls.Add(this.textBox7);
            this.EmpEntry.Controls.Add(this.label7);
            this.EmpEntry.Controls.Add(this.label8);
            this.EmpEntry.Controls.Add(this.label9);
            this.EmpEntry.Controls.Add(this.label10);
            this.EmpEntry.Controls.Add(this.label11);
            this.EmpEntry.Controls.Add(this.label12);
            this.EmpEntry.Controls.Add(this.empTB_Supervisor);
            this.EmpEntry.Controls.Add(this.empTB_Email);
            this.EmpEntry.Controls.Add(this.empTB_Phone);
            this.EmpEntry.Controls.Add(this.empTB_Address);
            this.EmpEntry.Controls.Add(this.empTB_LastName);
            this.EmpEntry.Controls.Add(this.empTB_FirstName);
            this.EmpEntry.Location = new System.Drawing.Point(4, 22);
            this.EmpEntry.Name = "EmpEntry";
            this.EmpEntry.Padding = new System.Windows.Forms.Padding(3);
            this.EmpEntry.Size = new System.Drawing.Size(1061, 558);
            this.EmpEntry.TabIndex = 0;
            this.EmpEntry.Text = "Entry";
            this.EmpEntry.UseVisualStyleBackColor = true;
            // 
            // emp_GridView
            // 
            this.emp_GridView.AllowUserToAddRows = false;
            this.emp_GridView.AllowUserToDeleteRows = false;
            this.emp_GridView.AllowUserToOrderColumns = true;
            this.emp_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.emp_GridView.Location = new System.Drawing.Point(16, 241);
            this.emp_GridView.Name = "emp_GridView";
            this.emp_GridView.RowHeadersWidth = 51;
            this.emp_GridView.Size = new System.Drawing.Size(981, 310);
            this.emp_GridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Supervisor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(570, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // btEmpClear
            // 
            this.btEmpClear.Location = new System.Drawing.Point(110, 212);
            this.btEmpClear.Name = "btEmpClear";
            this.btEmpClear.Size = new System.Drawing.Size(75, 23);
            this.btEmpClear.TabIndex = 29;
            this.btEmpClear.Text = "Clear";
            this.btEmpClear.UseVisualStyleBackColor = true;
            // 
            // btEmpAdd
            // 
            this.btEmpAdd.Location = new System.Drawing.Point(29, 212);
            this.btEmpAdd.Name = "btEmpAdd";
            this.btEmpAdd.Size = new System.Drawing.Size(75, 23);
            this.btEmpAdd.TabIndex = 28;
            this.btEmpAdd.Text = "Add";
            this.btEmpAdd.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Id";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(76, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(32, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Supervisor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "First Name";
            // 
            // empTB_Supervisor
            // 
            this.empTB_Supervisor.Location = new System.Drawing.Point(76, 176);
            this.empTB_Supervisor.Name = "empTB_Supervisor";
            this.empTB_Supervisor.Size = new System.Drawing.Size(100, 20);
            this.empTB_Supervisor.TabIndex = 18;
            // 
            // empTB_Email
            // 
            this.empTB_Email.Location = new System.Drawing.Point(76, 150);
            this.empTB_Email.Name = "empTB_Email";
            this.empTB_Email.Size = new System.Drawing.Size(100, 20);
            this.empTB_Email.TabIndex = 17;
            // 
            // empTB_Phone
            // 
            this.empTB_Phone.Location = new System.Drawing.Point(76, 124);
            this.empTB_Phone.Name = "empTB_Phone";
            this.empTB_Phone.Size = new System.Drawing.Size(100, 20);
            this.empTB_Phone.TabIndex = 16;
            // 
            // empTB_Address
            // 
            this.empTB_Address.Location = new System.Drawing.Point(76, 98);
            this.empTB_Address.Name = "empTB_Address";
            this.empTB_Address.Size = new System.Drawing.Size(100, 20);
            this.empTB_Address.TabIndex = 15;
            // 
            // empTB_LastName
            // 
            this.empTB_LastName.Location = new System.Drawing.Point(76, 72);
            this.empTB_LastName.Name = "empTB_LastName";
            this.empTB_LastName.Size = new System.Drawing.Size(100, 20);
            this.empTB_LastName.TabIndex = 14;
            // 
            // empTB_FirstName
            // 
            this.empTB_FirstName.Location = new System.Drawing.Point(76, 46);
            this.empTB_FirstName.Name = "empTB_FirstName";
            this.empTB_FirstName.Size = new System.Drawing.Size(100, 20);
            this.empTB_FirstName.TabIndex = 13;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.btItemAdd);
            this.Items.Controls.Add(this.comboBox2);
            this.Items.Controls.Add(this.btItemSave);
            this.Items.Controls.Add(this.btItemEdit);
            this.Items.Controls.Add(this.btItemRemove);
            this.Items.Controls.Add(this.label18);
            this.Items.Controls.Add(this.textBox1);
            this.Items.Controls.Add(this.label24);
            this.Items.Controls.Add(this.textBox2);
            this.Items.Controls.Add(this.label25);
            this.Items.Controls.Add(this.textBox3);
            this.Items.Controls.Add(this.btItemClear);
            this.Items.Controls.Add(this.label34);
            this.Items.Controls.Add(this.label35);
            this.Items.Controls.Add(this.label39);
            this.Items.Controls.Add(this.textBox8);
            this.Items.Controls.Add(this.textBox9);
            this.Items.Location = new System.Drawing.Point(4, 22);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(1065, 585);
            this.Items.TabIndex = 2;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.groupBox3);
            this.Order.Controls.Add(this.cbOrderType);
            this.Order.Controls.Add(this.label23);
            this.Order.Controls.Add(this.label20);
            this.Order.Controls.Add(this.label19);
            this.Order.Controls.Add(this.groupBox2);
            this.Order.Controls.Add(this.groupBox1);
            this.Order.Controls.Add(this.cbOrderCustomer);
            this.Order.Controls.Add(this.btOrderSave);
            this.Order.Controls.Add(this.btOrderEdit);
            this.Order.Controls.Add(this.btOrderRemove);
            this.Order.Controls.Add(this.dataGridView1);
            this.Order.Controls.Add(this.dataGridView3);
            this.Order.Controls.Add(this.btOrderClear);
            this.Order.Controls.Add(this.label21);
            this.Order.Controls.Add(this.tbOrderID);
            this.Order.Controls.Add(this.label22);
            this.Order.Controls.Add(this.btOrderAdd);
            this.Order.Location = new System.Drawing.Point(4, 22);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(1065, 585);
            this.Order.TabIndex = 3;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // cbOrderType
            // 
            this.cbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Items.AddRange(new object[] {
            "Estimate",
            "Sales Order"});
            this.cbOrderType.Location = new System.Drawing.Point(273, 19);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(100, 21);
            this.cbOrderType.TabIndex = 138;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(210, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 137;
            this.label23.Text = "Order Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(512, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 136;
            this.label20.Text = "Items";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 135;
            this.label19.Text = "Orders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.tbOrderShippingZip);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.tbOrderShippingState);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.tbOrderShippingCity);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.tbOrderShippingStreet);
            this.groupBox2.Controls.Add(this.checkShippingBilling);
            this.groupBox2.Location = new System.Drawing.Point(222, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 142);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping Address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(2, 116);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 129;
            this.label30.Text = "Zip Code";
            // 
            // tbOrderShippingZip
            // 
            this.tbOrderShippingZip.Location = new System.Drawing.Point(67, 113);
            this.tbOrderShippingZip.Name = "tbOrderShippingZip";
            this.tbOrderShippingZip.Size = new System.Drawing.Size(100, 20);
            this.tbOrderShippingZip.TabIndex = 132;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 128;
            this.label31.Text = "State";
            // 
            // tbOrderShippingState
            // 
            this.tbOrderShippingState.Location = new System.Drawing.Point(67, 87);
            this.tbOrderShippingState.Name = "tbOrderShippingState";
            this.tbOrderShippingState.Size = new System.Drawing.Size(100, 20);
            this.tbOrderShippingState.TabIndex = 131;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(24, 13);
            this.label32.TabIndex = 127;
            this.label32.Text = "City";
            // 
            // tbOrderShippingCity
            // 
            this.tbOrderShippingCity.Location = new System.Drawing.Point(67, 61);
            this.tbOrderShippingCity.Name = "tbOrderShippingCity";
            this.tbOrderShippingCity.Size = new System.Drawing.Size(100, 20);
            this.tbOrderShippingCity.TabIndex = 130;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(17, 38);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 125;
            this.label33.Text = "Street";
            // 
            // tbOrderShippingStreet
            // 
            this.tbOrderShippingStreet.Location = new System.Drawing.Point(67, 35);
            this.tbOrderShippingStreet.Name = "tbOrderShippingStreet";
            this.tbOrderShippingStreet.Size = new System.Drawing.Size(100, 20);
            this.tbOrderShippingStreet.TabIndex = 126;
            // 
            // checkShippingBilling
            // 
            this.checkShippingBilling.Location = new System.Drawing.Point(23, 13);
            this.checkShippingBilling.Name = "checkShippingBilling";
            this.checkShippingBilling.Size = new System.Drawing.Size(144, 25);
            this.checkShippingBilling.TabIndex = 0;
            this.checkShippingBilling.Text = "Same as Billing Address";
            this.checkShippingBilling.UseVisualStyleBackColor = true;
            this.checkShippingBilling.CheckedChanged += new System.EventHandler(this.CheckShippingBilling_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.tbOrderBillingZip);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tbOrderBillingState);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.tbOrderBillingCity);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.tbOrderBillingStreet);
            this.groupBox1.Location = new System.Drawing.Point(19, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 130);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing Address";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(2, 96);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 129;
            this.label26.Text = "Zip Code";
            // 
            // tbOrderBillingZip
            // 
            this.tbOrderBillingZip.Location = new System.Drawing.Point(67, 93);
            this.tbOrderBillingZip.Name = "tbOrderBillingZip";
            this.tbOrderBillingZip.Size = new System.Drawing.Size(100, 20);
            this.tbOrderBillingZip.TabIndex = 132;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 128;
            this.label27.Text = "State";
            // 
            // tbOrderBillingState
            // 
            this.tbOrderBillingState.Location = new System.Drawing.Point(67, 67);
            this.tbOrderBillingState.Name = "tbOrderBillingState";
            this.tbOrderBillingState.Size = new System.Drawing.Size(100, 20);
            this.tbOrderBillingState.TabIndex = 131;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 13);
            this.label28.TabIndex = 127;
            this.label28.Text = "City";
            // 
            // tbOrderBillingCity
            // 
            this.tbOrderBillingCity.Location = new System.Drawing.Point(67, 41);
            this.tbOrderBillingCity.Name = "tbOrderBillingCity";
            this.tbOrderBillingCity.Size = new System.Drawing.Size(100, 20);
            this.tbOrderBillingCity.TabIndex = 130;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 125;
            this.label29.Text = "Street";
            // 
            // tbOrderBillingStreet
            // 
            this.tbOrderBillingStreet.Location = new System.Drawing.Point(67, 15);
            this.tbOrderBillingStreet.Name = "tbOrderBillingStreet";
            this.tbOrderBillingStreet.Size = new System.Drawing.Size(100, 20);
            this.tbOrderBillingStreet.TabIndex = 126;
            // 
            // cbOrderCustomer
            // 
            this.cbOrderCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderCustomer.FormattingEnabled = true;
            this.cbOrderCustomer.Location = new System.Drawing.Point(89, 46);
            this.cbOrderCustomer.Name = "cbOrderCustomer";
            this.cbOrderCustomer.Size = new System.Drawing.Size(109, 21);
            this.cbOrderCustomer.TabIndex = 129;
            this.cbOrderCustomer.SelectedIndexChanged += new System.EventHandler(this.CbOrderCustomer_SelectedIndexChanged);
            this.cbOrderCustomer.Click += new System.EventHandler(this.CbOrderCustomer_Click);
            // 
            // btOrderSave
            // 
            this.btOrderSave.Location = new System.Drawing.Point(42, 217);
            this.btOrderSave.Name = "btOrderSave";
            this.btOrderSave.Size = new System.Drawing.Size(75, 23);
            this.btOrderSave.TabIndex = 128;
            this.btOrderSave.Text = "Save";
            this.btOrderSave.UseVisualStyleBackColor = true;
            this.btOrderSave.Visible = false;
            // 
            // btOrderEdit
            // 
            this.btOrderEdit.Location = new System.Drawing.Point(353, 244);
            this.btOrderEdit.Name = "btOrderEdit";
            this.btOrderEdit.Size = new System.Drawing.Size(75, 23);
            this.btOrderEdit.TabIndex = 127;
            this.btOrderEdit.TabStop = false;
            this.btOrderEdit.Text = "Edit";
            this.btOrderEdit.UseVisualStyleBackColor = true;
            // 
            // btOrderRemove
            // 
            this.btOrderRemove.Location = new System.Drawing.Point(434, 244);
            this.btOrderRemove.Name = "btOrderRemove";
            this.btOrderRemove.Size = new System.Drawing.Size(75, 23);
            this.btOrderRemove.TabIndex = 122;
            this.btOrderRemove.TabStop = false;
            this.btOrderRemove.Text = "Remove";
            this.btOrderRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView1.Location = new System.Drawing.Point(19, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 313);
            this.dataGridView1.TabIndex = 117;
            this.dataGridView1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Street";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "City";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "State";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Zip Code";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Sales Rep";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(515, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(529, 215);
            this.dataGridView3.TabIndex = 116;
            this.dataGridView3.TabStop = false;
            // 
            // btOrderClear
            // 
            this.btOrderClear.Location = new System.Drawing.Point(123, 217);
            this.btOrderClear.Name = "btOrderClear";
            this.btOrderClear.Size = new System.Drawing.Size(75, 23);
            this.btOrderClear.TabIndex = 115;
            this.btOrderClear.TabStop = false;
            this.btOrderClear.Text = "Clear";
            this.btOrderClear.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(67, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 13);
            this.label21.TabIndex = 114;
            this.label21.Text = "Id";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(89, 20);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(32, 20);
            this.tbOrderID.TabIndex = 113;
            this.tbOrderID.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 111;
            this.label22.Text = "Customer";
            // 
            // btOrderAdd
            // 
            this.btOrderAdd.Location = new System.Drawing.Point(42, 217);
            this.btOrderAdd.Name = "btOrderAdd";
            this.btOrderAdd.Size = new System.Drawing.Size(75, 23);
            this.btOrderAdd.TabIndex = 139;
            this.btOrderAdd.Text = "Add";
            this.btOrderAdd.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1065, 585);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(421, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 120);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 142;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 143;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 144;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 127;
            // 
            // btItemSave
            // 
            this.btItemSave.Location = new System.Drawing.Point(30, 219);
            this.btItemSave.Name = "btItemSave";
            this.btItemSave.Size = new System.Drawing.Size(75, 23);
            this.btItemSave.TabIndex = 126;
            this.btItemSave.Text = "Save";
            this.btItemSave.UseVisualStyleBackColor = true;
            this.btItemSave.Visible = false;
            // 
            // btItemEdit
            // 
            this.btItemEdit.Location = new System.Drawing.Point(341, 246);
            this.btItemEdit.Name = "btItemEdit";
            this.btItemEdit.Size = new System.Drawing.Size(75, 23);
            this.btItemEdit.TabIndex = 125;
            this.btItemEdit.TabStop = false;
            this.btItemEdit.Text = "Edit";
            this.btItemEdit.UseVisualStyleBackColor = true;
            // 
            // btItemRemove
            // 
            this.btItemRemove.Location = new System.Drawing.Point(422, 246);
            this.btItemRemove.Name = "btItemRemove";
            this.btItemRemove.Size = new System.Drawing.Size(75, 23);
            this.btItemRemove.TabIndex = 120;
            this.btItemRemove.TabStop = false;
            this.btItemRemove.Text = "Remove";
            this.btItemRemove.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 118;
            this.label18.Text = "Item UPC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 122;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 117;
            this.label24.Text = "Sell Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 121;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 116;
            this.label25.Text = "Purchase Price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 119;
            // 
            // btItemClear
            // 
            this.btItemClear.Location = new System.Drawing.Point(111, 219);
            this.btItemClear.Name = "btItemClear";
            this.btItemClear.Size = new System.Drawing.Size(75, 23);
            this.btItemClear.TabIndex = 115;
            this.btItemClear.TabStop = false;
            this.btItemClear.Text = "Clear";
            this.btItemClear.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 25);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 13);
            this.label34.TabIndex = 114;
            this.label34.Text = "Item Number";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(16, 51);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 13);
            this.label35.TabIndex = 111;
            this.label35.Text = "Vendor";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(14, 77);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 13);
            this.label39.TabIndex = 107;
            this.label39.Text = "Description";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(77, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 112;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(77, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 105;
            // 
            // btItemAdd
            // 
            this.btItemAdd.Location = new System.Drawing.Point(141, 272);
            this.btItemAdd.Name = "btItemAdd";
            this.btItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btItemAdd.TabIndex = 128;
            this.btItemAdd.TabStop = false;
            this.btItemAdd.Text = "Add";
            this.btItemAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple ERP";
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Employee.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.EmpEntry.ResumeLayout(false);
            this.EmpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_GridView)).EndInit();
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage EmpSummary;
        private System.Windows.Forms.TabPage EmpEntry;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox empTB_Supervisor;
        private System.Windows.Forms.TextBox empTB_Email;
        private System.Windows.Forms.TextBox empTB_Phone;
        private System.Windows.Forms.TextBox empTB_Address;
        private System.Windows.Forms.TextBox empTB_LastName;
        private System.Windows.Forms.TextBox empTB_FirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btEmpClear;
        private System.Windows.Forms.Button btEmpAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView emp_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btCustClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.Button btCustAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCustStreet;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCustZip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCustState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCustCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSales_Rep;
        private System.Windows.Forms.Button btCustRemove;
        private System.Windows.Forms.Button btCustEdit;
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.ComboBox cbCustSalesRep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbOrderBillingZip;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbOrderBillingState;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbOrderBillingCity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbOrderBillingStreet;
        private System.Windows.Forms.ComboBox cbOrderCustomer;
        private System.Windows.Forms.Button btOrderSave;
        private System.Windows.Forms.Button btOrderEdit;
        private System.Windows.Forms.Button btOrderRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btOrderClear;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbOrderShippingZip;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbOrderShippingState;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbOrderShippingCity;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbOrderShippingStreet;
        private System.Windows.Forms.CheckBox checkShippingBilling;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btOrderAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btItemAdd;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btItemSave;
        private System.Windows.Forms.Button btItemEdit;
        private System.Windows.Forms.Button btItemRemove;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btItemClear;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

