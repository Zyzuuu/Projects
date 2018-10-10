using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementMenager_v_1._1.Class.MainWindow.Users
{
    /// <summary>
    /// Saves and show current logged username.
    /// </summary>
        internal class UserInformation
        {
        /// <summary>
        /// Current logged username field.
        /// </summary>
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }
        }
}
