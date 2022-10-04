using System.ComponentModel.DataAnnotations;
using ApiRest.Models;

namespace ApiRest.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(20)]
        public string Titulo {get; set;} 

        [Required( ErrorMessage = "Campo obrigatório")]
        public DateTime Data {get; set;}
        public int ClassificacaoIndicativa {get; set;}
        public virtual Diretor Diretor {get; set;}
    }
}