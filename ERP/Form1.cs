using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hi
namespace ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshAllData();
           //this.tabControl2.SelectedIndexChanged += this.tabControl2_SelectedIndexChanged;
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
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
                dataCustomer.Rows[i].Cells["cStreet"].Value = c[i].Customer_Street;
                dataCustomer.Rows[i].Cells["cCity"].Value = c[i].Customer_City;
                dataCustomer.Rows[i].Cells["cState"].Value = c[i].Customer_State;
                dataCustomer.Rows[i].Cells["cZip"].Value = c[i].Customer_Zip;
                dataCustomer.Rows[i].Cells["cPhone"].Value = c[i].Customer_Phone;
                dataCustomer.Rows[i].Cells["cEmail"].Value = c[i].Customer_Email;
                dataCustomer.Rows[i].Cells["cSales_Rep"].Value = c[i].Employee_ID;
            }
        }

        //private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabControl2.SelectedTab == tabControl2.TabPages["Summary"])
        //    {
        //        RefreshAllData();
        //    }
        //}

        private void BtCustClear_Click_1(object sender, EventArgs e)
        {
            tbCustID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbCustStreet.Clear();
            tbCustCity.Clear();
            tbCustState.Clear();
            tbCustZip.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbSalesRep.Clear();
        }

        private void BtCustRemove_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteCustomer(dataCustomer.Rows[dataCustomer.CurrentCell.RowIndex].Cells["Cust_ID"].Value.ToString());
            RefreshAllData();
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
                c.Employee_ID = Convert.ToInt32(tbSalesRep.Text); tbSalesRep.Clear();

                SqliteDataAccess.SaveCustomer(c);

                dataCustomer.DataSource = null;
                RefreshAllData();
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
            tbSalesRep.Text = cust.Employee_ID.ToString();

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
                c.Employee_ID = Convert.ToInt32(tbSalesRep.Text); tbSalesRep.Clear();

                SqliteDataAccess.EditCustomer(c);
                btCustSave.SendToBack();
                dataCustomer.DataSource = null;
                RefreshAllData();
            }
        }
    }
    
}
