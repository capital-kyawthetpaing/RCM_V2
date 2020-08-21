using DL;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace Message_BL
{
    public class MessageBL
    {
        public string Message_Select(MessageModel messageModel)
        {
            BaseDL bdl = new BaseDL();
            messageModel.Sqlprms = new SqlParameter[1];
            messageModel.Sqlprms[0] = new SqlParameter("@MessageID", SqlDbType.VarChar) { Value = messageModel.MessageID };
            return bdl.SelectJson("Message_Select", messageModel.Sqlprms);
        }
    }
}
