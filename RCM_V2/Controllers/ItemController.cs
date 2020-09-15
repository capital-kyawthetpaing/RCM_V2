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

        public ActionResult  ItemManageList2()
        {
            return View();
        }

        public ActionResult ItemStockList()
        {
            return View();
        }

        public ActionResult ItemImportLogList()
        {
            return View();
        }

        public ActionResult ItemEntry()
        {
            return View();
        }
    }
}