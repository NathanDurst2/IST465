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
            this.Entry = new System.Windows.Forms.TabPage();
            this.btCustSave = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.EmpSummary = new System.Windows.Forms.TabPage();
            this.EmpEntry = new System.Windows.Forms.TabPage();
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
            this.Vendor = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.btEmpClear = new System.Windows.Forms.Button();
            this.btEmpAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emp_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSalesRep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCustAdd = new System.Windows.Forms.Button();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btCustClear = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cSales_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Entry.SuspendLayout();
            this.Employee.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.EmpEntry.SuspendLayout();
            this.Vendor.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.Order.SuspendLayout();
            this.tabControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
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
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1065, 585);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Entry);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1069, 584);
            this.tabControl2.TabIndex = 0;
            // 
            // Entry
            // 
            this.Entry.Controls.Add(this.comboBox2);
            this.Entry.Controls.Add(this.dataCustomer);
            this.Entry.Controls.Add(this.dataGridView2);
            this.Entry.Controls.Add(this.btCustClear);
            this.Entry.Controls.Add(this.label13);
            this.Entry.Controls.Add(this.tbCustID);
            this.Entry.Controls.Add(this.btCustAdd);
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
            this.Entry.Padding = new System.Windows.Forms.Padding(3);
            this.Entry.Size = new System.Drawing.Size(1061, 558);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "Entry";
            this.Entry.UseVisualStyleBackColor = true;
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
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1061, 558);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
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
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1061, 558);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(570, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
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
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(76, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(76, 65);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(76, 91);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(76, 117);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(76, 143);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbSalesRep
            // 
            this.tbSalesRep.Location = new System.Drawing.Point(76, 169);
            this.tbSalesRep.Name = "tbSalesRep";
            this.tbSalesRep.Size = new System.Drawing.Size(100, 20);
            this.tbSalesRep.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sales Rep";
            // 
            // btCustAdd
            // 
            this.btCustAdd.Location = new System.Drawing.Point(29, 210);
            this.btCustAdd.Name = "btCustAdd";
            this.btCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btCustAdd.TabIndex = 12;
            this.btCustAdd.Text = "Add";
            this.btCustAdd.UseVisualStyleBackColor = true;
            this.btCustAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(76, 13);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(32, 20);
            this.tbCustID.TabIndex = 14;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(502, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 215);
            this.dataGridView2.TabIndex = 18;
            // 
            // cSales_Rep
            // 
            this.cSales_Rep.HeaderText = "Sales Rep";
            this.cSales_Rep.MinimumWidth = 6;
            this.cSales_Rep.Name = "cSales_Rep";
            this.cSales_Rep.ReadOnly = true;
            this.cSales_Rep.Width = 125;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Width = 125;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            this.cPhone.Width = 125;
            // 
            // cAddress
            // 
            this.cAddress.HeaderText = "Address";
            this.cAddress.MinimumWidth = 6;
            this.cAddress.Name = "cAddress";
            this.cAddress.ReadOnly = true;
            this.cAddress.Width = 125;
            // 
            // cLastName
            // 
            this.cLastName.HeaderText = "Last Name";
            this.cLastName.MinimumWidth = 6;
            this.cLastName.Name = "cLastName";
            this.cLastName.ReadOnly = true;
            this.cLastName.Width = 125;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "First Name";
            this.cFirstName.MinimumWidth = 6;
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.ReadOnly = true;
            this.cFirstName.Width = 125;
            // 
            // Cust_ID
            // 
            this.Cust_ID.HeaderText = "ID";
            this.Cust_ID.MinimumWidth = 6;
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.ReadOnly = true;
            this.Cust_ID.Width = 125;
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
            this.dataCustomer.Location = new System.Drawing.Point(6, 239);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.Size = new System.Drawing.Size(1025, 313);
            this.dataCustomer.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(324, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)(this.emp_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Entry;
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
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btEmpClear;
        private System.Windows.Forms.Button btEmpAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSales_Rep;
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
        private System.Windows.Forms.TextBox tbSalesRep;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.DataGridView emp_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

