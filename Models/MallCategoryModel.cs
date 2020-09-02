using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MallCategoryModel:BaseModel
    {
        public string MallID { get; set; }
        public string CategoryID { get; set; }
        public string CategoryPath { get; set; }
    }
}
