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
    /// Creates user in database from fields name, surname, password.
    /// </summary>
    class CreateUser
    {
        /// <summary>
        /// Create user. By this class we can add user to database, it's checking fields, 
        /// they are must have values, can't be null, all three fields are requirement.
        /// If one of field is empty then we get message "Wprowadź dane użytkownika!" ["Enter users data!"].
        /// If all fields are filled method adds fields with values to database, and saves changes.
        /// </summary>
        /// <param name="userNameTextField">Used in AddUser as userNameTextField.Text</param>
        /// <param name="userSurnameTextField">Used in AddUser as userSurnameTextField.Text</param>
        /// <param name="passwordTextField">Used in AddUser as passwordTextField.Text</param>
        public static void AddClientToDatabase(string userNameTextField, string userSurnameTextField, string passwordTextField)
        {
            try
            {
                masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

                if (userNameTextField != "" && userSurnameTextField != "" && passwordTextField != "")
                {
                    var person = new user { Name = userNameTextField, Surname = userSurnameTextField, Password = passwordTextField };

                    dc.user.Add(person);
                    dc.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wprowadź dane użytkownika!");
                }
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Brak połączenia z bazą danych");
            }
          
        }
    }
}
