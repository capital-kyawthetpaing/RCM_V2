using Models;
using Option_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCM_V2.Controllers
{
    public class OptionApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("Option_Save")]
        public IHttpActionResult Option_Save([FromBody] OptionModel optionModel)
        {
            OptionBL optionBL = new OptionBL();
            return Ok(optionBL.Option_Save(optionModel));
        }
    }
}
