using Dominio.Entidades;
using Dominio.Servicos;
using Dominio.Validators;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dominio.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection ConfigureServicosDominio(this IServiceCollection services, IConfiguration configuration)
        {
            #region servicos
            services.AddScoped<IPedidosServico, PedidosServico>();
            #endregion

            #region validators
            services.AddScoped<IValidator<Cliente>, ClienteValidator>();
            services.AddScoped<IValidator<Pedido>, PedidoValidator>();
            #endregion

            return services;
        }
    }
}
