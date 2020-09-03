using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ExportField_BL;

namespace RCM_V2.Controllers
{
    public class ExportFieldApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ExportField_Save")]
        public IHttpActionResult ExportField_Save(ExportFieldsModel exportFieldsModel)
        {
            ExportFieldBL bl = new ExportFieldBL();
            return Ok(bl.ExportField_Save(exportFieldsModel));
        }
    }
}
