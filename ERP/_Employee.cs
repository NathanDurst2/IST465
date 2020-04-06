using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_FirstName { get; set; }
        public string Employee_LastName { get; set; }
        public string Employee_Street { get; set; }
        public string Employee_City { get; set; }
        public string Employee_State { get; set; }
        public string Employee_Zip { get; set; }
        public string Employee_Phone { get; set; }
        public string Employee_Email { get; set; }
        public int Employee_Supervisor_ID { get; set; }
    }
}
