using System.Collections.Generic;
using CommonLibrary;

namespace AccessScaffoldDbContextHelper
{
    public class AccessScaffoldConfigurationItem
    {
        public AccessScaffoldConfigurationItem()
        {
            Switches = new ConfigurationOption();
        }
        public string DatabaseName { get; set; }
        public DatabaseProvider Provider { get; set; }
        public IEnumerable<string> TableNames { get; set; }
        public string ContextName { get; set; }
        public string ContextDirectory { get; set; }
        public string FolderName { get; set; }
        public string StartupProject { get; set; }
        public ConfigurationOption Switches { get; set; }
    }
}
