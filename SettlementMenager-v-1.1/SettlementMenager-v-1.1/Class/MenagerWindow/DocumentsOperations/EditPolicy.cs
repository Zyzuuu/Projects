using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Edit selected insurance policy document in database.
    /// </summary>
    class EditPolicy
    {
        /// <summary>
        /// If id of insurance policy document is equals id selected insurance policy then can edit this document
        ///Fields policy number and user name must have value.
        /// </summary>
        /// <param name="policyNumber">Used as policyNumberTextField.Text</param>
        /// <param name="fullDate">Used as editDate.DisplayDate</param>
        /// <param name="userName">Used as userComboboxField.SelectedValue.ToString()</param>
        /// <param name="brokerName">Used as brokerNameTextField.Text</param>
        public static void InDatabaseChange(string policyNumber, DateTime? fullDate, string userName, string brokerName)
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var editPolicyQuery = dc.userPolicyData.Where(n => n.Id.Equals(CatchPolicyData.savedIdNumber)).FirstOrDefault();

            if (editPolicyQuery != null)
            {
                if (policyNumber != "" && userName != null)
                {
                    editPolicyQuery.policyNumber = policyNumber;
                    editPolicyQuery.fullDate = fullDate;
                    editPolicyQuery.userName = userName;
                    editPolicyQuery.brokerName = brokerName;

                    dc.SaveChanges();
                }
            }
        }
    }
}
