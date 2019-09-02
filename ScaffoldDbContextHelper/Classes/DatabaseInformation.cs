using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;

namespace ScaffoldDbContextHelper.Classes
{
    public class DatabaseInformation : SqlServerConnection
    {
        /// <summary>
        /// Available server e.g. SQLEXPRESS, named server, localdb
        /// </summary>
        /// <param name="pServerName">Server name</param>
        public DatabaseInformation(string pServerName)
        {
            DatabaseServer = pServerName;

            /*
             * Schemas are retrieved from master database
             */
            DefaultCatalog = "Master";

        }
        /// <summary>
        /// Get databases for connection string with an existing database
        /// </summary>
        /// <returns></returns>
        public List<string> DatabaseNames()
        {
            mHasException = false;

            var results = new List<string>();

            using (var cn = new SqlConnection(ConnectionString))
            {
                const string selectStatement = 
                    "SELECT Name " + 
                    "FROM sys.databases " +
                    "WHERE Name NOT IN ('master','model','msdb','temdb','UnitTesting') " +
                    "ORDER BY name";

                using (var cmd = new SqlCommand() {Connection = cn, CommandText = selectStatement })
                {
                    try
                    {

                        cn.Open();

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                results.Add(reader.GetString(0));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return results;
        }
        /// <summary>
        /// Get all user tables for a database
        /// </summary>
        /// <param name="pDatabaseName">Database to get tables</param>
        /// <returns></returns>
        public List<string> TableNames(string pDatabaseName)
        {
            mHasException = false;

            var tableNameList = new List<string>();

            using (var cn = new SqlConnection(ConnectionString))
            {

                using (var cmd = new SqlCommand() { Connection = cn})
                {

                    cmd.CommandText = $"SELECT TABLE_NAME FROM {pDatabaseName}." + 
                                       "INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";

                    try
                    {

                        cn.Open();

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var tableName = reader.GetString(0);

                                /*
                                 * Disregard database diagrams
                                 */
                                if (tableName == "sysdiagrams")
                                {
                                    continue;
                                }

                                /*
                                 * Enclose table names with spaces with brackets
                                 */
                                if (tableName.Contains(" "))
                                {
                                    tableName = $"[{tableName}]";
                                }

                                tableNameList.Add(tableName);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return tableNameList; 

        }
    }
}
