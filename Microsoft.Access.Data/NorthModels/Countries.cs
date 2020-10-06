using System;
using System.Collections.Generic;

namespace Microsoft.Access.Data.NorthModels
{
    public partial class Countries
    {
        public int CountryIdentifier { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

    }
}
