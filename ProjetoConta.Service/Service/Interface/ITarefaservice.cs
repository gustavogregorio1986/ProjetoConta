using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Service.Service.Interface
{
    public interface ITarefaservice
    {
        Task<Tarefa> AdicionarTarefa(Tarefa tarefa);

        Task<List<Tarefa>> ObterTarefas();
    }
}
