using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Receitas2019.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas2019.Core.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
