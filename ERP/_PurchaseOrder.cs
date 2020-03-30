using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class PurchaseOrder
    {
        public int PO_ID { get; set; }
        public int Vendor_ID { get; set; }
        public string PO_Date { get; set; }
        public string PO_ShipDate { get; set; }
        public double PO_Subtotal { get; set; }
        public double PO_Tax { get; set; }
        public double PO_Total { get; set; }
        public string PO_ShipStreet { get; set; }
        public string PO_ShipCity { get; set; }
        public string PO_ShipState { get; set; }
        public string PO_ShipZip { get; set; }
    }
}
