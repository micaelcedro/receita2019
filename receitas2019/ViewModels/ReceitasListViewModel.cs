using Receitas2019.Core.Models;
using System.Collections.Generic;

namespace Receitas2019.Web.ViewModels
{
    public class ReceitasListViewModel
    {
        public IEnumerable<Receita> Receitas { get; set; }

        public string CategoriaAtual { get; set; }
    }
}
