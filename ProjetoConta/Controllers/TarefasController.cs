using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoConta.Dominio.Dominio;
using ProjetoConta.Service.Service.Interface;

namespace ProjetoConta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaservice _tarefaService;
        private readonly IMapper _mapper;

        public TarefasController(ITarefaservice tarefaService, IMapper mapper)
        {
            _tarefaService = tarefaService;
            _mapper = mapper;
        }
        [HttpPost("AdicionarTarefa")]
        public async Task<IActionResult> AdicionarTarefa([FromBody] Tarefa tarefa)
        {
            if (tarefa == null)
            {
                return BadRequest("Tarefa não pode ser nula.");
            }
            var resultado = await _tarefaService.AdicionarTarefa(tarefa);
            return CreatedAtAction(nameof(ObterTarefas), new { id = resultado.Id }, resultado);
        }
        [HttpGet("ObterTarefas")]
        public async Task<IActionResult> ObterTarefas()
        {
            var tarefas = await _tarefaService.ObterTarefas();
            return Ok(tarefas);
        }
        [HttpGet("ObterTarefasConcluidasNosUltimosDias/{dias}")]
        public async Task<IActionResult> ObterTarefasConcluidasNosUltimosDias(int dias)
        {
            var tarefas = await _tarefaService.ObterTarefasConcluidasNosUltimosDias(dias);
            return Ok(tarefas);
        }
    }
}
