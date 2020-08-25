using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult ShopList()
        {
            return View();
        }

        public ActionResult Shop_ItemNamePriority()
        {
            return View();
        }

        public ActionResult Shop_TemplateList()
        {
            return View();
        }
    }
}