using DotNetConsoleDiExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetConsoleDiExample.Interfaces.Repository
{
    public interface IEventoRepository 
    {
        public EventoModel Incluir(EventoModel obj);
        public EventoModel Alterar(EventoModel obj);
        public bool Excluir(int id);
        public IEnumerable<EventoModel> Listar();
        public EventoModel Obter(int id);
    }
}
