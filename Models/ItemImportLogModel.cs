using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemImportLogModel:BaseModel
    {
        public int AutoID { get; set; }
        public string ImportType { get; set; }
        public int ImportCount { get; set; }
        public int ErrorCount { get; set; }
        public string ImportedBy { get; set; }
        public DateTime ImportedDateTime { get; set; }
    }
}
