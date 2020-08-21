using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Message_BL;

namespace RCM_V2.Controllers
{
    public class MessageApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult Message_Select([FromBody] MessageModel messageModel)
        {
            MessageBL messageBL = new MessageBL();
            return Ok(messageBL.Message_Select(messageModel));
        }
    }
}
