using System.Collections.Generic;

namespace ScaffoldDbContextHelper.Classes
{
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