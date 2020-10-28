using Application.Abstractions.Repositories;
using Application.Abstractions.Services;
using Domain.Model;

namespace Application.Services
{
    /// <summary>
    /// This is an internal service, so this should be inside application layer. and it is fine.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public long AddProduct(Product product)
        {
            bool notExisit = _productRepository.DoesExisit(product.Name);
            if (notExisit)
            {
                return _productRepository.Add(product);
            }
            return 0;
        }
    }
}
