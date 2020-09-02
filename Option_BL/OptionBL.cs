using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option_BL
{
    public class OptionBL
    {
        public String Option_Save(OptionModel optionModel)
        {
            BaseDL bdl = new BaseDL();
            optionModel.Sqlprms = new SqlParameter[13];
            optionModel.Sqlprms[0] = new SqlParameter("@AutoID", SqlDbType.VarChar) { Value = optionModel.AutoID };
            optionModel.Sqlprms[1] = new SqlParameter("@GroupName", SqlDbType.VarChar) { Value = optionModel.GroupName };
            optionModel.Sqlprms[2] = new SqlParameter("@Option1", SqlDbType.VarChar) { Value = optionModel.Option1 };
            optionModel.Sqlprms[3] = new SqlParameter("@Value1", SqlDbType.VarChar) { Value = optionModel.Value1 };
            optionModel.Sqlprms[4] = new SqlParameter("@Option2", SqlDbType.VarChar) { Value = optionModel.Option2 };
            optionModel.Sqlprms[5] = new SqlParameter("@Value2", SqlDbType.VarChar) { Value = optionModel.Value2 };
            optionModel.Sqlprms[6] = new SqlParameter("@Option3", SqlDbType.VarChar) { Value = optionModel.Option3 };
            optionModel.Sqlprms[7] = new SqlParameter("@Value3", SqlDbType.VarChar) { Value = optionModel.Value3 };
            optionModel.Sqlprms[8] = new SqlParameter("@Option4", SqlDbType.VarChar) { Value = optionModel.Option4 };
            optionModel.Sqlprms[9] = new SqlParameter("@Value4", SqlDbType.VarChar) { Value = optionModel.Value4 };
            optionModel.Sqlprms[10] = new SqlParameter("@Option5", SqlDbType.VarChar) { Value = optionModel.Option5 };
            optionModel.Sqlprms[11] = new SqlParameter("@Value5", SqlDbType.VarChar) { Value = optionModel.Value5 };
            optionModel.Sqlprms[12] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = optionModel.Mode };
            return bdl.InsertUpdateDeleteData("Option_CUD", optionModel.Sqlprms);
        }


        public OptionModel OptionModel_Select(OptionModel optionModel)
        {
            BaseDL bdl = new BaseDL();
            optionModel.Sqlprms = new SqlParameter[1];
            optionModel.Sqlprms[0] = new SqlParameter("@AutoID", SqlDbType.SmallInt) { Value = optionModel.AutoID };
            DataTable dt = bdl.SelectDatatable("Option_Select", optionModel.Sqlprms);
            foreach (DataRow dr in dt.Rows)
            {
                optionModel.GroupName = dr["GroupName"].ToString();
                optionModel.Option1 = dr["Option1"].ToString();
                optionModel.Value1 = dr["Value1"].ToString();
                optionModel.Option2 = dr["Option2"].ToString();
                optionModel.Value2 = dr["Value2"].ToString();
                optionModel.Option3 = dr["Option3"].ToString();
                optionModel.Value3 = dr["Value3"].ToString();
                optionModel.Option4 = dr["Option4"].ToString();
                optionModel.Value4 = dr["Value4"].ToString();
                optionModel.Option5 = dr["Option5"].ToString();
                optionModel.Value5 = dr["Value5"].ToString();
              
            }
            return optionModel;
        }
    }
}
