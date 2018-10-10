using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Configuration;
using SettlementMenager_v_1._1.Class.MainWindow.StartSqlDatabase;
using SettlementMenager_v_1._1.Class.MainWindow.Users;
using SettlementMenager_v_1._1;
using SettlementMenager_v_1._1.Class.MainWindow.Combobox;
using SettlementMenager_v_1._1.Class.ConnectionWithDatabaseSetup;
using System.Reflection;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Login window, here You can set connection with database, add/remove user from database, and login.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SwitchConnectionSetupConnectionStrings.SwitchConnectionStringsFromLocalDbToLanDb();
            if (!IfDatabaseExist.CheckDatabaseExist())
            {
                ExecuteSqlScript.LoadDatabase();
            }

            //Loads user from database into combobox, where DisplayMemberPath and SelectedValuePath = "Name".
            ComboBoxSource.SetupItemsInComboBoxDisplay(nameData.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                           nameData.DisplayMemberPath = "Name", nameData.SelectedValuePath = "Name");
        }

        /// <summary>
        /// Show add user window after button click and close current window.
        /// </summary>
        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            var addUserWindow = new addUser();
            addUserWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Show remove user window after button click and close current window.
        /// </summary>
        private void removeUserButton_Click(object sender, RoutedEventArgs e)
        {
            var removeUserWindow = new RemoveUser();
            removeUserWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Check user name and password after button click - if true - login.
        /// </summary>
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginUser.CheckIdentity((string)nameData.SelectedValue, passwordField.Password);
            passwordField.Clear();
        }

        /// <summary>
        /// Set connection with database after button click - open window.
        /// </summary>
        private void SetConnectionSetupButton(object sender, RoutedEventArgs e)
        {
            ConnectionWithDatabaseSetup openConnectionWithDatabaseSetupWindow = new ConnectionWithDatabaseSetup();
            openConnectionWithDatabaseSetupWindow.ShowDialog();
        }
    }
}
