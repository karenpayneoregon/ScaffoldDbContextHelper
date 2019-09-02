using System;
using System.Collections.Generic;

namespace NorthWind.Data.MasterModels
{
    public partial class OrderDetails
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Orders Order { get; set; }
    }
}
