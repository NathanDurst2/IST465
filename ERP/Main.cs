using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RefreshCustomers();
            RefreshItems();
            RefreshVendors();
            RefreshEmployeee();
            RefreshOrders();
        }
        List<SelectedItems> selectedItems = new List<SelectedItems>();
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
            }
            if(tabControl.SelectedTab.Text == "Customers")
            {
                dataCustomer.ClearSelection();
                dataCustOrders.ClearSelection();
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
                dataItem.Rows[i].Cells["itemPurchasePrice"].Value = c[i].Item_PurchasePrice;
                dataItem.Rows[i].Cells["itemSellPrice"].Value = c[i].Item_SellPrice;
                dataItem.Rows[i].Cells["itemUPC"].Value = c[i].Item_UPC;
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
                Employee emp = SqliteDataAccess.LoadEmployee(c[i].Employee_Supervisor_ID)[0];
                dataEmployee.Rows[i].Cells["empID"].Value = c[i].Employee_Id;
                dataEmployee.Rows[i].Cells["empFirstName"].Value = c[i].Employee_FirstName;
                dataEmployee.Rows[i].Cells["empLastName"].Value = c[i].Employee_LastName;
                dataEmployee.Rows[i].Cells["empStreet"].Value = c[i].Employee_Street;
                dataEmployee.Rows[i].Cells["empCity"].Value = c[i].Employee_City;
                dataEmployee.Rows[i].Cells["empState"].Value = c[i].Employee_State;
                dataEmployee.Rows[i].Cells["empZip"].Value = c[i].Employee_Zip;
                dataEmployee.Rows[i].Cells["empPhone"].Value = c[i].Employee_Phone;
                dataEmployee.Rows[i].Cells["empEmail"].Value = c[i].Employee_Email;
                dataEmployee.Rows[i].Cells["empSupervisorID"].Value = String.Format(c[i].Employee_Supervisor_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
            }
        }
        private void RefreshOrders()
        {
            dataOrder.Rows.Clear();
            dataOrder.DataSource = null;
            List<Estimate> c = new List<Estimate>();
            c = SqliteDataAccess.LoadAllEstimate();

            List<SalesOrder> s = new List<SalesOrder>();
            s = SqliteDataAccess.LoadAllSalesOrder();

            int neededRows = c.Count + s.Count;
            if (neededRows > 0)
            {
                dataOrder.Rows.Add();
                if (neededRows >= 2)
                {
                    dataOrder.Rows.AddCopies(0, neededRows - 1);
                }
            }

            int y = 0;
            for (int i = 0; i < c.Count + s.Count; i++, y++)
            {

                if (y < c.Count)
                {
                    Customer cust = SqliteDataAccess.LoadCustomer(c[y].Cust_ID)[0];
                    Employee emp = SqliteDataAccess.LoadEmployee(c[y].Employee_ID)[0];
                    dataOrder.Rows[i].Cells["orderID"].Value = c[y].Estimate_ID;
                    dataOrder.Rows[i].Cells["orderCustomer"].Value = String.Format(c[y].Cust_ID.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName);
                    dataOrder.Rows[i].Cells["orderType"].Value = "Estimate";
                    dataOrder.Rows[i].Cells["orderDate"].Value = c[y].Estimate_Date;
                    dataOrder.Rows[i].Cells["orderShipDate"].Value = "-";
                    dataOrder.Rows[i].Cells["orderTotal"].Value = Math.Round(c[y].Estimate_Total, 2);
                    dataOrder.Rows[i].Cells["orderSalesRep"].Value = String.Format(c[y].Employee_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
                    dataOrder.Rows[i].Cells["orderShippingStreet"].Value = c[y].Estimate_ShipStreet;
                    dataOrder.Rows[i].Cells["orderShippingCity"].Value = c[y].Estimate_ShipCity;
                    dataOrder.Rows[i].Cells["orderShippingState"].Value = c[y].Estimate_ShipState;
                    dataOrder.Rows[i].Cells["orderShippingZip"].Value = c[y].Estimate_ShipZip;
                }

                if (y < s.Count)
                {
                    if (y < c.Count)
                    {
                        i++;
                    }
                    Customer cust = SqliteDataAccess.LoadCustomer(s[y].Cust_ID)[0];
                    Employee emp = SqliteDataAccess.LoadEmployee(s[y].Employee_ID)[0];
                    dataOrder.Rows[i].Cells["orderID"].Value = s[y].Sales_ID;
                    dataOrder.Rows[i].Cells["orderCustomer"].Value = String.Format(s[y].Cust_ID.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName);
                    dataOrder.Rows[i].Cells["orderType"].Value = "Sales Order";
                    dataOrder.Rows[i].Cells["orderDate"].Value = s[y].Sales_Date;
                    dataOrder.Rows[i].Cells["orderTotal"].Value = Math.Round(s[y].Sales_Total, 2);
                    dataOrder.Rows[i].Cells["orderShipDate"].Value = s[y].Sales_ShipDate;
                    dataOrder.Rows[i].Cells["orderSalesRep"].Value = String.Format(s[y].Employee_ID.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName);
                    dataOrder.Rows[i].Cells["orderShippingStreet"].Value = s[y].Sales_ShipStreet;
                    dataOrder.Rows[i].Cells["orderShippingCity"].Value = s[y].Sales_ShipCity;
                    dataOrder.Rows[i].Cells["orderShippingState"].Value = s[y].Sales_ShipState;
                    dataOrder.Rows[i].Cells["orderShippingZip"].Value = s[y].Sales_ShipZip;
                }
            }

        }
        private void RefreshOrderItems()
        {
            dataOrderItems.Rows.Clear();
            dataOrderItems.DataSource = null;
            string orderType = "";
            int id = Convert.ToInt32(dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderID"].Value);
            try
            {
                orderType = dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderType"].Value.ToString();
            }
            catch (NullReferenceException)
            { }



            if (orderType == "Estimate")
            {

                List<Estimate_Item> c = SqliteDataAccess.LoadEstimate_ItemFOR(id);

                selectedItems = new List<SelectedItems>();

                foreach (Estimate_Item estItem in c)
                {
                    SelectedItems si = new SelectedItems();
                    si.Item_Number = estItem.Item_Number;
                    si.Item_Quantity = Convert.ToInt32(estItem.Estimate_Item_Quantity);
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
                    dataOrderItems.Rows[i].Cells["orderItemQuantity"].Value = c[i].Estimate_Item_Quantity;
                    dataOrderItems.Rows[i].Cells["orderItemPrice"].Value = items[0].Item_SellPrice;
                }
            }
            else if (orderType == "Sales Order")
            {
                List<SalesOrder_Item> c = SqliteDataAccess.LoadSalesOrder_ItemFOR(id);

                selectedItems = new List<SelectedItems>();

                foreach (SalesOrder_Item estItem in c)
                {
                    SelectedItems si = new SelectedItems();
                    si.Item_Number = estItem.Item_Number;
                    si.Item_Quantity = Convert.ToInt32(estItem.SalesOrder_Item_Quantity);
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
                    dataOrderItems.Rows[i].Cells["orderItemQuantity"].Value = c[i].SalesOrder_Item_Quantity;
                    dataOrderItems.Rows[i].Cells["orderItemPrice"].Value = items[0].Item_SellPrice;
                }
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
            List<Estimate> estimates = SqliteDataAccess.LoadEstimateFromCustID(id);
            List<SalesOrder> salesOrders = SqliteDataAccess.LoadSalesOrderFromCustID(id);
            int count = 0;
            foreach(Estimate est in estimates)
            {
                dataCustOrders.Rows.Add();
                dataCustOrders.Rows[count].Cells["custOrdersID"].Value = est.Estimate_ID.ToString();
                dataCustOrders.Rows[count].Cells["custOrdersType"].Value = "Estimate";
                dataCustOrders.Rows[count].Cells["custOrdersDate"].Value = est.Estimate_Date;
                dataCustOrders.Rows[count].Cells["custOrdersShipDate"].Value = "-";
                dataCustOrders.Rows[count].Cells["custOrdersTotal"].Value = est.Estimate_Total.ToString();
                count++;
            }
            foreach (SalesOrder est in salesOrders)
            {
                dataCustOrders.Rows.Add();
                dataCustOrders.Rows[count].Cells["custOrdersID"].Value = est.Sales_ID.ToString();
                dataCustOrders.Rows[count].Cells["custOrdersType"].Value = "Sales Order";
                dataCustOrders.Rows[count].Cells["custOrdersDate"].Value = est.Sales_Date;
                dataCustOrders.Rows[count].Cells["custOrdersShipDate"].Value = est.Sales_ShipDate;
                dataCustOrders.Rows[count].Cells["custOrdersTotal"].Value = est.Sales_Total.ToString();
                count++;
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
            if (tbFirstName.Text != "")
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
        }

        private void BtCustEdit_Click(object sender, EventArgs e)
        {
            int Cust_ID = (int)dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value;

            Customer cust = SqliteDataAccess.LoadCustomer(Cust_ID)[0];

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
            if (tbFirstName.Text != "")
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
        }

        private void CbCustSalesRep_Click(object sender, EventArgs e)
        {
            cbCustSalesRep.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbCustSalesRep.Items.AddRange(arrays);
        }
        private void CbOrderCustomer_Click(object sender, EventArgs e)
        {
            cbOrderCustomer.Items.Clear();
            List<Customer> custs = SqliteDataAccess.LoadAllCustomer();
            List<String> ID_Name = new List<String>();
            foreach (Customer cust in custs)
            {
                ID_Name.Add(string.Format(cust.Cust_Id.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbOrderCustomer.Items.AddRange(arrays);
        }
        private void cbEmpSupervisor_Click(object sender, EventArgs e)
        {
            cbEmpSupervisor.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbEmpSupervisor.Items.AddRange(arrays);
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
            cbOrderSalesRep.Items.Clear();
            List<Employee> emps = SqliteDataAccess.LoadAllEmployee();
            List<String> ID_Name = new List<String>();
            foreach (Employee emp in emps)
            {
                ID_Name.Add(String.Format(emp.Employee_Id.ToString() + " - " + emp.Employee_FirstName + " " + emp.Employee_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbOrderSalesRep.Items.AddRange(arrays);
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
            if (cbOrderType.Text == "Estimate")
            {
                Estimate est = new Estimate();

                string emp = cbOrderSalesRep.Text;
                int emp_id = Convert.ToInt32(emp.Substring(0, emp.IndexOf(" -")));

                string cust = cbOrderCustomer.Text;
                int cust_id = Convert.ToInt32(cust.Substring(0, cust.IndexOf(" -")));

                est.Cust_ID = cust_id;
                est.Employee_ID = emp_id;
                est.Estimate_Date = DateTime.Today.ToShortDateString();
                double subTotal = 0;
                foreach (SelectedItems si in selectedItems)
                    subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);

                est.Estimate_Subtotal = subTotal;
                est.Estimate_Tax = (subTotal * 0.07);
                est.Estimate_Total = (est.Estimate_Subtotal + est.Estimate_Tax);
                est.Estimate_BillStreet = tbOrderBillingStreet.Text;
                est.Estimate_BillCity = tbOrderBillingCity.Text;
                est.Estimate_BillState = tbOrderBillingState.Text;
                est.Estimate_BillZip = tbOrderBillingZip.Text;
                est.Estimate_ShipStreet = tbOrderShippingStreet.Text;
                est.Estimate_ShipCity = tbOrderShippingCity.Text;
                est.Estimate_ShipState = tbOrderShippingState.Text;
                est.Estimate_ShipZip = tbOrderShippingZip.Text;

                string est_id = SqliteDataAccess.AddEstimate(est);
                RefreshOrders();

                foreach (SelectedItems it in selectedItems)
                {
                    Estimate_Item ei = new Estimate_Item();
                    ei.Estimate_ID = Convert.ToInt32(est_id);
                    ei.Item_Number = it.Item_Number;
                    ei.Estimate_Item_Quantity = it.Item_Quantity.ToString();

                    SqliteDataAccess.AddEstimate_Item(ei);
                }
                //Clears out the list of items so that the next order is empty
                selectedItems = new List<SelectedItems>();
            }
            else if (cbOrderType.Text.StartsWith("Sales"))
            {
                SalesOrder est = new SalesOrder();

                string emp = cbOrderSalesRep.Text;
                int emp_id = Convert.ToInt32(emp.Substring(0, emp.IndexOf(" -")));

                string cust = cbOrderCustomer.Text;
                int cust_id = Convert.ToInt32(cust.Substring(0, cust.IndexOf(" -")));

                est.Cust_ID = cust_id;
                est.Employee_ID = emp_id;
                est.Sales_Date = DateTime.Today.ToShortDateString();
                est.Sales_ShipDate = DateTime.Today.AddDays(2).ToShortDateString();
                double subTotal = 0;
                foreach (SelectedItems si in selectedItems)
                    subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);

                est.Sales_Subtotal = subTotal;
                est.Sales_Tax = (subTotal * 0.07);
                est.Sales_Total = (est.Sales_Subtotal + est.Sales_Tax);
                est.Sales_BillStreet = tbOrderBillingStreet.Text;
                est.Sales_BillCity = tbOrderBillingCity.Text;
                est.Sales_BillState = tbOrderBillingState.Text;
                est.Sales_BillZip = tbOrderBillingZip.Text;
                est.Sales_ShipStreet = tbOrderShippingStreet.Text;
                est.Sales_ShipCity = tbOrderShippingCity.Text;
                est.Sales_ShipState = tbOrderShippingState.Text;
                est.Sales_ShipZip = tbOrderShippingZip.Text;

                string est_id = SqliteDataAccess.AddSalesOrder(est);
                RefreshOrders();

                foreach (SelectedItems it in selectedItems)
                {
                    SalesOrder_Item ei = new SalesOrder_Item();
                    ei.Sales_ID = Convert.ToInt32(est_id);
                    ei.Item_Number = it.Item_Number;
                    ei.SalesOrder_Item_Quantity = it.Item_Quantity;

                    SqliteDataAccess.AddSalesOrder_Item(ei);
                }
                //Clears out the list of items so that the next order is empty
                selectedItems = new List<SelectedItems>();
            }
            BtOrderClear_Click(null, null);
            orderButtonsDisable();
        }

        private void BtOrderSave_Click(object sender, EventArgs e)
        {
            orderButtonsDisable();
            if (cbOrderCustomer != null)
            {
                string orderType = cbOrderType.Text;
                if (orderType == "Estimate")
                {
                    Estimate es = new Estimate();
                    es.Estimate_ID = Convert.ToInt32(tbOrderID.Text); tbOrderID.Clear();
                    es.Cust_ID = Convert.ToInt32(cbOrderCustomer.Text.Substring(0, cbOrderCustomer.Text.IndexOf(" -"))); cbOrderCustomer.Items.Clear();
                    es.Employee_ID = Convert.ToInt32(cbOrderSalesRep.Text.Substring(0, cbOrderSalesRep.Text.IndexOf(" -"))); cbOrderSalesRep.Items.Clear();
                    es.Estimate_Date = DateTime.Today.ToShortDateString();

                    double subTotal = 0;
                    foreach (SelectedItems si in selectedItems)
                        subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);
                    es.Estimate_Subtotal = subTotal;
                    es.Estimate_Tax = subTotal * 0.07;
                    es.Estimate_Total = es.Estimate_Subtotal + es.Estimate_Tax;
                    cbOrderType.SelectedIndex = -1;
                    checkShippingBilling.Checked = false;
                    es.Estimate_BillStreet = tbOrderBillingStreet.Text; tbOrderBillingStreet.Clear();
                    es.Estimate_BillCity = tbOrderBillingCity.Text; tbOrderBillingCity.Clear();
                    es.Estimate_BillState = tbOrderBillingState.Text; tbOrderBillingState.Clear();
                    es.Estimate_BillZip = tbOrderBillingZip.Text; tbOrderBillingZip.Clear();
                    es.Estimate_ShipStreet = tbOrderShippingStreet.Text; tbOrderShippingStreet.Clear();
                    es.Estimate_ShipCity = tbOrderShippingCity.Text; tbOrderShippingCity.Clear();
                    es.Estimate_ShipState = tbOrderShippingState.Text; tbOrderShippingState.Clear();
                    es.Estimate_ShipZip = tbOrderShippingZip.Text; tbOrderShippingZip.Clear();
                    SqliteDataAccess.DeleteEstimate_Item(es.Estimate_ID);
                    SqliteDataAccess.EditEstimate(es);
                    foreach (SelectedItems it in selectedItems)
                    {
                        Estimate_Item ei = new Estimate_Item();
                        ei.Estimate_ID = Convert.ToInt32(es.Estimate_ID);
                        ei.Item_Number = it.Item_Number;
                        ei.Estimate_Item_Quantity = it.Item_Quantity.ToString();

                        SqliteDataAccess.AddEstimate_Item(ei);
                    }
                    RefreshOrders();
                    RefreshOrderItems();
                    btOrderSave.Visible = false;
                    btOrderSave.SendToBack();

                }
                else if (orderType == "Sales Order")
                {
                    SalesOrder es = new SalesOrder();
                    es.Sales_ID = Convert.ToInt32(tbOrderID.Text); tbOrderID.Clear();
                    es.Cust_ID = Convert.ToInt32(cbOrderCustomer.Text.Substring(0, cbOrderCustomer.Text.IndexOf(" -"))); cbOrderCustomer.Items.Clear();
                    es.Employee_ID = Convert.ToInt32(cbOrderSalesRep.Text.Substring(0, cbOrderSalesRep.Text.IndexOf(" -"))); cbOrderSalesRep.Items.Clear();
                    es.Sales_Date = DateTime.Today.ToShortDateString();
                    // Fix
                    es.Sales_ShipDate = DateTime.Today.ToShortDateString();

                    double subTotal = 0;
                    foreach (SelectedItems si in selectedItems)
                        subTotal += (si.Item_Quantity * SqliteDataAccess.LoadItem(si.Item_Number)[0].Item_SellPrice);
                    es.Sales_Subtotal = subTotal;
                    es.Sales_Tax = subTotal * 0.07;
                    es.Sales_Total = es.Sales_Subtotal + es.Sales_Tax;
                    cbOrderType.SelectedIndex = -1;
                    checkShippingBilling.Checked = false;
                    es.Sales_BillStreet = tbOrderBillingStreet.Text; tbOrderBillingStreet.Clear();
                    es.Sales_BillCity = tbOrderBillingCity.Text; tbOrderBillingCity.Clear();
                    es.Sales_BillState = tbOrderBillingState.Text; tbOrderBillingState.Clear();
                    es.Sales_BillZip = tbOrderBillingZip.Text; tbOrderBillingZip.Clear();
                    es.Sales_ShipStreet = tbOrderShippingStreet.Text; tbOrderShippingStreet.Clear();
                    es.Sales_ShipCity = tbOrderShippingCity.Text; tbOrderShippingCity.Clear();
                    es.Sales_ShipState = tbOrderShippingState.Text; tbOrderShippingState.Clear();
                    es.Sales_ShipZip = tbOrderShippingZip.Text; tbOrderShippingZip.Clear();
                    SqliteDataAccess.DeleteSalesOrder_Item(es.Sales_ID);
                    SqliteDataAccess.EditSalesOrder(es);
                    foreach (SelectedItems it in selectedItems)
                    {
                        SalesOrder_Item ei = new SalesOrder_Item();
                        ei.Sales_ID = Convert.ToInt32(es.Sales_ID);
                        ei.Item_Number = it.Item_Number;
                        ei.SalesOrder_Item_Quantity = it.Item_Quantity;

                        SqliteDataAccess.AddSalesOrder_Item(ei);
                    }
                    RefreshOrders();
                    RefreshOrderItems();
                    btOrderSave.Visible = false;
                    btOrderSave.SendToBack();
                }
                else
                {
                    MessageBox.Show("Missing order type");
                }
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

        private void BtOrderEdit_Click(object sender, EventArgs e)
        {
            orderButtonsEnable();
            btOrderNew.Visible = false;

            int orderID = (int)dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderID"].Value;
            string orderType = "";
            try
            {
                orderType = dataOrder.Rows[dataOrder.CurrentCell.RowIndex].Cells["orderType"].Value.ToString();
            }
            catch (NullReferenceException)
            { }

            if (orderType == "Estimate")
            {
                List<Estimate> estList = SqliteDataAccess.LoadEstimate(orderID);
                Estimate est = estList[0];
                List<Estimate_Item> itemList = SqliteDataAccess.LoadEstimate_ItemFOR(est.Estimate_ID);
                CbOrderCustomer_Click(null, null);
                selectedItems = new List<SelectedItems>();

                foreach (Estimate_Item estItem in itemList)
                {
                    SelectedItems si = new SelectedItems();
                    si.Item_Number = estItem.Item_Number;
                    si.Item_Quantity = Convert.ToInt32(estItem.Estimate_Item_Quantity);
                    si.Vendor_ID = SqliteDataAccess.LoadItem(si.Item_Number.ToString())[0].Vendor_ID;
                    selectedItems.Add(si);
                }

                tbOrderID.Text = est.Estimate_ID.ToString();
                cbOrderCustomer.SelectedIndex = cbOrderCustomer.FindString(est.Cust_ID.ToString());
                cbOrderType.SelectedIndex = cbOrderType.FindString("Estimate");
                tbOrderBillingStreet.Text = est.Estimate_BillStreet;
                tbOrderBillingCity.Text = est.Estimate_BillCity;
                tbOrderBillingState.Text = est.Estimate_BillState;
                tbOrderShippingZip.Text = est.Estimate_ShipZip;
                tbOrderShippingStreet.Text = est.Estimate_ShipStreet;
                tbOrderShippingCity.Text = est.Estimate_ShipCity;
                tbOrderShippingState.Text = est.Estimate_ShipState;
                tbOrderShippingZip.Text = est.Estimate_ShipZip;
                btOrderSave.Visible = true;
                btOrderSave.BringToFront();
            }

            if (orderType == "Sales Order")
            {
                List<SalesOrder> estList = SqliteDataAccess.LoadSalesOrder(orderID);
                SalesOrder est = estList[0];
                List<SalesOrder_Item> itemList = SqliteDataAccess.LoadSalesOrder_ItemFOR(est.Sales_ID);
                CbOrderCustomer_Click(null, null);
                selectedItems = new List<SelectedItems>();

                foreach (SalesOrder_Item estItem in itemList)
                {
                    SelectedItems si = new SelectedItems();
                    si.Item_Number = estItem.Item_Number;
                    si.Item_Quantity = Convert.ToInt32(estItem.SalesOrder_Item_Quantity);
                    si.Vendor_ID = SqliteDataAccess.LoadItem(si.Item_Number.ToString())[0].Vendor_ID;
                    selectedItems.Add(si);
                }

                tbOrderID.Text = est.Sales_ID.ToString();
                cbOrderCustomer.SelectedIndex = cbOrderCustomer.FindString(est.Cust_ID.ToString());
                cbOrderType.SelectedIndex = cbOrderType.FindString("Sales Order");
                tbOrderBillingStreet.Text = est.Sales_BillStreet;
                tbOrderBillingCity.Text = est.Sales_BillCity;
                tbOrderBillingState.Text = est.Sales_BillState;
                tbOrderShippingZip.Text = est.Sales_ShipZip;
                tbOrderShippingStreet.Text = est.Sales_ShipStreet;
                tbOrderShippingCity.Text = est.Sales_ShipCity;
                tbOrderShippingState.Text = est.Sales_ShipState;
                tbOrderShippingZip.Text = est.Sales_ShipZip;
                btOrderSave.Visible = true;
                btOrderSave.BringToFront();
            }
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

            if (orderType == "Estimate")
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this order?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqliteDataAccess.DeleteEstimate(id);
                    SqliteDataAccess.DeleteEstimate_Item(id);
                    RefreshOrders();
                    RefreshOrderItems();
                }
                
            }
            else if (orderType == "Sales Order")
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this order?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqliteDataAccess.DeleteSalesOrder(id);
                    SqliteDataAccess.DeleteSalesOrder_Item(id);
                    RefreshOrders();
                    RefreshOrderItems();
                }
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
            emp.Employee_Supervisor_ID = Convert.ToInt32(supervisor.Substring(0, supervisor.IndexOf(" -")));
            SqliteDataAccess.AddEmployee(emp);
            BtEmpClear_Click(null, null);
            RefreshEmployeee();
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
            emp.Employee_Supervisor_ID = Convert.ToInt32(supervisor.Substring(0, supervisor.IndexOf(" -")));
            SqliteDataAccess.EditEmployee(emp);
            btEmpSave.Visible = false;
            BtEmpClear_Click(null, null);
            RefreshEmployeee();
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
            ven.Vendor_Terms = cbVendorTerms.SelectedIndex.ToString();
            SqliteDataAccess.AddVendor(ven);
            RefreshVendors();
            BtVendorClear_Click(null, null);
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
    }

}
