using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.OpenAndLoadExcelFile
{
    /// <summary>
    /// Connection string for Excel file.
    /// </summary>
    class SwitchConnectionString
    {
        /// <summary>
        /// Connection strings switching on file extension and filepath.
        /// </summary>
        /// <returns></returns>
        public static string ConnectionStringForExcelFile()
        {
            string strFilePath = OpenFile.ShowDialogOpenFile();
            String strConnectionString = "";
            strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                                                 "Data Source=" + strFilePath + "; Jet OLEDB:Engine Type=5;" +
                                                                 "Extended Properties=Excel 8.0;";
            FileInfo fileExtension = new FileInfo(strFilePath);
            if (!fileExtension.Exists)
            {
                throw new Exception("Błąd! plik nie istnieje");
            }
            string extension = fileExtension.Extension;
            switch (extension)
            {
                case ".xls":
                    strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
                case ".xlsx":
                    strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    break;
                default:
                    strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
            }

            return strConnectionString;
        }
    }
}
