﻿using DL;
using Models;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System;

namespace User_BL
{
    public class UserBL
    {
        public string User_Select(UserModel Umodel)
        {           
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[4];
            Umodel.Sqlprms[0] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = Umodel.UserID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };
            Umodel.Sqlprms[2] = new SqlParameter("@UserName", SqlDbType.VarChar) { Value = Umodel.UserName };
            Umodel.Sqlprms[3] = new SqlParameter("@DeleteFlg", SqlDbType.Bit) { Value = Umodel.DeleteFlg };
            return bdl.SelectJson("User_Select", Umodel.Sqlprms);
        }

        public UserModel UserModel_Select(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();           
            Umodel.Sqlprms = new SqlParameter[4];
            Umodel.Sqlprms[0] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = Umodel.UserID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };
            Umodel.Sqlprms[2] = new SqlParameter("@UserName", SqlDbType.VarChar) { Value = Umodel.UserName };
            Umodel.Sqlprms[3] = new SqlParameter("@DeleteFlg", SqlDbType.VarChar) { Value = Umodel.DeleteFlg };
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(bdl.SelectJson("User_Select", Umodel.Sqlprms));            
            foreach (DataRow dr in dt.Rows)
            {
                Umodel.UserID = dr["UserID"].ToString();
                Umodel.UserName = dr["UserName"].ToString();
                Umodel.Password = dr["Password"].ToString();
                Umodel.DeleteFlg = dr["Status"].ToString();
            }            
            return Umodel;
        }

        public string User_Save(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();          
            Umodel.Sqlprms = new SqlParameter[7];
            Umodel.Sqlprms[0] = new SqlParameter("@UserID", SqlDbType.VarChar) { Value = Umodel.UserID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };
            Umodel.Sqlprms[2] = new SqlParameter("@UserName", SqlDbType.VarChar) { Value = Umodel.UserName };
            Umodel.Sqlprms[3] = new SqlParameter("@DeleteFlg", SqlDbType.VarChar) { Value = Umodel.DeleteFlg };
            Umodel.Sqlprms[4] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = Umodel.Mode };
            Umodel.Sqlprms[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar) { Value = Umodel.CreatedBy };
            Umodel.Sqlprms[6] = new SqlParameter("@UpdatedBy", SqlDbType.VarChar) { Value = Umodel.UpdatedBy };
            return bdl.InsertUpdateDeleteData("User_CUD", Umodel.Sqlprms);
        }
    }
}
