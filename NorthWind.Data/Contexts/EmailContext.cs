using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthWind.Data.EmailModels
{
    public partial class EmailContext : DbContext
    {
        public EmailContext()
        {
        }

        public EmailContext(DbContextOptions<EmailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CannedMessages> CannedMessages { get; set; }
        public virtual DbSet<EmailAddresses> EmailAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KARENS-PC;Database=EmailTesting;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CannedMessages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<EmailAddresses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });
        }
    }
}
