using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Order
    {
        public int Order_ID { get; set; }
        public int Cust_ID { get; set; }
        public int Employee_ID { get; set; }
        public string Order_Date { get; set; }
        public string Order_ShipDate { get; set; }
        public double Order_Subtotal { get; set; }
        public double Order_Tax { get; set; }
        public double Order_Total { get; set; }
        public string Order_BillStreet { get; set; }
        public string Order_BillCity { get; set; }
        public string Order_BillState { get; set; }
        public string Order_BillZip { get; set; }
        public string Order_ShipStreet { get; set; }
        public string Order_ShipCity { get; set; }
        public string Order_ShipState { get; set; }
        public string Order_ShipZip { get; set; }
        public string Order_Type { get; set; }
        public string Order_Status { get; set; }
    }
}
