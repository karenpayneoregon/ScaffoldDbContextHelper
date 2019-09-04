namespace ScaffoldDbContextHelper.Classes
{
    public class ApplicationSettings
    {
        public string LastServerName { get; set; }
        public string StartupProject { get; set; }
        public string DataProvider { get; set; }
        public override string ToString()
        {
            return $"{LastServerName}, {StartupProject}, {DataProvider}";
        }
    }
}
