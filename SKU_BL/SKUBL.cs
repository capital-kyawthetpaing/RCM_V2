using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKU_BL
{
    public class SKUBL
    {
        public string SKU_Select(ItemModel item)
        {
            BaseDL bdl = new BaseDL();
            item.Sqlprms = new SqlParameter[1];
            item.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = item.ItemCD };
            return bdl.SelectJson("SKU_Select", item.Sqlprms);
        }
    }
}
