using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using SettlementMenager_v_1._1.Class.SettlementWindow;
using SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations;
using System.Windows.Controls;

namespace LocalDatabaseApplication
{
    /// <summary>
    /// Display billing with assigned users from the database. You can export this full billing to an Excel file by clicking the button.
    /// at the same time, changing the status of the insurance policy in databse to be settled.
    /// </summary>
    public partial class SettlementWindow : System.Windows.Window
    {
        public SettlementWindow()
        {
            InitializeComponent();
            //Loads settlement sorted settlement list.
            settlementDataGrid.ItemsSource = SortSettlementDatagrid.FilterListByPolicyNumberThenByAgentNameThenByAgencyName();
        }

        /// <summary>
        /// Exports datagrid to excel file and changeing insurance policy status in database.
        /// </summary>
        private void prntButtonClick(object sender, RoutedEventArgs e)
        {
            ExportDatagrid.ToExcel(settlementDataGrid);
            ChangePolicyStatus.ForSettled();
        }
    }
}
