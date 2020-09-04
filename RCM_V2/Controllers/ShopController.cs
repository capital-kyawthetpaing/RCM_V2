using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_BL;
using Models;
using Newtonsoft.Json;
using ShopTemplate_BL;
using ShopNamePriority_BL;


namespace RCM_V2.Controllers
{
    public class ShopController : Controller
    {
        #region Shop
        // GET: Shop
        public ActionResult ShopList()
        {
            return View();
        }

        public ActionResult ShopEntry(ShopModel shopModel)
        {
            if (shopModel.Mode == null)
            {
                shopModel = new ShopModel();
                shopModel.Mode = "New";
            }

            ShopBL bl = new ShopBL();

            if (shopModel.Mode.Equals("Edit"))
                shopModel = bl.ShopModel_Select(shopModel);
            return View(shopModel);
        }

        #endregion

        #region ShopTemplate

        public ActionResult Shop_TemplateList()
        {
            return View();
        }

        public ActionResult Shop_TemplateEntry(ShopTemplateModel shopTemplateModel)
        {
            if (shopTemplateModel.Mode == null)
            {
                shopTemplateModel = new ShopTemplateModel();
                shopTemplateModel.Mode = "New";
            }

            ShopTemplateBL bl = new ShopTemplateBL();

            if (shopTemplateModel.Mode.Equals("Edit"))
                shopTemplateModel = bl.ShopTemplateModel_Select(shopTemplateModel);
            return View(shopTemplateModel);
        }

        #endregion

        #region Option
        public ActionResult OptionTemplateList()
        {
            return View();
        }
        #endregion

        public ActionResult Shop_ItemNamePriority()
        {
            return View();
        }

        public ActionResult Shop_ItemNamePriorityList()
        {
            return View();
        }

        public ActionResult Shop_ItemNameSettingEntry(Shop_ItemNamePriorityModel shopitmNamePriModel)
        {
            ShopNamePriorityBL bl = new ShopNamePriorityBL();
            if(!string.IsNullOrEmpty(shopitmNamePriModel.ShopID))
            {
                shopitmNamePriModel = bl.ShopPriorityModel_Select(shopitmNamePriModel);
            }
            shopitmNamePriModel = new Shop_ItemNamePriorityModel();
            return View(shopitmNamePriModel);
        }
    }
}