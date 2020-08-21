using System.Data.SqlClient;

namespace Models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Mode { get; set; }
        public string SPName { get; set; }
        public SqlParameter[] Sqlprms { get; set; }
        public string DeleteFlg { get; set; }
    }
}
