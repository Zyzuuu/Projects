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
    /// Checks is checkbox for local connection with database is checked
    /// </summary>
    class LocalDbCheckboxIsChecked
    {
        /// <summary>
        /// Takes path for text file, where is stored checkbox status. If value is 0 thats means localDbCheckboxIsChecked 
        /// is checked and lanDbCheckboxIsChecked is unchecked.
        /// </summary>
        /// <param name="localDbCheckboxIsChecked">Its localDbCheckBoxChecked checkbox in ConnectionWithDatabaseSetup.xaml.cs</param>
        /// <param name="lanDbCheckboxIsChecked">It's lanDbCheckBoxChecked in ConnectionWithDatabaseSetup.xaml.cs</param>
        public static void LocalDbCheckboxIsCheckedSave(CheckBox localDbCheckboxIsChecked, CheckBox lanDbCheckboxIsChecked)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var displayValue = System.IO.File.ReadAllText(path + "\\Resources\\AppFiles.txt");
            
            if (displayValue == "0")
            {
               localDbCheckboxIsChecked.IsChecked = true;
               lanDbCheckboxIsChecked.IsChecked = false;
            }
        }
    }
}
