using System;
using System.Data;
using System.Data.SqlClient;
using Models;
using DL;
using Newtonsoft.Json;


namespace Category_BL
{
    public class CategoryBL
    {
      public string  MallCategory_Select(MallCategoryModel mallCategoryModel)
      {
            BaseDL bdl = new BaseDL();
            string category1 = string.Empty;
            string category2 = string.Empty;
            string category3=string.Empty;
            if(!string.IsNullOrEmpty(mallCategoryModel.CategoryPath))
            {
                string[] arr = mallCategoryModel.CategoryPath.Split(',');
                if(arr.Length>0)                
                    category1 = mallCategoryModel.CategoryPath.Split(',')[0];
                if(arr.Length>1)
                    category2 = mallCategoryModel.CategoryPath.Split(',')[1];
                if(arr.Length>2)
                    category3 = mallCategoryModel.CategoryPath.Split(',')[2];
            }
            mallCategoryModel.Sqlprms= new SqlParameter[4];
            mallCategoryModel.Sqlprms[0] = new SqlParameter("@MallID", SqlDbType.VarChar) { Value=mallCategoryModel.MallID};
            mallCategoryModel.Sqlprms[1] = new SqlParameter("@cname1", SqlDbType.VarChar) { Value = category1 };
            mallCategoryModel.Sqlprms[2] = new SqlParameter("@cname2", SqlDbType.VarChar) { Value = category2 };
            mallCategoryModel.Sqlprms[3] = new SqlParameter("@cname3", SqlDbType.VarChar) { Value = category3};
            return bdl.SelectJson("MallCategory_Select", mallCategoryModel.Sqlprms);
        }

        public DataTable Category_Select(CategoryModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[2];
            model.Sqlprms[0] = new SqlParameter("@ParentCatCD", model.ParentCategoryCD);
            model.Sqlprms[1] = new SqlParameter("@CategoryCD", model.CategoryCD);
            return bdl.SelectDatatable("Category_Select", model.Sqlprms);
        }

        public string CategorySerial_Update(CategoryListModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[1];
            model.Sqlprms[0] = new SqlParameter("@CategoryJson", JsonConvert.SerializeObject(model.CategoryList));
            return bdl.InsertUpdateDeleteData("CategorySerial_Update", model.Sqlprms);
        }

        public string Category_CUD(CategoryEntryModel categoryModel)
        {
            BaseDL bdl = new BaseDL();
            categoryModel.Sqlprms = new SqlParameter[13];
            categoryModel.Sqlprms[0] = new SqlParameter("@CategoryName", SqlDbType.VarChar) { Value = categoryModel.CategoryName };
            categoryModel.Sqlprms[1] = new SqlParameter("@ParentCategoryCD", SqlDbType.VarChar) { Value = categoryModel.ParentCategoryCD };
            categoryModel.Sqlprms[2] = new SqlParameter("@RakutenDirectoryID", SqlDbType.VarChar) { Value = categoryModel.RakutenDirectoryID };
            categoryModel.Sqlprms[3] = new SqlParameter("@YahooCategoryID", SqlDbType.VarChar) { Value = categoryModel.YahooCategoryID };
            categoryModel.Sqlprms[4] = new SqlParameter("@PonpareCategoryID", SqlDbType.VarChar) { Value = categoryModel.PonpareCategoryID };
            categoryModel.Sqlprms[5] = new SqlParameter("@WowmaCategoryID", SqlDbType.VarChar) { Value = categoryModel.WowmaCategoryID };
            categoryModel.Sqlprms[6] = new SqlParameter("@RakutenCategorySetNo", SqlDbType.VarChar) { Value = categoryModel.RakutenCategorySetNo };
            categoryModel.Sqlprms[7] = new SqlParameter("@R_RacketCategoryID", SqlDbType.VarChar) { Value = categoryModel.R_RacketCategoryID };
            categoryModel.Sqlprms[8] = new SqlParameter("@R_SportsPlazaCategoryID", SqlDbType.VarChar) { Value = categoryModel.R_SportsPlazaCategoryID };
            categoryModel.Sqlprms[9] = new SqlParameter("@R_LuckpieceCategoryID", SqlDbType.VarChar) { Value = categoryModel.R_LuckpieceCategoryID };
            categoryModel.Sqlprms[10] = new SqlParameter("@R_HonpoCategoryID", SqlDbType.VarChar) { Value = categoryModel.R_HonpoCategoryID };
            categoryModel.Sqlprms[11] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = categoryModel.Mode };
            categoryModel.Sqlprms[12] = new SqlParameter("@catid", SqlDbType.VarChar) { Value = categoryModel.CategoryCD };
            return bdl.InsertUpdateDeleteData("Category_CUD", categoryModel.Sqlprms);
        }

        public CategoryEntryModel CategoryModel_Select(CategoryEntryModel categoryModel)
        {
            BaseDL bdl = new BaseDL();
            categoryModel.Sqlprms = new SqlParameter[2];
            categoryModel.Sqlprms[0] = new SqlParameter("@ParentCatCD", SqlDbType.VarChar) { Value = categoryModel.ParentCategoryCD };
            categoryModel.Sqlprms[1] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = categoryModel.CategoryCD };
            DataTable dt= bdl.SelectDatatable("Category_Select", categoryModel.Sqlprms);
            DataRow dr = dt.Rows[0];

                categoryModel.CategoryName = dr["CategoryName"].ToString();
                categoryModel.RakutenDirectoryID = dr["RakutenDirectoryID"].ToString();
                categoryModel.YahooCategoryID = dr["YahooCategoryID"].ToString();
                categoryModel.PonpareCategoryID = dr["PonpareCategoryID"].ToString();
                categoryModel.WowmaCategoryID = dr["WowmaCategoryID"].ToString();
                categoryModel.RakutenCategorySetNo = dr["RakutenCategorySetNo"].ToString();
                categoryModel.R_RacketCategoryID = dr["R_RacketCategoryID"].ToString();
                categoryModel.R_SportsPlazaCategoryID = dr["R_SportsPlazaCategoryID"].ToString();
                categoryModel.R_LuckpieceCategoryID = dr["R_LuckpieceCategoryID"].ToString();
                categoryModel.R_HonpoCategoryID = dr["R_HonpoCategoryID"].ToString();
            
            return categoryModel;


        }

    }
}
