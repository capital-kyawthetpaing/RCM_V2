using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace Notice_BL
{
    public class NoticeBL
    {
        public string NoticeSelect()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectJson("Notice_Select");
        }
    }
}
