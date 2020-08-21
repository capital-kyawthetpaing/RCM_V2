
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserModel : BaseModel
    {
        [Display(Name ="ID")]
        public string UserID { get; set; }
        public string UserName { get; set; }
        [Display(Name = "パスワード")]
        public string Password { get; set; }
    }

   
}
