using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUStock_BL
{
    public class SkuStockBL
    {
        public string SKU_Stock_Select(ItemModel item)
        {
            BaseDL bdl = new BaseDL();
   
            return bdl.SelectJson("SKU_Stock_Select", null);
        }
    }
}
