using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using SettlementMenager_v_1._1.Class.SettlementWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Change status of insurance policy in database from not settled to settled ("R").
    /// </summary>
    class ChangePolicyStatus
    {
        /// <summary>
        ///Changes status field in insurance policy in database if insurance policy  that number is in settlement.
        ///If insurance policy is marked as "R" then won't shows in not settled insrance policy datagrid.
        ///If status insurance policy field is null than it's shows that policy as not settled.
        /// </summary>
        public static void ForSettled()
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var userList = ShowImportedList.userList;
            var importedList = ShowImportedList.importedList;
            var checkNumber = MakeNewLIstFromMerge.MergeListsAndFilter().Select(n => n.settlementPolicyNumber).FirstOrDefault();
            var addStatus = dc.userPolicyData.Where(n => n.policyNumber.Equals(checkNumber)).FirstOrDefault();
            if (addStatus != null)
            {
                if (addStatus.policyNumber != null)
                {
                    addStatus.policyStatus = "R";
                    dc.SaveChanges();
                }
            }
        }
    }
}
