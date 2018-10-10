using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations.ImportManyPolicyItems;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;
using SettlementMenager_v_1._1.Class.SettlementWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class
{
    internal class ShowImportedList
    {   /// <summary>
        /// Variable which have assigned List ImportedDataGridList
        /// </summary>
        public static List<ImportedDataGridList> importedList { get; set; }
        /// <summary>
        /// Variable which have assigned List DatagridList
        /// </summary>
        public static List<DatagridList> userList { get; set; }
        /// <summary>
        /// Variable which have assigned List SettlementListFields
        /// </summary>
        public static List<SettlementListFields> settlementList { get; set; }
        /// <summary>
        /// Variable which have assigned List ImportedDataGridListWithUsersPolicy
        /// </summary>
        public static List<ImportedDataGridListWithUsersPolicy> ImportedDataGridListWithUsersPolicy { get; set; }
        /// <summary>
        /// Variable which have assigned List SettlementListFields with policies which aren't in database.
        /// </summary>
        public static List<SettlementListFields> settlementListPoliciesWhichArentInDatabase { get; set; }

    }
}
