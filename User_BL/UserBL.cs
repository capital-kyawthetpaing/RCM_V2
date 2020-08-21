using DL;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace User_BL
{
    public class UserBL
    {
        public string User_Select(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[4];
            Umodel.Sqlprms[0] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = Umodel.UserID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };
            Umodel.Sqlprms[2] = new SqlParameter("@UserName", SqlDbType.VarChar) { Value = Umodel.UserName };
            Umodel.Sqlprms[3] = new SqlParameter("@DeleteFlg", SqlDbType.VarChar) { Value = Umodel.DeleteFlg };
            return bdl.SelectJson("User_Select", Umodel.Sqlprms);
        }
    }
}
