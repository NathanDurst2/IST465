﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Item : Entity
    {
        public string Item_Number { get; set; }
        public int Vendor_ID { get; set; }
        public string Item_Description { get; set; }
        public double Item_PurchasePrice { get; set; }
        public double Item_SellPrice { get; set; }
        public string Item_UPC { get; set; }
    }
}
