using System.ComponentModel.DataAnnotations;
namespace ApiRest.Models
{
    public class Sessao
    {
        [Key]
        public int Id {get;set;}

        [Required]
        public int IdCinema {get; set;}

        [Required]
        public int IdFilme {get; set;}

        public virtual List<Filme> Filmes {get; set;}

        public virtual List<Cinema> Cinemas {get; set;}
    }
}