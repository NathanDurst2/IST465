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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Summary = new System.Windows.Forms.TabPage();
            this.btEditCust = new System.Windows.Forms.Button();
            this.btRemoveCust = new System.Windows.Forms.Button();
            this.btAddCust = new System.Windows.Forms.Button();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSales_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGetCust = new System.Windows.Forms.Button();
            this.Entry = new System.Windows.Forms.TabPage();
            this.btCustClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.customerAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSalesRep = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btCustSave = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.EmpSummary = new System.Windows.Forms.TabPage();
            this.EmpEntry = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Vendor = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.Entry.SuspendLayout();
            this.Employee.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.EmpEntry.SuspendLayout();
            this.Vendor.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.Order.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Employee);
            this.tabControl1.Controls.Add(this.Vendor);
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
            this.Customers.Controls.Add(this.tabControl2);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Customers.Size = new System.Drawing.Size(1065, 585);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Summary);
            this.tabControl2.Controls.Add(this.Entry);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1069, 584);
            this.tabControl2.TabIndex = 0;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.btEditCust);
            this.Summary.Controls.Add(this.btRemoveCust);
            this.Summary.Controls.Add(this.btAddCust);
            this.Summary.Controls.Add(this.dataCustomer);
            this.Summary.Controls.Add(this.btGetCust);
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Summary.Size = new System.Drawing.Size(1061, 558);
            this.Summary.TabIndex = 1;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            // 
            // btEditCust
            // 
            this.btEditCust.Location = new System.Drawing.Point(140, 494);
            this.btEditCust.Name = "btEditCust";
            this.btEditCust.Size = new System.Drawing.Size(75, 23);
            this.btEditCust.TabIndex = 4;
            this.btEditCust.Text = "Edit";
            this.btEditCust.UseVisualStyleBackColor = true;
            this.btEditCust.Click += new System.EventHandler(this.BtEditCust_Click);
            // 
            // btRemoveCust
            // 
            this.btRemoveCust.Location = new System.Drawing.Point(221, 494);
            this.btRemoveCust.Name = "btRemoveCust";
            this.btRemoveCust.Size = new System.Drawing.Size(75, 23);
            this.btRemoveCust.TabIndex = 3;
            this.btRemoveCust.Text = "Remove";
            this.btRemoveCust.UseVisualStyleBackColor = true;
            this.btRemoveCust.Click += new System.EventHandler(this.BtRemoveCust_Click);
            // 
            // btAddCust
            // 
            this.btAddCust.Location = new System.Drawing.Point(59, 494);
            this.btAddCust.Name = "btAddCust";
            this.btAddCust.Size = new System.Drawing.Size(75, 23);
            this.btAddCust.TabIndex = 2;
            this.btAddCust.Text = "Add";
            this.btAddCust.UseVisualStyleBackColor = true;
            this.btAddCust.Click += new System.EventHandler(this.BtAddCust_Click);
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
            this.cAddress,
            this.cPhone,
            this.cEmail,
            this.cSales_Rep});
            this.dataCustomer.Location = new System.Drawing.Point(4, 6);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.Size = new System.Drawing.Size(1054, 465);
            this.dataCustomer.TabIndex = 1;
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
            // cAddress
            // 
            this.cAddress.HeaderText = "Address";
            this.cAddress.MinimumWidth = 6;
            this.cAddress.Name = "cAddress";
            this.cAddress.ReadOnly = true;
            this.cAddress.Width = 125;
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
            // btGetCust
            // 
            this.btGetCust.Location = new System.Drawing.Point(409, 494);
            this.btGetCust.Name = "btGetCust";
            this.btGetCust.Size = new System.Drawing.Size(195, 23);
            this.btGetCust.TabIndex = 0;
            this.btGetCust.Text = "Refresh ";
            this.btGetCust.UseVisualStyleBackColor = true;
            this.btGetCust.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Entry
            // 
            this.Entry.Controls.Add(this.btCustClear);
            this.Entry.Controls.Add(this.label13);
            this.Entry.Controls.Add(this.tbCustID);
            this.Entry.Controls.Add(this.customerAdd);
            this.Entry.Controls.Add(this.label6);
            this.Entry.Controls.Add(this.label5);
            this.Entry.Controls.Add(this.label4);
            this.Entry.Controls.Add(this.label3);
            this.Entry.Controls.Add(this.label2);
            this.Entry.Controls.Add(this.label1);
            this.Entry.Controls.Add(this.tbSalesRep);
            this.Entry.Controls.Add(this.tbEmail);
            this.Entry.Controls.Add(this.tbPhone);
            this.Entry.Controls.Add(this.tbAddress);
            this.Entry.Controls.Add(this.tbLastName);
            this.Entry.Controls.Add(this.tbFirstName);
            this.Entry.Controls.Add(this.btCustSave);
            this.Entry.Location = new System.Drawing.Point(4, 22);
            this.Entry.Name = "Entry";
            this.Entry.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Entry.Size = new System.Drawing.Size(1061, 558);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "Entry";
            this.Entry.UseVisualStyleBackColor = true;
            // 
            // btCustClear
            // 
            this.btCustClear.Location = new System.Drawing.Point(110, 210);
            this.btCustClear.Name = "btCustClear";
            this.btCustClear.Size = new System.Drawing.Size(75, 23);
            this.btCustClear.TabIndex = 16;
            this.btCustClear.Text = "Clear";
            this.btCustClear.UseVisualStyleBackColor = true;
            this.btCustClear.Click += new System.EventHandler(this.BtCustClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Id";
            // 
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(76, 13);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(32, 20);
            this.tbCustID.TabIndex = 14;
            // 
            // customerAdd
            // 
            this.customerAdd.Location = new System.Drawing.Point(29, 210);
            this.customerAdd.Name = "customerAdd";
            this.customerAdd.Size = new System.Drawing.Size(75, 23);
            this.customerAdd.TabIndex = 12;
            this.customerAdd.Text = "Add";
            this.customerAdd.UseVisualStyleBackColor = true;
            this.customerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sales Rep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // tbSalesRep
            // 
            this.tbSalesRep.Location = new System.Drawing.Point(76, 169);
            this.tbSalesRep.Name = "tbSalesRep";
            this.tbSalesRep.Size = new System.Drawing.Size(100, 20);
            this.tbSalesRep.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(76, 143);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(76, 117);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(76, 91);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(76, 65);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(76, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // btCustSave
            // 
            this.btCustSave.Location = new System.Drawing.Point(29, 210);
            this.btCustSave.Name = "btCustSave";
            this.btCustSave.Size = new System.Drawing.Size(75, 23);
            this.btCustSave.TabIndex = 13;
            this.btCustSave.Text = "Save";
            this.btCustSave.UseVisualStyleBackColor = true;
            this.btCustSave.Visible = false;
            this.btCustSave.Click += new System.EventHandler(this.BtCustSave_Click);
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.tabControl3);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.EmpSummary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.EmpSummary.Size = new System.Drawing.Size(1061, 558);
            this.EmpSummary.TabIndex = 1;
            this.EmpSummary.Text = "Summary";
            this.EmpSummary.UseVisualStyleBackColor = true;
            // 
            // EmpEntry
            // 
            this.EmpEntry.Controls.Add(this.button2);
            this.EmpEntry.Controls.Add(this.label7);
            this.EmpEntry.Controls.Add(this.label8);
            this.EmpEntry.Controls.Add(this.label9);
            this.EmpEntry.Controls.Add(this.label10);
            this.EmpEntry.Controls.Add(this.label11);
            this.EmpEntry.Controls.Add(this.label12);
            this.EmpEntry.Controls.Add(this.textBox1);
            this.EmpEntry.Controls.Add(this.textBox2);
            this.EmpEntry.Controls.Add(this.textBox3);
            this.EmpEntry.Controls.Add(this.textBox4);
            this.EmpEntry.Controls.Add(this.textBox5);
            this.EmpEntry.Controls.Add(this.textBox6);
            this.EmpEntry.Location = new System.Drawing.Point(4, 22);
            this.EmpEntry.Name = "EmpEntry";
            this.EmpEntry.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.EmpEntry.Size = new System.Drawing.Size(1061, 558);
            this.EmpEntry.TabIndex = 0;
            this.EmpEntry.Text = "Entry";
            this.EmpEntry.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sales Rep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // Vendor
            // 
            this.Vendor.Controls.Add(this.tabControl4);
            this.Vendor.Location = new System.Drawing.Point(4, 22);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(1065, 585);
            this.Vendor.TabIndex = 2;
            this.Vendor.Text = "Vendor";
            this.Vendor.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Location = new System.Drawing.Point(-2, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1069, 584);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1061, 558);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1061, 558);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.tabControl5);
            this.Order.Location = new System.Drawing.Point(4, 22);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(1065, 585);
            this.Order.TabIndex = 3;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage5);
            this.tabControl5.Controls.Add(this.tabPage6);
            this.tabControl5.Location = new System.Drawing.Point(-2, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(1069, 584);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(1061, 558);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(1061, 558);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
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
            this.tabControl2.ResumeLayout(false);
            this.Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.Entry.ResumeLayout(false);
            this.Entry.PerformLayout();
            this.Employee.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.EmpEntry.ResumeLayout(false);
            this.EmpEntry.PerformLayout();
            this.Vendor.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.Order.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Entry;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabPage Vendor;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage EmpSummary;
        private System.Windows.Forms.TabPage EmpEntry;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalesRep;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button customerAdd;
        private System.Windows.Forms.Button btGetCust;
        private System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSales_Rep;
        private System.Windows.Forms.Button btAddCust;
        private System.Windows.Forms.Button btEditCust;
        private System.Windows.Forms.Button btRemoveCust;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btCustClear;
    }
}

