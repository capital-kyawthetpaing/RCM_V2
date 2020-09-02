using Models;
using Option_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM_V2.Controllers
{
    public class OptionController : Controller
    {
        // GET: Option
        public ActionResult OptionEntry(OptionModel optionModel)
        {
            if (optionModel.Mode == null)
            {
                optionModel = new OptionModel();
                optionModel.Mode = "New";
            }

            OptionBL bl = new OptionBL();

            if (optionModel.Mode.Equals("Edit"))
                optionModel = bl.OptionModel_Select(optionModel);
            return View(optionModel);
        }
    }
}