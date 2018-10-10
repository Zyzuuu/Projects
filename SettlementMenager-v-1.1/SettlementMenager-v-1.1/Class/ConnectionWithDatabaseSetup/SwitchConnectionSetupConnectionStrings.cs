using System.Reflection;
using System.Configuration;
using WebAPI;

namespace SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup
{
    /// <summary>
    /// Switching connection strings needed to connect/create with database.
    /// </summary>
    class SwitchConnectionSetupConnectionStrings
    {
        /// <summary>
        /// Read value from txt file, and based on this value switch connection strings
        /// value = 0 -> local database strings
        /// value = 1 -> external database strings
        /// </summary>
        public static void SwitchConnectionStringsFromLocalDbToLanDb()
        {
            
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string value = System.IO.File.ReadAllText(path + "\\Resources\\AppFiles.txt");
            
            SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionDatabase = Properties.Settings.Default.databaseLocalDb;
            SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionMaster = "Data Source=localhost\\SQLEXPRESS; Database = master; Integrated security=SSPI;";
            SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase = ConfigurationManager.ConnectionStrings["masterEntities"].ConnectionString;

            switch (value)
            {
                case "0":
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionDatabase = Properties.Settings.Default.databaseLocalDb;
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionMaster = "Data Source=localhost\\SQLEXPRESS; Database = master; Integrated security=SSPI;";
                    SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase = ConfigurationManager.ConnectionStrings["masterEntities"].ConnectionString;
                    break;
                case "1":
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionDatabase = Properties.Settings.Default.databaseLanDb;
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionMaster = Properties.Settings.Default.masterLanDb;
                    SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase = SingleConnection.ConString;
                    break;
                default:
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionDatabase = Properties.Settings.Default.databaseLocalDb;
                    SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionMaster = "Data Source=localhost\\SQLEXPRESS; Database = master; Integrated security=SSPI;";
                    SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase = ConfigurationManager.ConnectionStrings["masterEntities"].ConnectionString;
                    break;
            }
        }
    }
}

