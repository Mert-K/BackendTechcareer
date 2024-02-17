using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6_efcore1.Context
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database = Sport_DB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Player> Players { get; set; }
    }
}
