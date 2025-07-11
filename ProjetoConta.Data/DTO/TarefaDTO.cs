using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Data.DTO
{
    public class TarefaDTO
    {
        public Guid Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public string? Status { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataConclusao { get; set; }
    }
}
