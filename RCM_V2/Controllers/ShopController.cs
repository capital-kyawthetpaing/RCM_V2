using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_BL;
using Models;
using Newtonsoft.Json;
using ShopTemplate_BL;

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

        public ActionResult Shop_TemplateList()
        {
            return View();
        }

        public ActionResult Shop_TemplateEntry(string id,string mode)
        {
            ShopTemplateBL bl = new ShopTemplateBL();
            ShopTemplateModel obj = new ShopTemplateModel();
            obj.TemplateID = id;
            obj.Mode = mode;
            if (mode == "Edit")
                obj = bl.ShopTemplateModel_Select(obj);
            return View(obj);
        }

        public ActionResult Shop_ItemNamePriority()
        {
            return View();
        }


    }
}