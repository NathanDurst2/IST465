using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ERP
{
    public class SqliteDataAccess
    {
        public static List<Customer> LoadAllCustomer()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Customer> c = cnn.Query<Customer>("select * from Customer").ToList();
                return c;
            }
        }
        public static List<Customer> LoadCustomer(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Customer> c = cnn.Query<Customer>(String.Format("select * from Customer where Cust_ID = {0}", id)).ToList();
                return c;
            }
        }
        public static List<Item> LoadItem(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Item> c = cnn.Query<Item>(String.Format("select * from Item where Item_Number = \"{0}\"", id)).ToList();
                return c;
            }
        }
        public static void SaveCustomer(Customer c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customer (Customer_FirstName, Customer_LastName, Customer_Street, Customer_City, Customer_State, Customer_Zip, Customer_Phone, Customer_Email, Employee_ID) values (@Customer_FirstName, @Customer_LastName, @Customer_Street, @Customer_City, @Customer_State, @Customer_Zip, @Customer_Phone, @Customer_Email, @Employee_ID)", c);
            }
        }
        public static void EditCustomer(Customer c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Customer SET Customer_FirstName = @Customer_FirstName, Customer_LastName = @Customer_LastName, Customer_Street = @Customer_Street, Customer_City = @Customer_City, Customer_State = @Customer_State, Customer_Zip = @Customer_Zip, Customer_Phone = @Customer_Phone, Customer_Email = @Customer_Email, Employee_ID = @Employee_ID WHERE Cust_ID = @Cust_ID", c);
            }
        }
        public static void DeleteCustomer(string Cust_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Customer WHERE Cust_ID = {0}", Cust_ID));
            }
        }
        public  static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<Employee> LoadAllEmployee()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Employee> c = cnn.Query<Employee>("select * from Employee").ToList();
                return c;
            }
        }
        public static List<Item> LoadAllItem()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Item> c = cnn.Query<Item>("select * from Item").ToList();
                return c;
            }
        }
        public static List<Vendor> LoadAllVendor()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Vendor> c = cnn.Query<Vendor>("select * from Vendor").ToList();
                return c;
            }
        }
        public static List<Estimate> LoadAllEstimate()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Estimate> c = cnn.Query<Estimate>("select * from Estimate").ToList();
                return c;
            }
        }
        public static List<SalesOrder> LoadAllSalesOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<SalesOrder> c = cnn.Query<SalesOrder>("select * from SalesOrder").ToList();
                return c;
            }
        }
        public static List<SalesOrder_Item> LoadSalesOrder_ItemFOR(int saleID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<SalesOrder_Item> c = cnn.Query<SalesOrder_Item>(string.Format("select * from SalesOrder_Item where Sales_ID = {0}", saleID)).ToList();
                return c;
            }
        }
        public static List<Estimate_Item> LoadEstimate_ItemFOR(int estimateID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Estimate_Item> c = cnn.Query<Estimate_Item>(string.Format("select * from Estimate_Item where Estimate_ID = {0}", estimateID)).ToList();
                return c;
            }
        }
        public static string AddEstimate(Estimate c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Estimate (Cust_ID, Employee_ID, Estimate_Date, Estimate_Subtotal, Estimate_Tax, Estimate_Total, Estimate_BillStreet, Estimate_BillCity, Estimate_BillState, Estimate_BillZip, Estimate_ShipStreet, Estimate_ShipCity, Estimate_ShipState, Estimate_ShipZip) values (@Cust_ID, @Employee_ID, @Estimate_Date, @Estimate_Subtotal, @Estimate_Tax, @Estimate_Total, @Estimate_BillStreet, @Estimate_BillCity, @Estimate_BillState, @Estimate_BillZip, @Estimate_ShipStreet, @Estimate_ShipCity, @Estimate_ShipState, @Estimate_ShipZip)", c);
                dynamic e = cnn.QueryFirst("SELECT seq FROM sqlite_sequence where name=\"Estimate\"");
                return e.seq.ToString();
            }
        }
        public static void AddSalesOrder(SalesOrder c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SalesOrder (Cust_ID, Employee_ID, Sales_Date, Sales_ShipDate, Sales_Subtotal, Sales_Tax, Sales_Total, Sales_BillStreet, Sales_BillCity, Sales_BillState, Sales_BillZip, Sales_ShipStreet, Sales_ShipCity, Sales_ShipState, Sales_ShipZip) values (@Cust_ID, @Employee_ID, @Sales_Date, @Sales_ShipDate, @Sales_Subtotal, @Sales_Tax, @Sales_Total, @Sales_BillStreet, @Sales_BillCity, @Sales_BillState, @Sales_BillZip, @Sales_ShipStreet, @Sales_ShipCity, @Sales_ShipState, @Sales_ShipZip)", c);
            }
        }
        public static void AddSalesOrder_Item(SalesOrder_Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SalesOrder_Item (Sales_ID, Item_Number) values (@Sales_ID, @Item_Number)", c);
            }
        }
        public static void AddEstimate_Item(Estimate_Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Estimate_Item (Estimate_ID, Item_Number) values (@Estimate_ID, @Item_Number)", c);

            }
        }
    }
}
