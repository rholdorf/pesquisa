using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Pesquisa.Data
{
    public class NpsDbContext : DbContext
    {
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Pesquisa> Pesquisas { get; set; }
        public DbSet<Razao> Razoes { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
    }
}
