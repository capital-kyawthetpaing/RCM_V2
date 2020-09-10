using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel:BaseModel
    {
        public string CategoryCD { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryCD { get; set; }
        public string SEQ { get; set; }
    }

    public class CategoryListModel:BaseModel
    {
        public List<CategoryModel> CategoryList { get; set; }
    }
}
