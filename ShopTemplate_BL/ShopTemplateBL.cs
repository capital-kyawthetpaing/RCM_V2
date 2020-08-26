﻿using DL;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace ShopTemplate_BL
{
    public class ShopTemplateBL
    {
        public string ShopTemplate_Select(ShopTemplateModel shopTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            shopTemplateModel.Sqlprms = new SqlParameter[3];
            shopTemplateModel.Sqlprms[0] = new SqlParameter("@TemplateID", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateID };
            shopTemplateModel.Sqlprms[1] = new SqlParameter("@TemplateName", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateName };
            shopTemplateModel.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopTemplateModel.Status };
            return bdl.SelectJson("ShopTemplate_Select", shopTemplateModel.Sqlprms);
        }
    }
}
