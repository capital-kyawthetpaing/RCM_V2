using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Notice_BL;

namespace RCM_V2.Controllers
{
    public class DashboardApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("Notice_Select")]
        public IHttpActionResult Notice_Select()
        {
            NoticeBL bl = new NoticeBL();
            return Ok(bl.NoticeSelect());
        }
    }
}
