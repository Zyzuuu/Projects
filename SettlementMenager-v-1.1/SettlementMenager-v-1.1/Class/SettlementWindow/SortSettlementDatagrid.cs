using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Filter list.
    /// </summary>
    class SortSettlementDatagrid
    {
        /// <summary>
        /// OrderBy settlement list displayed in datagrid - order it by settlementPolicyOwner and secondly by settlementSerName.
        /// </summary>
        /// <returns></returns>
        public static List<SettlementListFields> FilterListByPolicyNumberThenByAgentNameThenByAgencyName()
        {
            var filterListWithOrderBy = CreateNewListFromTwoLists.MergeTwoListsWithoutDuplicates()
                                                                 .OrderBy(n => n.settlementPolicyOwner)
                                                                 .ThenBy(n=>n.settlementUserName);
                                                                                
            return filterListWithOrderBy.ToList();
        }
    }
}
