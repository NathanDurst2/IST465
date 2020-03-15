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
            //this.tabControl2.SelectedIndexChanged += this.tabControl2_SelectedIndexChanged;


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
                dataCustomer.Rows[i].Cells["Cust_ID"].Value = c[i].Cust_Id;
                dataCustomer.Rows[i].Cells["cFirstName"].Value = c[i].Customer_FirstName;
                dataCustomer.Rows[i].Cells["cLastName"].Value = c[i].Customer_LastName;
                dataCustomer.Rows[i].Cells["cStreet"].Value = c[i].Customer_Street;
                dataCustomer.Rows[i].Cells["cCity"].Value = c[i].Customer_City;
                dataCustomer.Rows[i].Cells["cState"].Value = c[i].Customer_State;
                dataCustomer.Rows[i].Cells["cZip"].Value = c[i].Customer_Zip;
                dataCustomer.Rows[i].Cells["cPhone"].Value = c[i].Customer_Phone;
                dataCustomer.Rows[i].Cells["cEmail"].Value = c[i].Customer_Email;
                dataCustomer.Rows[i].Cells["cSales_Rep"].Value = c[i].Employee_ID;
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
                dataItem.Rows[i].Cells["itemNumber"].Value = c[i].Item_Number;
                dataItem.Rows[i].Cells["itemVendorID"].Value = c[i].Vendor_ID;
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
                dataEmployee.Rows[i].Cells["empID"].Value = c[i].Employee_Id;
                dataEmployee.Rows[i].Cells["empFirstName"].Value = c[i].Employee_FirstName;
                dataEmployee.Rows[i].Cells["empLastName"].Value = c[i].Employee_FirstName;
                dataEmployee.Rows[i].Cells["empStreet"].Value = c[i].Employee_Street;
                dataEmployee.Rows[i].Cells["empCity"].Value = c[i].Employee_City;
                dataEmployee.Rows[i].Cells["empState"].Value = c[i].Employee_State;
                dataEmployee.Rows[i].Cells["empZip"].Value = c[i].Employee_Zip;
                dataEmployee.Rows[i].Cells["empPhone"].Value = c[i].Employee_Phone;
                dataEmployee.Rows[i].Cells["empEmail"].Value = c[i].Employee_Email;
                dataEmployee.Rows[i].Cells["empSupervisorID"].Value = c[i].Employee_Supervisor_ID;
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
            if(neededRows > 0)
            {
                dataOrder.Rows.Add();
                if(neededRows >= 2)
                {
                    dataOrder.Rows.AddCopies(0, neededRows - 1);
                }
            }

            int y = 0;
            for (int i = 0; i < c.Count + s.Count; i++, y++)
            {
                
                if (y < c.Count)
                {
                    dataOrder.Rows[i].Cells["orderID"].Value = c[y].Estimate_ID;
                    dataOrder.Rows[i].Cells["orderCustomer"].Value = c[y].Cust_ID;
                    dataOrder.Rows[i].Cells["orderType"].Value = "Estimate";
                    dataOrder.Rows[i].Cells["orderDate"].Value = c[y].Estimate_Date;
                    dataOrder.Rows[i].Cells["orderSalesRep"].Value = c[y].Employee_ID;
                    dataOrder.Rows[i].Cells["orderShippingStreet"].Value = c[y].Estimate_ShipStreet;
                    dataOrder.Rows[i].Cells["orderShippingCity"].Value = c[y].Estimate_ShipCity;
                    dataOrder.Rows[i].Cells["orderShippingState"].Value = c[y].Estimate_ShipState;
                    dataOrder.Rows[i].Cells["orderShippingZip"].Value = c[y].Estimate_ShipZip;
                }
                
                if (y < s.Count)
                {
                    if(y < c.Count)
                    {
                        i++;
                    }
                    dataOrder.Rows[i].Cells["orderID"].Value = s[y].Sales_ID;
                    dataOrder.Rows[i].Cells["orderCustomer"].Value = s[y].Cust_ID;
                    dataOrder.Rows[i].Cells["orderType"].Value = "Sales Order";
                    dataOrder.Rows[i].Cells["orderDate"].Value = s[y].Sales_Date;
                    dataOrder.Rows[i].Cells["orderShipDate"].Value = s[y].Sales_ShipDate;
                    dataOrder.Rows[i].Cells["orderSalesRep"].Value = s[y].Employee_ID;
                    dataOrder.Rows[i].Cells["orderShippingStreet"].Value = s[y].Sales_ShipStreet;
                    dataOrder.Rows[i].Cells["orderShippingCity"].Value = s[y].Sales_ShipCity;
                    dataOrder.Rows[i].Cells["orderShippingState"].Value = s[y].Sales_ShipState;
                    dataOrder.Rows[i].Cells["orderShippingZip"].Value = s[y].Sales_ShipZip;
                }
            }

            //int lastRow = dataOrder.Rows.GetLastRow(DataGridViewElementStates.Visible);
            //for (int i = lastRow; i < s.Count; i++)
            //{
            //    if (dataOrder.Rows.Count == i)
            //    {
            //        dataOrder.Rows.Add();
            //    }
            //    dataOrder.Rows[i].Cells["orderID"].Value = s[i].Sales_ID;
            //    dataOrder.Rows[i].Cells["orderCustomer"].Value = s[i].Cust_ID;
            //    dataOrder.Rows[i].Cells["orderType"].Value = "Sales Order";
            //    dataOrder.Rows[i].Cells["orderDate"].Value = s[i].Sales_Date;
            //    dataOrder.Rows[i].Cells["orderShipDate"].Value = s[i].Sales_ShipDate;
            //    dataOrder.Rows[i].Cells["orderSalesRep"].Value = s[i].Employee_ID;
            //    dataOrder.Rows[i].Cells["orderShippingStreet"].Value = s[i].Sales_ShipStreet;
            //    dataOrder.Rows[i].Cells["orderShippingCity"].Value = s[i].Sales_ShipCity;
            //    dataOrder.Rows[i].Cells["orderShippingState"].Value = s[i].Sales_ShipState;
            //    dataOrder.Rows[i].Cells["orderShippingZip"].Value = s[i].Sales_ShipZip;

            //}

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
        bool newOrder = false;
        List<Item> selectedItems;
        public void BtOrderManageItems_Click(object sender, EventArgs e)
        {
            ManageItems mi;
            if (newOrder)
            {
                mi = new ManageItems(new List<Item>());
            }
            else
            {

                mi = new ManageItems(new List<Item>());
            }

            mi.ShowDialog();
            selectedItems = mi.selectedItems;

            if(selectedItems.Count > 0)
            {
                dataOrderItems.Rows.Add();
                if(selectedItems.Count >= 2)
                {
                    dataOrderItems.Rows.AddCopies(0, selectedItems.Count - 1);
                }
            }
            

        }

        private void BtOrderAdd_Click(object sender, EventArgs e)
        {
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
                est.Estimate_Subtotal = 0;
                est.Estimate_Tax = 0;
                est.Estimate_Total = 0;
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

                foreach(Item it in selectedItems)
                {
                    Estimate_Item ei = new Estimate_Item();

                    ei.Estimate_ID = Convert.ToInt32(est_id);
                    ei.Item_Number = it.Item_Number;

                    SqliteDataAccess.AddEstimate_Item(ei);
                }
                selectedItems = new List<Item>();
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
                est.Sales_Subtotal = 0;
                est.Sales_Tax = 0;
                est.Sales_Total = 0;
                est.Sales_BillStreet = tbOrderBillingStreet.Text;
                est.Sales_BillCity = tbOrderBillingCity.Text;
                est.Sales_BillState = tbOrderBillingState.Text;
                est.Sales_BillZip = tbOrderBillingZip.Text;
                est.Sales_ShipStreet = tbOrderShippingStreet.Text;
                est.Sales_ShipCity = tbOrderShippingCity.Text;
                est.Sales_ShipState = tbOrderShippingState.Text;
                est.Sales_ShipZip = tbOrderShippingZip.Text;

                SqliteDataAccess.AddSalesOrder(est);
                RefreshOrders();
            }
        }

        private void BtOrderSave_Click(object sender, EventArgs e)
        {

        }
    }

}
