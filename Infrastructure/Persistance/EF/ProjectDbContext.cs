using Domain.Model;
using Infrastructure.Persistance.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.EF
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
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
