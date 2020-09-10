using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
   public class CategoryEntryModel : BaseModel {
        public string CategoryCD { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryCD { get; set; }
        public string RakutenDirectoryID { get; set; }
        public string YahooCategoryID { get; set; }
        public string PonpareCategoryID { get; set; }
        public string WowmaCategoryID { get; set; }
        public string RakutenCategorySetNo { get; set; }
        public string R_RacketCategoryID { get; set; }
        public string R_SportsPlazaCategoryID { get; set; }
        public string R_LuckpieceCategoryID { get; set; }
        public string R_HonpoCategoryID { get; set; }
        public string SEQ { get; set; }
     
    }
}


