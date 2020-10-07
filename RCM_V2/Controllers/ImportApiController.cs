using DL;
using Import_BL;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
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

        [UserAuthentication]
        [HttpPost]
        [ActionName("Import_Item_Data_Save")]
        public HttpResponseMessage Import_Item_Data_Save()
        {
            //Create the Directory.
            string path = HttpContext.Current.Server.MapPath("~/ImportFiles/ItemData/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //Fetch the File.
            HttpPostedFile postedFile = HttpContext.Current.Request.Files[0];

            //Fetch the File Name.
            string fileName = HttpContext.Current.Request.Form["fileName"];
            if (fileName.Contains(".xlsx"))
            {
                fileName = fileName.Replace(" ", "_").Replace(".xls", "");
                fileName = fileName + "$" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss") + ".xlsx";
            }
            //Save the File.
            postedFile.SaveAs(path + fileName);

            //insert to table
            ImportBL bl = new ImportBL();
            bl.Import_Item_Data(path + fileName, "Sheet1");

            //Send OK Response to Client.
            return Request.CreateResponse(HttpStatusCode.OK, fileName);
        }       
    }
}
