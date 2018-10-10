using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using SettlementMenager_v_1._1.Class.MainWindow.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Adds insurance policy document to database.
    /// </summary>
    class AddPolicy
    {
        /// <summary>
        /// Thanks to AddPoliy class You can add policy document to database. First it's checking policy number
        /// if this number is in database already it's return message "Polisa jest już w bazie!",
        /// ["Policy is already in database!"]. Otherwise going forward and checking fields like policyNumber,
        /// dateMonth, dateYear, userName, if they are filled, after click button alghoritm add that fields to database.
        /// If one of fields are empty then You get message "Wprowadź dane do polisy!" ["Enter policy data!" 
        /// + Adding name of logged user to policy position in database. After that clearing text fields.
        /// </summary>
        /// <param name="policyNumber">Used as policyNumberTextField.Text</param>
        /// <param name="fullDate">Used as addDate.DisplayDate</param>
        /// <param name="brokerName">Used as brokerNameTextField.Text</param>
        public static void UserPolicyToDatabase(string policyNumber, DateTime? fullDate, string brokerName)
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var checkIfPolicyInDatabase = dc.userPolicyData.Where(n => policyNumber.Equals(n.policyNumber)).FirstOrDefault();

            if (checkIfPolicyInDatabase != null)

            {
                MessageBox.Show("Polisa jest już w bazie!");
            }
            else
            {
                if (policyNumber != "")
                {
                    var documentData = new userPolicyData
                    {
                        policyNumber = policyNumber,
                        fullDate = fullDate
                                                           ,
                        userName = UserInformation.CurrentLoggedInUser
                                                           ,
                        brokerName = brokerName
                    };

                    dc.userPolicyData.Add(documentData);
                    dc.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wprowadź dane polisy!");
                }
            }
        }
    }
}
