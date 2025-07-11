using AutoMapper;
using ProjetoConta.Data.DTO;
using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Service.AutoMapper
{
    public class TarefaProfile : Profile 
    {
        public TarefaProfile()
        {
            CreateMap<TarefaDTO, Tarefa>();
            CreateMap<Tarefa, TarefaDTO>();
        }
    }
}
