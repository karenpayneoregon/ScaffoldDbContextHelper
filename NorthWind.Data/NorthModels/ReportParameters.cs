using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class ReportParameters
    {
        [Column("id")]
        public int Id { get; set; }
        public int? StatementId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }

        [ForeignKey("StatementId")]
        [InverseProperty("ReportParameters")]
        public virtual ReportStatements Statement { get; set; }
    }
}
