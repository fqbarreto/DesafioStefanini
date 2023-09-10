using Desafio.Infra.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Infra.Database
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //public DataContext(DbContextOptions options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<ItensPedido>? ItensPedido { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
    }
}
