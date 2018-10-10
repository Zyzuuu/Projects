using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Create settlement list (second).
    /// </summary>
    class SecondListWithNotEqualsPolicyNumbers
    {
        /// <summary>
        /// Create second settlement list, same as MakeNewListFromMerge. This list have settlement class field but not all fields are
        /// filled. Only four fields are filled - the same fields which should be filled by data from imported excel file.
        /// Other fields needs been empty becouse positions on this list arent assignet to any position in database.
        /// </summary>
        /// <returns></returns>
        public static List<SettlementListFields> DisplayInsurancePoliciesWhichArentInDatabase()
        {
            try
            {
                var userList = ShowImportedList.userList;
                var importedList = ShowImportedList.importedList;
                
                var query = importedList.Select(n=> new SettlementListFields

                               {
                                   settlementPolicyNumber = n.importedPolicyNumber,
                                   settlementPolicyOwner = n.importedPolicyOwner.ToUpper(),
                                   settlementAgentProvision = n.ImportedAgnetProvision,
                                   settlementCashpayment = n.importedCashpayment,

                               });

                return query.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}