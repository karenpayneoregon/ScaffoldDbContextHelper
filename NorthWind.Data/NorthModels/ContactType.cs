using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class ContactType
    {
        public ContactType()
        {
            Customers = new HashSet<Customers>();
        }

        [Key]
        public int ContactTypeIdentifier { get; set; }
        public string ContactTitle { get; set; }

        [InverseProperty("ContactTypeIdentifierNavigation")]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
