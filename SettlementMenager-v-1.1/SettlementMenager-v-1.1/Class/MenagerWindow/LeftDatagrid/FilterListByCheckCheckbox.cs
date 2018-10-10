using SettlementMenager_v_1._1.Class.MainWindow.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid
{
    /// <summary>
    /// Filter DatagridList by selected checkbox
    /// </summary>
    class FilterListByCheckCheckbox 
    {
        /// <summary>
        /// Shows all documents which are in database after when displayAllCheckbox is marked. 
        /// Score is display in left datagrid in menager window.
        /// </summary>
        /// <param name="displayAllCheckbox">It's atLoggedUser checkbox in MenagerWindow</param>
        /// <param name="displayLoggedUserCheckbox">It's allDocuments checkbox in MenagerWindow</param>
        /// <param name="dataSource">It's agentDocument ItemsSource</param>
        public static void AllDocumentCheckboxChecked(CheckBox displayAllCheckbox, CheckBox displayLoggedUserCheckbox, DataGrid dataSource)
        {
            dataSource.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid();
            displayLoggedUserCheckbox.IsChecked = false;
            displayAllCheckbox.IsChecked = true;
        }

        /// <summary>
        /// Shows  filtered documents by logged user in database after when displayLoggedUserCheckbox is marked. 
        /// Score is display in left datagrid in menager window.
        /// </summary>
        /// <param name="displayAllCheckbox">It's atLoggedUser checkbox in MenagerWindow</param>
        /// <param name="displayLoggedUserCheckbox">It's allDocuments checkbox in MenagerWindow</param>
        /// <param name="dataSource">It's agentDocument ItemsSource</param>
        /// <param name="loggedUser">It's userNameField.Text (label) in MenagerWindow</param>
        public static void LoggedUserCheckboxChecked(CheckBox displayAllCheckbox, CheckBox displayLoggedUserCheckbox, DataGrid dataSource, TextBlock loggedUser)
        {
            displayAllCheckbox.IsChecked = false;
            displayLoggedUserCheckbox.IsChecked = true;
            dataSource.ItemsSource = UserDatagrid.DisplayPolicyListInDataGrid().Where(n => n.UserName.Equals(loggedUser.Text));
        }

    }
}
