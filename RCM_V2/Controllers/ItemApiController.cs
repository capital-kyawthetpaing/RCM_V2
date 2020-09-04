﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Item_BL;
using SpecialFlag_BL;
using ReservationFlag_BL;

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
    }
}