using System;
using System.Collections.Generic;

namespace Microsoft.Access.Data
{
    public partial class SuppliersContactTitle
    {
        public SuppliersContactTitle()
        {
            Suppliers = new HashSet<Suppliers>();
        }

        public int SuppliersTitleId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}
