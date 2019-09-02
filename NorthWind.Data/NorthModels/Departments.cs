using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class Departments
    {
        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
