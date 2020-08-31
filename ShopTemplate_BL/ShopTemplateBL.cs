using DL;
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

        public string ShopTemplate_List(ShopTemplateModel shopTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            shopTemplateModel.Sqlprms = new SqlParameter[3];
            shopTemplateModel.Sqlprms[0] = new SqlParameter("@TemplateID", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateID };
            shopTemplateModel.Sqlprms[1] = new SqlParameter("@TemplateName", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateName };
            shopTemplateModel.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopTemplateModel.Status };
            return bdl.SelectJson("ShopTemplate_List", shopTemplateModel.Sqlprms);
        }


        public string ShopTemplate_Save(ShopTemplateModel shopTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            shopTemplateModel.Sqlprms = new SqlParameter[19];
            shopTemplateModel.Sqlprms[0] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = shopTemplateModel.Mode };
            shopTemplateModel.Sqlprms[1] = new SqlParameter("@TemplateID", SqlDbType.VarChar) {Value=shopTemplateModel.TemplateID };
            shopTemplateModel.Sqlprms[2] = new SqlParameter("@TemplateName", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateName };
            shopTemplateModel.Sqlprms[3] = new SqlParameter("@R_racket", SqlDbType.VarChar) { Value = shopTemplateModel.R_racket};
            shopTemplateModel.Sqlprms[4] = new SqlParameter("@R_sportsplaza", SqlDbType.VarChar) { Value = shopTemplateModel.R_sportsplaza};
            shopTemplateModel.Sqlprms[5] = new SqlParameter("@R_luckpiece", SqlDbType.VarChar) { Value = shopTemplateModel.R_luckpiece};
            shopTemplateModel.Sqlprms[6] = new SqlParameter("@R_honpo", SqlDbType.VarChar) { Value = shopTemplateModel.R_honpo};
            shopTemplateModel.Sqlprms[7] = new SqlParameter("@Y_racket", SqlDbType.VarChar) { Value = shopTemplateModel.Y_racket};
            shopTemplateModel.Sqlprms[8] = new SqlParameter("@Y_sportsplaza", SqlDbType.VarChar) { Value = shopTemplateModel.Y_sportsplaza};
            shopTemplateModel.Sqlprms[9] = new SqlParameter("@Y_luckpiece", SqlDbType.VarChar) { Value = shopTemplateModel.Y_luckpiece};
            shopTemplateModel.Sqlprms[10] = new SqlParameter("@Y_honpo", SqlDbType.VarChar) { Value = shopTemplateModel.Y_honpo};
            shopTemplateModel.Sqlprms[11] = new SqlParameter("@Y_bb_plaza", SqlDbType.VarChar) { Value = shopTemplateModel.Y_bb_plaza};
            shopTemplateModel.Sqlprms[12] = new SqlParameter("@P_racket", SqlDbType.VarChar) { Value = shopTemplateModel.P_racket};
            shopTemplateModel.Sqlprms[13] = new SqlParameter("@A_rasta", SqlDbType.VarChar) { Value = shopTemplateModel.A_rasta};
            shopTemplateModel.Sqlprms[14] = new SqlParameter("@J_racket", SqlDbType.VarChar) { Value = shopTemplateModel.J_racket};
            shopTemplateModel.Sqlprms[15] = new SqlParameter("@W_wowma", SqlDbType.VarChar) { Value = shopTemplateModel.W_wowma};
            shopTemplateModel.Sqlprms[16] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopTemplateModel.Status };            
            shopTemplateModel.Sqlprms[17] = new SqlParameter("@CreatedBy", SqlDbType.VarChar) { Value = shopTemplateModel.CreatedBy };
            shopTemplateModel.Sqlprms[18] = new SqlParameter("@UpdatedBy", SqlDbType.VarChar) { Value = shopTemplateModel.UpdatedBy };
            return bdl.InsertUpdateDeleteData("ShopTemplate_CUD", shopTemplateModel.Sqlprms);
            
        }

        public string ShopTemplate_ExistCheck(ShopTemplateModel shopTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            shopTemplateModel.Sqlprms = new SqlParameter[1];
            shopTemplateModel.Sqlprms[0] = new SqlParameter("@TemplateID",SqlDbType.VarChar) { Value = shopTemplateModel.TemplateID };
            return bdl.SelectJson("ShopTemplate_ExistsCheck", shopTemplateModel.Sqlprms);
        }

        public ShopTemplateModel ShopTemplateModel_Select(ShopTemplateModel shopTemplateModel)
        {
            BaseDL bdl = new BaseDL();
            shopTemplateModel.Sqlprms = new SqlParameter[3];
            shopTemplateModel.Sqlprms[0] = new SqlParameter("@TemplateID", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateID };
            shopTemplateModel.Sqlprms[1] = new SqlParameter("@TemplateName", SqlDbType.VarChar) { Value = shopTemplateModel.TemplateName };
            shopTemplateModel.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = shopTemplateModel.Status };
            DataTable dt= bdl.SelectDatatable("ShopTemplate_Select", shopTemplateModel.Sqlprms);
            foreach(DataRow dr in dt.Rows)
            {
                shopTemplateModel.TemplateName = dr["TemplateName"].ToString();
                shopTemplateModel.R_racket = dr["R_racket_Template"].ToString();
                shopTemplateModel.R_sportsplaza = dr["R_sportsplaza_Template"].ToString();
                shopTemplateModel.R_luckpiece = dr["R_luckpiece_Template"].ToString();
                shopTemplateModel.R_honpo = dr["R_honpo_Template"].ToString();
                shopTemplateModel.Y_racket = dr["Y_racket_Template"].ToString();
                shopTemplateModel.Y_sportsplaza = dr["Y_sportsplaza_Template"].ToString();
                shopTemplateModel.Y_luckpiece = dr["Y_luckpiece_Template"].ToString();
                shopTemplateModel.Y_honpo = dr["Y_honpo_Template"].ToString();
                shopTemplateModel.Y_bb_plaza = dr["Y_bb_plaza_Template"].ToString();
                shopTemplateModel.P_racket = dr["P_racket_Template"].ToString();
                shopTemplateModel.A_rasta = dr["A_rasta_Template"].ToString();
                shopTemplateModel.J_racket = dr["J_racket_Template"].ToString();
                shopTemplateModel.W_wowma = dr["W_wowma_Template"].ToString();
                shopTemplateModel.Status = dr["Status"].ToString();
            }
            return shopTemplateModel;
        }
    }
}
