using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Estimate
    {
        public int Estimate_ID { get; set; }
        public int Cust_ID { get; set; }
        public int Employee_ID {get;set;}
        public string Estimate_Date { get; set; }
        public double Estimate_Subtotal { get; set; }
        public double Estimate_Tax { get; set; }
        public double Estimate_Total { get; set; }
        public string Estimate_BillStreet { get; set; }
        public string Estimate_BillCity { get; set; }
        public string Estimate_BillState { get; set; }
        public string Estimate_BillZip { get; set; }
        public string Estimate_ShipStreet { get; set; }
        public string Estimate_ShipCity { get; set; }
        public string Estimate_ShipState { get; set; }
        public string Estimate_ShipZip { get; set; }
    }
}
