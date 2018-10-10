using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Windows;
using SettlementMenager_v_1._1.Class.MainWindow.Combobox;
using SettlementMenager_v_1._1.Class.MainWindow.Users;


namespace LocalDatabaseApplication
{
    /// <summary>
    /// Interaction logic for removeUser.xaml
    /// </summary>
    public partial class RemoveUser : Window
    {

        public RemoveUser()
        {
            InitializeComponent();
            //Loads user from database into combobox, where DisplayMemberPath and SelectedValuePath = "Name".
            ComboBoxSource.SetupItemsInComboBoxDisplay(nameDataUserName.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                          nameDataUserName.DisplayMemberPath = "Name", nameDataUserName.SelectedValuePath = "ID");
        }

        /// <summary>
        /// Close that window and opens Main Window, thanks by this combobox is refreshing.
        /// </summary>
        private void CloseThisWindowButton(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Deletes user from database after selecting in combobox and click delete button.
        /// </summary>
        private void DeleteUserFromDatabaseButton(object sender, RoutedEventArgs e)
        {
            DeleteUser.DeleteClientFromDatabase(nameDataUserName.DisplayMemberPath, nameDataUserName.SelectedValue);

            ComboBoxSource.SetupItemsInComboBoxDisplay(nameDataUserName.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                          nameDataUserName.DisplayMemberPath = "Name", nameDataUserName.SelectedValuePath = "ID");
        }
    }
}
