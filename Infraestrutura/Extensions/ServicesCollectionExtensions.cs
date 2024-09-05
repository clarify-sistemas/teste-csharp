using Dominio.Repositorio;
using Infraestrutura.EfDbContext;
using Infraestrutura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestrutura.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection ConfigureServicosInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext, PostgresDbContext>(o => o.UseNpgsql(configuration.GetConnectionString("sql")));
            services
                .AddScoped<IClienteRepositorio, ClienteRepositorio>()
                .AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            return services;
        }
    }
}
