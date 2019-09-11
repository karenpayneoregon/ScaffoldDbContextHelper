using System;
using System.Linq;

namespace AccessScaffoldDbContextHelper.Classes
{
    /// <summary>
    /// This class generated a script to create a context and models
    /// for MS-Access database with selected tables.
    /// 
    /// After running the generated script a reference to
    /// using EntityFrameworkCore.Jet;
    /// needs to be added to the newly generated context class.
    /// </summary>
    public class ScaffoldBuilder
    {
        /// <summary>
        /// Change to match your server e.g.
        /// localdb, sqlexpress etc.
        /// </summary>
        public string DatabaseName { get; set; }

        public ScaffoldBuilder(string databaseName)
        {
            DatabaseName = databaseName;
        }

        public string Generate(AccessScaffoldConfigurationItem configuration)
        {
            var script = $"Scaffold-DbContext \"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={configuration.DatabaseName}\" -Provider {configuration.Provider.Type}";

            var folderName = "";
            folderName = configuration.FolderName.Contains(" ") ? $"\"{configuration.FolderName}\"" : configuration.FolderName;

            script += $" -OutputDir {folderName} ";

            if (!string.IsNullOrWhiteSpace(configuration.ContextName))
            {
                script += $" -Context {configuration.ContextName} ";
            }

            if (configuration.Switches.Verbose)
            {
                script = script + " -v";
            }

            if (configuration.Switches.Force)
            {
                script += " -f ";
            }

            if (configuration.Switches.UseDataAnnotations)
            {
                script += " -DataAnnotations ";
            }


            if (configuration.Switches.UseDatabaseNames)
            {
                script += " -UseDatabaseNames ";
            }

            if (!string.IsNullOrWhiteSpace(configuration.StartupProject))
            {
                script += $" -project {configuration.StartupProject}";
                script += $" -startupproject {configuration.StartupProject}";
            }

            if (!string.IsNullOrWhiteSpace(configuration.ContextDirectory))
            {
                script += $" -ContextDir {configuration.ContextDirectory}";
            }

            var tableNames = string.Join("", configuration.TableNames.Select(tb => $"\"{tb}\",").ToArray()).TrimEnd(',');

            script += " -t "; // parameter for adding tables to the script
            script += tableNames;

            return script;
        }
    }
}
