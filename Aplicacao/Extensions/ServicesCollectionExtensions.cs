using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aplicacao.Extensions
{
    public static class ServicesCollectionExtensions
    {
        private static readonly string[] assemblyNamesToScan = ["Aplicacao"];
        public static IServiceCollection ConfigureServicosAplicacao(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddAutoMapper(cfg => cfg.AddMaps(assemblyNamesToScan));
            return services;
        }
    }
}
