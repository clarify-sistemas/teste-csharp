using Infraestrutura.EfDbContext.TypeConfiguration;
using Infraestrutura.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.EfDbContext
{
    internal class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoTypeConfiguration());
            modelBuilder.ToSnakeCaseAllColumns();
        }
    }
}
