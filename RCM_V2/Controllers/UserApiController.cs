using System.Web.Http;
using User_BL;
using Models;

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

        //[UserAuthentication]
        //[HttpPost]
        //[ActionName("User_Select")]
        //public IHttpActionResult User_Select(string id)
        //{
        //    UserBL Ubl = new UserBL();
        //    //Ubl.User_Select(Umodel)
        //    return Ok();
        //}

        //[HttpGet]
        //[ActionName("User_Select")]
        //public IHttpActionResult User_Select(string id)
        //{
        //    UserBL Ubl = new UserBL();
        //    //Ubl.User_Select(Umodel)
        //    return Ok();
        //}

        //[UserAuthentication]
        //[HttpPost]
        //[ActionName("User_Select")]
        //public IHttpActionResult User_Select([FromBody] UserModel Umodel)
        //{
        //    UserBL Ubl = new UserBL();
        //    return Ok(Ubl.User_Select(Umodel));
        //}

        //[UserAuthentication]
        //[HttpGet]
        //[ActionName("GetUserList")]
    }
}
