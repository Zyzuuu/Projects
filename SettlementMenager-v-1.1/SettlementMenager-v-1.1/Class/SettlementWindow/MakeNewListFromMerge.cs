using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Concatenates two lists.
    /// </summary>
    class MakeNewLIstFromMerge
    {
        /// <summary>
        ///Concatenate two lists where policy numbers are equals.
        ///If policy numbers in database is equal of insurance policy number on settlement from insurance company.
        ///Next display chosen datas from database and that settlement list.If You won't load Excel file with
        ///settlement from insurance company you get message "Wczytaj plik Excel" ["Load the Excel file"].
        /// </summary>
        /// <returns>List of SettlementListFields</returns>
        public static List<SettlementListFields> MergeListsAndFilter()
        {
            try
            {
                var userList = ShowImportedList.userList;
                var importedList = ShowImportedList.importedList;

                var query = (from n in userList
                             join m in importedList
                             on n.PolicyNumber equals m.importedPolicyNumber

                             select new SettlementListFields
                             {
                                 settlementPolicyNumber = n.PolicyNumber,
                                 settlementUserName = n.UserName.ToUpper(),
                                 settlementDate = n.FullDate,
                                 settlementBrokerName = n.Broker.ToUpper(),
                                 settlementCashpayment = m.importedCashpayment,
                                 settlementAgentProvision = m.ImportedAgnetProvision,
                                 settlementPolicyOwner = m.importedPolicyOwner.ToUpper(),

                             });
                             
                return query.ToList();

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Wczytaj plik Excel");
                return null;
            }
        }
    }
}
