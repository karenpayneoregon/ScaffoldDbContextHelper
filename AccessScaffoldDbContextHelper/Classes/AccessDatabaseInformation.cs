using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

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
                    .Where(col => col.Field<string>("TABLE_TYPE") == "TABLE" && 
                                  !col.Field<string>("TABLE_NAME").ToLower().Contains("tmp"))
                    .Select(data => data.Field<string>("TABLE_NAME"))
                    .ToList();

            }
        }
    }
}
