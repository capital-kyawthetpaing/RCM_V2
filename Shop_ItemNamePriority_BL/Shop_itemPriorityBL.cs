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
                model.PriorityValueID = dr["PriorityValueID"].ToString();
                model.MallID = dr["MallID"].ToString();
            }
            return model;
        }

        public string ShopItemNamePriority_Update(Shop_ItemNamePriorityModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[3];
            model.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = model.ShopID };
            model.Sqlprms[1] = new SqlParameter("@PriorityValue", SqlDbType.VarChar) { Value = model.PriorityValue };
            model.Sqlprms[2] = new SqlParameter("@PriorityValueID", SqlDbType.VarChar) { Value = model.PriorityValueID };
            return bdl.InsertUpdateDeleteData("ShopItemNamePriority_Update", model.Sqlprms);
        }
    }
}
