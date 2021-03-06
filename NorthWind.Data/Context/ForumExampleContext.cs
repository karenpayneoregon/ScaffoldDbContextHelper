﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthWind.Data.Models
{
    public partial class ForumExampleContext : DbContext
    {
        public ForumExampleContext()
        {
        }

        public ForumExampleContext(DbContextOptions<ForumExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TransactionsLog> TransactionsLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ForumExample;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TransactionsLog>(entity =>
            {
                entity.HasKey(e => e.TransactionLogId)
                    .HasName("PK_TranzilaTransactionsLog");

                entity.Property(e => e.ResponseCode).IsUnicode(false);
            });

            modelBuilder.HasSequence<int>("seq_test").HasMin(1);
        }
    }
}
