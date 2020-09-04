using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFlag_BL
{
    public class SpecialFlagBL
    {
        public string SpecialFlag_Select()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectJson("SpecialFlag_Select", null);
        }
    }
}