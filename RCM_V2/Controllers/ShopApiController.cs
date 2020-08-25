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
            return Ok();
            ShopBL shopBL = new ShopBL();
            return Ok(shopBL.Shop_Save(shopModel));
        }
    }
}
