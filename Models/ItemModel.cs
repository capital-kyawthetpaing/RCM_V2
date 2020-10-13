namespace Models
{
    public class ItemModel : BaseModel
    {
        #region Item
        public bool chkiv { get; set; }
        public string Type { get; set; }
        public string ExportID { get; set; }
        public string ItemCD { get; set; }
        public string ItemName { get; set; }
        public string MakerCD { get; set; }
        public string YearCD { get; set; }
        public string SeasonCD { get; set; }
        public string CatalogInfo { get; set; }
        public string SpecialFlagCD { get; set; }
        public string ReservationFlagCD { get; set; }
        public string UserID { get; set; }
        public string CompetitionName { get; set; }
        public string ClassName { get; set; }
        public string JanCD { get; set; }
        public string BrandName { get; set; }
        public string MakerName { get; set; }
        public string ImageFileName { get; set; }
        public string CategoryName { get; set; }
        public string ColorName { get; set; }
        public string SearchKeyword { get; set; }
        public string SKSStatus { get; set; }
        public string ShopStatus { get; set; }
        public string CampaignImage { get; set; }
        public string ShopCategory { get; set; }
        public string CategoryRakuten { get; set; }
        public string CategoryYahoo { get; set; }
        public string CategoryPonpare { get; set; }
        public string CategoryWowma { get; set; }
        public string Yahoospec { get; set; }
        public string JanTextbox { get; set; }
        public string ItemZSale { get; set; }
        public string ItemZ { get; set; }
        public string ProductInfo { get; set; }
        public string PcSaleDescriptionSmart { get; set; }
        public string PcSaleDescription { get; set; }
        public string ProductDetail { get; set; }
        public string RelatedComment { get; set; }
        public string ProductName { get; set; }
        public string RelatedProduct { get; set; }

        #endregion

        public ExportFieldsModel exportFieldsModel { get; set; }

        #region ItemPrice
        public string ListPrice { get; set; }
        public string SalePrice { get; set; }
        public string RakutenPrice { get; set; }
        public string Cost { get; set; }
        #endregion

        public string fileName { get; set; }
        public string sheetName { get; set; }
        public string importType { get; set; }
    }
}
