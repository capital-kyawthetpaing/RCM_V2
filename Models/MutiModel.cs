using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
  public  class MutiModel : BaseModel {
        public ShopModel model { get; set; }
        public Shop_ItemNamePriorityModel pmodel { get; set; }


        public ItemModel itemModel { get; set; }
        public ExportFieldsModel exportFieldsModel { get; set; }

      
    }
}
