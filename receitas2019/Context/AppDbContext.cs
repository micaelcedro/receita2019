using Microsoft.EntityFrameworkCore;
using receitas2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace receitas2019.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
