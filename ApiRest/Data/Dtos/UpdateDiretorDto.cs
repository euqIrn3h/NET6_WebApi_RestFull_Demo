using System.ComponentModel.DataAnnotations;

namespace ApiRest.Data.Dtos
{
    public class UpdateDiretorDto
    {
        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string Nome {get; set;} 
    }
}