namespace Models
{
    public class UserModel : BaseModel
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DeleteFlg { get; set; }
    }
}
