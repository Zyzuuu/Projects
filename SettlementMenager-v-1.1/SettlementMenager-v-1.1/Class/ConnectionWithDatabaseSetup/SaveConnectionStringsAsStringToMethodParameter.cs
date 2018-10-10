using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup
{
    /// <summary>
    /// Fields class with connection strings fields.
    /// </summary>
   internal class SaveConnectionStringsAsStringToMethodParameter
    {
        /// <summary>
        /// Stores SqlConnectionString to Database.mdf (created database by script.sql)
        /// </summary>
        public static string connstringSqlConnectionDatabase { get; set; }
        /// <summary>
        /// Stores SqlConnectionString to Master database, which is create with sqlserver install.
        /// </summary>
        public static string connstringSqlConnectionMaster { get; set; }
        /// <summary>
        /// Stores EntityFrameworkConnectionString, which is located originally in app.config. 
        /// But here we need make ouer own connection string which we can edit in runtime.
        /// </summary>
        public static string connstringMasterEntitiesConnectionDatabase { get; set; }
    }
}
