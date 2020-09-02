using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Item_BL;

namespace RCM_V2.Controllers
{
    public class ItemApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ItemManage_Select")]
        public IHttpActionResult ItemManage_Select(ItemModel itemModel)
        {
            ItemBL itemBL = new ItemBL();
            return Ok(itemBL.ItemManage_Select(itemModel));
        }
    }
}
