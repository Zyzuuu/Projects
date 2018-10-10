using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System.Reflection;

namespace SettlementMenager_v_1._1.Class.MainWindow.StartSqlDatabase
{
    /// <summary>
    /// Checking if there is a connection with database.
    /// </summary>
    class IfDatabaseExist
    {
        /// <summary>
        ///  Method checking if database exist. Trying to open connection with Database.mdf if can - return true and nothing happens
        ///  if can't return false and get message "Nie można połączyć się z bazą danych" ["Can't connect to database"].
        /// </summary>
        /// <exception cref="Exception">Throws when can't connect with created database</exception>
        /// <returns>bool</returns>
        public static bool CheckDatabaseExist()
        {
            try
            {
                string cs = (SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionDatabase); 
                var con = new SqlConnection(cs);
                con.Open();
                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
            }
        }
    }
}
