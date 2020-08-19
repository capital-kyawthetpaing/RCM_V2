using System.Web.Http;
using User_BL;
using Models;

namespace RCM_V2.Controllers
{
    public class UserApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("UserLogin_Select")]
        public IHttpActionResult UserLogin_Select([FromBody] UserModel Umodel)
        {
            UserBL Ubl = new UserBL();           
            return Ok(Ubl.User_Select(Umodel));
        }
    }
}
