using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SettlementMenager_v_1._1.Class;
using SettlementMenager_v_1._1.Class.ImportedExcelToDatagridWindow;
using SettlementMenager_v_1._1.Class.MainWindow.Combobox;
using SettlementMenager_v_1._1.Class.MainWindow.Users;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations.ImportManyPolicyItems;
using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;

namespace SettlementMenager_v_1._1
{
    /// <summary>
    /// Interaction logic for ImportUserPolicyToDatabase.xaml
    /// </summary>
    public partial class ImportUserPolicyToDatabase : Window
    {
        public ImportUserPolicyToDatabase()
        {
            InitializeComponent();

            //Loads user from database into combobox, where DisplayMemberPath and SelectedValuePath = "Name".
            ComboBoxSource.SetupItemsInComboBoxDisplay(chosePolicyOwnerCombobox.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                           chosePolicyOwnerCombobox.DisplayMemberPath = "Name", chosePolicyOwnerCombobox.SelectedValuePath = "Name");

            //Fill combobox by current logged user.
            chosePolicyOwnerCombobox.SelectedValue = UserInformation.CurrentLoggedInUser;
        }

        /// <summary>
        /// Fill datagrid by values from opened excel file and display path of this file in textbox.
        /// </summary>
        private void openExcelFileButton(object sender, RoutedEventArgs e)
        {
            usersDatagridImportFromExcel.ItemsSource = ImportDatagridToDatabase.LoadUsersPolicyFromExcelFile(chosePolicyOwnerCombobox.SelectedValue.ToString());
            importedExcelPath.Text = ShowPathFile.showThatPath;
        }

        /// <summary>
        /// Add positions from datagrind into database.
        /// </summary>
        private void importDatagridToDatabaseButton(object sender, RoutedEventArgs e)
        {
            AddToDatabase.AddDatagridListWithAllDocuments();
        }

        /// <summary>
        /// Remove item from database by select item in datagrid and click delete button. After delete refresh datagrid.
        /// </summary>
        private void removeElemetsFromListButton(object sender, RoutedEventArgs e)
        {
            DeleteItemsFromImportedExcelFileWithSettlementDocumentsFromInsuranceCompany
                .DeleteSelectedPosition(usersDatagridImportFromExcel.SelectedValue);
            usersDatagridImportFromExcel.ItemsSource = null;
            usersDatagridImportFromExcel.ItemsSource = ShowImportedList.ImportedDataGridListWithUsersPolicy;
        }

        /// <summary>
        /// Event assigned to key press "delete". Select position in datagrid and press delete key to delete position from datagrid.
        /// </summary>
        private void DeleteItemFromImportedListFromExcelFile(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                DeleteItemsFromImportedExcelFileWithSettlementDocumentsFromInsuranceCompany
               .DeleteSelectedPosition(usersDatagridImportFromExcel.SelectedValue);
                usersDatagridImportFromExcel.ItemsSource = null;
                usersDatagridImportFromExcel.ItemsSource = ShowImportedList.ImportedDataGridListWithUsersPolicy;
            }
        }
    }
}
