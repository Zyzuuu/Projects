using System.Reflection;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup
{
    /// <summary>
    /// 
    /// </summary>
    class TakeFromDatabaseConnectionData
    {
        /// <summary>
        /// Takes all text from txt file in program location and insert it's into array.
        /// After that takes line by line text and assign to text boxes: ipNumber.Text, databaseLogin.Text and databasePassword.Password.
        /// </summary>
        /// <param name="ipNumber">It's ipNumber text field in ConnectionWithDatabaseSetup Window</param>
        /// <param name="databaseLogin">It's databaseLogin text field in ConnectionWithDatabaseSetup Window</param>
        /// <param name="databasePassword">It's databasePassword text field in ConnectionWithDatabaseSetup Window</param>
        public static void FillTextFieldsByConnectionStringDataFromDatabase(TextBox ipNumber, TextBox databaseLogin, PasswordBox databasePassword)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string[] allLines = System.IO.File.ReadAllLines(path + "\\Resources\\ConnectionConfig.txt");
            if (allLines[0] != "" && allLines[1] != "" && allLines[2] != "" )
            {
                ipNumber.Text = allLines[0];
                databaseLogin.Text = allLines[1];
                databasePassword.Password = allLines[2];
            }
            else
            {
                ipNumber.Text = "0.0.0.0";
                databaseLogin.Text = "Login";
                databasePassword.Password = "Hasło";
            }
        }
    }
}

