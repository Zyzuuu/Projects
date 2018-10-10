using SettlementMenager_v_1._1.Class.MainWindow.Users;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Add user to database.
    /// </summary>
    public partial class addUser : Window
    {
        public addUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close addUser Window and open MainWindow (thanks by this Mainwindow Combobox is refreshed after adding user)
        /// </summary>
        private void CloseButton(object sender, RoutedEventArgs e)
        {
            var showMainWindow = new MainWindow();
            showMainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Saves user in database and clear all fields after click "Zapisz" ["Save"].
        /// </summary>
        private void SaveButton(object sender, RoutedEventArgs e)
        {
            CreateUser.AddClientToDatabase(userNameTextField.Text, userSurnameTextField.Text, passwordTextField.Text);

            userNameTextField.Clear();
            userSurnameTextField.Clear();
            passwordTextField.Clear();
        }
    }
}
