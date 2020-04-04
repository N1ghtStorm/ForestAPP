using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ForestDbContext : DbContext
    {
        public ForestDbContext(DbContextOptions options) : base (options) { }

        public DbSet<Forest> Forests { get; set; }

        public DbSet<Tree> Trees { get; set; }

        public DbSet<ForestType> ForestTypes { get; set; }

        public DbSet<TreeType> TreeTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForestType>().HasData(new ForestType { Id = 1, Name = "Oak"});
        }
    }
}
