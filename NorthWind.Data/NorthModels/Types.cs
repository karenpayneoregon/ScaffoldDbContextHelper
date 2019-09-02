using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class Types
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        public int? Hight { get; set; }
        public int? Width { get; set; }
        public int? Length { get; set; }
        public int? Area { get; set; }
        public int? Type { get; set; }
        [Column("kg")]
        public int? Kg { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("Types")]
        public virtual Products Product { get; set; }
    }
}
