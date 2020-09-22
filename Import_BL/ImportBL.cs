using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
