using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Abstractions.Services
{
    public interface IProductService
    {
        long AddProduct(Product product);
    }
}
