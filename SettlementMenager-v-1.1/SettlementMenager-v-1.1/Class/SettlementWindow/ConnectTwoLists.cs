using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Connect Two lists in one.
    /// </summary>
    class ConnectTwoLists
    {
        /// <summary>
        ///Connect two lists using Addrange , where we display first list, and add second list to first list,
        ///where are all positions from first list and second list on which delete elements from first list 
        ///at equal insurance policy numbers on both lists.
        /// </summary>
        /// <returns></returns>
        public static List<SettlementListFields> JoinListWithPoliciesInDatabaseAndPoliciesWhichArentInDatabase()
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);
            var userListFilter = dc.userPolicyData.Select(n => n.policyNumber).FirstOrDefault();

            var merged = new List<SettlementListFields>();

            merged.AddRange(SecondListWithNotEqualsPolicyNumbers.DisplayInsurancePoliciesWhichArentInDatabase().Where(p2 =>
                MakeNewLIstFromMerge.MergeListsAndFilter().All(p1 => p1.settlementPolicyNumber != p2.settlementPolicyNumber)));

            return merged.ToList();
        }
    }
}
