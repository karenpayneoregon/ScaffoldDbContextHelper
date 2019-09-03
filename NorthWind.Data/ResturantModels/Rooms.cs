using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.ResturantModels
{
    public partial class Rooms
    {
        public Rooms()
        {
            Guests = new HashSet<Guests>();
        }

        [Key]
        public int RoomIdentifier { get; set; }
        public int? RoomFloor { get; set; }
        [StringLength(1)]
        public string RoomDesginator { get; set; }
        public int? RoomNumber { get; set; }

        [InverseProperty("RoomIdentifierNavigation")]
        public virtual ICollection<Guests> Guests { get; set; }
    }
}
