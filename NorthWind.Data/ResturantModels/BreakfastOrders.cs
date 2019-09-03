using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.ResturantModels
{
    public partial class BreakfastOrders
    {
        public BreakfastOrders()
        {
            BreakfastOrderItems = new HashSet<BreakfastOrderItems>();
        }

        [Key]
        public int BreakfastIdentifier { get; set; }
        public int? GuestIdentifier { get; set; }
        public DateTime? OrderDate { get; set; }

        [ForeignKey("GuestIdentifier")]
        [InverseProperty("BreakfastOrders")]
        public virtual Guests GuestIdentifierNavigation { get; set; }
        [InverseProperty("BreakfastIdentifierNavigation")]
        public virtual ICollection<BreakfastOrderItems> BreakfastOrderItems { get; set; }
    }
}
