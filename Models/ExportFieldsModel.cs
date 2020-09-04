using System.Collections.Generic;

namespace Models
{
    public class ExportFieldsModel : BaseModel
    {
        public string AutoID { get; set; }
        public string ExportName { get; set; }
        public string ExportValue { get; set; }
        public string ExportValueID { get; set; }
        public string ExportType { get; set; }
        //public List<ExportFieldInfo> ExportFieldList { get; set; }
    }

}
