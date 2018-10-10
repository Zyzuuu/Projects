using System.Windows;
using System.Windows.Input;
using SettlementMenager_v_1._1;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.SettlementWindow;
using SettlementMenager_v_1._1.Class;
using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Menager window, split at two parts left and right. In left part you have datagrid with insurance policies in database.
    /// At right part is datagrid with positions from excel file settlement from insurance companies.
    /// At bottom are buttons with features.
    /// </summary>
    public partial class MenagerWindow : System.Windows.Window
    {
        /// <summary>
        /// Displays current logged user.
        /// </summary>
        /// <param name="welcomeUser"></param>
        /// <returns></returns>
        public string Welcome(string welcomeUser = null)
        {
            return userNameField.Text =  welcomeUser;
        }

        public MenagerWindow()
        {
            InitializeComponent();
            //Current logged user.
            Welcome();
            //Left datagrid source at start.
            agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid();
        }

        /// <summary>
        /// Open add document into database window.
        /// After close opened window refresh datagrid.
        /// </summary>
        private void AddInsuranceDocumentButton(object sender, RoutedEventArgs e)
        {
            var addPolicyDocument = new AddDocument();
            addPolicyDocument.ShowDialog();
            Refresh.DataGrid(agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid());
        }

        /// <summary>
        /// Delete item by select it in datagrid. Position in database is deleting by button click.
        /// After delete datagrid is refreshing.
        /// </summary>
        private void RemovInsuranceDocumentButton(object sender, RoutedEventArgs e)
        {
            DeleteItemFromDataBase.DeleteAfterSelectRowInDataGrid(agentDocument.SelectedItem);
            Refresh.DataGrid(agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid());
        }
        /// <summary>
        /// Supplement for delete button, after select item in datagrid press delete key to delete item from database.
        /// After delete datagrid is refreshing.
        /// </summary>
        private void DeleteItemFromDatabaseByDeleteKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            { 
                DeleteItemFromDataBase.DeleteAfterSelectRowInDataGrid(agentDocument.SelectedItem);
                Refresh.DataGrid(agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid());
                e.Handled = true;
            }
        }

        /// <summary>
        /// Refresh button, refreshing datagrid if refresh is need.
        /// </summary>
        public void RefreshUserDatagridButton(object sender, RoutedEventArgs e)
        {
            Refresh.DataGrid(agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid());
        }

        /// <summary>
        /// Opens new window after select position and click button.
        /// </summary>
        private void EditInsuranceDocumentButton(object sender, RoutedEventArgs e)
        {
            DisplayDataEditPolicy.EditPolicyInDatabase(agentDocument.SelectedItem);
            Refresh.DataGrid(agentDocument.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid());
        }

        /// <summary>
        /// Opens window with search policy stuff.
        /// </summary>
        private void SearchPolicyButton(object sender, RoutedEventArgs e)
        {
            var searchWindow = new SearchPolicyDocument();
            searchWindow.ShowDialog();
            agentDocument.ItemsSource = SearchItemInDatagrid.SearchPosition(null);
        }

        /// <summary>
        /// Open excel file and shows path that file in textbox field. Plus loads excel columns to datagrid.
        /// </summary>
        private void OpenFileButton(object sender, RoutedEventArgs e)
        {
            importedDocument.ItemsSource = ImportedExcelToDataGrid.LoadDataFromExcelFile();
            pathFile.Text = ShowPathFile.showThatPath;
        }

        /// <summary>
        /// Opens settlement window after click generate list button. If excel file is imported then loads new window and displays 
        /// two connected lists with insurance policies assigned to user.
        /// </summary>
        private void GenerateSettlementButton(object sender, RoutedEventArgs e)
        {
            if (MakeNewLIstFromMerge.MergeListsAndFilter() != null)
            {
                SettlementWindow showWindow = new SettlementWindow();
                showWindow.ShowDialog();
            }
        }

        /// <summary>
        /// Opens import excel document window, where You can import excel file with insurance policies and adds them into database.
        /// </summary>
        private void ImportButton(object sender, RoutedEventArgs e)
        {
            ImportUserPolicyToDatabase importUserPolicyToDatabaseWindow = new ImportUserPolicyToDatabase();
            importUserPolicyToDatabaseWindow.ShowDialog();
        }

        /// <summary>
        /// Shows insurance policies that have not been settled / paid. If they did not appear to be settled
        /// from the insurance company at least once they will be visible in this datagrid.
        /// </summary>
        private void NotSettledPolicysButton(object sender, RoutedEventArgs e)
        {
            NotSettledPolicyDocumentsDatagrid notSettledPolicyDocumentsDatagridWindow = new NotSettledPolicyDocumentsDatagrid();
            notSettledPolicyDocumentsDatagridWindow.ShowDialog();
        }

        /// <summary>
        /// Filter datagrid with policies from database. This checkbox filters by logged user.
        /// </summary>
        private void atLoggedUser_Checked(object sender, RoutedEventArgs e)
        {
            FilterListByCheckCheckbox.LoggedUserCheckboxChecked(allDocuments, atLoggedUser, agentDocument, userNameField);
        }

        /// <summary>
        /// Filter datagrid with policies from database. This checkbox display all policies in database.
        /// </summary>
        private void allDocuments_Checked(object sender, RoutedEventArgs e)
        {
            FilterListByCheckCheckbox.AllDocumentCheckboxChecked(allDocuments, atLoggedUser, agentDocument);
        }
    }
}
