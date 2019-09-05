using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;

namespace AccessScaffoldDbContextHelper.Classes
{
    public static class ConnectionsAccess
    {
        private static readonly Dictionary<string, string> Providers = new Dictionary<string, string>()
        {
            { ".accdb" , "Microsoft.ACE.OLEDB.12.0" },
            { ".mdb" , "Microsoft.Jet.OLEDB.4.0" }
        };

        public static string BuildConnectionString(this string pDatabaseName)
        {

            var builder = new OleDbConnectionStringBuilder
            {
                // ReSharper disable once PossibleNullReferenceException
                Provider = Providers[Path.GetExtension(pDatabaseName).ToLower()],
                DataSource = pDatabaseName
            };

            return builder.ConnectionString;

        }
    }
}
