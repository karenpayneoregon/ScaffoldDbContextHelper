using System.Collections.Generic;

namespace ScaffoldDbContextHelper.Classes
{
    public class DatabaseProviders
    {
        public List<DatabaseProvider> List = new List<DatabaseProvider>()  
        {
            new DatabaseProvider() {Name = "SQL-Server", Type = "Microsoft.EntityFrameworkCore.SqlServer" },
            new DatabaseProvider() {Name = "Oracle", Type = "Oracle.EntityFrameworkCore" },
            new DatabaseProvider() {Name = "MS-Access", Type = "EntityFrameworkCore.Jet" }
        };
    }
}