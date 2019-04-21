using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Receitas2019.Core.Models
{
    public class Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string ModoDePreparo { get; set; }
        [Required]
        public string Ingredientes { get; set; }
        [Required]
        public string TempoDePreparo { get; set; }
        public string Imagem { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        [Required]
        public string Tag { get; set; }
    }
}
