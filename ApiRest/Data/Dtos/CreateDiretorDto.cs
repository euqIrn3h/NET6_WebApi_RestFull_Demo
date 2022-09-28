using System.ComponentModel.DataAnnotations;

namespace ApiRest.Data.Dtos
{
    public class CreateDiretorDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string nome {get; set;} 
    }
}