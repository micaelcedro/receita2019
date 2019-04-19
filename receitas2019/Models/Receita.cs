using System.ComponentModel.DataAnnotations;

namespace receitas2019.Models
{
    public class Receita
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(900)]
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
    }
}
