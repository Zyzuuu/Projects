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
    /// Search policy number in database.
    /// </summary>
    class SearchItemInDatagrid
    {
        /// <summary>
        /// Search for the policy number in the database according to the entered number in the text field. 
        /// If the search policy is in the database then return the filtered list with the searched document, 
        /// if not, it returns an unfiltered list.If you have a hit - the window is closing and returns filtered list.
        /// Ff not - receive the message "Enter correct policy number" ["Enter correct document number"]
        /// </summary>
        /// <param name="PolicyDocument">Used as this inSearchPoliyDocument</param>
        /// <returns></returns>
        public static List<DatagridList> SearchPosition(SearchPolicyDocument PolicyDocument)
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var checkPolicyInDatabse = dc.userPolicyData.Where(n => SearchPolicyField.findPolicy.Contains(n.policyNumber));

            var rowQuery = dc.userPolicyData.Where(n => n.policyNumber.Equals(SearchPolicyField.findPolicy))
                                              .Select(n => new DatagridList()
                                              {
                                                  UserName = n.userName,
                                                  PolicyNumber = n.policyNumber,
                                                  FullDate = n.fullDate,
                                                  Broker = n.brokerName,
                                              });

            if (rowQuery != null)
            {
                if (checkPolicyInDatabse != null)
                {
                    if (PolicyDocument != null)
                        PolicyDocument.Close();

                    return rowQuery.ToList();
                }
                else
                {
                    if (PolicyDocument != null)
                    {
                        MessageBox.Show("Wpisz poprawny numer polisy");
                    }
                    else
                    {
                    }
                }
            }
                return ShowImportedList.userList;
        }
    }
}
