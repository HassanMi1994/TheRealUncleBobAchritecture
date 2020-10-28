using Application.Abstractions.Repositories;
using Domain.Model;

namespace Infrastructure.Implementation.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(projectdbcontex)
        {

        }

        public long Add(Product product)
        {
            return 0;
        }

        public bool DoesExisit(string name)
        {
            //for fun, we are going to lie that it does not exist.
            return false;
        }
    }
}
