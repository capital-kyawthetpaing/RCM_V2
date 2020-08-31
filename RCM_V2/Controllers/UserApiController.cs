using System;
using System.Web.Http;
using User_BL;
using Models;
using System.Data;
using View_BL;
using Newtonsoft.Json;

namespace RCM_V2.Controllers
{
    public class UserApiController : ApiController
    {

        [UserAuthentication]
        [HttpPost]
        [ActionName("User_Select")]
        public IHttpActionResult User_Select([FromBody]UserModel Umodel)
        {
            UserBL Ubl = new UserBL();
            return Ok(Ubl.User_Select(Umodel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("User_Save")]
        public IHttpActionResult User_Save([FromBody]UserModel Umodel)
        {
            UserBL Ubl = new UserBL();
           // Umodel.ViewJson = JsonConvert.SerializeObject(Umodel.UserView);
            return Ok(Ubl.User_Save(Umodel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("User_ExistCheck")]
        public IHttpActionResult User_ExistCheck([FromBody] UserModel Umodel)
        {
            UserBL Ubl = new UserBL();
            Umodel.UserID = Umodel.Val1;
            return Ok(Ubl.User_ExistsCheck(Umodel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("View_Select")]
        public IHttpActionResult View_Select([FromBody] ViewModel viewModel)
        {
            ViewBL viewBL = new ViewBL();
            return Ok(viewBL.View_Select(viewModel));
        }
    }
}
