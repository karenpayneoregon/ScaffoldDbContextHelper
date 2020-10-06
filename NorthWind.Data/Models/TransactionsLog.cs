using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.Models
{
    public partial class TransactionsLog
    {
        [Column("TransactionLogID")]
        public int TransactionLogId { get; set; }
        [Column("TransactionID")]
        public Guid TransactionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [StringLength(500)]
        public string Reponse { get; set; }
        [Required]
        [StringLength(50)]
        public string ResponseCode { get; set; }
    }
}
