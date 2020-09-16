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
            itemModel.Sqlprms[9] = new SqlParameter("@Type", SqlDbType.VarChar) { Value = "1" };
            itemModel.Sqlprms[10] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = "" };
            itemModel.Sqlprms[11] = new SqlParameter("@ExportID", SqlDbType.VarChar) { Value = "" };
            return bdl.SelectJson("ItemManage_Select", itemModel.Sqlprms);
        }

        public string ItemImportLog_Select(ItemImportLogModel itemImportModel)
        {
            BaseDL bdl = new BaseDL();
            itemImportModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("ItemImportLog_Select", itemImportModel.Sqlprms);
        }
    }
}
