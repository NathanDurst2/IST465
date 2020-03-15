using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    class Estimate
    {
        public int Estimate_ID { get; set; }
        public int Cust_ID { get; set; }
        public int Employee_ID {get;set;}
        public List<Item> Estimate_Items { get; set; }
        public string Estimate_Date { get; set; }
        public long Estimate_Subtotal { get; set; }
        public long Estimate_Tax { get; set; }
        public long Estimate_Total { get; set; }
        public long Estimate_BillStreet { get; set; }
        public long Estimate_BillCity { get; set; }
        public long Estimate_BillState { get; set; }
        public long Estimate_BillZip { get; set; }
        public long Estimate_ShipStreet { get; set; }
        public long Estimate_ShipCity { get; set; }
        public long Estimate_ShipState { get; set; }
        public long Estimate_ShipZip { get; set; }
    }
}
