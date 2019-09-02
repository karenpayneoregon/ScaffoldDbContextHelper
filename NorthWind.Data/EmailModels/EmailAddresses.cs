using System;
using System.Collections.Generic;

namespace NorthWind.Data.EmailModels
{
    public partial class EmailAddresses
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
