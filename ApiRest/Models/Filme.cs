using System.ComponentModel.DataAnnotations;
namespace ApiRest.Models
{
    public class Filme
    {
        [Key]
        public int Id {get;set;}

        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(20)]
        public string Titulo {get; set;} 

        [Required( ErrorMessage = "Campo obrigatório")]
        public DateTime Data {get; set;}

        [Required(ErrorMessage = "Campo obrigatório")]
        public Diretor diretor {get; set;}

        public int IdDiretor {get; set;}
    }
}