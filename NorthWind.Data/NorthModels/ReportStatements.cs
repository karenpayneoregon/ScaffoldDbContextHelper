using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class ReportStatements
    {
        public ReportStatements()
        {
            ReportParameters = new HashSet<ReportParameters>();
        }

        [Column("id")]
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public string Statement { get; set; }

        [ForeignKey("ReportId")]
        [InverseProperty("ReportStatements")]
        public virtual Report Report { get; set; }
        [InverseProperty("Statement")]
        public virtual ICollection<ReportParameters> ReportParameters { get; set; }
    }
}
