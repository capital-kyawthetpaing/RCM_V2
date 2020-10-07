using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class ImportController : Controller
    {
        // GET: Import
        public ActionResult ItemImportLogList()
        {
            return View();
        }
        public ActionResult Import_Item_Data()
        {
            return View();
        }
        public ActionResult Import_Template_Detail()
        {
            return View();
        }
    }
}