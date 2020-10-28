using Domain.Model;
using Infrastructure.Persistance.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.EF
{
    public class UncleBobDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public UncleBobDbContext(DbContextOptions<UncleBobDbContext> options)
            : base(options)
        {

        }

        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
