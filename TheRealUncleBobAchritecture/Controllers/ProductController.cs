using Application.Abstractions.Services;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace TheRealUncleBobAchritecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public long Post(Product product)
        {
            return _productService.AddProduct(product);
        }
    }
}
