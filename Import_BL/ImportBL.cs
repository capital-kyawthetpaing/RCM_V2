using DL;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import_BL
{
    public class ImportBL
    {
        public string ItemImportLog_Select(ItemImportLogModel itemImportModel)
        {
            BaseDL bdl = new BaseDL();
            itemImportModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("ItemImportLog_Select", itemImportModel.Sqlprms);
        }

        public string Import_Item_Data(string filename, string sheetname,string importType)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.fileName = filename;
            itemModel.sheetName = sheetname;
            itemModel.importType = importType;
            itemModel.UserID = "KTP";
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[4];
            itemModel.Sqlprms[0] = new SqlParameter("@FileName", itemModel.fileName);
            itemModel.Sqlprms[1] = new SqlParameter("@SheetName", itemModel.sheetName);
            itemModel.Sqlprms[2] = new SqlParameter("@ImportType", itemModel.importType);
            itemModel.Sqlprms[3] = new SqlParameter("@ImportedBy", itemModel.UserID);
            return bdl.InsertUpdateDeleteData("Import_ItemData", itemModel.Sqlprms);
        }

        public string Import_SKU_Inventory_Update(string filename, string sheetname)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.fileName = filename;
            itemModel.sheetName = sheetname;
            itemModel.UserID = "KTP";
            BaseDL bdl = new BaseDL();
            itemModel.Sqlprms = new SqlParameter[3];
            itemModel.Sqlprms[0] = new SqlParameter("@FileName", itemModel.fileName);
            itemModel.Sqlprms[1] = new SqlParameter("@SheetName", itemModel.sheetName);
            itemModel.Sqlprms[3] = new SqlParameter("@ImportedBy", itemModel.UserID);
            return bdl.InsertUpdateDeleteData("Import_SKUInventory_Update", itemModel.Sqlprms);
        }

    }
}
