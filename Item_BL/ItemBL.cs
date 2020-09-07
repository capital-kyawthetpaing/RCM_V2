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
            itemModel.Sqlprms = new SqlParameter[7];
            itemModel.Sqlprms[0] = new SqlParameter("@ItemName", SqlDbType.VarChar) { Value = itemModel.ItemName };
            itemModel.Sqlprms[1] = new SqlParameter("@MakerCD", SqlDbType.VarChar) { Value = itemModel.MakerCD };
            itemModel.Sqlprms[2] = new SqlParameter("@YearCD", SqlDbType.VarChar) { Value = itemModel.YearCD };
            itemModel.Sqlprms[3] = new SqlParameter("@SeasonCD", SqlDbType.VarChar) { Value = itemModel.SeasonCD };
            itemModel.Sqlprms[4] = new SqlParameter("@CatalogInfo", SqlDbType.VarChar) { Value = itemModel.CatalogInfo };
            itemModel.Sqlprms[5] = new SqlParameter("@ClassName", SqlDbType.VarChar) { Value = itemModel.ClassName };
            itemModel.Sqlprms[6] = new SqlParameter("@CompetitionName", SqlDbType.VarChar) { Value = itemModel.CompetitionName };
            return bdl.SelectJson("ItemManage_Select", itemModel.Sqlprms);
        }
    }
}
