using Microsoft.EntityFrameworkCore;
using ProjetoConta.Data.Mapping;
using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Data.Data
{
    public class ProjetoContaContext : DbContext
    {
        public ProjetoContaContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
