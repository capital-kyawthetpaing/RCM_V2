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
            optionModel.Sqlprms = new SqlParameter[11];
            optionModel.Sqlprms[0] = new SqlParameter("@GroupName", SqlDbType.VarChar) { Value = optionModel.GroupName };
            optionModel.Sqlprms[1] = new SqlParameter("@Option1", SqlDbType.VarChar) { Value = optionModel.Option1 };
            optionModel.Sqlprms[2] = new SqlParameter("@Value1", SqlDbType.VarChar) { Value = optionModel.Value1 };
            optionModel.Sqlprms[3] = new SqlParameter("@Option2", SqlDbType.VarChar) { Value = optionModel.Option2 };
            optionModel.Sqlprms[4] = new SqlParameter("@Value2", SqlDbType.VarChar) { Value = optionModel.Value2 };
            optionModel.Sqlprms[5] = new SqlParameter("@Option3", SqlDbType.VarChar) { Value = optionModel.Option3 };
            optionModel.Sqlprms[6] = new SqlParameter("@Value3", SqlDbType.VarChar) { Value = optionModel.Value3 };
            optionModel.Sqlprms[7] = new SqlParameter("@Option4", SqlDbType.VarChar) { Value = optionModel.Option4 };
            optionModel.Sqlprms[8] = new SqlParameter("@Value4", SqlDbType.VarChar) { Value = optionModel.Value4 };
            optionModel.Sqlprms[9] = new SqlParameter("@Option5", SqlDbType.VarChar) { Value = optionModel.Option5 };
            optionModel.Sqlprms[10] = new SqlParameter("@Value5", SqlDbType.VarChar) { Value = optionModel.Value5 };
            return bdl.InsertUpdateDeleteData("Option_CUD", optionModel.Sqlprms);
        }
    }
}
