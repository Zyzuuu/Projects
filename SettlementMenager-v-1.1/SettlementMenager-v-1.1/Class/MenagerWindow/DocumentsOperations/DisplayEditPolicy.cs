using LocalDatabaseApplication;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Displays selected policy to edit. Left side fields to edit, right side of window insurance policy data in edition.
    /// </summary>
    class DisplayDataEditPolicy
    {
        /// <summary>
        /// Gets data from selected insurance policy which is in database and display in window to edit.
        /// </summary>
        /// <param name="agentDocument">agentDocument.SelectedItem</param>
        /// <exception cref="NullReferenceException">Zaznacz pozycję do edycji</exception>
        public static void EditPolicyInDatabase(object agentDocument)
        {
            if (agentDocument != null)
            {
                try
                {
                    masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

                    var editItem = (agentDocument as DatagridList).PolicyNumber;
                    userPolicyData editPolicy = dc.userPolicyData.Single(n => n.policyNumber.Equals(editItem));

                    CatchPolicyData.savedIdNumber = editPolicy.Id;
                    CatchPolicyData.savedPolicyNumber = editPolicy.policyNumber;
                    CatchPolicyData.savedUserName = editPolicy.userName;
                    CatchPolicyData.savedFullDate = editPolicy.fullDate;
                    CatchPolicyData.savedBrokerName = editPolicy.brokerName;

                    var editPolicyWindow = new EditPolicyDocument();
                    editPolicyWindow.ShowDialog();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Zaznacz pozycję do edycji");
                }
            }
            else
            {
                MessageBox.Show("Zaznacz pozycję do edycji");
            }
        }
    }
}
