using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public string CustomerId { get; set; }
        public int Identifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public int? ContactTitleId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual CustomersContactTitle ContactTitleNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
