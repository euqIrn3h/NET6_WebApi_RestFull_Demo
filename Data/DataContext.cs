using ApiRest.Models;

namespace ApiRest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Filme> Filmes {get; set;}
        //public DbSet<Cliente> Clientes {get; set;}
    }
}