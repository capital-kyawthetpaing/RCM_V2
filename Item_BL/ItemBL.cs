using DL;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Item_BL
{
    public class ItemBL
    {
        public string ItemManage_Select(ItemModel itemModel)
        {
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("ItemManage_Select", itemModel.Sqlprms);
        }
        public string ItemManage_List(ItemModel itemModel)
        {
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[0];
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
