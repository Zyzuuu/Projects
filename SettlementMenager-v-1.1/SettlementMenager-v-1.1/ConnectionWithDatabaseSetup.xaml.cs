using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System.Reflection;
using System.Windows;

namespace SettlementMenager_v_1._1
{
    /// <summary>
    /// Setup Connection type and connection string adress.
    /// </summary>
    public partial class ConnectionWithDatabaseSetup : Window
    {
        /// <summary>
        /// Shows program location path.
        /// </summary>
        string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public ConnectionWithDatabaseSetup()
        {
            InitializeComponent();
            //Load checkboxes status.
            SwitchCheckboxes.SwitchCheckboxStatusWhenInDatabaseIsChanged(localDbCheckbox, lanDbCheckbox);
            ////Load datas from txt file into text fields.
            TakeFromDatabaseConnectionData.FillTextFieldsByConnectionStringDataFromDatabase(ipNumber, databaseLogin, databasePassword);
        }

        /// <summary>
        /// Shows program location path.
        /// </summary>
        private void localDbCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(path + "\\Resources\\AppFiles.txt", "0");
            LocalDbCheckboxIsChecked.LocalDbCheckboxIsCheckedSave(localDbCheckbox, lanDbCheckbox);
        }

        /// <summary>
        /// Checks checkbox status and check landb checkbox.
        /// </summary>
        private void lanDbCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(path + "\\Resources\\AppFiles.txt", "1");
            LanCheckboxIsChecked.LanDbCheckboxIsCheckedSave(localDbCheckbox, lanDbCheckbox);
        }

        /// <summary>
        /// Saves checkbox status into txt file and close window.
        /// </summary>
        private void CloseConnectionSetupWindowButton(object sender, RoutedEventArgs e)
        {
            SaveConnectionDataToFile.SaveFieldsFromConnectionSetupLanDbData(ipNumber, databaseLogin, databasePassword);
            this.Close();
        }
    }
}

