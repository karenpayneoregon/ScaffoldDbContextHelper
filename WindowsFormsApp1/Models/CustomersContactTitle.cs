using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public partial class CustomersContactTitle
    {
        public CustomersContactTitle()
        {
            Customers = new HashSet<Customers>();
        }

        public int ContactTitleId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
