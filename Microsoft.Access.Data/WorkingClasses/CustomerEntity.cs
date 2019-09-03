namespace Microsoft.Access.Data.WorkingClasses
{
    public class CustomerEntity
    {
        public int CustomerIdentifier { get; set; }
        public string CustomerName { get; set; }
        public int? CountryIdentifier { get; set; }
        public string Country { get; set; }
    }
}