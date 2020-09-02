using DL;
using Models;
using System.Data.SqlClient;

namespace ExportField_BL
{
    public class ExportFieldBL
    {
        public string ExportField_Select(ExportFieldsModel exportFieldsModel)
        {
            BaseDL bdl = new BaseDL();
            exportFieldsModel.Sqlprms = new SqlParameter[4];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", exportFieldsModel.ExportName);
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@ExportValue", exportFieldsModel.ExportValue);
            exportFieldsModel.Sqlprms[2] = new SqlParameter("@ExportType", exportFieldsModel.ExportType);
            exportFieldsModel.Sqlprms[3] = new SqlParameter("@Status", exportFieldsModel.Status);
            return bdl.SelectJson("Export_Select", exportFieldsModel.Sqlprms);
        }
    }
}
