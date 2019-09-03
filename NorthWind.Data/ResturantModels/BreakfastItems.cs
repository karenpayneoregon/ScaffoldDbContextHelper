using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.ResturantModels
{
    public partial class BreakfastItems
    {
        public BreakfastItems()
        {
            BreakfastOrderItems = new HashSet<BreakfastOrderItems>();
        }

        [Key]
        public int ItemIdentifier { get; set; }
        public string Item { get; set; }

        [InverseProperty("ItemIdentifierNavigation")]
        public virtual ICollection<BreakfastOrderItems> BreakfastOrderItems { get; set; }
    }
}
