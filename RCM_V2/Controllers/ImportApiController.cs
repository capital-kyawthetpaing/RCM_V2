using Import_BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCM_V2.Controllers
{
    public class ImportApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ItemImportLog_Select")]
        public IHttpActionResult ItemImportLog_Select([FromBody] ItemImportLogModel itmImportModel)
        {
            ImportBL bl = new ImportBL();
            return Ok(bl.ItemImportLog_Select(itmImportModel));
        }
    }
}
