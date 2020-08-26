using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop_BL;
using Models;

namespace RCM_V2.Controllers
{
    public class ShopApiController : ApiController
    {
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
    }
}
