using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mall_BL;
using Models;

namespace RCM_V2.Controllers
{
    public class MallApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult User_Select([FromBody] MallModel mallModel)
        {
            MallBL mallBL = new MallBL();
            return Ok(mallBL.Mall_Select(mallModel));
        }
    }
}
