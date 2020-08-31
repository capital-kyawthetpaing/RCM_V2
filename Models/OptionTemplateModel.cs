using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OptionTemplateModel:BaseModel
    {
        public int AutoID { get; set; }
        public string GroupName { get; set; }
        public string Option1 { get; set; }
        public string Value1 { get; set; }
        public string Option2 { get; set; }
        public string Value2 { get; set; }
        public string Option3 { get; set; }
        public string Value3 { get; set; }
        public string Option4 { get; set; }
        public string Value4 { get; set; }
        public string Option5 { get; set; }
        public string Value5 { get; set; }
    }
}
