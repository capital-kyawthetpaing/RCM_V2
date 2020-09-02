using System;
using System.Data;
using System.Data.SqlClient;
using Models;
using DL;

namespace OptionTemplate_BL
{
    public class OptionTemplateBL
    {
        public string OptionTemplate_Select(OptionTemplateModel optionTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            optionTemplateModel.Sqlprms = new SqlParameter[1];
            optionTemplateModel.Sqlprms[0] = new SqlParameter("@AutoID",SqlDbType.VarChar) {Value=optionTemplateModel.AutoID };
            return bdl.SelectJson("OptionTemplate_Select");
        }
    }
}
