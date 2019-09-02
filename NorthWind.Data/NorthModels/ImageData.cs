using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class ImageData
    {
        [Key]
        [Column("ImageID")]
        public int ImageId { get; set; }
        [Column("ImageData", TypeName = "image")]
        public byte[] ImageData1 { get; set; }
        public string Description { get; set; }
    }
}
