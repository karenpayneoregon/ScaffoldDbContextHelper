using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class TableNames
    {
        [Column("id")]
        public int Id { get; set; }
        public string TableName { get; set; }
    }
}
