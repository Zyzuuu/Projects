using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Microsoft.Win32;
using System.Windows;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations.ImportManyPolicyItems;
using SettlementMenager_v_1._1.Class.OpenAndLoadExcelFile;

namespace SettlementMenager_v_1._1.Class.ImportedExcelToDatagridWindow
{   /// <summary>
    /// Class imports excel file to datagrid.
    /// </summary>
    class ImportDatagridToDatabase
    {
        /// <summary>
        /// Method open file dialog, where You can chose file to open, when file opens it import data from Excel
        /// to to list.
        /// </summary>
        /// <returns>List of ImportedDataGridListWithUsersPolicy</returns>
        /// <exception cref="FormatException">Throw when Excel file have wrong cells format (date for example)</exception>
        /// <exception cref="ArgumentException">Throw when Excel file have wrong Column name - if you change [0]
        /// for ["ColumName"] in listOfUsersPolicy you can get that exception</exception>
        /// <exception cref="OleDbException">Throw when Excel file have wrong cells format </exception>
        /// <exception cref="InvalidCastException">Throw when Column with date have wrong format (not date)</exception>
        /// <exception cref="IndexOutOfRangeException">Throw when Excel file have not enough of columns (less than eleven)</exception>
        public static List<ImportedDataGridListWithUsersPolicy> LoadUsersPolicyFromExcelFile(string userName)
        {
            try
            {
                List<ImportedDataGridListWithUsersPolicy> listOfUsersPolicy = FormatLoadList.LoadListReadyToWriteSpecificDatagridList().Tables[0].AsEnumerable().Select(s => new ImportedDataGridListWithUsersPolicy
                    {
                        importedId = Convert.ToInt32(s[0] != DBNull.Value ? s[0] : null),
                        importedDataPolicy = Convert.ToDateTime(s[1] != DBNull.Value ? s[1] : null),
                        importedPolicyNumber = Convert.ToString(s[2] != DBNull.Value ? s[2] : ""),
                        importedUserPolicyOwner = userName,
                        importedInsurer = Convert.ToString(s[4] != DBNull.Value ? s[4] : ""),
                        importedPicture = Convert.ToString(s[5] != DBNull.Value ? s[5] : ""),
                        ImportedM6 = Convert.ToString(s[6] != DBNull.Value ? s[6] : ""),
                        importedStatus = Convert.ToString(s[7] != DBNull.Value ? s[7] : ""),
                        importedBroker = Convert.ToString(s[8] != DBNull.Value ? s[8] : ""),
                        importedPublic = Convert.ToString(s[9] != DBNull.Value ? s[9] : ""),
                        importedPolicyOwner = Convert.ToString(s[10] != DBNull.Value ? s[10] : ""),
                        importedCashpayment = Convert.ToString(s[11] != DBNull.Value ? s[11] : ""),

                    }).ToList();

                var filteredList = listOfUsersPolicy.Where(n => n.importedId != 0).Select(n => n);
                ShowImportedList.ImportedDataGridListWithUsersPolicy = filteredList.ToList();
                return ShowImportedList.ImportedDataGridListWithUsersPolicy;
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowe formatowanie elementów w pliku Excel");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nieprawidłowe nazwy kolumn");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (OleDbException)
            {
                MessageBox.Show("Nieprawidłowe formatowanie elementów w pliku Excel");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Nieprawidłowy format w kolumnie daty - plik Excel");
                ShowPathFile.showThatPath = null;
                return null;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Plik powinien zawierać minimum 11 kolumn" + Environment.NewLine
                    + "Przykładowy plik możesz pobrać z: www.easymodeoff.pl/plik_do_importu_polis.xls");
                ShowPathFile.showThatPath = null;
                return null;
            }
        }
    }
}

