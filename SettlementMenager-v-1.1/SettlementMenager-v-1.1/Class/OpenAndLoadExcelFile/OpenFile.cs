using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.OpenAndLoadExcelFile
{
    /// <summary>
    /// Opens filedialog.
    /// </summary>
    class OpenFile
    {
        /// <summary>
        /// Open filedialog for excel extensions, default opened directory is Desktop, and first selected index is 1 = *.xls, cant select many files thanks
        /// to Multiselect = false.
        /// </summary>
        /// <returns></returns>
        public static string ShowDialogOpenFile()
        {
            OpenFileDialog openFilteredExtensions = new OpenFileDialog();
            openFilteredExtensions.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";
            openFilteredExtensions.FilterIndex = 1;
            openFilteredExtensions.Multiselect = false;
            openFilteredExtensions.InitialDirectory = @"Desktop";
            bool? result = openFilteredExtensions.ShowDialog();

            if (result == true)
            {
                string fileName = openFilteredExtensions.FileName;
                ShowPathFile.showThatPath = fileName;


                return fileName;
            }
            return null;
        }
    }
}
