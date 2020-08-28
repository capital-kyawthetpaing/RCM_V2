using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class ExportFieldController : Controller
    {
        // GET: ExportField
        public ActionResult ExportFieldEntry()
        {
            return View();
        }

        public ActionResult ExportFieldList()
        {
            return View();
        }
    }
}