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

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdDiretor {get; set;}
       
        public virtual Diretor Diretor {get; set;}

        public virtual List<Sessao> Sessoes {get; set;}
  
    }
}