using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Data.Repository.Interface
{
    public interface ITarefaRepository
    {
        Task<Tarefa> AdicionarTarefa(Tarefa tarefa);

        Task<List<Tarefa>> ObterTarefas();

        Task<List<Tarefa>> ObterTarefasConcluidasNosUltimosDias(int dias);
    }
}
