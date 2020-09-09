using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class MallController : Controller
    {
        // GET: Mall
        public ActionResult MallSetting_Rakuten_Fixed()
        {
            return View();
        }
        public ActionResult MallSetting_Yahoo_Fixed()
        {
            return View();
        }
    }
}