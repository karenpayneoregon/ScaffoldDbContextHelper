using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.ResturantModels
{
    public partial class BreakfastOrderItems
    {
        [Key]
        public int OrderItemIdentifier { get; set; }
        public int? BreakfastIdentifier { get; set; }
        public int? GuestIdentifier { get; set; }
        public int? Quantity { get; set; }
        public int? ItemIdentifier { get; set; }

        [ForeignKey("BreakfastIdentifier")]
        [InverseProperty("BreakfastOrderItems")]
        public virtual BreakfastOrders BreakfastIdentifierNavigation { get; set; }
        [ForeignKey("ItemIdentifier")]
        [InverseProperty("BreakfastOrderItems")]
        public virtual BreakfastItems ItemIdentifierNavigation { get; set; }
    }
}
