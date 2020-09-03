using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult ItemManageList()
        {
            return View();
        }

        //GET: Item_View2
        public ActionResult Item_View2()
        {
            return View();
        }
    }
}