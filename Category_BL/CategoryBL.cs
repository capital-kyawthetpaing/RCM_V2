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
            model.Sqlprms = new SqlParameter[1];
            model.Sqlprms[0] = new SqlParameter("@ParentCatCD", model.ParentCategoryCD);
            return bdl.SelectDatatable("Category_Select", model.Sqlprms);
        }
        
        public string CategorySerial_Update(CategoryListModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[1];
            model.Sqlprms[0] = new SqlParameter("@CategoryJson", JsonConvert.SerializeObject(model.CategoryList));
            return bdl.InsertUpdateDeleteData("CategorySerial_Update", model.Sqlprms);
        }
    }
}
