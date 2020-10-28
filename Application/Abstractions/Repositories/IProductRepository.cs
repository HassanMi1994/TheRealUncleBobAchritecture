using Domain.Model;

namespace Application.Abstractions.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Check if the product exist or not, if false returns false.
        /// The checking process can be from database or caching system or whatever, this is not application business how this is implemented.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool DoesExist(string name);

        /// <summary>
        /// Add a product and return an ID for it.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        long Add(Product product);
    }
}
