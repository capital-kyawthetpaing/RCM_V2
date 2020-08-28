using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User_BL;
using Models;
using Newtonsoft.Json;

namespace RCM_V2.Controllers
{
    public class UserController : Controller
    {
        
        // GET: User
        public ActionResult UserLogin()
        {
            return View();
        }

        public ActionResult UserList()
        {
            return View();
        }
        //public ActionResult UserEntry(string id,string mode)
        //{
        //    UserBL bl = new UserBL();
        //    UserModel obj = new UserModel();
        //    obj.UserID = id;
        //    obj.Mode = mode;
        //    if (mode == "Edit")
        //        obj = bl.UserModel_Select(obj);
        //    return View(obj);
        //}
        //public ActionResult UserEntry(UserModel userModel)
        //{
        //    if (userModel.Mode == null)
        //    {
        //        userModel = new UserModel();
        //        userModel.Mode = "New";
        //    }

        //    UserBL bl = new UserBL();

        //    if (userModel.Mode.Equals("Edit"))
        //        userModel = bl.UserModel_Select(userModel);
        //    return View(userModel);
        //}
    }
}