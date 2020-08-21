namespace Models
{
    public class ShopModel:BaseModel
    {
        public string ShopID { get; set; }
        public string ShopName { get; set; }
        public string MallID { get; set; }
        public string FtpHost { get; set; }
        public string FtpUserName { get; set; }
        public string FtpPassword { get; set; }
        public string ImageURL { get; set; }
        public string ItemURL { get; set; }
        public string FreeShippingAmount { get; set; }
    }
}
