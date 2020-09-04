using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ItemNamePriority_BL
{
    public class Shop_itemPriorityBL
    {
        //public string ShopPriority_Select(Shop_ItemNamePriorityModel shopModel)
        //{
        //    BaseDL bdl = new BaseDL();

        //    return bdl.SelectJson("ShopPriority_Select", null);
        //}

        public string ShopPriority_Select(Shop_ItemNamePriorityModel shopModel)
        {
            BaseDL bdl = new BaseDL();
            shopModel.Sqlprms = new SqlParameter[1];
            shopModel.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = shopModel.ShopID };
            return bdl.SelectJson("ShopPriority_Select", shopModel.Sqlprms);
        }

        public Shop_ItemNamePriorityModel ShopPriorityModel_Select(Shop_ItemNamePriorityModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[1];
            model.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = model.ShopID };
            DataTable dt = bdl.SelectDatatable("ShopPriority_Select", model.Sqlprms);
            foreach (DataRow dr in dt.Rows)
            {
                model.ShopID = dr["ShopID"].ToString();
                model.ShopName = dr["ShopName"].ToString();
                model.PriorityValue = dr["PriorityValue"].ToString();
                model.MallID = dr["MallID"].ToString();
            }
            return model;
        }
    }
}
