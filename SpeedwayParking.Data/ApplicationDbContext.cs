using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SpeedwayParking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<EventLot> EventLots { get; set; }
        public DbSet<LotStandardConfig> LotStandardConfigs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Creates a compound key in EventLot using LotId and EventId with fluent API.
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EventLot>().HasKey(e => new { e.LotId, e.EventId });
        }

    }
}