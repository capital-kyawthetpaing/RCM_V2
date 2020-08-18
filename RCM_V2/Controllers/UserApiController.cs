using System.Web.Http;
using User_BL;
using Models;

namespace RCM_V2.Controllers
{
    public class UserApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        public string UserLogin_Select([FromBody] UserModel Umodel)
        {
            UserBL Ubl = new UserBL();
            return Ubl.UserLogin_Select(Umodel);
        }
    }
}
