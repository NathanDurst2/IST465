using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Item
    {
        public string Item_Number { get; set; }
        public int Vendor_ID { get; set; }
        public string Item_Description { get; set; }
        public long Item_PurchasePrice { get; set; }
        public long Item_SellPrice { get; set; }
        public string Item_UPC { get; set; }
    }
}
