using Models;
using DL;
using System.Data.SqlClient;

namespace ExportColumn_BL
{
    public class ExportColumnBL
    {
        public string ExportColumn_Select(ExportColumnModel exportColumnModel)
        {
            BaseDL bdl = new BaseDL();
            exportColumnModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("ExprtColumn_Select", exportColumnModel.Sqlprms);
        }
    }
}
