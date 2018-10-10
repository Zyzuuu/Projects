using System;
using System.Linq;
using System.Windows;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;

namespace SettlementMenager_v_1._1.Class.ImportedExcelToDatagridWindow
{
    /// <summary>
    /// Class adds and saves many records to database.
    /// </summary>
    class AddToDatabase
    {
        /// <summary>
        ///Method checks if policyNumber(in datagrid) is equals n.policyNumber(in database) and if is on any of position
        ///in database we get msg "Polisy są już w bazie" plus numbers of that documents, if not we save
        ///list in database and we geting msg "Polisy dodane pomyślnie".
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// /// <exception cref="NullReferenceException"></exception>
        public static void  AddDatagridListWithAllDocuments()
        {
            try
            {
                masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

                var policyNumber = ShowImportedList.ImportedDataGridListWithUsersPolicy.Select(n => n.importedPolicyNumber).FirstOrDefault().ToString();
                var checkIsPolicyInDatabase = dc.userPolicyData.Where(n => policyNumber.Equals(n.policyNumber)).FirstOrDefault();
                if (checkIsPolicyInDatabase != null)
                {
                    string displayNumbersAlreadyInDatabase = String.Join(", ", dc.userPolicyData.Where(n => n.policyNumber.Equals(policyNumber)).Select(n => n.policyNumber));
                    MessageBox.Show("Polisy są już w bazie: " + displayNumbersAlreadyInDatabase);
                }
                else
                {
                    var newList = ShowImportedList.ImportedDataGridListWithUsersPolicy.Select(n => new userPolicyData
                    {
                        userName = n.importedUserPolicyOwner,
                        fullDate = n.importedDataPolicy,
                        brokerName = n.importedBroker,
                        policyNumber = n.importedPolicyNumber
                    });

                    dc.userPolicyData.AddRange(newList);
                    dc.SaveChanges();

                    MessageBox.Show("Polisy dodane pomyślnie");
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Nie można dodać pustej listy");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nie można dodać pustej listy");
            }
        }
    }
}
