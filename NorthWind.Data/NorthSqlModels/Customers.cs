﻿using System;
using System.Collections.Generic;

namespace NorthWind.Data.NorthSqlModels
{
    public partial class Customers
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public int? ContactId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual Countries CountryIdentifierNavigation { get; set; }
    }
}
