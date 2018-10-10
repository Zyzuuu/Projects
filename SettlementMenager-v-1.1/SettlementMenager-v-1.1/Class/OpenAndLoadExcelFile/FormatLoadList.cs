using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.OpenAndLoadExcelFile
{
    /// <summary>
    /// Loads excel file by first sheet using specific connection string which shows on file extension.
    /// </summary>
    class FormatLoadList
    {
        /// <summary>
        /// Loads all selecting from sheet in Excel file and returns as DataSet ds, which is part of source for list.
        /// </summary>
        /// <returns></returns>
        public static DataSet LoadListReadyToWriteSpecificDatagridList()
        {
            string sheet1;
            string strConnectionString = SwitchConnectionString.ConnectionStringForExcelFile();
            OleDbConnection cnCSV = new OleDbConnection(strConnectionString);
            cnCSV.Open();
            var dtSchema = cnCSV.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            sheet1 = dtSchema.Rows[0].Field<string>("TABLE_NAME");
            OleDbCommand cmdSelect = new OleDbCommand(@"SELECT * FROM [" + sheet1 + "]", cnCSV);
            OleDbDataAdapter daCSV = new OleDbDataAdapter(); daCSV.SelectCommand = cmdSelect;
            //System.Data. DataTable dtCSV = new System.Data. DataTable();
            DataSet ds = new DataSet();
            daCSV.Fill(ds);
            cnCSV.Close();

            return ds;
        }
    }
}
