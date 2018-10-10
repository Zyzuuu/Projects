using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations.ImportManyPolicyItems;
using System;
using System.Linq;

using System.Windows;

namespace SettlementMenager_v_1._1.Class.ImportedExcelToDatagridWindow
{
    /// <summary>
    /// Delete items from datagrid/list in ImportedUserPolicyToDatabase.
    /// </summary>
    class DeleteItemsFromImportedExcelFileWithSettlementDocumentsFromInsuranceCompany
    {
        /// <summary>
        /// You can select row in datagrid and after selection delete position where id of this position is equal with position in database.
        /// You must select any position before click delete in other case you get message "Zaznacz pozycję do usunięcia" ["Select position to delete"].
        /// </summary>
        /// <param name="selectedValue">It's a chosePolicyOwnerCombobox ItemsSource in ImportedUserPolicyToDatabase Window</param>
        /// <exception cref="NullReferenceException"></exception>
        public static void DeleteSelectedPosition(object selectedValue)
        {
            if (selectedValue != null)
            {
                if (MessageBox.Show("Czy na pewno usunąć polisę?", "Ostrzeżenie", MessageBoxButton.YesNo
                   , MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                }
                else
                {
                    try
                    {
                        var deleteItem = (selectedValue as ImportedDataGridListWithUsersPolicy).importedId;
                        ImportedDataGridListWithUsersPolicy deletePolicy = ShowImportedList.ImportedDataGridListWithUsersPolicy
                                                                                   .Where(n => n.importedId.Equals(deleteItem))
                                                                                   .SingleOrDefault();

                        ShowImportedList.ImportedDataGridListWithUsersPolicy.Remove(deletePolicy);

                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Zaznacz pozycję do usunięcia");
                    }
                }
            }
            else
            {
                MessageBox.Show("Zaznacz pozycję do usunięcia");
            }
        }
    }
}
