namespace Models
{
    public class ItemModel : BaseModel
    {
        #region Item
        public bool chkiv { get; set; }
        public string ItemCD { get; set; }
        public string ItemName { get; set; }
        public string MakerCD { get; set; }
        public string YearCD { get; set; }
        public string SeasonCD { get; set; }
        public string CatalogInfo { get; set; }
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
