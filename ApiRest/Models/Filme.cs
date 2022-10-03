using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
  
    }
}