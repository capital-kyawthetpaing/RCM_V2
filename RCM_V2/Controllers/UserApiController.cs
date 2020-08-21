using System.Web.Http;
using User_BL;
using Models;
using System.Data;

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

    }
}
