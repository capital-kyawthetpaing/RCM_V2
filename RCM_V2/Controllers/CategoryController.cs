using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        public ActionResult Test()
        {
            return View();
        }
    }
}