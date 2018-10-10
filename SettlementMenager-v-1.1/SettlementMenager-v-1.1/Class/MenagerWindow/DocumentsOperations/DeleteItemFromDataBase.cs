using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Removes selected insurance policy from datagrid and database.
    /// </summary>
    class DeleteItemFromDataBase
    {
        /// <summary>
        /// Delete items from database by selecting datagrid row position. First checking if position isn't selected 
        /// write show messagebox with "Zaznacz pozycję do usunięcia" ["Select position to delete"].
        /// If position to delete is selected then get agentData.ItemSource is checking as DatagridList 
        /// as PolicyNumber, next to we have sql query by linq, where that query checking is policyNumber in database 
        /// is equal deleteItem(PolicyNumber in selected item/list) if it's equal than deleting position in database 
        /// and next to save changes in database. We have here one more thing like messagebox with question 
        /// "Czy na pewno usunąć polisę" ("Ostrzeżenie") ["Are you sure to delete that policy?"] [("Warning")].
        /// </summary>
        /// <param name="agentDocument">Used as agentDocument.SelectedItem</param>
        /// <exception cref="NullReferenceException">Zaznacz pozycję do usunięcia</exception>
        public static void DeleteAfterSelectRowInDataGrid(object agentDocument)
        {
            if (agentDocument != null)
            {
                if (MessageBox.Show("Czy na pewno usunąć polisę?", "Ostrzeżenie", MessageBoxButton.YesNo
                   , MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                }
                else
                {
                    try
                    {
                        masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

                        var deleteItem = (agentDocument as DatagridList).ID;
                        userPolicyData deletePolicy = dc.userPolicyData.Where(n => n.Id.Equals(deleteItem)).SingleOrDefault();
                        dc.userPolicyData.Remove(deletePolicy);
                        dc.SaveChanges();
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
