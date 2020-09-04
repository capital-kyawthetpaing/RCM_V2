using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUStockList_BL
{
    public class SKUStockListBL
    {
        public string SKU_Stock_Select(ItemModel item)
        {
            BaseDL bdl = new BaseDL();

            return bdl.SelectJson("SKU_Stock_Select", null);
        }
    }
}
