namespace Models
{
    public class Shop_ItemNamePriorityModel : BaseModel
    {
        public string ShopID { get; set; }
        public string ShopName { get; set; }
        public string PriorityValue { get; set; }
        public string PriorityValueID { get; set; }
        public string MallID { get; set; }
    }
}
