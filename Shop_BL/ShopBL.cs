using DL;
using Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Shop_BL
{
    public class ShopBL
    {
        public string Shop_Select(ShopModel shopModel)
        {
            BaseDL bdl = new BaseDL();
            shopModel.Sqlprms = new SqlParameter[4];
            shopModel.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = shopModel.ShopID };
            shopModel.Sqlprms[1] = new SqlParameter("@ShopName", SqlDbType.VarChar) { Value = shopModel.ShopName };
            shopModel.Sqlprms[2] = new SqlParameter("@MAllID", SqlDbType.VarChar) { Value = shopModel.MallID };
            shopModel.Sqlprms[3] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopModel.Status };
            return bdl.SelectJson("Shop_Select", shopModel.Sqlprms);
        }

        public ShopModel ShopModel_Select(ShopModel shopModel)
        {
            BaseDL bdl = new BaseDL();
            shopModel.Sqlprms = new SqlParameter[4];
            shopModel.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = shopModel.ShopID };
            shopModel.Sqlprms[1] = new SqlParameter("@ShopName", SqlDbType.VarChar) { Value = shopModel.ShopName };
            shopModel.Sqlprms[2] = new SqlParameter("@MAllID", SqlDbType.VarChar) { Value = shopModel.MallID };
            shopModel.Sqlprms[3] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopModel.Status };
            DataTable dt = bdl.SelectDatatable("Shop_Select", shopModel.Sqlprms);
            foreach(DataRow dr in dt.Rows)
            {
                shopModel.ShopID = dr["ShopID"].ToString();
                shopModel.ShopIDPrefix = dr["ShopIDPrefix"].ToString();
                shopModel.ShopSiteID = dr["ShopSiteID"].ToString();
                shopModel.ShopName = dr["ShopName"].ToString();
                shopModel.MallID = dr["MallID"].ToString();
                shopModel.FtpHost = dr["FtpHost"].ToString();
                shopModel.FtpUserName= dr["FtpUserName"].ToString();
                shopModel.FtpPassword = dr["FtpPassword"].ToString();
                shopModel.ItemURL = dr["ItemURL"].ToString();
                shopModel.ImageURL = dr["ImageURL"].ToString();               
                shopModel.FreeShippingAmount = dr["FreeShippingAmount"]!=null?Convert.ToInt32(dr["FreeShippingAmount"]).ToString(): dr["FreeShippingAmount"].ToString();
                shopModel.Status = dr["Status"].ToString();
            }
            return shopModel;
        }

        public string Shop_Save(ShopModel shopModel)
        {
            BaseDL bdl = new BaseDL();
            shopModel.Sqlprms = new SqlParameter[12];
            shopModel.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) { Value = shopModel.ShopID };
            shopModel.Sqlprms[1] = new SqlParameter("@ShopSiteID", SqlDbType.VarChar) { Value =shopModel.ShopSiteID };
            shopModel.Sqlprms[2] = new SqlParameter("@ShopName", SqlDbType.VarChar) { Value = shopModel.ShopName };
            shopModel.Sqlprms[3] = new SqlParameter("@MAllID", SqlDbType.VarChar) { Value = shopModel.MallID };
            shopModel.Sqlprms[4] = new SqlParameter("@FtpHost", SqlDbType.VarChar) { Value = shopModel.FtpHost };
            shopModel.Sqlprms[5] = new SqlParameter("@FtpUserName", SqlDbType.VarChar) { Value = shopModel.FtpUserName };
            shopModel.Sqlprms[6] = new SqlParameter("@FtpPassword", SqlDbType.VarChar) { Value = shopModel.FtpPassword };
            shopModel.Sqlprms[7] = new SqlParameter("@ItemURL", SqlDbType.VarChar) { Value = shopModel.ItemURL };
            shopModel.Sqlprms[8] = new SqlParameter("@ImageURL", SqlDbType.VarChar) { Value = shopModel.ImageURL };
            shopModel.Sqlprms[9] = new SqlParameter("@FreeShipAmt", SqlDbType.VarChar) { Value = shopModel.FreeShippingAmount };
            shopModel.Sqlprms[10] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopModel.Status };
            shopModel.Sqlprms[11] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = shopModel.Mode };
            return bdl.InsertUpdateDeleteData("Shop_CUD", shopModel.Sqlprms);
        }

        public string Shop_ExistCheck(ShopModel shopModel)
        {
            BaseDL bdl = new BaseDL();
            shopModel.Sqlprms = new SqlParameter[1];
            shopModel.Sqlprms[0] = new SqlParameter("@ShopID", SqlDbType.VarChar) {Value=shopModel.ShopID };
            return bdl.SelectJson("Shop_ExistsCheck", shopModel.Sqlprms);
        }
    }
}
