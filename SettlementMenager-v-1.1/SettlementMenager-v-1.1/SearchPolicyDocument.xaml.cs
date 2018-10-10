using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Here You can search policy in database.
    /// </summary>
    public partial class SearchPolicyDocument : Window
    {
        public SearchPolicyDocument()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Search button. After fill textfield and click button program starts searching 
        /// number in database. If hit then close window and give result in datagrid.
        /// </summary>
        private void SearchPolicyNowButton(object sender, RoutedEventArgs e)
        {
            SearchPolicyField.findPolicy = searchPolicyTextField.Text;
            SearchItemInDatagrid.SearchPosition(this);
        }
    }
}
