using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Category_BL;
using Models;

namespace RCM_V2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult MallCategoryList(string id)
        {
            MallCategoryModel obj = new MallCategoryModel();
            obj.MallID = id;
            return View(obj);
        }

        public ActionResult CategoryList()
        {
            return View();
        }

        public ActionResult Test1()
        {
            return View();
        }

        public class JsTreeModel
        {
            public string id { get; set; }
            public string parent { get; set; }
            public string text { get; set; }
            public bool children { get; set; } // if node has sub-nodes set true or not set false
        }
        public JsonResult GetRoot()
        {
            CategoryModel m = new CategoryModel();
            List<JsTreeModel> items = GetTree(m);

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetChildren(string id)
        {
            CategoryModel categoryModel = new CategoryModel(); ;
            categoryModel.ParentCategoryCD = id;
            List<JsTreeModel> items = GetChildTree(categoryModel);

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        static List<JsTreeModel> GetTree(CategoryModel categoryModel)
        {
            var items = new List<JsTreeModel>();
            CategoryBL bl = new CategoryBL();
            DataTable dt = bl.Category_Select(categoryModel);
           
            foreach (DataRow dr in dt.Rows)
            {
                JsTreeModel m = new JsTreeModel();
                if (string.IsNullOrEmpty(dr["ParentCategoryCD"].ToString()) && dr["CategoryCD"].ToString() == "Root")
                {
                    m.id = dr["CategoryCD"].ToString();
                    m.text = dr["CategoryName"].ToString();
                    m.parent = "#";
                    m.children = true;
                    items.Add(m);
                }
            }
            
            return items;
        }

        static List<JsTreeModel> GetChildTree(CategoryModel categoryModel)
        {
            var items = new List<JsTreeModel>();
            CategoryBL bl = new CategoryBL();
            DataTable dt = bl.Category_Select(categoryModel);
            foreach (DataRow dr in dt.Rows)
            {
                JsTreeModel m = new JsTreeModel();
                m.id = dr["CategoryCD"].ToString();
                m.text = dr["CategoryName"].ToString();
                m.parent = dr["ParentCategoryCD"].ToString();
                m.children = Convert.ToInt32(dr["ChildCount"]) > 0 ? true : false;
                items.Add(m);
            }
            return items;
        }
    }
}