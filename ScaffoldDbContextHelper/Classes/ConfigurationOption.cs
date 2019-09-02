namespace ScaffoldDbContextHelper.Classes
{
    /// <summary>
    /// Various scaffold switches
    /// </summary>
    public class ConfigurationOption
    {
        public bool Verbose { get; set; }
        public bool Force { get; set; }
        public bool UseDataAnnotations { get; set; }
        public bool UseDatabaseNames { get; set; }
    }
}