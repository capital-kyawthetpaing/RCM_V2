﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
  public class Shop_ItemNamePriorityModel :BaseModel{
        public string ShopID { get; set; }
        public string ShopName { get; set; }
        public string PriorityValue { get; set; }

    }
}
