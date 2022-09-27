using System.ComponentModel.DataAnnotations;
namespace ApiRest.Models
{
    public class Diretor
    {
        [Key]
        public int Id {get;set;}

        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string nome {get; set;} 
    }
}