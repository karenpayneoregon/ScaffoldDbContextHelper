using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.ResturantModels
{
    public partial class Guests
    {
        public Guests()
        {
            BreakfastOrders = new HashSet<BreakfastOrders>();
        }

        [Key]
        public int GuestIdentifier { get; set; }
        public int? RoomIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("RoomIdentifier")]
        [InverseProperty("Guests")]
        public virtual Rooms RoomIdentifierNavigation { get; set; }
        [InverseProperty("GuestIdentifierNavigation")]
        public virtual ICollection<BreakfastOrders> BreakfastOrders { get; set; }
    }
}
