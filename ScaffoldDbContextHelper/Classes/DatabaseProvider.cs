namespace ScaffoldDbContextHelper.Classes
{
    public class DatabaseProvider
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
