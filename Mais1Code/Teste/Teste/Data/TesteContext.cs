#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste.Views;

namespace Teste.Data
{
    public class TesteContext : DbContext
    {
        public TesteContext (DbContextOptions<TesteContext> options)
            : base(options)
        {
        }

        public DbSet<Teste.Views.Cadastro> Cadastro { get; set; }
    }
}
