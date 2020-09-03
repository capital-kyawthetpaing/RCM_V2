using DL;
using System;
using System.Collections.Generic;
namespace Multi_BL
{
    public class MultiBL
    {
        public string Year_Select()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectJson("Year_Select", null);
        }

        public string Season_Select()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectJson("Season_Select",null);
        }
    }
}
