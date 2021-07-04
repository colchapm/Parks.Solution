using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
          .HasData(
            new Park {ParkId = 1, Name = "Olympic National Park", Location = "Washington", Type = "National"},
            new Park {ParkId = 2, Name = "North Cascades National Park", Location = "Washington", Type = "National"},
            new Park {ParkId = 3, Name = "Mount Rainier National Park", Location = "Washington", Type = "National"},
            new Park {ParkId = 4, Name = "Cape Disappointment State Park", Location = "Washington", Type = "State"},
            new Park {ParkId = 5, Name = "Deception Pass State Park", Location = "Washington", Type = "State"},
            new Park {ParkId = 6, Name = "Crater Lake National Park", Location = "Oregon", Type = "National"},
            new Park {ParkId = 7, Name = "Smith Rock State Park", Location = "Oregon", Type = "State"},
            new Park {ParkId = 8, Name = "Joshua Tree National Park", Location = "California", Type = "National"},
            new Park {ParkId = 9, Name = "Sequoia National Park", Location = "California", Type = "National"},
            new Park {ParkId = 10, Name = "Milo McIver State Park", Location = "Oregon", Type = "State"}
          );
        }
    }
}