using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldDbContextHelper.Classes
{
    public class ScaffoldBuilder
    {
        /// <summary>
        /// Change to match your server e.g.
        /// localdb, sqlexpress etc.
        /// </summary>
        public string ServerName { get; set; }

        public ScaffoldBuilder()
        {
            
        }

        public ScaffoldBuilder(string serverName)
        {
            ServerName = serverName;
        }

        public string Generate(ScaffoldConfigurationItem configuration)
        {

            var script = "";

            if (string.IsNullOrWhiteSpace(configuration.FolderName))
            {
                script = $"Scaffold-DbContext \"Server={ServerName}; " +
                         $"Database={configuration.DatabaseName};" +
                         $"Trusted_Connection=True;\" -Provider {configuration.Provider.Type}";
            }
            else
            {
                var folderName = "";
                folderName = configuration.FolderName.Contains(" ") ? $"\"{configuration.FolderName}\"" : configuration.FolderName;

                script = $"Scaffold-DbContext \"Server={ServerName};Database={configuration.DatabaseName};" +
                         $"Trusted_Connection=True;\" -Provider Microsoft.EntityFrameworkCore.SqlServer " +
                         $"-OutputDir {folderName}";
            }


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

    public class ScaffoldConfigurationItem
    {
        /// <summary>
        /// Database type to target
        /// </summary>
        public DatabaseProvider Provider { get; set; } 
        /// <summary>
        /// Database name to work against to create a model
        /// </summary>
        public string DatabaseName { get; set; }
        /// <summary>
        /// Points to output folder for models folder
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// Project to create models for
        /// </summary>
        public string StartupProject { get; set; }
        /// <summary>
        /// Name of DbContext
        /// </summary>
        public string ContextName { get; set; }
        /// <summary>
        /// Folder to place DbContext
        /// </summary>
        public string ContextDirectory { get; set; }
        /// <summary>
        /// Table names for models
        /// </summary>
        public IEnumerable<string> TableNames { get; set; }
        /// <summary>
        /// Switches/options
        /// </summary>
        public ConfigurationOption Switches { get; set; }

        public ScaffoldConfigurationItem()
        {
            Switches = new ConfigurationOption();
        }
    }
}
