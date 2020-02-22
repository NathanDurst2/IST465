using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshAllData();
            this.tabControl2.SelectedIndexChanged += this.tabControl2_SelectedIndexChanged;
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();

            c.Customer_FirstName = tbFirstName.Text; tbFirstName.Clear();
            c.Customer_LastName = tbLastName.Text; tbLastName.Clear();
            c.Customer_Address = tbAddress.Text; tbAddress.Clear();
            c.Customer_Phone = tbPhone.Text; tbPhone.Clear();
            c.Customer_Email = tbEmail.Text; tbEmail.Clear();
            c.Employee_ID = Convert.ToInt32(tbSalesRep.Text); tbSalesRep.Clear();

            SqliteDataAccess.SaveCustomer(c);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            RefreshAllData();
        }
        private void RefreshAllData()
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
                dataCustomer.Rows[i].Cells["cAddress"].Value = c[i].Customer_Address;
                dataCustomer.Rows[i].Cells["cPhone"].Value = c[i].Customer_Phone;
                dataCustomer.Rows[i].Cells["cEmail"].Value = c[i].Customer_Email;
                dataCustomer.Rows[i].Cells["cSales_Rep"].Value = c[i].Employee_ID;
            }
        }

        private void BtAddCust_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = Entry;
        }

        private void BtEditCust_Click(object sender, EventArgs e)
        {
            int Cust_ID = (int)dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value;
            Customer cust = SqliteDataAccess.LoadCustomer(Cust_ID)[0];

            tbCustID.Text = cust.Cust_Id.ToString();
            tbFirstName.Text = cust.Customer_FirstName;
            tbLastName.Text = cust.Customer_LastName;
            tbAddress.Text = cust.Customer_Address;
            tbPhone.Text = cust.Customer_Phone;
            tbEmail.Text = cust.Customer_Email;
            tbSalesRep.Text = cust.Employee_ID.ToString();

            btCustSave.Visible = true;
            btCustSave.BringToFront();

            tabControl2.SelectedTab = Entry;

        }

        private void BtCustSave_Click(object sender, EventArgs e)
        {
            if(tbFirstName.Text != "")
            {
                Customer c = new Customer();
                c.Cust_Id = Convert.ToInt32(tbCustID.Text);
                c.Customer_FirstName = tbFirstName.Text; tbFirstName.Clear();
                c.Customer_LastName = tbLastName.Text; tbLastName.Clear();
                c.Customer_Address = tbAddress.Text; tbAddress.Clear();
                c.Customer_Phone = tbPhone.Text; tbPhone.Clear();
                c.Customer_Email = tbEmail.Text; tbEmail.Clear();
                c.Employee_ID = Convert.ToInt32(tbSalesRep.Text); tbSalesRep.Clear();

                SqliteDataAccess.EditCustomer(c);
                btCustSave.SendToBack();
                tabControl2.SelectedTab = Summary;
                dataCustomer.DataSource = null;
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tabControl2.TabPages["Summary"])
            {
                RefreshAllData();
            }
        }

        private void BtCustClear_Click(object sender, EventArgs e)
        {
            tbCustID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbSalesRep.Clear();
        }

        private void BtRemoveCust_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteCustomer(dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value.ToString());
            RefreshAllData();
        }
    }
    public class Customer
    {
        public int Cust_Id { get; set; }
        public string Customer_FirstName { get; set; }
        public string Customer_LastName { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public int Employee_ID { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Supervisor_ID { get; set; }
    }
    
}
