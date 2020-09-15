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
        #endregion

        public ExportFieldsModel exportFieldsModel { get; set; }

        #region ItemPrice
        public string ListPrice { get; set; }
        public string SalePrice { get; set; }
        public string RakutenPrice { get; set; }
        public string Cost { get; set; }
        #endregion
    }
}
