﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Data.NorthModels
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
            Types = new HashSet<Types>();
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("SupplierID")]
        public int? SupplierId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Products")]
        public virtual Categories Category { get; set; }
        [ForeignKey("SupplierId")]
        [InverseProperty("Products")]
        public virtual Suppliers Supplier { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Types> Types { get; set; }
    }
}
