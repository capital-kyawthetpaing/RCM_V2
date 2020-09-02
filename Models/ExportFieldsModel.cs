using System.Collections.Generic;

namespace Models
{
    public class ExportFieldsModel : BaseModel
    {
        public string ExportName { get; set; }
        public string ExportValue { get; set; }
        public string ExportType { get; set; }
        public List<string> TableColumnList { get; set; }
        public List<string> FormColumnList { get; set; }
        public string TableColumnJson { get; set; }
        public string FormColumnJson { get; set; }
    }
}
