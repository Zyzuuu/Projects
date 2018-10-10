using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System.Windows;
using SettlementMenager_v_1._1.Class;
using SettlementMenager_v_1._1.Class.OpenAndLoadExcelFile;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid
{

    /// <summary>
    /// Import list to datagrid from Excel file.
    /// </summary>
    class ImportedExcelToDataGrid
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ImportedDataGridList> LoadDataFromExcelFile()
        {
            try
            {
                List<ImportedDataGridList> list = FormatLoadList.LoadListReadyToWriteSpecificDatagridList().Tables[0].AsEnumerable().Select(s => new ImportedDataGridList
                {
                    importedPolicyNumber = Convert.ToString(s[0] != DBNull.Value ? s[0] : ""),
                    importedCashpayment = Convert.ToString(s[1] != DBNull.Value ? s[1] : ""),
                    ImportedAgnetProvision = Convert.ToDouble(s[2] != DBNull.Value ? s[2] : null),
                    importedPolicyOwner = Convert.ToString(s[3] != DBNull.Value ? s[3] : ""),
                }).ToList();

                ShowImportedList.importedList = list.ToList();
                return list.ToList();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowe formatowanie elementów w pliku Excel");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Błędne nazwy kolumn(y)");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (OleDbException)
            {
                MessageBox.Show("Nieprawidłowy format pliku");
                ShowPathFile.showThatPath = null;
                return null;
            }
        }
    }
}
