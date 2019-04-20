using Microsoft.EntityFrameworkCore;
using Receitas2019.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas2019.Core.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<IngredientesDaReceita> IngredientesDaReceitas { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
