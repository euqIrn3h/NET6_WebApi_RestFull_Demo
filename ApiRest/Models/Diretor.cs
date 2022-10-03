using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiRest.Models
{
    public class Diretor
    {
        [Key]
        public int Id {get;set;}

        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string Nome {get; set;} 
        [JsonIgnore]
        public virtual List<Filme> Filmes {get; set;}
    }
}