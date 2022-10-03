using System.ComponentModel.DataAnnotations;
using ApiRest.Models;

namespace ApiRest.Data.Dtos
{
    public class ReadDiretorDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string nome {get; set;}
        public virtual List<Filme> Filmes {get; set;}
    }
}