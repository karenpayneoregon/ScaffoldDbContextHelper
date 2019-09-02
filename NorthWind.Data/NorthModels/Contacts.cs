using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class Contacts
    {
        public Contacts()
        {
            Customers = new HashSet<Customers>();
        }

        [Key]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [InverseProperty("Contact")]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
