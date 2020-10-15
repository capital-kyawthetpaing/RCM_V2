using DL;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace Item_BL
{
    public class ItemBL
    {
        public string ItemManage_List(ItemModel itemModel)
        {
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[12];
            itemModel.Sqlprms[0] = new SqlParameter("@BrandName", SqlDbType.VarChar) { Value = itemModel.BrandName };
            itemModel.Sqlprms[1] = new SqlParameter("@ItemName", SqlDbType.VarChar) { Value = itemModel.ItemName };
            itemModel.Sqlprms[2] = new SqlParameter("@MakerCD", SqlDbType.VarChar) { Value = itemModel.MakerCD };
            itemModel.Sqlprms[3] = new SqlParameter("@MakerName", SqlDbType.VarChar) { Value = itemModel.MakerName };
            itemModel.Sqlprms[4] = new SqlParameter("@YearCD", SqlDbType.VarChar) { Value = itemModel.YearCD };
            itemModel.Sqlprms[5] = new SqlParameter("@SeasonCD", SqlDbType.VarChar) { Value = itemModel.SeasonCD };
            itemModel.Sqlprms[6] = new SqlParameter("@CatalogInfo", SqlDbType.VarChar) { Value = itemModel.CatalogInfo };
            itemModel.Sqlprms[7] = new SqlParameter("@ClassName", SqlDbType.VarChar) { Value = itemModel.ClassName };
            itemModel.Sqlprms[8] = new SqlParameter("@CompetitionName", SqlDbType.VarChar) { Value = itemModel.CompetitionName };
            itemModel.Sqlprms[9] = new SqlParameter("@Type", SqlDbType.VarChar) { Value = itemModel.Type };
            itemModel.Sqlprms[10] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = itemModel.ItemCD };
            itemModel.Sqlprms[11] = new SqlParameter("@ExportID", SqlDbType.VarChar) { Value = itemModel.ExportID };
            return bdl.SelectJson("ItemManage_Select", itemModel.Sqlprms);
        }

        public string ItemPageCreate_List(ItemModel itemModel)
        {
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[18];
            itemModel.Sqlprms[0] = new SqlParameter("@ItemName", SqlDbType.VarChar) { Value = itemModel.ItemName };
            itemModel.Sqlprms[1] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = itemModel.ItemCD };
            itemModel.Sqlprms[2] = new SqlParameter("@ImageFileName", SqlDbType.VarChar) { Value = itemModel.ImageFileName };
            itemModel.Sqlprms[3] = new SqlParameter("@CatalogInfo", SqlDbType.VarChar) { Value = itemModel.CatalogInfo };
            itemModel.Sqlprms[4] = new SqlParameter("@BrandName", SqlDbType.VarChar) { Value = itemModel.BrandName };
            itemModel.Sqlprms[5] = new SqlParameter("@CategoryName", SqlDbType.VarChar) { Value = itemModel.CategoryName };
            itemModel.Sqlprms[6] = new SqlParameter("@CompetitionName", SqlDbType.VarChar) { Value = itemModel.CompetitionName };
            itemModel.Sqlprms[7] = new SqlParameter("@ColorName", SqlDbType.VarChar) { Value = itemModel.ColorName };
            itemModel.Sqlprms[8] = new SqlParameter("@YearCD", SqlDbType.VarChar) { Value = itemModel.YearCD };
            itemModel.Sqlprms[9] = new SqlParameter("@SeasonCD", SqlDbType.VarChar) { Value = itemModel.SeasonCD };
            itemModel.Sqlprms[10] = new SqlParameter("@SKSStatus", SqlDbType.VarChar) { Value = itemModel.SKSStatus };
            itemModel.Sqlprms[11] = new SqlParameter("@ShopStatus", SqlDbType.VarChar) { Value = itemModel.ShopStatus };
            itemModel.Sqlprms[12] = new SqlParameter("@SpecialFlagCD", SqlDbType.VarChar) { Value = itemModel.SpecialFlagCD };
            itemModel.Sqlprms[13] = new SqlParameter("@ReservationFlagCD", SqlDbType.VarChar) { Value = itemModel.ReservationFlagCD };
            itemModel.Sqlprms[14] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = itemModel.UserID };
            itemModel.Sqlprms[15] = new SqlParameter("@SearchKeyword", SqlDbType.VarChar) { Value = itemModel.SearchKeyword };
            itemModel.Sqlprms[16] = new SqlParameter("@ExportID", SqlDbType.VarChar) { Value = itemModel.ExportID };
            itemModel.Sqlprms[17] = new SqlParameter("@Type", SqlDbType.VarChar) { Value = itemModel.Type };
            return bdl.SelectJson("ItemPageCreateList_Select", itemModel.Sqlprms);
        }

        public string ItemEntry_Detail(ItemModel itemModel)
        {
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[1];
            itemModel.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = itemModel.ItemCD };
            return bdl.SelectJson("Select_ItemEntry_Detail", itemModel.Sqlprms);
        }
    }
}
