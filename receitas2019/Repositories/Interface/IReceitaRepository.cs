using Receitas2019.Core.Models;
using System.Collections.Generic;

namespace receitas2019.Repositories.Interface
{
    public interface IReceitaRepository
    {
        IEnumerable<Receita> Receitas { get; }
        Receita GetReceitaById(int receitaId);
    }
}
