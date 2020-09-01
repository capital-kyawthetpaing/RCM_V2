using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult ExportColumnList()
        {
            return PartialView();
        }
    }
}