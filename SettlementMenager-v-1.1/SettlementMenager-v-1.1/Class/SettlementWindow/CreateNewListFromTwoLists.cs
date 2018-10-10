using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Union Two lists.
    /// </summary>
    class CreateNewListFromTwoLists
    {
        /// <summary>
        /// Union two lists, both without duplicates. This list is  designated to display in datagrid after earlier filtering.
        /// </summary>
        /// <returns></returns>
        public static List<SettlementListFields> MergeTwoListsWithoutDuplicates()
        {
            var twoListsWithoutDuplicates = MakeNewLIstFromMerge.MergeListsAndFilter().Union(ConnectTwoLists.JoinListWithPoliciesInDatabaseAndPoliciesWhichArentInDatabase());

            return twoListsWithoutDuplicates.ToList();
        }
    }
}
