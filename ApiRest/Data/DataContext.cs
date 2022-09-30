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

            builder.Entity<Sessao>()
                .HasOne( sessao => sessao.Cinema)
                .WithMany( cinema => cinema.Sessoes)
                .HasForeignKey( sessao => sessao.IdCinema)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<Sessao>()
                .HasOne( sessao => sessao.Filme)
                .WithMany( filme => filme.Sessoes)
                .HasForeignKey( sessao => sessao.IdFilme)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Filme> Filmes {get; set;}
        public DbSet<Diretor> Diretores {get; set;}
        public DbSet<Sessao> Sessoes {get; set;}
        public DbSet<Cinema> Cinemas {get; set;}

    }
}