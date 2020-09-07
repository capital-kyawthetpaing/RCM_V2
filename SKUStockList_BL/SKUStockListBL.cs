using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            item.Sqlprms = new SqlParameter[6];
            item.Sqlprms[0] = new SqlParameter("@JanCD", SqlDbType.VarChar) { Value = item.JanCD };
            item.Sqlprms[1] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = item.ItemCD };
            item.Sqlprms[2] = new SqlParameter("@ItemName", SqlDbType.VarChar) { Value = item.ItemName };
            item.Sqlprms[3] = new SqlParameter("@YearCD", SqlDbType.VarChar) { Value = item.YearCD };
            item.Sqlprms[4] = new SqlParameter("@SeasonCD", SqlDbType.VarChar) { Value = item.SeasonCD };
            item.Sqlprms[5] = new SqlParameter("@CompetitionName", SqlDbType.VarChar) { Value = item.CompetitionName };
            return bdl.SelectJson("SKU_Stock_Select", item.Sqlprms);
        }
    }
}
