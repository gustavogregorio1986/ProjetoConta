using ProjetoConta.Data.Data;
using ProjetoConta.Data.Repository.Interface;
using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Data.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ProjetoContaContext _context;

        public TarefaRepository(ProjetoContaContext context)
        {
            _context = context;
        }

        public async Task<Tarefa> AdicionarTarefa(Tarefa tarefa)
        {
            await _context.AddAsync(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Tarefa>> ObterTarefas()
        {
            return await _context.Tarefas.ToListAsync();
        }
    }
}
