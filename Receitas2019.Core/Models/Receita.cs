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
        public string Nome { get; set; }
        public IEnumerable<IngredientesDaReceita> Ingredientes { get; set; }
        public string ModoDePreparo { get; set; }
        public float TempoDePreparo { get; set; }
        public string Imagem { get; set; }
    }
}
