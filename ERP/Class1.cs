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
// Sean Testing
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
        public static void SaveCustomer(Customer c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customer (Customer_FirstName, Customer_LastName, Customer_Address, Customer_Phone, Customer_Email, Employee_ID) values (@Customer_FirstName, @Customer_LastName, @Customer_Address, @Customer_Phone, @Customer_Email, @Employee_ID)", c);
            }
        }
        public static void EditCustomer(Customer c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Customer SET Customer_FirstName = @Customer_FirstName, Customer_LastName = @Customer_LastName, Customer_Address = @Customer_Address, Customer_Phone = @Customer_Phone, Customer_Email = @Customer_Email, Employee_ID = @Employee_ID WHERE Cust_ID = @Cust_ID", c);
            }
        }
        public static void DeleteCustomer(string Cust_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Customer WHERE Cust_ID = {0}", Cust_ID));
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
