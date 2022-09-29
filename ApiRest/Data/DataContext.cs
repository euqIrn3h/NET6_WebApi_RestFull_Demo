using ApiRest.Models;

namespace ApiRest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Filme>()
                .HasOne( filme => filme.Diretor)
                .WithMany( diretor => diretor.Filmes)
                .HasForeignKey( filme => filme.IdDiretor)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Filme> Filmes {get; set;}
        public DbSet<Diretor> Diretores {get; set;}
    }
}