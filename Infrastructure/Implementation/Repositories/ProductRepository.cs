using Application.Abstractions.Repositories;
using Domain.Model;
using Infrastructure.Persistance.EF;

namespace Infrastructure.Implementation.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly UncleBobDbContext _uncleBobDbContext;

        public ProductRepository(UncleBobDbContext uncleBobDbContext)
        {
            _uncleBobDbContext = uncleBobDbContext;
        }

        public long Add(Product product)
        {
            _uncleBobDbContext.Products.Add(product);
            return _uncleBobDbContext.SaveChanges();
        }

        public bool DoesExisit(string name)
        {
            //for fun, we are going to lie that it does not exist.
            return false;
        }
    }
}
