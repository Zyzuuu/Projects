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
    /// Add document as insurance policy into database.
    /// You should make up all fields before clicking "Dodaj" ["Add"].
    /// </summary>
    public partial class AddDocument : Window
    {

        public AddDocument()
        {
            InitializeComponent();

            //Sets default date in date picker field.
            addDate.SelectedDate = DateTime.Today;
        }

        /// <summary>
        /// Adds insurance policy into database.Clear policy number field, thanks by this You can add next insurance policy
        /// by write new number, other fields are already filled.
        /// </summary>
        private void AddPolicyToDatabaseButton(object sender, RoutedEventArgs e)
        {
            AddPolicy.UserPolicyToDatabase(policyNumberTextField.Text, addDate.DisplayDate, brokerNameTextField.Text);
            policyNumberTextField.Clear();

        }
        /// <summary>
        /// Clear all fields in this window.
        /// </summary>
        private void ClearFieldsButton(object sender, RoutedEventArgs e)
        {
            policyNumberTextField.Clear();
            addDate.SelectedDate = null;
        }

        /// <summary>
        /// Close AddDocument window.
        /// </summary>
        private void CloseWindowButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
