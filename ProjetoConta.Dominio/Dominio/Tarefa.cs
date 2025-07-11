using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Dominio.Dominio
{
    public class Tarefa
    {
        public Guid Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public string? Status { get; set; }

        public DateTime? DataCriacao { get; set; }

        public DateTime? DataConclusao { get; set; }
    }
}
