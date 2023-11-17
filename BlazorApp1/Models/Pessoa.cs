using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Pessoa
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(100)]
        public string Sobrenome { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descricao { get; set; }
    }
}
