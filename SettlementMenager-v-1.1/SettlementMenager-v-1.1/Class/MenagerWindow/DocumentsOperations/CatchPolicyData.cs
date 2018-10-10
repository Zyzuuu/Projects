using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations
{
    /// <summary>
    /// Stores fields with insurance policy data.
    /// </summary>
    internal class CatchPolicyData
    {
        /// <summary>
        /// Stores insurance policy number.
        /// </summary>
        public static string savedPolicyNumber { get; set; }
        /// <summary>
        /// Stores user name of the person who issued the policy. 
        /// </summary>
        public static string savedUserName { get; set; }
        /// <summary>
        /// Stores the date of adding insurance policy to database.
        /// </summary>
        public static DateTime? savedFullDate { get; set; }
        /// <summary>
        /// Stores user id.
        /// </summary>
        public static int savedIdNumber { get; set; }
        /// <summary>
        /// Stores broker name.
        /// </summary>
        public static string savedBrokerName { get; set; }
    }

    /// <summary>
    /// Sotres field with insurance policy number for search.
    /// </summary>
    internal class SearchPolicyField
    {
        /// <summary>
        /// Stores insurance policy number to search.
        /// </summary>
        public static string findPolicy { get; set; }
    }
}
