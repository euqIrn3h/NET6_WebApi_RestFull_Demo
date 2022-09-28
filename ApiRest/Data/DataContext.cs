using ApiRest.Models;

namespace ApiRest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder){
        }

        public DbSet<Filme> Filmes {get; set;}
        public DbSet<Diretor> Diretores {get; set;}
    }
}