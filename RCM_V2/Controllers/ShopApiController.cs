using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop_BL;
using Models;
using ShopTemplate_BL;

namespace RCM_V2.Controllers
{
    public class ShopApiController : ApiController
    {
        #region Shop 
        [UserAuthentication]
        [HttpPost]
        [ActionName("Shop_Select")]
        public IHttpActionResult Shop_Select([FromBody] ShopModel shopModel)
        {
            ShopBL shopBL = new ShopBL();
            return Ok(shopBL.Shop_Select(shopModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("Shop_Save")]
        public IHttpActionResult Shop_Save([FromBody] ShopModel shopModel)
        {
            string[] arr = shopModel.MallID.Split('/');
            ShopBL shopBL = new ShopBL();
            shopModel.MallID = arr[0];
            shopModel.ShopID = arr[1] + shopModel.ShopSiteID;
            return Ok(shopBL.Shop_Save(shopModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("Shop_ExistCheck")]
        public IHttpActionResult Shop_ExistCheck([FromBody] ShopModel shopModel)
        {
            ShopBL shopBL = new ShopBL();
            string[] arr = shopModel.Val2.Split('/');
            shopModel.ShopID = shopModel.Val2.Split('/')[1]+ shopModel.Val1;
            return Ok(shopBL.Shop_ExistCheck(shopModel));
        }
        #endregion

        #region Shop Template

        [UserAuthentication]
        [HttpPost]
        [ActionName("ShopTemplate_Select")]
        public IHttpActionResult ShopTemplate_Select([FromBody] ShopTemplateModel shopTemplateModel)
        {
            ShopTemplateBL shopTemplateBL = new ShopTemplateBL();
            return Ok(shopTemplateBL.ShopTemplate_Select(shopTemplateModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ShopTemplate_Save")]
        public IHttpActionResult ShopTemplate_Save([FromBody] ShopTemplateModel shopTemplateModel)
        {
            ShopTemplateBL shopTemplateBL = new ShopTemplateBL();
            return Ok(shopTemplateBL.ShopTemplate_Save(shopTemplateModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ShopTemplate_ExistCheck")]
        public IHttpActionResult ShopTemplate_ExistCheck([FromBody] ShopTemplateModel shopTemplateModel)
        {
            ShopTemplateBL shopTemplateBL = new ShopTemplateBL();
            shopTemplateModel.TemplateID = shopTemplateModel.Val1;
            return Ok(shopTemplateBL.ShopTemplate_ExistCheck(shopTemplateModel));
        }
        #endregion

    }
}
