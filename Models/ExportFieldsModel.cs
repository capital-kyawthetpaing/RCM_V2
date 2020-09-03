using System.Collections.Generic;

namespace Models
{
    public class ExportFieldsModel : BaseModel
    {
        public string AutoID { get; set; }
        public string ExportName { get; set; }
        public string ExportValue { get; set; }
        public string ExportType { get; set; }
        public List<ExportFieldInfo> ExportFieldList { get; set; }
        public string ExportFieldJson { get; set; }
    }

    public class ExportFieldInfo
    {
        public string FormColumnName { get; set; }
        public string TableColumnName { get; set; }
    }
}
