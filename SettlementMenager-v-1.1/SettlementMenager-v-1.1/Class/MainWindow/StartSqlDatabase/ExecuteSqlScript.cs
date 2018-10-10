using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using System;
using System.Windows;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System.Configuration;

namespace SettlementMenager_v_1._1.Class.MainWindow.StartSqlDatabase
{

    /// <summary>
    /// Executing SQL script which creates new database -> Database.mdf - for this objective you
    /// need to have SQLEXPRESS server installed on your machine.
    /// </summary>
    class ExecuteSqlScript
    {
        /// <summary>
        /// Method connecting with SQL server and make new database from script.sql.
        /// After connect to database opens script.sql, and execute it after splits "GO" commands.
        /// If can't connect to external database then changing connection string to local connection string
        /// by changing value in txt file.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadDatabase()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
           
            try
            {
                string cs = (SaveConnectionStringsAsStringToMethodParameter.connstringSqlConnectionMaster);


                var fileContent = File.ReadAllText(path + "\\script.sql");
                var sqlQueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                var con = new SqlConnection(cs);
                var cmd = new SqlCommand("query", con);
                con.Open();
                foreach (var query in sqlQueries)
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nie można nawiązać połączenia z bazą danych (dostęp może być ograniczony do lokalnej bazy danych)");
            }
            catch(SqlException)
            {
                MessageBox.Show("Nie można nawiązać połączenia z bazą danych (dostęp może być ograniczony do lokalnej bazy danych)");
            }
            finally
            {
                System.IO.File.WriteAllText(path + "\\Resources\\AppFiles.txt", "0");
            }
        }
    }
}
