﻿using DL;
using Models;
using System.Data.SqlClient;

namespace View_BL
{
    public class ViewBL
    {
        public string View_Select(ViewModel viewModel)
        {
            BaseDL bdl = new BaseDL();
            viewModel.Sqlprms = new SqlParameter[1];
            viewModel.Sqlprms[0] = new SqlParameter("@UserID", viewModel.UserID);
            return bdl.SelectJson("View_Select", viewModel.Sqlprms);
        }
    }
}
