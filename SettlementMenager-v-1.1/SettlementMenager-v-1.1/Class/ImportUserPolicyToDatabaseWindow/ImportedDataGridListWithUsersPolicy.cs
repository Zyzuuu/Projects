using SettlementMenager_v_1._1.Class.MenagerWindow.RightDatagrid;
using System;

namespace SettlementMenager_v_1._1.Class.MenagerWindow.DocumentsOperations.ImportManyPolicyItems
{
    /// <summary>
    /// Merge fields from ImportedDataGridListWithUsersPolicy and ImportedDataGridList classes.
    /// </summary>
    class ImportedDataGridListWithUsersPolicy : ImportedDataGridList
    {
        /// <summary>
        /// Nullable DateTime field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public DateTime? importedDataPolicy { get; set; }
        /// <summary>
        /// "Ubezpieczający" ["Insurer"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedInsurer { get; set; }
        /// <summary>
        /// "Zdjęcia" ["Pictures"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedPicture { get; set; }
        /// <summary>
        /// "Agent M6" ["Agent M6"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string ImportedM6 { get; set; }
        /// <summary>
        /// "Status" ["Status"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedStatus { get; set; }
        /// <summary>
        ///  "Pośrednik" ["Broker"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedBroker { get; set; }
        /// <summary>
        /// "Public" ["Public"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedPublic { get; set; }
        /// <summary>
        /// "Agencja" ["Agency Name"] - String type field for column imported from Excel file in ImportedUserPolicyToDataBaseWindow.
        /// </summary>
        public string importedUserPolicyOwner { get; set; }
    }
}
