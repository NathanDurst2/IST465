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
        public static List<PurchaseOrder> LoadPurchaseOrder(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<PurchaseOrder> c = cnn.Query<PurchaseOrder>(String.Format("select * from PurchaseOrder where PO_ID = {0}", id)).ToList();
                return c;
            }
        }
        public static List<Employee> LoadEmployee(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Employee> c = cnn.Query<Employee>(String.Format("select * from Employee where Employee_ID = {0}", id)).ToList();
                return c;
            }
        }
        public static List<Vendor> LoadVendor(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Vendor> c = cnn.Query<Vendor>(String.Format("select * from Vendor where Vendor_ID = {0}", id)).ToList();
                return c;
            }
        }
        public static List<Order> LoadOrder(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Order> c = cnn.Query<Order>(String.Format("select * from [Order] where Order_ID = {0}", id)).ToList();
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
        public static List<Item> LoadVendorItem(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Item> c = cnn.Query<Item>(String.Format("select * from Item where Vendor_ID = \"{0}\"", id)).ToList();
                return c;
            }
        }
        public static List<PurchaseOrder> LoadVendorPOs(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<PurchaseOrder> c = cnn.Query<PurchaseOrder>(String.Format("select * from PurchaseOrder where Vendor_ID = \"{0}\"", id)).ToList();
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
        public static void EditOrder(Order c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE [Order] SET Cust_ID = @Cust_ID, Employee_ID = @Employee_ID, Order_Date = @Order_Date, Order_ShipDate = @Order_ShipDate, Order_Subtotal = @Order_Subtotal, Order_Tax = @Order_Tax, Order_Total = @Order_Total, Order_BillStreet = @Order_BillStreet, Order_BillCity = @Order_BillCity, Order_BillState = @Order_BillState, Order_BillZip = @Order_BillZip, Order_ShipStreet = @Order_ShipStreet, Order_ShipCity = @Order_ShipCity, Order_ShipState = @Order_ShipState, Order_ShipZip = @Order_ShipZip, Order_Status = @Order_Status, Order_Type = @Order_Type WHERE Order_ID = @Order_ID", c);
            }
        }
        public static void EditEmployee(Employee c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Employee SET Employee_FirstName = @Employee_FirstName, Employee_LastName = @Employee_LastName, Employee_Street = @Employee_Street, Employee_City = @Employee_City, Employee_State = @Employee_State, Employee_Zip = @Employee_Zip, Employee_Phone = @Employee_Phone, Employee_Email = @Employee_Email, Employee_Supervisor_ID = @Employee_Supervisor_ID WHERE Employee_Id = @Employee_ID", c);
            }
        }
        public static void EditVendor(Vendor c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Vendor SET Vendor_Name = @Vendor_Name, Vendor_Street = @Vendor_Street, Vendor_City = @Vendor_City, Vendor_State = @Vendor_State, Vendor_Zip = @Vendor_Zip, Vendor_Phone = @Vendor_Phone, Vendor_Email = @Vendor_Email, Vendor_CreditLimit = @Vendor_CreditLimit, Vendor_Terms = @Vendor_Terms WHERE Vendor_Id = @Vendor_ID", c);
            }
        }
        public static void EditItem(Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Item SET Item_Number = @Item_Number, Vendor_ID = @Vendor_ID, Item_Description = @Item_Description, Item_PurchasePrice = @Item_PurchasePrice, Item_SellPrice = @Item_SellPrice, Item_UPC = @Item_UPC WHERE Item_Number = @Item_Number", c);
            }
        }
        public static void DeleteCustomer(string Cust_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Customer WHERE Cust_ID = {0}", Cust_ID));
            }
        }
        public static void DeletePurchaseOrder(int po_id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM PurchaseOrder WHERE PO_ID = {0}", po_id));
            }
        }
        public static void DeleteEmployee(int Employee_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Employee WHERE Employee_ID = {0}", Employee_Id));
            }
        }
        public static void DeleteVendor(int Vendor_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Vendor WHERE Vendor_ID = {0}", Vendor_Id));
            }
        }
        public static void DeleteItem(string Item_Number)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Item WHERE Item_Number = '{0}'", Item_Number));
            }
        }
        public static void DeleteOrder_Item(int Order_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Order_Item WHERE Order_ID = {0}", Order_ID));
            }
        }
        public static void DeleteOrder(int Order_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM [Order] WHERE Order_ID = {0}", Order_ID));
            }
        }
        public static string LoadConnectionString(string id = "Default")
        {
            if(ConfigurationManager.ConnectionStrings["Custom"].ConnectionString == "")
            {
                return ConfigurationManager.ConnectionStrings[id].ConnectionString;
            }
            else
            {
                return ConfigurationManager.ConnectionStrings["Custom"].ConnectionString;
            }
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

        public static List<Order> LoadAllOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Order> c = cnn.Query<Order>("select * from [Order]").ToList();
                return c;
            }
        }
        public static List<Order_Item> LoadOrder_ItemFOR(int orderID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Order_Item> c = cnn.Query<Order_Item>(string.Format("select * from Order_Item where Order_ID = {0}", orderID)).ToList();
                return c;
            }
        }
        public static List<Order> LoadOrderFromCustID(int custID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<Order> c = cnn.Query<Order>(string.Format("select * from [Order] where Cust_ID = {0}", custID)).ToList();
                return c;
            }
        }

        public static string AddOrder(Order c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into [Order] (Cust_ID, Employee_ID, Order_Date, Order_ShipDate, Order_Subtotal, Order_Tax, Order_Total, Order_BillStreet, Order_BillCity, Order_BillState, Order_BillZip, Order_ShipStreet, Order_ShipCity, Order_ShipState, Order_ShipZip, Order_Type, Order_Status) values (@Cust_ID, @Employee_ID, @Order_Date, @Order_ShipDate, @Order_Subtotal, @Order_Tax, @Order_Total, @Order_BillStreet, @Order_BillCity, @Order_BillState, @Order_BillZip, @Order_ShipStreet, @Order_ShipCity, @Order_ShipState, @Order_ShipZip, @Order_Type, @Order_Status)", c);
                dynamic e = cnn.QueryFirst("SELECT seq FROM sqlite_sequence where name=\"Order\"");
                return e.seq.ToString();
            }
        }
        public static string AddPurchaseOrder(PurchaseOrder c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into [PurchaseOrder] (Vendor_ID, PO_Date, PO_ShipDate, PO_Subtotal, PO_Tax, PO_Total, PO_ShipStreet, PO_ShipCity, PO_ShipState, PO_ShipZip) values (@Vendor_ID, @PO_Date, @PO_ShipDate, @PO_Subtotal, @PO_Tax, @PO_Total, @PO_ShipStreet, @PO_ShipCity, @PO_ShipState, @PO_ShipZip)", c);
                dynamic e = cnn.QueryFirst("SELECT seq FROM sqlite_sequence where name=\"PurchaseOrder\"");
                return e.seq.ToString();
            }
        }
        public static void AddEmployee(Employee c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Employee (Employee_FirstName, Employee_LastName, Employee_Street, Employee_City, Employee_State, Employee_Zip, Employee_Phone, Employee_Email, Employee_Supervisor_ID) values (@Employee_FirstName, @Employee_LastName, @Employee_Street, @Employee_City, @Employee_State, @Employee_Zip, @Employee_Phone, @Employee_Email, @Employee_Supervisor_ID)", c);
            }
        }
        public static void AddVendor(Vendor c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Vendor (Vendor_Name, Vendor_Street, Vendor_City, Vendor_State, Vendor_Zip, Vendor_Phone, Vendor_Email, Vendor_CreditLimit, Vendor_Terms) values (@Vendor_Name, @Vendor_Street, @Vendor_City, @Vendor_State, @Vendor_Zip, @Vendor_Phone, @Vendor_Email, @Vendor_CreditLimit, @Vendor_Terms)", c);
            }
        }
        public static void AddItem(Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Item (Item_Number, Vendor_ID, Item_Description, Item_PurchasePrice, Item_SellPrice, Item_UPC) values (@Item_Number, @Vendor_Id, @Item_Description, @Item_PurchasePrice, @Item_SellPrice, @Item_UPC)", c);
            }
        }
        public static void AddOrder_Item(Order_Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Order_Item (Order_ID, Item_Number, Order_Item_Quantity) values (@Order_ID, @Item_Number, @Order_Item_Quantity)", c);
            }
        }
        public static void AddPurchaseOrder_Item(PurchaseOrder_Item c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into PurchaseOrder_Item (PO_ID, Item_Number, Item_Quantity, Item_Cost) values (@PO_ID, @Item_Number, @Item_Quantity, @Item_Cost)", c);
            }
        }
        public static void AddUser(User c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (Username, Password, isAdmin, LastLogon) values (@Username, @Password, @isAdmin, @LastLogon)", c);
            }
        }
        public static void DeleteUser(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("DELETE FROM Users WHERE Username = '{0}'", username));
            }
        }
        public static void SetUserLastLogon(string lastLogon, string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("UPDATE Users set LastLogon = '{0}' WHERE Username = '{1}'", lastLogon, username));
            }
        }
        public static void SetUserPassword(string password, string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(String.Format("UPDATE Users set password = '{0}' WHERE Username = '{1}'", password, username));
            }
        }
        public static List<User> VerifyPassword(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<User> c = cnn.Query<User>(String.Format("select * from [Users] where Username = '{0}'", username )).ToList();
                return c;
            }
        }
        public static List<User> LoadAllUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                List<User> c = cnn.Query<User>("select * from [Users]").ToList();
                return c;
            }
        }
    }
}
