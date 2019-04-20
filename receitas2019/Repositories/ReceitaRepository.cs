using Microsoft.EntityFrameworkCore;
using receitas2019.Repositories.Interface;
using Receitas2019.Core.Context;
using Receitas2019.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace receitas2019.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly AppDbContext _context;

        public ReceitaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Receita> Receitas => _context.Receitas;

        public Receita GetReceitaById(int receitaId)
        {
            return _context.Receitas.FirstOrDefault(r => r.Id == receitaId);
        }
    }
}
