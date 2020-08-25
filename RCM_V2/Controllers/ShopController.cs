using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_BL;
using Models;
using Newtonsoft.Json;

namespace RCM_V2.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult ShopList()
        {
            return View();
        }

        public ActionResult ShopEntry(string id, string mode)
        {
            ShopBL bl = new ShopBL();
            ShopModel obj = new ShopModel();
            obj.ShopID = id;
            obj.Mode = mode;
            if (mode == "Edit")
                obj = bl.ShopModel_Select(obj);           
            return View(obj);
            
        }
    }
}