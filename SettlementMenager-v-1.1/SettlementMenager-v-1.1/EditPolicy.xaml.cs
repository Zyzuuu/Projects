using SettlementMenager_v_1._1.Class.MainWindow.Combobox;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Interaction logic for editPolicyDocument.xaml
    /// </summary>
    public partial class EditPolicyDocument : Window
    {
        public EditPolicyDocument()
        {
            InitializeComponent();
            //Loads user from database into combobox, where DisplayMemberPath and SelectedValuePath = "Name".
            ComboBoxSource.SetupItemsInComboBoxDisplay(userComboboxField.ItemsSource = DisplayComboboxList.SetUpNameInComboBox(),
                                                           userComboboxField.DisplayMemberPath = "Name", userComboboxField.SelectedValuePath = "Name");
           
            //Policy data label and saved policy number to edit.
            policyDataLabel.Content = CatchPolicyData.savedPolicyNumber;
            //Date picker and saved date to edit.
            dateToEdit.Content = CatchPolicyData.savedFullDate;
            //User name label and saved user name to edit.
            userDataLabel.Content = CatchPolicyData.savedUserName;
            //Broker name label and saved broker name to edit.
            brokerNameLabel.Content = CatchPolicyData.savedBrokerName;

            //Fill data picker by date saved in database.
            editDate.SelectedDate = CatchPolicyData.savedFullDate;
            //Fill User name combobox by name saved in database.
            userComboboxField.SelectedValue = userDataLabel.Content.ToString();
            //Fill insurance policy text field by policy number saved in date base.
            policyNumberTextField.Text = policyDataLabel.Content.ToString();
            //Fill Broker name text field by broker name saved in data base.
            brokerNameTextField.Text = brokerNameLabel.Content.ToString();
        }

        /// <summary>
        /// Saves changes in database and close window.
        /// </summary>
        private void SaveAndCloseWindowButton(object sender, RoutedEventArgs e)
        {
            EditPolicy.InDatabaseChange(policyNumberTextField.Text, editDate.DisplayDate,
                 userComboboxField.SelectedValue.ToString(), brokerNameTextField.Text);

            this.Close();
        }
    }
}
