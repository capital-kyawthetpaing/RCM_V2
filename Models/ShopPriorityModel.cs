using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
   public class ShopPriorityModel : BaseModel {

        public string ShopID { get; set; }
        public string PrioritySEQForm { get; set; }
        public string PrioritySEQColumn { get; set; }

    }
}
