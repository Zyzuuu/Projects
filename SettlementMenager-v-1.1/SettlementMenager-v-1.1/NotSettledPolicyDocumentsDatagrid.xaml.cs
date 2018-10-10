using SettlementMenager_v_1._1.Class;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations;
using SettlementMenager_v_1._1.Class.MainWindow.Combobox;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.SettlementWindow;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1
{
    /// <summary>
    /// Interaction logic for NotSettledPolicyDocumentsDatagrid.xaml
    /// </summary>
    public partial class NotSettledPolicyDocumentsDatagrid : Window
    {
        public NotSettledPolicyDocumentsDatagrid()
        {
            InitializeComponent();

            //Sets usernames into combobox from database.
            ComboBoxSource.SetupItemsInComboBoxDisplay(userNameCombobox.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                                userNameCombobox.DisplayMemberPath = "Name", userNameCombobox.SelectedValuePath = "Name");

            //Load not settled insurance policies into datagrid.
            showNotSettledPolicyDocumentDatagrid.ItemsSource = DisplayNotSettledDocuments.InDataGrid();
        }

        /// <summary>
        /// Exports datagrid not settled insurance policies to excel file.
        /// </summary>
        private void ExportToExcelButton(object sender, RoutedEventArgs e)
        {
            ExportDatagrid.ToExcel(showNotSettledPolicyDocumentDatagrid);
        }

        /// <summary>
        /// Filter datagrid list by selected value in combobox - displays only documents where user is equal combobox value.
        /// </summary>
        private void userNameCombobox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            showNotSettledPolicyDocumentDatagrid.ItemsSource = DisplayNotSettledDocuments.InDataGrid()
                .Where(n=>n.UserName.Equals(userNameCombobox.SelectedValue.ToString()));
        }

        /// <summary>
        /// Reset combobox value and set originally list - display all documents, not filtered.
        /// </summary>
        private void ResetComboboxButton(object sender, RoutedEventArgs e)
        {
            userNameCombobox.SelectedValue = null;
            showNotSettledPolicyDocumentDatagrid.ItemsSource = DisplayNotSettledDocuments.InDataGrid();
        }
    }
}
