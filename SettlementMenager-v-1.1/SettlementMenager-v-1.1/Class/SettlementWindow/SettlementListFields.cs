using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Fields in settlement list.
    /// </summary>
    class SettlementListFields
    {
        /// <summary>
        /// Stores insurance policy number from settlement loaded from excel file into settlement datagrid.
        /// </summary>
        public string settlementPolicyNumber { get; set; }
        /// <summary>
        /// Stores name of Agent who's made a insurance policy loaded from database into settlement  datagrid.
        /// </summary>
        public string settlementUserName { get; set; }
        /// <summary>
        /// Stores date of issue of the policy loaded from database into settlement  datagrid.
        /// </summary>
        public DateTime? settlementDate { get; set; }
        /// <summary>
        /// Stores value of money taken for insurance policy. Loaded from excel file into settlement datagrid.
        /// </summary>
        public string settlementCashpayment { get; set; }
        /// <summary>
        /// Stores value of Agency name/external company. Loaded from excel file into settlement datagrid.
        /// </summary>
        public string settlementPolicyOwner { get; set; }
        /// <summary>
        /// Stores value of money belonging to agency. Loaded from excel file into settlement datagrid.
        /// </summary>
        public double settlementAgentProvision { get; set; }
        /// <summary>
        /// Stores name of broker which led the client. Loaded from database into settlement datagrid.
        /// </summary>
        public string settlementBrokerName { get; set; }
    }
}
