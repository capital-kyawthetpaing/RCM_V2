using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ItemNamePriority_BL
{
    public class ShopItemNamePriorityBL
    {
        public string ShopPriority_Select(Shop_ItemNamePriorityModel shopModel)
        {
            BaseDL bdl = new BaseDL();

            return bdl.SelectJson("ShopPriority_Select", null);
        }
    }
}
