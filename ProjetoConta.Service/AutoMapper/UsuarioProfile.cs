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
    public class UsuarioProfile : Profile 
    {
        public UsuarioProfile()
        {
            CreateMap<TarefaDTO, Tarefa>();
            CreateMap<Tarefa, TarefaDTO>();
        }
    }
}
