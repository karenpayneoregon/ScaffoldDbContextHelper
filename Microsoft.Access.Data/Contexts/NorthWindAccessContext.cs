using EntityFrameworkCore.Jet;
using Microsoft.Access.Data.NorthModels;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Access.Data.Contexts
{
    public partial class NorthWindAccessContext : DbContext
    {
        public NorthWindAccessContext()
        {
        }

        public NorthWindAccessContext(DbContextOptions<NorthWindAccessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasKey(e => e.ContactTypeIdentifier)
                    .HasName("PrimaryKey");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PrimaryKey");

                entity.HasIndex(e => e.ContactId)
                    .HasName("ContactsContactId");

                entity.Property(e => e.ContactId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryIdentifier)
                    .HasName("PrimaryKey");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerIdentifier)
                    .HasName("PrimaryKey");

                entity.HasIndex(e => e.ContactId)
                    .HasName("CustomersContactId");

                entity.HasIndex(e => e.ContactTypeIdentifier)
                    .HasName("CustomersContactTypeIdentifier");

                entity.HasIndex(e => e.CountryIdentifier)
                    .HasName("CustomersCountryIdentifier");

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.ModifiedDate).HasMaxLength(29);
            });
        }
    }
}
