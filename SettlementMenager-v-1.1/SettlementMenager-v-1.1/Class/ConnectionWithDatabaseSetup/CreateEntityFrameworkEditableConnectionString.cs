namespace WebAPI
{
    using System;
    using System.Data.Entity.Core.EntityClient;
    using System.Data.SqlClient;


    /// <summary>
    /// Class makeing connection string for Entity Framework with editable fields: IP, Login, Passowrd  
    /// </summary>
    public class SingleConnection
    {
        /// <summary>
        /// Default constructor initialization
        /// </summary>
        private SingleConnection() { }
        /// <summary>
        /// SingleConnection type field initialized by null
        /// </summary>
        private static SingleConnection ConsString = null;
        /// <summary>
        /// String class type initialized by null
        /// </summary>
        private String String = null;
        /// <summary>
        /// Get/Set Field string type for connectionstring
        /// </summary>
        public static string ConString
        {
            get
            {
                if (ConsString == null)
                {
                    ConsString = new SingleConnection { String = SingleConnection.Connect() };

                    return ConsString.String;
                }
                else
                    return ConsString.String;
            }
        }
        public static string Connect()

        {
            /// <summary>
            /// Build an connection string for Entity Framework app.config
            /// </summary>
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = "25.51.93.64", // Server name
                InitialCatalog = "Database.mdf",  //Database
                UserID = "sa",         //Username
                Password = "palka8",  //Password
            };

            //
            /// <summary>
            /// Build an Entity Framework connection string
            /// </summary>
            EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                Metadata = "res://*/DataModelDB.csdl|res://*/DataModelDB.ssdl|res://*/DataModelDB.msl",
                ProviderConnectionString = sqlString.ToString()
            };

            return entityString.ConnectionString;
        }
    }
}

