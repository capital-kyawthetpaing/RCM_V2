using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryTreeInfo
    {
        public string text { get; set; }
        public string Code { get; set; }
        public List<CategoryTreeInfo> nodes { get; set; }
    }
}
