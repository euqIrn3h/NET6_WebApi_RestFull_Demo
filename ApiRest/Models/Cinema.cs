using System.ComponentModel.DataAnnotations;
namespace ApiRest.Models
{
    public class Cinema
    {
        [Key]
        public int Id {get;set;}

        [Required( ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string Nome {get; set;}

        public virtual List<Sessao> Sessoes {get; set;}
    }
}