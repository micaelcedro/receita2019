using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace receitas2019.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        public List<Receita> ListaReceita { get; set; }
    }
}
