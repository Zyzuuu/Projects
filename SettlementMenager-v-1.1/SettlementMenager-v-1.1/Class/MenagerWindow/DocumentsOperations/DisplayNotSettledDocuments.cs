using SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Display of all insurance policies documents which are not settled.
    /// </summary>
    class DisplayNotSettledDocuments
    {
        /// <summary>
        ///Display of all insurance policies documents where status have mark "R",
        ///If not have any mark(is null or have any other than "R")  displays as
        ///insurance policy which as not settled.
        /// </summary>
        /// <returns></returns>
        public static List<DatagridList> InDataGrid()
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var settledPolicyDocument = dc.userPolicyData.Where(n => n.policyStatus != "R")
                                               .Select(n => new DatagridList()
                                               {
                                                   UserName = n.userName,
                                                   PolicyNumber = n.policyNumber,
                                                   FullDate = n.fullDate,
                                                   Broker = n.brokerName,
                                               });

            return settledPolicyDocument.ToList();
        }
    }
}
