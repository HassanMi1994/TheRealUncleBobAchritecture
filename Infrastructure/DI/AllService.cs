namespace Microsoft.Extensions.DependencyInjection
{
    public static class AllService
    {
        public static IServiceCollection AddAllInfrastructureServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddServices();
            return services;
        }
    }
}
