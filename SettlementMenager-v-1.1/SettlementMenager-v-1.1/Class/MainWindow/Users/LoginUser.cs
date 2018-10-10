using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Data;
using SettlementMenager_v_1._1;
using LocalDatabaseApplication;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;

namespace SettlementMenager_v_1._1.Class.MainWindow.Users
{
    /// <summary>
    /// Login user procedure.
    /// </summary>
    class LoginUser
    {
        /// <summary>
        ///  Login user, check if user and password is equal values in database, if true - login, open new window 
        ///  with program and close login window.If false - show message box with message "Błędne hasło lub login!"
        /// ["Wrong password or login"].
        /// </summary>
        /// <param name="user">nameData.SelectedValue in combobox</param>
        /// <param name="password">passwordField.Password text field where need to enter password to login</param>
        /// <exception cref="InvalidOperationException">Throws if login or password field or both are empty / wrong</exception>
        public static void CheckIdentity(string user, string password)
        {
            masterEntities dc = new masterEntities(SaveConnectionStringsAsStringToMethodParameter.connstringMasterEntitiesConnectionDatabase);

            try
            {
                var checkLogin = dc.user.Where(n => password.Equals(n.Password) && user.Equals(n.Name + " " + n.Surname)).First();

                if (checkLogin != null)
                {
                    var menagerWindow = new LocalDatabaseApplication.MenagerWindow();
                    menagerWindow.Show();
                    LocalDatabaseApplication.MainWindow loginWindow = App.Current.Windows.OfType<LocalDatabaseApplication.MainWindow>().FirstOrDefault();
                    loginWindow.Close();

                    var menagerWindowUserName = new LocalDatabaseApplication.MenagerWindow();
                    menagerWindow.Welcome(user);

                    UserInformation.CurrentLoggedInUser = user;
                }
                else
                {
                    MessageBox.Show("Błędne hasło lub login!");
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Błędne hasło lub login!");
            }
        }
    }

   
}
