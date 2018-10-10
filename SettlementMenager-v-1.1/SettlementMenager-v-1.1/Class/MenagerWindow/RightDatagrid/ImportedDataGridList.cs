using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid
{
    /// <summary>
    /// ImportedDataGridList fields.
    /// </summary>
    class ImportedDataGridList
    {
        /// <summary>
        /// Id field in importedDocument Datagrid.
        /// </summary>
        public int? importedId { get; set; }
        /// <summary>
        /// Insurance Policy number, imported from excel in importedDocument datagrid.
        /// </summary>
        public string importedPolicyNumber { get; set; }
        /// <summary>
        /// Insurance Policy number, imported from excel in importedDocument datagrid.
        /// </summary>
        public string importedCashpayment { get; set; }
        /// <summary>
        /// Cash payed for insurance policy by customer, imported from excel in importedDocument datagrid.
        /// </summary>
        public string importedPolicyOwner { get; set; }
        /// <summary>
        /// Cash payed for Agent by insurance company, imported from excel in importedDocument datagrid.
        /// </summary>
        public double ImportedAgnetProvision { get; set; }
    }
}
