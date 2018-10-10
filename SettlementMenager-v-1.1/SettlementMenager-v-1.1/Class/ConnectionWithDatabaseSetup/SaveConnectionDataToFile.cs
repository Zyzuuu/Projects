using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup
{
    /// <summary>
    /// Saves connection datas from textfields in ConnectionWithDatabaseSetup to textfile.
    /// </summary>
    class SaveConnectionDataToFile
    {
        /// <summary>
        ///Takes path to Connection.Config.txt file, and write there all texts writes in textfields as ipNumber, databaseLogin, databasePassword.
        ///Each of above fields is saved line after line in text file.
        /// </summary>
        /// <param name="ipNumber">It's ipNumber in ConnectionWithDatabaseSetup</param>
        /// <param name="databaseLogin">It's databaseLogin in ConnectionWithDatabaseSetup</param>
        /// <param name="databasePassword">It's databasePassword in ConnectionWithDatabaseSetup</param>
        public static void SaveFieldsFromConnectionSetupLanDbData(TextBox ipNumber, TextBox databaseLogin, PasswordBox databasePassword)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            System.IO.File.WriteAllText(path + "\\Resources\\ConnectionConfig.txt", ipNumber.Text 
                + Environment.NewLine + databaseLogin.Text 
                + Environment.NewLine+ databasePassword.Password);
        }
    }
}
