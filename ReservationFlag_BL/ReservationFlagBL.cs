using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationFlag_BL
{
    public class ReservationFlagBL
    {
        public string ReservationFlag_Select()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectJson("ReservationFlag_Select", null);
        }
    }
}
