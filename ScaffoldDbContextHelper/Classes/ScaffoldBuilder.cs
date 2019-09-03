using System;
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
                         $"Trusted_Connection=True;\" -Provider {configuration.Provider.Type} " +
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
