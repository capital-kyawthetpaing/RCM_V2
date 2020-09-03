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
            exportFieldsModel.Sqlprms = new SqlParameter[4];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", exportFieldsModel.ExportName);
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@ExportValue", exportFieldsModel.ExportValue);
            exportFieldsModel.Sqlprms[2] = new SqlParameter("@ExportType", exportFieldsModel.ExportType);
            exportFieldsModel.Sqlprms[3] = new SqlParameter("@Status", exportFieldsModel.Status);
            return bdl.SelectJson("Export_Select", exportFieldsModel.Sqlprms);
        }

        public string ExportField_Save(ExportFieldsModel exportFieldsModel)
        {
            BaseDL bdl = new BaseDL();
            exportFieldsModel.FormColumnJson = JsonConvert.SerializeObject(exportFieldsModel.FormColumnList);
            exportFieldsModel.TableColumnJson = JsonConvert.SerializeObject(exportFieldsModel.TableColumnList);
            exportFieldsModel.Sqlprms= new SqlParameter[6];
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@ExportName", SqlDbType.VarChar) { Value = exportFieldsModel.ExportName };
            exportFieldsModel.Sqlprms[1] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = exportFieldsModel.Status };
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@FormColumnJson", SqlDbType.VarChar) { Value = exportFieldsModel.FormColumnJson };
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@TableColumnJson", SqlDbType.VarChar) { Value = exportFieldsModel.TableColumnJson };
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@CreatedBy", SqlDbType.VarChar) { Value = exportFieldsModel.CreatedBy };
            exportFieldsModel.Sqlprms[0] = new SqlParameter("@UpdatedBy", SqlDbType.VarChar) { Value = exportFieldsModel.UpdatedBy };
            return bdl.InsertUpdateDeleteData("", exportFieldsModel.Sqlprms);

        }
    }
}
