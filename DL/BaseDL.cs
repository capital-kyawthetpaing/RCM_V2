﻿using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System;

namespace DL
{
    public class BaseDL
    {
        readonly ReadIni Rini = new ReadIni();
        public string conStr = string.Empty;

        public BaseDL()
        {
            conStr = Rini.GetConnectionString();
        }

        public string SelectJson(string sSQL, params SqlParameter[] para)
        {
            DataTable dt = new DataTable
            {
                TableName = "data"
            };
            try
            {
                var newCon = new SqlConnection(conStr);
                using (var adapt = new SqlDataAdapter(sSQL, newCon))
                {
                    newCon.Open();
                    adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    if (para != null)
                    {
                        para = ChangeToDBNull(para);
                        adapt.SelectCommand.Parameters.AddRange(para);
                    }
                    adapt.Fill(dt);
                    newCon.Close();
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
            return DataTableToJSONWithJSONNet(dt);
        }

        private SqlParameter[] ChangeToDBNull(SqlParameter[] para)
        {
            foreach (var p in para)
            {
                if (p.Value == null || string.IsNullOrWhiteSpace(p.Value.ToString()))
                {
                    p.Value = DBNull.Value;
                    p.SqlValue = DBNull.Value;
                }
                else
                {
                    p.Value = p.Value.ToString().Trim();
                    p.SqlValue = p.Value.ToString().Trim();
                }
            }

            return para;
        }

        public DataTable SelectDatatable(string sSQL, params SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            var newCon = new SqlConnection(conStr);
            using (var adapt = new SqlDataAdapter(sSQL, newCon))
            {
                newCon.Open();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (para != null)
                {
                    para = ChangeToDBNull(para);
                    adapt.SelectCommand.Parameters.AddRange(para);
                }

                adapt.Fill(dt);
                newCon.Close();
            }
            return dt;
        }

        public DataSet SelectDataSet(string sSQL, params SqlParameter[] para)
        {
            DataSet ds = new DataSet();
            var newCon = new SqlConnection(conStr);
            using (var adapt = new SqlDataAdapter(sSQL, newCon))
            {
                newCon.Open();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    adapt.SelectCommand.Parameters.AddRange(para);
                adapt.Fill(ds);
                newCon.Close();
            }
            return ds;
        }

        public string InsertUpdateDeleteData(string sSQL, params SqlParameter[] para)
        {
            try
            {
                var newCon = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sSQL, newCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(para);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return "false";
            }
        }

        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            return JsonConvert.SerializeObject(table);
        }
    }
}
