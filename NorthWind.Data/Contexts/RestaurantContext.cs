using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthWind.Data.ResturantModels
{
    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BreakfastItems> BreakfastItems { get; set; }
        public virtual DbSet<BreakfastOrderItems> BreakfastOrderItems { get; set; }
        public virtual DbSet<BreakfastOrders> BreakfastOrders { get; set; }
        public virtual DbSet<Guests> Guests { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BreakfastOrderItems>(entity =>
            {
                entity.HasOne(d => d.BreakfastIdentifierNavigation)
                    .WithMany(p => p.BreakfastOrderItems)
                    .HasForeignKey(d => d.BreakfastIdentifier)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BreakfastOrderItems_BreakfastOrders1");

                entity.HasOne(d => d.ItemIdentifierNavigation)
                    .WithMany(p => p.BreakfastOrderItems)
                    .HasForeignKey(d => d.ItemIdentifier)
                    .HasConstraintName("FK_BreakfastOrderItems_BreakfastItems");
            });

            modelBuilder.Entity<BreakfastOrders>(entity =>
            {
                entity.Property(e => e.OrderDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.GuestIdentifierNavigation)
                    .WithMany(p => p.BreakfastOrders)
                    .HasForeignKey(d => d.GuestIdentifier)
                    .HasConstraintName("FK_BreakfastOrders_Guests1");
            });

            modelBuilder.Entity<Guests>(entity =>
            {
                entity.HasOne(d => d.RoomIdentifierNavigation)
                    .WithMany(p => p.Guests)
                    .HasForeignKey(d => d.RoomIdentifier)
                    .HasConstraintName("FK_Guests_Rooms1");
            });
        }
    }
}
