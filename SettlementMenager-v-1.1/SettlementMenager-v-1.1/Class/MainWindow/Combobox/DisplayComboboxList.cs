using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.MainWindow.Combobox
{
    /// <summary>
    /// Class generates list with Name and Surname wchich are displaying in Combobox (Login window and RemoveUser window)
    /// </summary>
    class DisplayComboboxList
    {
        /// <summary>
        /// Makes list of Name, Surname and ID from database after connect with that database. If can't get data
        /// returns msg "Problem z bazą danych"
        /// </summary>
        /// <exception cref="Exception">Throws when can't connect with database</exception>
        /// <returns>List of ComboboxList</returns>
        public static List<ComboboxList> SetUpNameInComboBox()
        {
            try
            {
                masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);
                var name = from n in dc.user select new ComboboxList() { Name = n.Name + " " + n.Surname, ID = n.Id };
                return name.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem z bazą danych");
                return null;
            }
        }
    }
}
