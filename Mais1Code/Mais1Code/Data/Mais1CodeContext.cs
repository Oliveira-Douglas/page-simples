#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mais1Code.Views;

namespace Mais1Code.Data
{
    public class Mais1CodeContext : DbContext
    {
        public Mais1CodeContext (DbContextOptions<Mais1CodeContext> options)
            : base(options)
        {
        }

        public DbSet<Mais1Code.Views.Cadastro> Cadastro { get; set; }
    }
}
