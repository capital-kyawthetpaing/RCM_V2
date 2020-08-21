using Models;
using DL;
using System.Data.SqlClient;

namespace Mall_BL
{
    public class MallBL
    {
        public string Mall_Select(MallModel mallModel)
        {
            BaseDL bdl = new BaseDL();
            mallModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("User_Select", mallModel.Sqlprms);
        }
    }
}
