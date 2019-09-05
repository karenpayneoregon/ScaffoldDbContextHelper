using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessScaffoldDbContextHelper.Classes
{
    public class AccessDatabaseInformation
    {

        /// <summary>
        /// Get user table names from database
        /// </summary>
        /// <param name="pDatabaseName">Existing database path and name</param>
        /// <returns></returns>
        public List<string> TableNames(string pDatabaseName)
        {
        using (var cn = new OleDbConnection { ConnectionString = pDatabaseName.BuildConnectionString() })
            {

                cn.Open();

                // ReSharper disable once AssignNullToNotNullAttribute
                return cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null)
                    .AsEnumerable()
                    .Where((col) => col.Field<string>("TABLE_TYPE") == "TABLE")
                    .Select((data) => data.Field<string>("TABLE_NAME"))
                    .ToList();

            }
        }
        /// <summary>
        /// Get column names for a specific table
        /// </summary>
        /// <param name="pDatabaseName">Path and database name</param>
        /// <param name="pTableName">Table to retrieve column names</param>
        /// <returns></returns>
        public List<string> GetColumnNames(string pDatabaseName, string pTableName)
        {
            using (var cn = new OleDbConnection { ConnectionString = pDatabaseName.BuildConnectionString() })
            {
                string[] filterValues = { null, null, pTableName, null };
                cn.Open();

                return cn.GetSchema("Columns", filterValues)
                    .AsEnumerable().Select((data) => $"[{data.Field<string>("COLUMN_NAME")}]")
                    .ToList();
            }
        }
    }
}
