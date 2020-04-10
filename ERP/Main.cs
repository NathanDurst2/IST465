using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;

namespace ERP
{
    public partial class Main : Form
    {
        User session = new User();
        public Main()
        {
            InitializeComponent();
            RefreshCustomers();
            RefreshItems();
            RefreshVendors();
            RefreshEmployeee();
            RefreshOrders();

            string path = ConfigurationManager.AppSettings.Get("backgroundPath").ToString();
            if (path != "")
            {
                this.BackgroundImage = Image.FromFile(path);
            }
            lbCompany.Text = ConfigurationManager.AppSettings.Get("companyName").ToString();
            this.Text = ConfigurationManager.AppSettings.Get("companyName").ToString();

            linkChangePassword.TabStop = false;
        }
        List<SelectedItems> selectedItems = new List<SelectedItems>();
        double taxRate = Convert.ToDouble(ConfigurationManager.AppSettings.Get("taxRate").ToString());

        private void tabControl_Selected(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text == "Order")
            {
                dataOrder.ClearSelection();
                dataOrderItems.ClearSelection();
                dataOrderItems.Rows.Clear();
                dataOrderItems.DataSource = null;
                tbOrderSubTotal.Text = "";
                tbOrderTotal.Text = "";
                selectedItems = new List<SelectedItems>();
                RefreshOrders();
            }
            if (tabControl.SelectedTab.Text == "Customers")
            {
                dataCustomer.ClearSelection();
                dataCustOrders.ClearSelection();
            }
            if (tabControl.SelectedTab.Text == "Settings")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Custom"].ConnectionString;
                if (connectionString != "")
                {
                    tbDatabaseLoc.Text = connectionString.Replace("Data Source=", "").Replace("; Version=3;", "");
                }
                var settings = (AppSettingsSection)ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection("appSettings");
                tbSettingCompanyName.Text = settings.Settings["companyName"].Value;
                tbSettingDefaultTaxRate.Text = settings.Settings["taxRate"].Value;
                tbBackgroundImage.Text = settings.Settings["backgroundPath"].Value;
                tbSettingsPOStreet.Text = settings.Settings["purchaseOrderDefaultStreet"].Value;
                tbSettingsPOCity.Text = settings.Settings["purchaseOrderDefaultCity"].Value;
                tbSettingsPOState.Text = settings.Settings["purchaseOrderDefaultState"].Value;
                tbSettingsPOZip.Text = settings.Settings["purchaseOrderDefaultZip"].Value;
                RefreshUsers();

            }
        }
        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtLogin_Click(sender, e);
            }
        }
        private void RefreshCustomers()
        {
            dataCustomer.Rows.Clear();
            dataCustomer.DataSource = null;
            List<Customer> c = new List<Customer>();
            c = SqliteDataAccess.LoadAllCustomer();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataCustomer.Rows.Count == i)
                {
                    dataCustomer.Rows.Add();
                }
                Employee emp = SqliteDataAccess.LoadEmployee(c[i].Employee_ID)[0];
                dataCustomer.Rows[i].Cells["Cust_ID"].Value = c[i].Cust_Id;
                dataCustomer.Rows[i].Cells["cFirstName"].Value = c[i].Customer_FirstName;
                dataCustomer.Rows[i].Cells["cLastName"].Value = c[i].Customer_LastName;
                dataCustomer.Rows[i].Cells["cStreet"].Value = c[i].Customer_Street;
                dataCustomer.Rows[i].Cells["cCity"].Value = c[i].Customer_City;
                dataCustomer.Rows[i].Cells["cState"].Value = c[i].Customer_State;
                dataCustomer.Rows[i].Cells["cZip"].Value = c[i].Customer_Zip;
                dataCustomer.Rows[i].Cells["cPhone"].Value = c[i].Customer_Phone;
                dataCustomer.Rows[i].Cells["cEmail"].Value = c[i].Customer_Email;
                dataCustomer.Rows[i].Cells["cSales_Rep"].Value = String.Format(c[i].Employee_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
            }
        }
        private void RefreshItems()
        {
            dataItem.Rows.Clear();
            dataItem.DataSource = null;
            List<Item> c = new List<Item>();
            c = SqliteDataAccess.LoadAllItem();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataItem.Rows.Count == i)
                {
                    dataItem.Rows.Add();
                }
                Vendor ven = SqliteDataAccess.LoadVendor(c[i].Vendor_ID)[0];
                dataItem.Rows[i].Cells["itemNumber"].Value = c[i].Item_Number;
                dataItem.Rows[i].Cells["itemVendorID"].Value = String.Format(c[i].Vendor_ID.ToString() + " - " + ven.Vendor_Name);
                dataItem.Rows[i].Cells["itemDesc"].Value = c[i].Item_Description;
                dataItem.Rows[i].Cells["itemPurchasePrice"].Value = String.Format("$ " + Math.Round(c[i].Item_PurchasePrice, 2));
                dataItem.Rows[i].Cells["itemSellPrice"].Value = String.Format("$ " + Math.Round(c[i].Item_SellPrice, 2));
                dataItem.Rows[i].Cells["itemUPC"].Value = c[i].Item_UPC;
            }
        }
        private void RefreshUsers()
        {
            dataUsers.Rows.Clear();
            dataUsers.DataSource = null;
            List<User> c = new List<User>();
            c = SqliteDataAccess.LoadAllUsers();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataUsers.Rows.Count == i)
                {
                    dataUsers.Rows.Add();
                }
                dataUsers.Rows[i].Cells["usersUsername"].Value = c[i].Username;
                dataUsers.Rows[i].Cells["usersLastLogin"].Value = c[i].LastLogon;
                if (c[i].isAdmin == "1")
                {
                    dataUsers.Rows[i].Cells["usersIsAdmin"].Value = true;
                }




            }
        }
        private void RefreshVendors()
        {
            dataVendor.Rows.Clear();
            dataVendor.DataSource = null;
            List<Vendor> c = new List<Vendor>();
            c = SqliteDataAccess.LoadAllVendor();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataVendor.Rows.Count == i)
                {
                    dataVendor.Rows.Add();
                }
                dataVendor.Rows[i].Cells["vendorID"].Value = c[i].Vendor_ID;
                dataVendor.Rows[i].Cells["vendorName"].Value = c[i].Vendor_Name;
                dataVendor.Rows[i].Cells["vendorStreet"].Value = c[i].Vendor_Street;
                dataVendor.Rows[i].Cells["vendorCity"].Value = c[i].Vendor_City;
                dataVendor.Rows[i].Cells["vendorState"].Value = c[i].Vendor_State;
                dataVendor.Rows[i].Cells["vendorZip"].Value = c[i].Vendor_Zip;
                dataVendor.Rows[i].Cells["vendorPhone"].Value = c[i].Vendor_Phone;
                dataVendor.Rows[i].Cells["vendorEmail"].Value = c[i].Vendor_Email;
                dataVendor.Rows[i].Cells["vendorTerms"].Value = c[i].Vendor_Terms;
                dataVendor.Rows[i].Cells["vendorCreditLimit"].Value = c[i].Vendor_CreditLimit;
            }
        }
        private void RefreshEmployeee()
        {
            dataEmployee.Rows.Clear();
            dataEmployee.DataSource = null;
            List<Employee> c = new List<Employee>();
            c = SqliteDataAccess.LoadAllEmployee();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataEmployee.Rows.Count == i)
                {
                    dataEmployee.Rows.Add();
                }
                try
                {
                    Employee emp = SqliteDataAccess.LoadEmployee(c[i].Employee_Supervisor_ID)[0];
                    dataEmployee.Rows[i].Cells["empSupervisorID"].Value = String.Format(c[i].Employee_Supervisor_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
                }
                catch (ArgumentOutOfRangeException) { }
                dataEmployee.Rows[i].Cells["empID"].Value = c[i].Employee_Id;
                dataEmployee.Rows[i].Cells["empFirstName"].Value = c[i].Employee_FirstName;
                dataEmployee.Rows[i].Cells["empLastName"].Value = c[i].Employee_LastName;
                dataEmployee.Rows[i].Cells["empStreet"].Value = c[i].Employee_Street;
                dataEmployee.Rows[i].Cells["empCity"].Value = c[i].Employee_City;
                dataEmployee.Rows[i].Cells["empState"].Value = c[i].Employee_State;
                dataEmployee.Rows[i].Cells["empZip"].Value = c[i].Employee_Zip;
                dataEmployee.Rows[i].Cells["empPhone"].Value = c[i].Employee_Phone;
                dataEmployee.Rows[i].Cells["empEmail"].Value = c[i].Employee_Email;
            }
        }
        private void RefreshOrders()
        {
            dataOrder.Rows.Clear();
            dataOrder.DataSource = null;
            List<Order> c = new List<Order>();
            c = SqliteDataAccess.LoadAllOrder();

            int neededRows = c.Count;
            if (neededRows > 0)
            {
                dataOrder.Rows.Add();
                if (neededRows >= 2)
                {
                    dataOrder.Rows.AddCopies(0, neededRows - 1);
                }
            }

            int y = 0;
            for (int i = 0; i < c.Count; i++, y++)
            {
                Customer cust = SqliteDataAccess.LoadCustomer(c[i].Cust_ID)[0];
                Employee emp = SqliteDataAccess.LoadEmployee(c[i].Employee_ID)[0];
                dataOrder.Rows[i].Cells["orderID"].Value = c[i].Order_ID;
                dataOrder.Rows[i].Cells["orderCustomer"].Value = String.Format(c[y].Cust_ID.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName);
                dataOrder.Rows[i].Cells["orderDate"].Value = c[i].Order_Date;
                dataOrder.Rows[i].Cells["orderShipDate"].Value = "-";
                dataOrder.Rows[i].Cells["orderTotal"].Value = String.Format("$ " + Math.Round(c[i].Order_Total, 2));
                dataOrder.Rows[i].Cells["orderSalesRep"].Value = String.Format(c[i].Employee_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
                dataOrder.Rows[i].Cells["orderShippingStreet"].Value = c[i].Order_ShipStreet;
                dataOrder.Rows[i].Cells["orderShippingCity"].Value = c[i].Order_ShipCity;
                dataOrder.Rows[i].Cells["orderShippingState"].Value = c[i].Order_ShipState;
                dataOrder.Rows[i].Cells["orderShippingZip"].Value = c[i].Order_ShipZip;

                if (c[i].Order_Type == "Estimate")
                {
                    dataOrder.Rows[i].Cells["orderType"].Value = "Estimate";
                    dataOrder.Rows[i].Cells["orderShipDate"].Value = "-";
                }
                else if (c[i].Order_Type == "Sales Order")
                {
                    dataOrder.Rows[i].Cells["orderType"].Value = "Sales Order";
                    dataOrder.Rows[i].Cells["orderShipDate"].Value = c[i].Order_ShipDate;
                    dataOrder.Rows[i].Cells["orderStatus"].Value = c[i].Order_Status;
                }
            }

        }
        private void RefreshOrderItems()
        {
            dataOrderItems.Rows.Clear();
            dataOrderItems.DataSource = null;
            string orderType = "";
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderID"].Value);
                orderType = dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderType"].Value.ToString();
            }
            catch (NullReferenceException)
            { }


            List<Order_Item> c = SqliteDataAccess.LoadOrder_ItemFOR(id);

            selectedItems = new List<SelectedItems>();

            foreach (Order_Item estItem in c)
            {
                SelectedItems si = new SelectedItems();
                si.Item_Number = estItem.Item_Number;
                si.Item_Quantity = Convert.ToInt32(estItem.Order_Item_Quantity);
                si.Vendor_ID = SqliteDataAccess.LoadItem(si.Item_Number.ToString())[0].Vendor_ID;
                selectedItems.Add(si);
            }

            for (int i = 0; i < c.Count; i++)
            {
                List<Item> items = SqliteDataAccess.LoadItem(c[i].Item_Number);
                if (dataOrderItems.Rows.Count == i)
                {
                    dataOrderItems.Rows.Add();
                }
                dataOrderItems.Rows[i].Cells["orderItemsNumber"].Value = c[i].Item_Number;
                dataOrderItems.Rows[i].Cells["orderItemsDesc"].Value = items[0].Item_Description;
                dataOrderItems.Rows[i].Cells["orderItemQuantity"].Value = c[i].Order_Item_Quantity;
                dataOrderItems.Rows[i].Cells["orderItemPrice"].Value = items[0].Item_SellPrice;
            }

            double subTotal = 0;

            foreach (SelectedItems si in selectedItems)
            {
                subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);
            }

            tbOrderSubTotal.Text = String.Format("$ " + Math.Round(subTotal, 2).ToString());
            tbOrderTotal.Text = String.Format("$ " + Math.Round(subTotal * 1.07, 2).ToString());
        }

        private void RefreshCustOrders()
        {
            dataCustOrders.Rows.Clear();
            dataCustOrders.DataSource = null;

            int id = Convert.ToInt32(dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value);
            List<Order> estimates = SqliteDataAccess.LoadOrderFromCustID(id);

            for (int i = 0; i < estimates.Count; i++)
            {
                dataCustOrders.Rows.Add();
                dataCustOrders.Rows[i].Cells["custOrdersID"].Value = estimates[i].Order_ID.ToString();
                dataCustOrders.Rows[i].Cells["custOrdersDate"].Value = estimates[i].Order_Date;

                dataCustOrders.Rows[i].Cells["custOrdersTotal"].Value = String.Format("$ " + Math.Round(estimates[i].Order_Total, 2));

                if (estimates[i].Order_Type == "Estimate")
                {
                    dataCustOrders.Rows[i].Cells["custOrdersType"].Value = "Estimate";
                    dataCustOrders.Rows[i].Cells["custOrdersShipDate"].Value = "-";
                }
                else if (estimates[i].Order_Type == "Sales Order")
                {
                    dataCustOrders.Rows[i].Cells["custOrdersType"].Value = "Sales Order";
                    dataCustOrders.Rows[i].Cells["custOrdersShipDate"].Value = estimates[i].Order_ShipDate;
                    dataCustOrders.Rows[i].Cells["custOrderStatus"].Value = estimates[i].Order_Status;
                }
                if (estimates[i].Order_Status == "Canceled" || estimates[i].Order_Status == "Closed")
                {
                    dataCustOrders.Rows[i].Visible = false;
                }
            }

        }
        private void RefreshVendorPOs()
        {
            dataPurchaseOrders.Rows.Clear();
            dataPurchaseOrders.DataSource = null;

            int id = Convert.ToInt32(dataVendor.Rows[dataVendor.CurrentCell.RowIndex].Cells["vendorID"].Value);

            List<PurchaseOrder> pos = SqliteDataAccess.LoadVendorPOs(id);

            for (int i = 0; i < pos.Count; i++)
            {
                PurchaseOrder po = pos[i];
                dataPurchaseOrders.Rows.Add();
                dataPurchaseOrders.Rows[i].Cells["poID"].Value = po.PO_ID;
                dataPurchaseOrders.Rows[i].Cells["poTotal"].Value = String.Format("$ " + Math.Round(po.PO_Total));
                dataPurchaseOrders.Rows[i].Cells["poShipDate"].Value = po.PO_ShipDate;
            }
        }
        private void BtCustClear_Click_1(object sender, EventArgs e)
        {
            btCustSave.Visible = false;
            tbCustID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbCustStreet.Clear();
            tbCustCity.Clear();
            tbCustState.Clear();
            tbCustZip.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            cbCustSalesRep.Items.Clear();
        }

        private void BtCustRemove_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteCustomer(dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value.ToString());
            RefreshCustomers();
        }

        private void BtCustAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && tbCustStreet.Text != "" && tbCustCity.Text != "" && tbCustState.Text != "" && tbCustZip.Text != "" && tbPhone.Text != "" && tbEmail.Text != "" && cbCustSalesRep.Text != "")
            {
                Customer c = new Customer();

                c.Customer_FirstName = tbFirstName.Text; tbFirstName.Clear();
                c.Customer_LastName = tbLastName.Text; tbLastName.Clear();
                c.Customer_Street = tbCustStreet.Text; tbCustStreet.Clear();
                c.Customer_City = tbCustCity.Text; tbCustCity.Clear();
                c.Customer_State = tbCustState.Text; tbCustState.Clear();
                c.Customer_Zip = tbCustZip.Text; tbCustZip.Clear();
                c.Customer_Phone = tbPhone.Text; tbPhone.Clear();
                c.Customer_Email = tbEmail.Text; tbEmail.Clear();
                string salesrep = cbCustSalesRep.Text; cbCustSalesRep.Items.Clear();
                c.Employee_ID = Convert.ToInt32(salesrep.Substring(0, salesrep.IndexOf(" -")));

                SqliteDataAccess.SaveCustomer(c);

                dataCustomer.DataSource = null;
                RefreshCustomers();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void BtCustEdit_Click(object sender, EventArgs e)
        {
            int Cust_ID = (int)dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value;

            Customer cust = SqliteDataAccess.LoadCustomer(Cust_ID)[0];
            //CreateExcelFile(SqliteDataAccess.LoadCustomer(Cust_ID), "");

            tbCustID.Text = cust.Cust_Id.ToString();
            tbFirstName.Text = cust.Customer_FirstName;
            tbLastName.Text = cust.Customer_LastName;
            tbCustStreet.Text = cust.Customer_Street;
            tbCustCity.Text = cust.Customer_City;
            tbCustState.Text = cust.Customer_State;
            tbCustZip.Text = cust.Customer_Zip;
            tbPhone.Text = cust.Customer_Phone;
            tbEmail.Text = cust.Customer_Email;
            CbCustSalesRep_Click(null, null);
            cbCustSalesRep.SelectedIndex = cbCustSalesRep.FindString(cust.Employee_ID.ToString());

            btCustSave.Visible = true;
            btCustSave.BringToFront();

        }

        private void BtCustSave_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && tbCustStreet.Text != "" && tbCustCity.Text != "" && tbCustState.Text != "" && tbCustZip.Text != "" && tbPhone.Text != "" && tbEmail.Text != "" && cbCustSalesRep.Text != "")
            {
                Customer c = new Customer();
                c.Cust_Id = Convert.ToInt32(tbCustID.Text); tbCustID.Clear();
                c.Customer_FirstName = tbFirstName.Text; tbFirstName.Clear();
                c.Customer_LastName = tbLastName.Text; tbLastName.Clear();
                c.Customer_Street = tbCustStreet.Text; tbCustStreet.Clear();
                c.Customer_City = tbCustCity.Text; tbCustCity.Clear();
                c.Customer_State = tbCustState.Text; tbCustState.Clear();
                c.Customer_Zip = tbCustZip.Text; tbCustZip.Clear();
                c.Customer_Phone = tbPhone.Text; tbPhone.Clear();
                c.Customer_Email = tbEmail.Text; tbEmail.Clear();
                string salesrep = cbCustSalesRep.Text; cbCustSalesRep.Items.Clear();
                c.Employee_ID = Convert.ToInt32(salesrep.Substring(0, salesrep.IndexOf(" -")));

                SqliteDataAccess.EditCustomer(c);
                btCustSave.SendToBack();
                dataCustomer.DataSource = null;
                RefreshCustomers();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void CbCustSalesRep_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbCustSalesRep.Text != "")
            {
                temp = cbCustSalesRep.Text;
            }
            cbCustSalesRep.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbCustSalesRep.Items.AddRange(arrays);
            cbCustSalesRep.SelectedItem = temp;
        }
        private void CbOrderCustomer_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbOrderCustomer.Text != "")
            {
                temp = cbOrderCustomer.Text;
            }
            cbOrderCustomer.Items.Clear();
            List<Customer> custs = SqliteDataAccess.LoadAllCustomer();
            List<String> ID_Name = new List<String>();
            foreach (Customer cust in custs)
            {
                ID_Name.Add(string.Format(cust.Cust_Id.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbOrderCustomer.Items.AddRange(arrays);
            cbOrderCustomer.SelectedItem = temp;
        }
        private void cbEmpSupervisor_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbEmpSupervisor.Text != "")
            {
                temp = cbEmpSupervisor.Text;
            }
            cbEmpSupervisor.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbEmpSupervisor.Items.AddRange(arrays);
            cbEmpSupervisor.SelectedItem = temp;

        }

        private void CheckShippingBilling_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShippingBilling.Checked)
            {
                tbOrderShippingStreet.Text = tbOrderBillingStreet.Text;
                tbOrderShippingStreet.Enabled = false;
                tbOrderShippingCity.Text = tbOrderBillingCity.Text;
                tbOrderShippingCity.Enabled = false;
                tbOrderShippingState.Text = tbOrderBillingState.Text;
                tbOrderShippingState.Enabled = false;
                tbOrderShippingZip.Text = tbOrderBillingZip.Text;
                tbOrderShippingZip.Enabled = false;
            }
            else
            {
                tbOrderShippingStreet.Enabled = true;
                tbOrderShippingCity.Enabled = true;
                tbOrderShippingState.Enabled = true;
                tbOrderShippingZip.Enabled = true;
            }
        }

        private void CbOrderCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cust = cbOrderCustomer.Text;
            int cust_id = Convert.ToInt32(cust.Substring(0, cust.IndexOf(" -")));
            Customer c = SqliteDataAccess.LoadCustomer(cust_id)[0];

            tbOrderBillingStreet.Text = c.Customer_Street;
            tbOrderBillingCity.Text = c.Customer_City;
            tbOrderBillingState.Text = c.Customer_State;
            tbOrderBillingZip.Text = c.Customer_Zip;

            if (checkShippingBilling.Checked)
            {
                tbOrderShippingStreet.Text = tbOrderBillingStreet.Text;
                tbOrderShippingCity.Text = tbOrderBillingCity.Text;
                tbOrderShippingState.Text = tbOrderBillingState.Text;
                tbOrderShippingZip.Text = tbOrderBillingZip.Text;
            }

            CbOrderSalesRep_Click(null, null);
            cbOrderSalesRep.SelectedIndex = cbOrderSalesRep.FindString(c.Employee_ID.ToString());
        }

        private void CbOrderSalesRep_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbOrderSalesRep.Text != "")
            {
                temp = cbOrderSalesRep.Text;
            }
            cbOrderSalesRep.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbOrderSalesRep.Items.AddRange(arrays);
            cbOrderSalesRep.SelectedItem = temp;
        }
        private void cbItemVendor_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbItemVendor.Text != "")
            {
                temp = cbItemVendor.Text;
            }
            cbItemVendor.Items.Clear();
            List<Vendor> vens = SqliteDataAccess.LoadAllVendor();
            List<String> ID_Name = new List<String>();
            foreach (Vendor ven in vens)
            {
                ID_Name.Add(String.Format(ven.Vendor_ID.ToString() + " - " + ven.Vendor_Name));
            }
            String[] arrays = ID_Name.ToArray();
            cbItemVendor.Items.AddRange(arrays);
            cbItemVendor.SelectedItem = temp;
        }
        public void BtOrderManageItems_Click(object sender, EventArgs e)
        {
            dataOrderItems.Rows.Clear();
            dataOrderItems.DataSource = null;

            ManageItems mi = new ManageItems(selectedItems);

            mi.ShowDialog();
            selectedItems = mi.selected;

            double subTotal = 0;

            foreach (SelectedItems si in selectedItems)
            {
                subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);
            }

            tbOrderSubTotal.Text = String.Format("$ " + Math.Round(subTotal, 2).ToString());
            tbOrderTotal.Text = String.Format("$ " + Math.Round(subTotal * 1.07, 2).ToString());

            if (selectedItems.Count > 0)
            {

                dataOrderItems.Rows.Add();
                if (selectedItems.Count >= 2)
                {
                    dataOrderItems.Rows.AddCopies(0, selectedItems.Count - 1);
                }
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    List<Item> items = SqliteDataAccess.LoadItem(selectedItems[i].Item_Number);
                    dataOrderItems.Rows[i].Cells["orderItemsNumber"].Value = selectedItems[i].Item_Number;
                    dataOrderItems.Rows[i].Cells["orderItemsDesc"].Value = items[0].Item_Description;
                    dataOrderItems.Rows[i].Cells["orderItemQuantity"].Value = selectedItems[i].Item_Quantity;
                    dataOrderItems.Rows[i].Cells["orderItemPrice"].Value = items[0].Item_SellPrice;
                }
            }

        }
        private void BtOrderAdd_Click(object sender, EventArgs e)
        {
            orderButtonsDisable();

            Order est = new Order();

            string emp = cbOrderSalesRep.Text;
            int emp_id = Convert.ToInt32(emp.Substring(0, emp.IndexOf(" -")));

            string cust = cbOrderCustomer.Text;
            int cust_id = Convert.ToInt32(cust.Substring(0, cust.IndexOf(" -")));

            est.Cust_ID = cust_id;
            est.Employee_ID = emp_id;
            est.Order_Date = DateTime.Today.ToShortDateString();

            est.Order_Type = cbOrderType.Text;
            if (est.Order_Type == "Sales Order")
            {
                est.Order_ShipDate = orderDatePicker.Value.ToShortDateString();
                est.Order_Status = cbOrderStatus.Text;
            }

            double subTotal = 0;
            foreach (SelectedItems si in selectedItems)
                subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);

            est.Order_Subtotal = subTotal;
            est.Order_Tax = (subTotal * taxRate);
            est.Order_Total = (est.Order_Subtotal + est.Order_Tax);
            est.Order_BillStreet = tbOrderBillingStreet.Text;
            est.Order_BillCity = tbOrderBillingCity.Text;
            est.Order_BillState = tbOrderBillingState.Text;
            est.Order_BillZip = tbOrderBillingZip.Text;
            est.Order_ShipStreet = tbOrderShippingStreet.Text;
            est.Order_ShipCity = tbOrderShippingCity.Text;
            est.Order_ShipState = tbOrderShippingState.Text;
            est.Order_ShipZip = tbOrderShippingZip.Text;

            string est_id = SqliteDataAccess.AddOrder(est);

            foreach (SelectedItems it in selectedItems)
            {
                Order_Item ei = new Order_Item();
                ei.Order_ID = Convert.ToInt32(est_id);
                ei.Item_Number = it.Item_Number;
                ei.Order_Item_Quantity = it.Item_Quantity;

                SqliteDataAccess.AddOrder_Item(ei);
            }
            //Clears out the list of items so that the next order is empty
            selectedItems = new List<SelectedItems>();

            //Clears out the list of items so that the next order is empty
            selectedItems = new List<SelectedItems>();
            BtOrderClear_Click(null, null);
            orderButtonsDisable();
            RefreshOrders();
        }

        private void BtOrderSave_Click(object sender, EventArgs e)
        {
            orderButtonsDisable();
            if (cbOrderCustomer != null)
            {
                Order es = new Order();
                es.Order_ID = Convert.ToInt32(tbOrderID.Text); tbOrderID.Clear();
                es.Cust_ID = Convert.ToInt32(cbOrderCustomer.Text.Substring(0, cbOrderCustomer.Text.IndexOf(" -"))); cbOrderCustomer.Items.Clear();
                es.Employee_ID = Convert.ToInt32(cbOrderSalesRep.Text.Substring(0, cbOrderSalesRep.Text.IndexOf(" -"))); cbOrderSalesRep.Items.Clear();
                es.Order_Date = DateTime.Today.ToShortDateString();
                es.Order_Type = cbOrderType.Text;
                if (es.Order_Type == "Sales Order")
                {
                    es.Order_ShipDate = orderDatePicker.Value.ToShortDateString();
                    es.Order_Status = cbOrderStatus.Text;
                }

                double subTotal = 0;
                foreach (SelectedItems si in selectedItems)
                    subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);

                es.Order_Subtotal = subTotal;
                es.Order_Tax = subTotal * taxRate;
                es.Order_Total = es.Order_Subtotal + es.Order_Tax;
                cbOrderType.SelectedIndex = -1;
                checkShippingBilling.Checked = false;
                es.Order_BillStreet = tbOrderBillingStreet.Text; tbOrderBillingStreet.Clear();
                es.Order_BillCity = tbOrderBillingCity.Text; tbOrderBillingCity.Clear();
                es.Order_BillState = tbOrderBillingState.Text; tbOrderBillingState.Clear();
                es.Order_BillZip = tbOrderBillingZip.Text; tbOrderBillingZip.Clear();
                es.Order_ShipStreet = tbOrderShippingStreet.Text; tbOrderShippingStreet.Clear();
                es.Order_ShipCity = tbOrderShippingCity.Text; tbOrderShippingCity.Clear();
                es.Order_ShipState = tbOrderShippingState.Text; tbOrderShippingState.Clear();
                es.Order_ShipZip = tbOrderShippingZip.Text; tbOrderShippingZip.Clear();
                SqliteDataAccess.DeleteOrder_Item(es.Order_ID);
                SqliteDataAccess.EditOrder(es);
                foreach (SelectedItems it in selectedItems)
                {
                    Order_Item ei = new Order_Item();
                    ei.Order_ID = Convert.ToInt32(es.Order_ID);
                    ei.Item_Number = it.Item_Number;
                    ei.Order_Item_Quantity = it.Item_Quantity;

                    SqliteDataAccess.AddOrder_Item(ei);
                }
                RefreshOrders();
                RefreshOrderItems();
                btOrderSave.Visible = false;
                btOrderSave.SendToBack();
            }
        }
        private void dataOrder_SelectionChanged(object sender, EventArgs e)
        {
            RefreshOrderItems();
        }
        private void dataCustomer_SelectionChanged(object sender, EventArgs e)
        {
            RefreshCustOrders();
        }
        private void dataVendor_SelectionedChanged(object sender, EventArgs e)
        {
            RefreshVendorPOs();
        }
        private void BtOrderEdit_Click(object sender, EventArgs e)
        {
            orderButtonsEnable();
            btOrderNew.Visible = false;

            int orderID = (int)dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderID"].Value;

            Order est = SqliteDataAccess.LoadOrder(orderID)[0];
            List<Order_Item> itemList = SqliteDataAccess.LoadOrder_ItemFOR(est.Order_ID);
            CbOrderCustomer_Click(null, null);
            selectedItems = new List<SelectedItems>();

            foreach (Order_Item estItem in itemList)
            {
                SelectedItems si = new SelectedItems();
                si.Item_Number = estItem.Item_Number;
                si.Item_Quantity = Convert.ToInt32(estItem.Order_Item_Quantity);
                si.Vendor_ID = SqliteDataAccess.LoadItem(si.Item_Number.ToString())[0].Vendor_ID;
                selectedItems.Add(si);
            }
            if (est.Order_Type == "Sales Order")
            {
                orderDatePicker.Value = DateTime.Parse(est.Order_ShipDate);
                cbOrderStatus.SelectedIndex = cbOrderStatus.FindString(est.Order_Status);
            }
            tbOrderID.Text = est.Order_ID.ToString();
            cbOrderCustomer.SelectedIndex = cbOrderCustomer.FindString(est.Cust_ID.ToString());
            cbOrderType.SelectedIndex = cbOrderType.FindString(est.Order_Type);
            tbOrderBillingStreet.Text = est.Order_BillStreet;
            tbOrderBillingCity.Text = est.Order_BillCity;
            tbOrderBillingState.Text = est.Order_BillState;
            tbOrderShippingZip.Text = est.Order_ShipZip;
            tbOrderShippingStreet.Text = est.Order_ShipStreet;
            tbOrderShippingCity.Text = est.Order_ShipCity;
            tbOrderShippingState.Text = est.Order_ShipState;
            tbOrderShippingZip.Text = est.Order_ShipZip;
            btOrderSave.Visible = true;
            btOrderSave.BringToFront();
        }

        private void BtOrderClear_Click(object sender, EventArgs e)
        {
            btOrderNew.Visible = true;
            orderButtonsDisable();
            tbOrderID.Clear();
            cbOrderCustomer.Items.Clear();
            cbOrderType.SelectedIndex = -1;
            cbOrderSalesRep.SelectedIndex = -1;
            tbOrderBillingStreet.Clear();
            tbOrderBillingCity.Clear();
            tbOrderBillingState.Clear();
            tbOrderBillingZip.Clear();
            tbOrderShippingStreet.Clear();
            tbOrderShippingCity.Clear();
            tbOrderShippingState.Clear();
            tbOrderShippingZip.Clear();
            tbOrderSubTotal.Clear();
            tbOrderTotal.Clear();
            checkShippingBilling.Checked = false;
            selectedItems = new List<SelectedItems>();
            RefreshOrderItems();
            tabControl_Selected(null, null);
        }

        private void BtOrderNew_Click(object sender, EventArgs e)
        {
            btOrderSave.Visible = false;
            BtOrderClear_Click(null, null);
            orderButtonsEnable();
            orderDatePicker.Value = DateTime.Today.AddDays(2);
            cbOrderStatus.SelectedIndex = cbOrderStatus.FindString("Open");
        }
        private void cbOrderType_SelectionChanged(object sender, EventArgs e)
        {
            if (cbOrderType.Text == "Sales Order")
            {
                labelOrderStatus.Visible = true;
                labelOrderShipDate.Visible = true;
                cbOrderStatus.Visible = true;
                orderDatePicker.Visible = true;
            }
            else
            {
                labelOrderStatus.Visible = false;
                labelOrderShipDate.Visible = false;
                cbOrderStatus.Visible = false;
                orderDatePicker.Visible = false;
            }
        }
        private void orderButtonsDisable()
        {
            cbOrderCustomer.Enabled = false;
            cbOrderType.Enabled = false;
            cbOrderSalesRep.Enabled = false;
            tbOrderBillingStreet.Enabled = false;
            tbOrderBillingCity.Enabled = false;
            tbOrderBillingState.Enabled = false;
            tbOrderBillingZip.Enabled = false;
            tbOrderShippingStreet.Enabled = false;
            tbOrderShippingCity.Enabled = false;
            tbOrderShippingState.Enabled = false;
            tbOrderShippingZip.Enabled = false;
            tbOrderSubTotal.Enabled = false;
            tbOrderTotal.Enabled = false;
            checkShippingBilling.Enabled = false;
            btOrderManageItems.Enabled = false;
            btOrderAdd.Enabled = false;
            btOrderSave.Enabled = false;
            btOrderNew.Visible = true;
        }
        private void orderButtonsEnable()
        {
            cbOrderCustomer.Enabled = true;
            cbOrderType.Enabled = true;
            cbOrderSalesRep.Enabled = true;
            tbOrderBillingStreet.Enabled = true;
            tbOrderBillingCity.Enabled = true;
            tbOrderBillingState.Enabled = true;
            tbOrderBillingZip.Enabled = true;
            tbOrderShippingStreet.Enabled = true;
            tbOrderShippingCity.Enabled = true;
            tbOrderShippingState.Enabled = true;
            tbOrderShippingZip.Enabled = true;
            tbOrderSubTotal.Enabled = true;
            tbOrderTotal.Enabled = true;
            checkShippingBilling.Enabled = true;
            btOrderManageItems.Enabled = true;
            btOrderAdd.Enabled = true;
            btOrderSave.Enabled = true;
        }

        private void BtOrderRemove_Click(object sender, EventArgs e)
        {
            string orderType = "";
            int id = Convert.ToInt32(dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderID"].Value);
            try
            {
                orderType = dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderType"].Value.ToString();
            }
            catch (NullReferenceException)
            { }

            DialogResult result = MessageBox.Show("Are you sure you wish to delete this order?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteOrder(id);
                SqliteDataAccess.DeleteOrder_Item(id);
                RefreshOrders();
                RefreshOrderItems();
            }


        }
        private void BtEmpClear_Click(object sender, EventArgs e)
        {
            tbEmpID.Clear();
            tbEmpFirstName.Clear();
            tbEmpLastName.Clear();
            tbEmpPhone.Clear();
            tbEmpStreet.Clear();
            tbEmpState.Clear();
            tbEmpCity.Clear();
            tbEmpState.Clear();
            tbEmpZip.Clear();
            tbEmpEmail.Clear();
            cbEmpSupervisor.SelectedIndex = -1;
            btEmpSave.Visible = false;
        }

        private void BtEmpAdd_Click(object sender, EventArgs e)
        {
            if (tbEmpFirstName.Text != "" && tbEmpLastName.Text != "" && tbEmpStreet.Text != "" && tbEmpCity.Text != "" && tbEmpState.Text != "" && tbEmpZip.Text != "" && tbEmpPhone.Text != "")
            {
                Employee emp = new Employee();
                emp.Employee_FirstName = tbEmpFirstName.Text;
                emp.Employee_LastName = tbEmpLastName.Text;
                emp.Employee_Street = tbEmpStreet.Text;
                emp.Employee_State = tbEmpState.Text;
                emp.Employee_City = tbEmpCity.Text;
                emp.Employee_Zip = tbEmpZip.Text;
                emp.Employee_Phone = tbEmpPhone.Text;
                emp.Employee_Email = tbEmpEmail.Text;
                string supervisor = cbEmpSupervisor.Text;
                if (supervisor.Length > 0 & supervisor.Contains(" -"))
                {
                    emp.Employee_Supervisor_ID = Convert.ToInt32(supervisor.Substring(0, supervisor.IndexOf(" -")));
                }
                SqliteDataAccess.AddEmployee(emp);
                BtEmpClear_Click(null, null);
                RefreshEmployeee();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }

        }

        private void BtEmpEdit_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataEmployee.Rows[dataEmployee.CurrentCell.RowIndex].Cells["empID"].Value);
            Employee emp = SqliteDataAccess.LoadEmployee(id)[0];
            tbEmpID.Text = emp.Employee_Id.ToString();
            tbEmpFirstName.Text = emp.Employee_FirstName;
            tbEmpLastName.Text = emp.Employee_LastName;
            tbEmpStreet.Text = emp.Employee_Street;
            tbEmpState.Text = emp.Employee_State;
            tbEmpCity.Text = emp.Employee_City;
            tbEmpZip.Text = emp.Employee_Zip;
            tbEmpPhone.Text = emp.Employee_Phone;
            tbEmpEmail.Text = emp.Employee_Email;
            cbEmpSupervisor_Click(null, null);
            cbEmpSupervisor.SelectedIndex = cbEmpSupervisor.FindString(emp.Employee_Supervisor_ID.ToString());
            btEmpSave.Visible = true;

        }

        private void BtEmpSave_Click(object sender, EventArgs e)
        {
            if (tbEmpFirstName.Text != "" && tbEmpLastName.Text != "" && tbEmpStreet.Text != "" && tbEmpCity.Text != "" && tbEmpState.Text != "" && tbEmpZip.Text != "" && tbEmpPhone.Text != "" && tbEmpEmail.Text != "" && cbEmpSupervisor.Text != "")
            {
                Employee emp = new Employee();
                emp.Employee_Id = Convert.ToInt32(tbEmpID.Text);
                emp.Employee_FirstName = tbEmpFirstName.Text;
                emp.Employee_LastName = tbEmpLastName.Text;
                emp.Employee_Street = tbEmpStreet.Text;
                emp.Employee_State = tbEmpState.Text;
                emp.Employee_City = tbEmpCity.Text;
                emp.Employee_Zip = tbEmpZip.Text;
                emp.Employee_Phone = tbEmpPhone.Text;
                emp.Employee_Email = tbEmpEmail.Text;
                string supervisor = cbEmpSupervisor.Text;
                if (supervisor.Length > 0 & supervisor.Contains(" -"))
                    emp.Employee_Supervisor_ID = Convert.ToInt32(supervisor.Substring(0, supervisor.IndexOf(" -")));
                SqliteDataAccess.EditEmployee(emp);
                btEmpSave.Visible = false;
                BtEmpClear_Click(null, null);
                RefreshEmployeee();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void BtEmpRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataEmployee.Rows[dataEmployee.CurrentCell.RowIndex].Cells["empID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you wish to delete this employee?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteEmployee(id);
                RefreshEmployeee();
            }
        }

        private void BtVendorAdd_Click(object sender, EventArgs e)
        {
            if (tbVendorName.Text != "" && tbVendorStreet.Text != "" && tbVendorStreet.Text != "" && tbVendorState.Text != "" && tbVendorCity.Text != "" && tbVendorZip.Text != "" && tbVendorPhone.Text != "" && tbVendorCreditLimit.Text != "" && tbVendorEmail.Text != "" && cbVendorTerms.Text != "")
            {
                Vendor ven = new Vendor();
                ven.Vendor_Name = tbVendorName.Text;
                ven.Vendor_Street = tbVendorStreet.Text;
                ven.Vendor_State = tbVendorState.Text;
                ven.Vendor_City = tbVendorCity.Text;
                ven.Vendor_State = tbVendorState.Text;
                ven.Vendor_Zip = tbVendorZip.Text;
                ven.Vendor_Phone = tbVendorPhone.Text;
                ven.Vendor_Email = tbVendorEmail.Text;
                ven.Vendor_CreditLimit = tbVendorCreditLimit.Text;
                ven.Vendor_Terms = cbVendorTerms.SelectedItem.ToString();
                SqliteDataAccess.AddVendor(ven);
                RefreshVendors();
                BtVendorClear_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void BtVendorClear_Click(object sender, EventArgs e)
        {
            tbVendorID.Clear();
            tbVendorName.Clear();
            tbVendorStreet.Clear();
            tbVendorState.Clear();
            tbVendorCity.Clear();
            tbVendorState.Clear();
            tbVendorZip.Clear();
            tbVendorPhone.Clear();
            tbVendorEmail.Clear();
            tbVendorCreditLimit.Clear();
            cbVendorTerms.SelectedIndex = -1;
            btVendorSave.Visible = false;
        }

        private void BtVendorEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataVendor.Rows[dataVendor.CurrentCell.RowIndex].Cells["vendorID"].Value);
            Vendor ven = SqliteDataAccess.LoadVendor(id)[0];
            tbVendorID.Text = ven.Vendor_ID.ToString();
            tbVendorName.Text = ven.Vendor_Name;
            tbVendorStreet.Text = ven.Vendor_Street;
            tbVendorState.Text = ven.Vendor_State;
            tbVendorCity.Text = ven.Vendor_City;
            tbVendorZip.Text = ven.Vendor_Zip;
            tbVendorPhone.Text = ven.Vendor_Phone;
            tbVendorEmail.Text = ven.Vendor_Email;
            tbVendorCreditLimit.Text = ven.Vendor_CreditLimit;
            cbVendorTerms.SelectedIndex = cbVendorTerms.FindString(ven.Vendor_Terms);
            btVendorSave.BringToFront();
            btVendorSave.Visible = true;
        }

        private void BtVendorSave_Click(object sender, EventArgs e)
        {
            if (tbVendorName.Text != "" && tbVendorStreet.Text != "" && tbVendorStreet.Text != "" && tbVendorState.Text != "" && tbVendorCity.Text != "" && tbVendorZip.Text != "" && tbVendorPhone.Text != "" && tbVendorCreditLimit.Text != "" && tbVendorEmail.Text != "" && cbVendorTerms.Text != "")
            {
                Vendor ven = new Vendor();
                ven.Vendor_ID = Convert.ToInt32(tbVendorID.Text);
                ven.Vendor_Name = tbVendorName.Text;
                ven.Vendor_Street = tbVendorStreet.Text;
                ven.Vendor_State = tbVendorState.Text;
                ven.Vendor_City = tbVendorCity.Text;
                ven.Vendor_Zip = tbVendorZip.Text;
                ven.Vendor_Phone = tbVendorPhone.Text;
                ven.Vendor_Email = tbVendorEmail.Text;
                ven.Vendor_CreditLimit = tbVendorCreditLimit.Text;
                ven.Vendor_Terms = cbVendorTerms.Text;
                SqliteDataAccess.EditVendor(ven);
                btVendorSave.Visible = false;
                BtVendorClear_Click(null, null);
                RefreshVendors();
                btVendorSave.Visible = false;
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void BtVendorRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataVendor.Rows[dataVendor.CurrentCell.RowIndex].Cells["vendorID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you wish to delete this Vendor?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteVendor(id);
                RefreshVendors();
            }
        }

        private void BtDatabaseBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbDatabaseLoc.Text = openFileDialog1.FileName;
            }
        }
        private void btBackgroundBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image.FromFile(openFileDialog1.FileName).Save(Path.GetFileName(openFileDialog1.FileName));
                tbBackgroundImage.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void BtSettingsSave_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            var appSetting = (AppSettingsSection)config.GetSection("appSettings");
            // Company name
            if (appSetting != null && tbSettingCompanyName.Text != "")
            {
                appSetting.Settings["companyName"].Value = tbSettingCompanyName.Text;
                ConfigurationManager.RefreshSection("appSettings");
                config.Save();
            }
            // Default address for purchase orders
            if (appSetting != null)
            {
                appSetting.Settings["purchaseOrderDefaultStreet"].Value = tbSettingsPOStreet.Text;
                appSetting.Settings["purchaseOrderDefaultCity"].Value = tbSettingsPOCity.Text;
                appSetting.Settings["purchaseOrderDefaultState"].Value = tbSettingsPOState.Text;
                appSetting.Settings["purchaseOrderDefaultZip"].Value = tbSettingsPOZip.Text;
                ConfigurationManager.RefreshSection("appSettings");
                config.Save();
            }
            // Background image
            if (appSetting != null && tbBackgroundImage.Text != "")
            {
                if (appSetting.Settings["backgroundPath"].Value != tbBackgroundImage.Text)
                {
                    appSetting.Settings["backgroundPath"].Value = Path.GetFileName(tbBackgroundImage.Text);
                }
                ConfigurationManager.RefreshSection("appSettings");
                config.Save();
            }
            else
            {
                appSetting.Settings["backgroundPath"].Value = "";
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            // Custom database location
            if (connectionStringsSection != null && tbDatabaseLoc.Text != "")
            {
                connectionStringsSection.ConnectionStrings["Custom"].ConnectionString = String.Format("Data Source=" + tbDatabaseLoc.Text + "; Version=3;");
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            else
            {
                connectionStringsSection.ConnectionStrings["Custom"].ConnectionString = "";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            MessageBox.Show("A restart will be required for these changes to take affect.");
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginUser.Text != "" && tbLoginPass.Text != "")
            {
                try
                {

                    User user = SqliteDataAccess.VerifyPassword(tbLoginUser.Text)[0];
                    if (user != null)
                    {
                        if (SecurePasswordHasher.Verify(tbLoginPass.Text, user.Password))
                        {
                            if (user.LastLogon == null)
                            {
                                PasswordReset reset = new PasswordReset(user);
                                reset.ShowDialog();
                                SqliteDataAccess.SetUserLastLogon(DateTime.Now.ToString(), user.Username);
                            }
                            tabControl.Visible = true;
                            btLogin.Visible = false;
                            tbLoginPass.Visible = false;
                            tbLoginUser.Visible = false;
                            lbLogin1.Visible = false;
                            lbLogin2.Visible = false;
                            this.BackgroundImage = null;
                            lbCompany.Visible = false;
                            session = user;
                            lbSessionUsername.Parent = this;
                            lbSessionUsername.BringToFront();
                            linkChangePassword.Visible = true;
                            lbSessionUsername.Text = String.Format(session.Username + " - " + DateTime.Now.ToString());
                            SqliteDataAccess.SetUserLastLogon(DateTime.Now.ToString(), user.Username);
                            if (user.isAdmin == "0")
                            {
                                this.tabSettings.Parent = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username and/or password. Contact your Administrator if this error persists.");
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Incorrect username and/or password. Contact your Administrator if this error persists.");
                }
            }
        }

        private void BtSettingsUserAdd_Click(object sender, EventArgs e)
        {
            if (tbSettingsUsername.Text != "")
            {
                User user = new User();
                user.Username = tbSettingsUsername.Text;
                user.Password = SecurePasswordHasher.Hash("password");
                if (settingsIsAdmin.Checked)
                {
                    user.isAdmin = "1";
                }
                else
                {
                    user.isAdmin = "0";
                }
                SqliteDataAccess.AddUser(user);
                tbSettingsUsername.Clear();
                settingsIsAdmin.Checked = false;
                RefreshUsers();
            }
        }

        private void BtSettingsUserRemove_Click(object sender, EventArgs e)
        {
            string username = (string)dataUsers.Rows[dataUsers.CurrentCell.RowIndex].Cells["usersUsername"].Value;

            DialogResult result = MessageBox.Show("Are you sure you wish to delete this user?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteUser(username);
                RefreshUsers();
            }

        }

        private void LinkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordReset reset = new PasswordReset(session);
            reset.ShowDialog();
        }

        private void BtManagePOs_Click(object sender, EventArgs e)
        {
            PurchaseOrders po = new PurchaseOrders(new PurchaseOrder(), "new");
            po.ShowDialog();
            RefreshVendorPOs();
        }

        private void BtItemEdit_Click(object sender, EventArgs e)
        {
            Item item = SqliteDataAccess.LoadItem((string)dataItem.Rows[dataItem.CurrentCell.RowIndex].Cells["itemNumber"].Value)[0];
            tbItemNumber.Text = item.Item_Number;
            tbItemDesc.Text = item.Item_Description;
            tbItemPurchase.Text = item.Item_PurchasePrice.ToString();
            tbItemSell.Text = item.Item_SellPrice.ToString();
            tbItemUPC.Text = item.Item_UPC;
            cbItemVendor_Click(null, null);
            cbItemVendor.SelectedIndex = cbItemVendor.FindString(item.Vendor_ID.ToString());
            btItemSave.BringToFront();
            btItemSave.Visible = true;

        }

        private void BtItemRemove_Click(object sender, EventArgs e)
        {
            string id = "";
            try
            {
                id = (string)dataItem.Rows[dataItem.CurrentCell.RowIndex].Cells["itemNumber"].Value;
            }
            catch (NullReferenceException)
            { }
            SqliteDataAccess.DeleteItem(id);
            RefreshItems();
        }

        private void BtItemClear_Click(object sender, EventArgs e)
        {
            tbItemNumber.Clear();
            tbItemDesc.Clear();
            tbItemPurchase.Clear();
            tbItemSell.Clear();
            tbItemUPC.Clear();
            btItemSave.Visible = false;
            cbItemVendor.SelectedIndex = -1;
        }

        private void BtItemAdd_Click(object sender, EventArgs e)
        {
            if (tbItemNumber.Text != "" && tbItemDesc.Text != "" && tbItemPurchase.Text != "" && tbItemSell.Text != "" && cbItemVendor.Text != "")
            {
                Item item = new Item();
                item.Item_Number = tbItemNumber.Text;
                item.Item_Description = tbItemDesc.Text;
                item.Item_PurchasePrice = Convert.ToDouble(tbItemPurchase.Text);
                item.Vendor_ID = Convert.ToInt32(cbItemVendor.Text.Substring(0, cbItemVendor.Text.IndexOf(" - ")));
                item.Item_SellPrice = Convert.ToDouble(tbItemSell.Text);
                item.Item_UPC = tbItemUPC.Text;

                SqliteDataAccess.AddItem(item);
                RefreshItems();
                BtItemClear_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }


        }

        private void BtItemSave_Click(object sender, EventArgs e)
        {
            if (tbItemNumber.Text != "" && tbItemDesc.Text != "" && tbItemPurchase.Text != "" && tbItemSell.Text != "" && cbItemVendor.Text != "")
            {
                Item item = new Item();
                item.Item_Number = tbItemNumber.Text;
                item.Item_Description = tbItemDesc.Text;
                item.Item_PurchasePrice = Convert.ToDouble(tbItemPurchase.Text);
                item.Item_SellPrice = Convert.ToDouble(tbItemSell.Text);
                item.Vendor_ID = Convert.ToInt32(cbItemVendor.Text.Substring(0, cbItemVendor.Text.IndexOf(" - ")));
                item.Item_UPC = tbItemUPC.Text;

                SqliteDataAccess.EditItem(item);
                RefreshItems();
                BtItemClear_Click(null, null);
                btItemSave.Visible = false;
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void BtPORemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataPurchaseOrders.Rows[dataPurchaseOrders.CurrentCell.RowIndex].Cells["poID"].Value);
            SqliteDataAccess.DeletePurchaseOrder(id);
            RefreshVendorPOs();
        }

        private void BtPOEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataPurchaseOrders.Rows[dataPurchaseOrders.CurrentCell.RowIndex].Cells["poID"].Value);
            PurchaseOrder po = SqliteDataAccess.LoadPurchaseOrder(id)[0];
            PurchaseOrders poForm = new PurchaseOrders(po, "edit");
            poForm.ShowDialog();
            RefreshVendorPOs();
        }
        private void exportExcel(string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Custom"].ConnectionString;
            if (connectionString == "")
            {
                connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //string cs = "URI=file:test.db";
            string data = String.Empty;

            int i = 1;
            int j = 0;

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string stm = String.Format("SELECT * FROM [{0}]", table);

                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for(int g = 0; g< rdr.FieldCount; g++) //Label columns
                            {
                                xlWorkSheet.Cells[1, g + 1] = rdr.GetOriginalName(g);
                            }
                            for (j = 0; j <= rdr.FieldCount - 1; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(j).ToString();
                                xlWorkSheet.Cells[i + 1, j + 1] = data;
                            }
                            i++;
                        }
                        xlWorkSheet.Name = rdr.GetTableName(0);
                    }
                }
                con.Close();
            }

            try
            {
                xlWorkBook.SaveAs(String.Format("{0}_ExcelDump-{1}-{2}.xls", table, DateTime.Now.ToShortDateString(), DateTime.Now.ToFileTime()).Replace("/", ""), Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }
            catch (System.Runtime.InteropServices.COMException)
            { }
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);


        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void custExport_Click(object sender, EventArgs e)
        {
            exportExcel("Order");
        }

        private void EmpExport_Click(object sender, EventArgs e)
        {
            exportExcel("Employee");
        }

        private void VendorExport_Click(object sender, EventArgs e)
        {
            exportExcel("Vendor");
        }

        private void ItemExport_Click(object sender, EventArgs e)
        {
            exportExcel("Item");
        }

        private void OrderExport_Click(object sender, EventArgs e)
        {
            exportExcel("Order");
        }

        private void UserExport_Click(object sender, EventArgs e)
        {
            exportExcel("Users");
        }

        //// Excel Test Export 
        //// Figure out how to export class name
        //private void CreateExcelFile(object data, string directory)
        //{
        //    directory = @"C:\Users\Nathan\Desktop\testexel.xlsx";
        //    using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(directory, SpreadsheetDocumentType.Workbook))
        //    {
        //        // Add a WorkbookPart to the document.
        //        WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
        //        workbookpart.Workbook = new Workbook();

        //        // Add a WorksheetPart to the WorkbookPart.
        //        WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
        //        worksheetPart.Worksheet = new Worksheet(new SheetData());

        //        // Add Sheets to the Workbook.
        //        Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
        //            AppendChild<Sheets>(new Sheets());


        //        MessageBox.Show(data.GetType().FullName);
        //        // Append a new worksheet and associate it with the workbook.
        //        Sheet sheet = new Sheet()
        //        {
        //            Id = spreadsheetDocument.WorkbookPart.
        //            GetIdOfPart(worksheetPart),
        //            SheetId = 1,
        //            Name = data.GetType().ToString()
        //        };
        //        sheets.Append(sheet);
        //        MessageBox.Show(data.GetType().ToString());

        //        workbookpart.Workbook.Save();

        //        // Close the document.
        //        spreadsheetDocument.Close();

        //    }
        //}
    }

}
