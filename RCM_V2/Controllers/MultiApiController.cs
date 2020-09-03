using Multi_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCM_V2.Controllers
{
    public class MultiApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult Year_Select()
        {
            MultiBL multiBL = new MultiBL();
            return Ok(multiBL.Year_Select());
        }

        [UserAuthentication]
        [HttpPost]
        public IHttpActionResult Season_Select()
        {
            MultiBL multiBL = new MultiBL();
            return Ok(multiBL.Season_Select());
        }
    }
}
