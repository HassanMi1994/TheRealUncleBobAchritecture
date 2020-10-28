using Application.Abstractions.Repositories;
using Infrastructure.Implementation.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    internal static class Repositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
