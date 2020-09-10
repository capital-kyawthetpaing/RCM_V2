using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Category_BL;
using System.Data;


namespace RCM_V2.Controllers
{
    public class CategoryApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("MallCategory_Select")]
        public IHttpActionResult MallCategory_Select(MallCategoryModel mallCategoryModel)
        {
            CategoryBL bl = new CategoryBL();
            return Ok(bl.MallCategory_Select(mallCategoryModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("CategoryTree_Select")]
        public IHttpActionResult CategoryTree_Select(CategoryModel categoryModel)
        {
            CategoryBL bl = new CategoryBL();
            DataTable dt = bl.Category_Select(categoryModel);
            List<CategoryTreeInfo> clist = new List<CategoryTreeInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                if (string.IsNullOrEmpty(dr["ParentCategoryCD"].ToString()) && dr["CategoryCD"].ToString()=="Root")
                {
                    CategoryTreeInfo info = new CategoryTreeInfo();
                    info.text = dr["CategoryName"].ToString();
                    info.Code = dr["CategoryCD"].ToString();
                    info.nodes = GetChildern(dr["CategoryCD"].ToString(), dt);
                    clist.Add(info);
                }
            }        
            return Ok(clist);
        }

        public List<CategoryTreeInfo> GetChildern(string ParentCode,DataTable dt)
        {
            List<CategoryTreeInfo> clist = new List<CategoryTreeInfo>();            
            foreach(DataRow dr in dt.Rows)
            {
                if (dr["ParentCategoryCD"].ToString() == ParentCode)
                {
                    CategoryTreeInfo cinfo = new CategoryTreeInfo();
                    cinfo.text = dr["CategoryName"].ToString();
                    cinfo.Code = dr["CategoryCD"].ToString();
                    cinfo.nodes = GetChildern(dr["CategoryCD"].ToString(), dt);
                    clist.Add(cinfo);
                }                
            }
            return clist;
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ChildCategory_Select")]
        public IHttpActionResult ChildCategory_Select(CategoryModel categoryModel)
        {
            CategoryBL bl = new CategoryBL();
            return Ok(bl.Category_Select(categoryModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("CategorySerial_Update")]
        public IHttpActionResult CategorySerial_Update(CategoryListModel categoryModel)
        {
            CategoryBL bl = new CategoryBL();
            return Ok(bl.CategorySerial_Update(categoryModel));
        }


        [UserAuthentication]
        [HttpPost]
        [ActionName("Category_CUD")]
        public IHttpActionResult Category_CUD([FromBody] CategoryEntryModel categoryModel)
        {
            CategoryBL categoryBL = new CategoryBL();
            return Ok(categoryBL.Category_CUD(categoryModel));
        }

    }
}
