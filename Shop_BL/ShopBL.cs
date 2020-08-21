using DL;
using Models;
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
            shopModel.Sqlprms[3] = new SqlParameter("@DeleteFlg", SqlDbType.VarChar) { Value = shopModel.DeleteFlg };
            return bdl.SelectJson("Shop_Select", shopModel.Sqlprms);
        }
    }
}
