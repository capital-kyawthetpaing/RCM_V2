using DL;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace User_BL
{
    public class UserBL
    {
        public string UserLogin_Select(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[2];
            Umodel.Sqlprms[0] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = Umodel.UserID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };

            return bdl.SelectJson("User_Select", Umodel.Sqlprms);
        }
    }
}
