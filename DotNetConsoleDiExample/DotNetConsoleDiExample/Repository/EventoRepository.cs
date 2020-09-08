using DotNetConsoleDiExample.Context;
using DotNetConsoleDiExample.Entities;
using DotNetConsoleDiExample.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetConsoleDiExample.Repository
{
    public class EventoRepository : IEventoRepository
    {
        private readonly DatabaseContext _context;
        public EventoRepository(DatabaseContext ctx )
        {
            _context = ctx;
        }

        public bool Excluir(int id)
        {
            var obj = this.Obter(id);
            if (obj == null)
                return false;

            _context.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public EventoModel Incluir(EventoModel obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }
        public EventoModel Alterar(EventoModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventoModel> Listar()
        {
            return _context.Eventos.ToList();
        }

        public EventoModel Obter(int id)
        {
            return _context.Eventos.Where(a => a.EventoId == id).FirstOrDefault();
        }
    }
}
