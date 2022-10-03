

using System.ComponentModel.DataAnnotations;

namespace ApiRest.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(20)]
        public string Titulo {get; set;} 
        [Required( ErrorMessage = "Campo obrigatório")]
        public DateTime Data {get; set;}
        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdDiretor {get; set;}
    }
}