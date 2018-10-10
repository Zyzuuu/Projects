using LocalDatabaseApplication;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid
{
    /// <summary>
    /// Returns list with fields from DataGridList.
    /// </summary>
    class UserDatagrid
    {
        /// <summary>
        /// takes fields from DataGridList and making list which display items from database in datagrid
        /// </summary>
        /// <returns>List of DatagridList</returns>
        public static List<DatagridList> DisplayPolicyListInDataGrid()
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            var userDataGridContent = from n in dc.userPolicyData
                                      select new DatagridList()
                                      {
                                          UserName = n.userName,
                                          PolicyNumber = n.policyNumber,
                                          FullDate = n.fullDate,
                                          Broker = n.brokerName,
                                          ID = n.Id,
                                          Status = n.policyStatus
                                      };

            ShowImportedList.userList = userDataGridContent.ToList();

            return userDataGridContent.ToList();
        }
    }
}
