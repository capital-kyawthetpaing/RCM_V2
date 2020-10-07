using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Item_BL;
using SpecialFlag_BL;
using ReservationFlag_BL;
using SKUStockList_BL;
using SKU_BL;

namespace RCM_V2.Controllers
{
    public class ItemApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ItemManage_List")]
        public IHttpActionResult ItemManage_List(ItemModel itemModel)
        {
            ItemBL itemBL = new ItemBL();
            return Ok(itemBL.ItemManage_List(itemModel));
        }

        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult SpecialFlag_Select()
        {
            SpecialFlagBL specialFlagBL = new SpecialFlagBL();
            return Ok(specialFlagBL.SpecialFlag_Select());
        }

        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult ReservationFlag_Select()
        {
            ReservationFlagBL reservationFlagBL = new ReservationFlagBL();
            return Ok(reservationFlagBL.ReservationFlag_Select());
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("SKU_Stock_Select")]
        public IHttpActionResult SKU_Stock_Select([FromBody] ItemModel skuModel)
        {
            SKUStockListBL skuBL = new SKUStockListBL();
            return Ok(skuBL.SKU_Stock_Select(skuModel));          
        }      
        [UserAuthentication]
        [HttpPost]
        [ActionName("SKU_Select")]
        public IHttpActionResult SKU_Select([FromBody] ItemModel skuModel)
        {
            SKUBL _skuBL = new SKUBL();
            return Ok(_skuBL.SKU_Select(skuModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ItemPageCreate_List")]
        public IHttpActionResult ItemPageCreate_List(ItemModel itemModel)
        {
            ItemBL itemBL = new ItemBL();
            return Ok(itemBL.ItemPageCreate_List(itemModel));
        }
    }
}
