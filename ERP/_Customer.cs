using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Customer : Entity
    {
        public int Cust_Id { get; set; }
        public string Customer_FirstName { get; set; }
        public string Customer_LastName { get; set; }
        public string Customer_Street { get; set; }
        public string Customer_City { get; set; }
        public string Customer_State { get; set; }
        public string Customer_Zip { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public int Employee_ID { get; set; }
    }
}
