using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.LeftDatagrid
{
   
    /// <summary>
    /// Fields for UserDataGrid LIST.
    /// </summary>
    class DatagridList
    {
        /// <summary>
        /// Insurance policy id number of UserDataGrid LIST.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Agent username of UserDataGrid LIST.
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Insurance policy number of UserDataGrid LIST.
        /// </summary>
        public string PolicyNumber { get; set; }
        /// <summary>
        /// Nullable date of UserDataGrid LIST.
        /// </summary>
        public DateTime? FullDate { get; set; }
        /// <summary>
        /// Broker name of UserDataGrid LIST.
        /// </summary>
        public string Broker { get; set; }
        /// <summary>
        /// Insurance policy status of UserDataGrid LIST.
        /// </summary>
        public string Status { get; set; }
    }
}
