using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class PurchaseOrder_Item
    {
        public int PO_ID { get; set; }
        public string Item_Number { get; set; }
        public double Item_Cost { get; set; }
        public int Item_Quantity { get; set; }
    }
}
