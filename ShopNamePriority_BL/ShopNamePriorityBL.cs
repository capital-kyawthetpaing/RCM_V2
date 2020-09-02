using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNamePriority_BL
{
    public class ShopNamePriorityBL
    {
        public string ShopPriority_Select(MutiModel shopModel)
        {
            BaseDL bdl = new BaseDL();
          
            return bdl.SelectJson("ShopPriority_Select",null);
        }


    }
}
