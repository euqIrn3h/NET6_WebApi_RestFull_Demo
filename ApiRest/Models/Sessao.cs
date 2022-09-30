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

        public virtual Filme Filme {get; set;}

        public virtual Cinema Cinema {get; set;}
    }
}