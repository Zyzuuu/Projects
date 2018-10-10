using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SettlementMenager_v_1._1.Class.MainWindow.Users
{
    /// <summary>
    /// Delete selected user.
    /// </summary>
    class DeleteUser
    {
        /// <summary>
        ///  Delete user, it's checking id of selected user (combobox - nameData) if true - delete user from database.
        ///  i've used here try catch for NullReferenceExeption, because if database is empty (no users) we get that exeption 
        ///  - if exeption appears then  message "Baza danych jest pusta!" ["Database is empty!"] */
        /// <summary>
        /// <param name="Id">DisplayMemberPath which is set on ID</param>
        /// <param name="selectedValue">SelectedValue which is set on "Name"</param>
        /// <exception cref="NullReferenceException">Throws when database is empty</exception>
        public static void DeleteClientFromDatabase(string Id, object selectedValue)
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            try
            {
                var itemToRemove = dc.user.SingleOrDefault(x => x.Id.Equals((int)selectedValue));
                if (itemToRemove != null)
                {
                    dc.user.Remove(itemToRemove);
                    dc.SaveChanges();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Baza danych jest pusta!");
            }
        }
    }
}
