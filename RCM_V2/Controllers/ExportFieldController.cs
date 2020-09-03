using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using ExportField_BL;


namespace RCM_V2.Controllers
{
    public class ExportFieldController : Controller
    {
        // GET: ExportField    
        public ActionResult ExportFieldList()
        {
            return View();
        }
        public ActionResult ExportFieldEntry(ExportFieldsModel exportFieldModel)
        {
            if (exportFieldModel.Mode == null)
            {
                exportFieldModel.Mode = "New";
            }

            ExportFieldBL bl = new ExportFieldBL();

            //if (exportFieldModel.Mode.Equals("Edit"))
            //    exportFieldModel = bl.ExportFieldModel_Select(exportFieldModel);           
            return View(exportFieldModel);
        }
    }
}