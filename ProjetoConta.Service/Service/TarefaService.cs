using ProjetoConta.Data.Repository.Interface;
using ProjetoConta.Dominio.Dominio;
using ProjetoConta.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Service.Service
{
    public class TarefaService : ITarefaservice
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<Tarefa> AdicionarTarefa(Tarefa tarefa)
        {
            return await _tarefaRepository.AdicionarTarefa(tarefa);
        }

        public async Task<List<Tarefa>> ObterTarefas()
        {
            return await _tarefaRepository.ObterTarefas();
        }
    }
}
