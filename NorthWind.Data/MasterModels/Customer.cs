using System;
using System.Collections.Generic;

namespace NorthWind.Data.MasterModels
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AccountNumber { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
