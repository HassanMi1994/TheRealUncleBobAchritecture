using Application.Abstractions.Services;
using Application.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    internal static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
