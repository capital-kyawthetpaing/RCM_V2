using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Category_BL;
using System.Data;
using System.Web.Http.Results;


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
        [ActionName("GetRootNode")]
        public IHttpActionResult GetRootNode(CategoryModel model)
        {
            CategoryModel m = new CategoryModel();
            List<CategoryTreeInfo> items = GetTree(m);
            return Ok(items);
        }

        public static List<CategoryTreeInfo> GetTree(CategoryModel categoryModel)
        {
            var items = new List<CategoryTreeInfo>();
            CategoryBL bl = new CategoryBL();
            DataTable dt = bl.Category_Select(categoryModel);
            foreach (DataRow dr in dt.Rows)
            {
                CategoryTreeInfo m = new CategoryTreeInfo();
                if (dr["ParentCategoryCD"].ToString() == "0000")
                {
                    m.id = dr["CategoryCD"].ToString();
                    m.text = dr["CategoryName"].ToString();
                    m.parent = "#";
                    m.SEQ = dr["SEQ"].ToString();
                    m.children = Convert.ToInt32(dr["ChildCount"]) > 0 ? true : false;
                    items.Add(m);
                }
            }
            return items;
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("GetChildren")]
        public IHttpActionResult GetChildren(string id)
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.ParentCategoryCD = id;
            List<CategoryTreeInfo> items = GetChildTree(categoryModel);
            return Ok(items);
        }
        public static List<CategoryTreeInfo> GetChildTree(CategoryModel categoryModel)
        {
            var items = new List<CategoryTreeInfo>();
            CategoryBL bl = new CategoryBL();
            DataTable dt = bl.Category_Select(categoryModel);
            foreach (DataRow dr in dt.Rows)
            {
                CategoryTreeInfo m = new CategoryTreeInfo();
                m.id = dr["CategoryCD"].ToString();
                m.text = dr["CategoryName"].ToString();
                m.parent = dr["ParentCategoryCD"].ToString();
                m.SEQ = dr["SEQ"].ToString();
                m.children = Convert.ToInt32(dr["ChildCount"]) > 0 ? true : false;
                items.Add(m);
            }
            return items;
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ChildCategory_Select")]
        public IHttpActionResult ChildCategory_Select(CategoryModel categoryModel)
        {
            CategoryBL bl = new CategoryBL();
            return Ok(GetChildTree(categoryModel));
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
