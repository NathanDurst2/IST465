using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class SalesOrder
    {
        public int Sales_ID { get; set; }
        public int Cust_ID { get; set; }
        public int Employee_ID { get; set; }
        public string Sales_Items { get; set; }
        public string Sales_Date { get; set; }
        public string Sales_ShipDate { get; set; }
        public long Sales_Subtotal { get; set; }
        public long Sales_Tax { get; set; }
        public long Sales_Total { get; set; }
        public string Sales_BillStreet { get; set; }
        public string Sales_BillCity { get; set; }
        public string Sales_BillState { get; set; }
        public string Sales_BillZip { get; set; }
        public string Sales_ShipStreet { get; set; }
        public string Sales_ShipCity { get; set; }
        public string Sales_ShipState { get; set; }
        public string Sales_ShipZip { get; set; }
    }
}
