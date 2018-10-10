using System.Reflection;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup
{
    

    /// <summary>
    /// Sets checkbox status at program start.
    /// </summary>
    class SwitchCheckboxes
    {
        /// <summary>
        ///  Reads checkboxes status, value in txt file is 0  - we have at start localdbcheckbox checked,
        ///but if in txt file value is 1 then we have at start landbcheckbock checked.
        ///Thanks by this method our connection is always set as we seted in past in connection setup window.
        /// </summary>
        /// <param name="localDbCheckboxIsChecked">Its localDbCheckBoxChecked checkbox in ConnectionWithDatabaseSetup.xaml.cs</param>
        /// <param name="lanDbCheckboxIsChecked">It's lanDbCheckBoxChecked in ConnectionWithDatabaseSetup.xaml.cs</param>
        public static void SwitchCheckboxStatusWhenInDatabaseIsChanged(CheckBox localDbCheckbox, CheckBox lanDbCheckbox)
        {
            var path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string value = System.IO.File.ReadAllText(path + "\\Resources\\AppFiles.txt");
            if (value == "0")
            {
                localDbCheckbox.IsChecked = true;
                lanDbCheckbox.IsChecked = false;
            }
            else if (value == "1")
            {
                lanDbCheckbox.IsChecked = true;
                localDbCheckbox.IsChecked = false;
            }
        }
    }
}
