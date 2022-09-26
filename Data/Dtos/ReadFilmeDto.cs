using System.ComponentModel.DataAnnotations;

namespace ApiRest.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(20)]
        public string Titulo {get; set;} 

        [Required( ErrorMessage = "Campo obrigatório")]
        public DateTime Data {get; set;}

        public DateTime DataConsulta {get; set;}
    }
}