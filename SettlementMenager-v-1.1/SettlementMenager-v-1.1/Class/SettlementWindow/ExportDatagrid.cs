using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SettlementMenager_v_1._1.Class.SettlementWindow
{
    /// <summary>
    /// Exports datagrid to Excel.
    /// </summary>
    class ExportDatagrid
    {
        /// <summary>
        ///Creates new excel file and exports datas from datagridview to that excel.
        ///if excel.Visible = true, shows file, if not window is not shows. by the reflection - creates sheet.
        ///By the first loop inserts to that sheet as many columns as is in datagrid.
        ///In first line makes headers with bolded font takes from headers in datagrid.Next sets columns width.
        ///In the second and third loop counts columns and cells in datagrid and takes that data as textblock.
        ///Next starts insert data into cells starting at second line, becouse in first line we have header from first loop.
        /// </summary>
        /// <param name="settlementDataGrid">Used as settlementDataGrid</param>
        public static void ToExcel(DataGrid settlementDataGrid)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < settlementDataGrid.Columns.Count; j++) // first loop
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = settlementDataGrid.Columns[j].Header;
            }
            for (int i = 0; i < settlementDataGrid.Columns.Count; i++) // second loop
            {
                for (int j = 0; j < settlementDataGrid.Items.Count; j++) //third loop
                {
                    TextBlock b = settlementDataGrid.Columns[i].GetCellContent(settlementDataGrid.Items[j]) as TextBlock;
                    Range myRange = (Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }
    }
}
