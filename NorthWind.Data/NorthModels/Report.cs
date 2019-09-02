using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class Report
    {
        public Report()
        {
            ReportStatements = new HashSet<ReportStatements>();
        }

        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [InverseProperty("Report")]
        public virtual ICollection<ReportStatements> ReportStatements { get; set; }
    }
}
