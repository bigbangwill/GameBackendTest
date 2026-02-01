using Microsoft.EntityFrameworkCore;

namespace FruitCopyBackTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PlayerSave> PlayerSaves => Set<PlayerSave>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerSave>().Property(x => x.UpdatedAtUtc).HasDefaultValueSql("now() at time zone 'utc'");
        }
    }
}