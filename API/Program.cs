using API.Extensions;
using Aplicacao.Extensions;
using Dominio.Extensions;
using Infraestrutura.Extensions;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureServicosAPI(builder.Configuration);
            builder.Services.ConfigureServicosAplicacao(builder.Configuration);
            builder.Services.ConfigureServicosInfra(builder.Configuration);
            builder.Services.ConfigureServicosDominio(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
