using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshCustomers();
            RefreshItems();
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
                if(dataCustomer.Rows.Count == i)
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

        //private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabControl2.SelectedTab == tabControl2.TabPages["Summary"])
        //    {
        //        RefreshCustomers();
        //    }
        //}

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
            foreach(Customer cust in custs)
            {
                ID_Name.Add(string.Format(cust.Cust_Id.ToString() + " - " + cust.Customer_FirstName + " " + cust.Customer_LastName));
            }
            String[] arrays = ID_Name.ToArray();
            cbOrderCustomer.Items.AddRange(arrays);
        }

        private void CheckShippingBilling_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShippingBilling.Checked)
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
                
                if(checkShippingBilling.Checked)
                {
                    tbOrderShippingStreet.Text = tbOrderBillingStreet.Text;
                    tbOrderShippingCity.Text = tbOrderBillingCity.Text;
                    tbOrderShippingState.Text = tbOrderBillingState.Text;
                    tbOrderShippingZip.Text = tbOrderBillingZip.Text;
                }

            
        }
    }
    
}
