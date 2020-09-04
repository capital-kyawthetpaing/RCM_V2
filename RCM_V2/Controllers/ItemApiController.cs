using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Item_BL;
using SKUStock_BL;

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
        [UserAuthentication]
        [HttpPost]
        [ActionName("ItemManage_List")]
        public IHttpActionResult ItemManage_List([FromBody] ItemModel itemModel)
        {
            ItemBL itemBL = new ItemBL();
            return Ok(itemBL.ItemManage_List(itemModel));
        }


        [UserAuthentication]
        [HttpPost]
        [ActionName("SKU_Stock_Select")]
        public IHttpActionResult SKU_Stock_Select([FromBody] ItemModel skuModel)
        {
            SkuStockBL skuBL = new SkuStockBL();
            return Ok(skuBL.SKU_Stock_Select(skuModel));
        }
    }
}
