using DL;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import_BL
{
    public class ImportBL
    {
        public string ItemImportLog_Select(ItemImportLogModel itemImportModel)
        {
            BaseDL bdl = new BaseDL();
            itemImportModel.Sqlprms = new SqlParameter[0];
            return bdl.SelectJson("ItemImportLog_Select", itemImportModel.Sqlprms);
        }

        public string Import_Item_Data(DataTable dt)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dt);
            BaseDL bdl = new BaseDL();
            ItemModel itemModel = new ItemModel();
            itemModel.Sqlprms = new SqlParameter[1];
            itemModel.Sqlprms[0] = new SqlParameter("@jsonString", json);
            return bdl.InsertUpdateDeleteData("Import_ItemData", itemModel.Sqlprms);
        }

        public DataTable ConvertXSLXtoDataTable(string filepath, string connString)
        {
            Microsoft.Office.Interop.Excel.Application objXL = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook objWB = objXL.Workbooks.Open(filepath);
            Microsoft.Office.Interop.Excel.Worksheet objSHT = objWB.Worksheets[1];

            int rows = objSHT.UsedRange.Rows.Count;
            int cols = objSHT.UsedRange.Columns.Count;
            DataTable dt = new DataTable();
            int noofrow = 1;
            for (int c = 1; c <= cols; c++)
            {
                string colname = objSHT.Cells[1, c].Text;
                dt.Columns.Add(colname);
                noofrow = 2;
            }
            for (int r = noofrow; r <= rows; r++)
        {
            DataRow dr = dt.NewRow();
            for (int c = 1; c <= cols; c++)
            {
                dr[c - 1] = objSHT.Cells[r, c].Text;
            }
            dt.Rows.Add(dr);
        }

        objWB.Close();
        objXL.Quit();
        return dt;        
        }     
    }
}
