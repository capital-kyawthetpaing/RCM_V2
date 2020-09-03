using DL;
using Models;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace ExportField_BL
{
    public class ExportFieldBL
    {
        public string ExportField_Select(ExportFieldsModel exportFieldsModel)
        {
            BaseDL bdl = new BaseDL();
            exportFieldsModel.Sqlprms = new SqlParameter[5];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", exportFieldsModel.ExportName);
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@ExportValue", exportFieldsModel.ExportValue);
            exportFieldsModel.Sqlprms[2] = new SqlParameter("@ExportType", exportFieldsModel.ExportType);
            exportFieldsModel.Sqlprms[3] = new SqlParameter("@Status", exportFieldsModel.Status);
            exportFieldsModel.Sqlprms[4] = new SqlParameter("@AutoID", exportFieldsModel.AutoID);
            return bdl.SelectJson("Export_Select", exportFieldsModel.Sqlprms);
        }

        public string ExportField_Save(ExportFieldsModel exportFieldsModel)
        {
            BaseDL bdl = new BaseDL(); 
            exportFieldsModel.Sqlprms= new SqlParameter[9];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", SqlDbType.VarChar) { Value = exportFieldsModel.ExportName };
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@ExportValue", SqlDbType.VarChar) { Value = exportFieldsModel.ExportValue };
            exportFieldsModel.Sqlprms[2] = new SqlParameter("@ExportValueID", SqlDbType.VarChar) { Value = exportFieldsModel.ExportValueID };
            exportFieldsModel.Sqlprms[3] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = exportFieldsModel.Status };
            exportFieldsModel.Sqlprms[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar) { Value = exportFieldsModel.CreatedBy };
            exportFieldsModel.Sqlprms[5] = new SqlParameter("@UpdatedBy", SqlDbType.VarChar) { Value = exportFieldsModel.UpdatedBy };
            exportFieldsModel.Sqlprms[6] = new SqlParameter("@ExportType", SqlDbType.VarChar) { Value=exportFieldsModel.ExportType};
            exportFieldsModel.Sqlprms[7] = new SqlParameter("@Mode", SqlDbType.VarChar) {Value=exportFieldsModel.Mode};
            exportFieldsModel.Sqlprms[8] = new SqlParameter("@AutoID", SqlDbType.VarChar) { Value = exportFieldsModel.AutoID };
            return bdl.InsertUpdateDeleteData("ExportColumn_CUD", exportFieldsModel.Sqlprms);
        }

        public ExportFieldsModel ExportFieldModel_Select(ExportFieldsModel exportFieldsModel)
        {
            BaseDL bdl = new BaseDL();
            exportFieldsModel.Sqlprms = new SqlParameter[5];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", exportFieldsModel.ExportName);
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@ExportValue", exportFieldsModel.ExportValue);
            exportFieldsModel.Sqlprms[2] = new SqlParameter("@ExportType", exportFieldsModel.ExportType);
            exportFieldsModel.Sqlprms[3] = new SqlParameter("@Status", exportFieldsModel.Status);
            exportFieldsModel.Sqlprms[4] = new SqlParameter("@AutoID", exportFieldsModel.AutoID);
            DataTable dt = bdl.SelectDatatable("Export_Select", exportFieldsModel.Sqlprms);
            foreach(DataRow dr in dt.Rows)
            {
                exportFieldsModel.AutoID = dr["AutoID"].ToString();
                exportFieldsModel.ExportName = dr["ExportName"].ToString();
                exportFieldsModel.Status = dr["Status"].ToString();
                exportFieldsModel.ExportType = dr["ExportType"].ToString();
                exportFieldsModel.ExportValue = dr["ExportValue"].ToString();
                exportFieldsModel.ExportValueID = dr["ExportValueID"].ToString();
            }
            return exportFieldsModel;
        }
    }
}
