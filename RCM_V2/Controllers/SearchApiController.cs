using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ExportColumn_BL;

namespace RCM_V2.Controllers
{
    public class SearchApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ExportColumn_Select")]
        public IHttpActionResult ExportColumn_Select(ExportColumnModel exportColumnModel)
        {
            ExportColumnBL exportColumnBL = new ExportColumnBL();
            return Ok(exportColumnBL.ExportColumn_Select(exportColumnModel));
        }
    }
}
