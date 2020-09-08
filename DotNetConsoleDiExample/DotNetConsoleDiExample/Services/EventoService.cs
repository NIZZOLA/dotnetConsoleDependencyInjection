using DotNetConsoleDiExample.Entities;
using DotNetConsoleDiExample.Interfaces;
using DotNetConsoleDiExample.Interfaces.Repository;
using DotNetConsoleDiExample.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetConsoleDiExample.Services
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepo;
        public EventoService(IEventoRepository eventoRepo)
        {
            _eventoRepo = eventoRepo;
        }

        public void ProcessarFila()
        {
            Console.WriteLine("Obtendo a lista:");
            var lista = _eventoRepo.Listar();
            Console.WriteLine("Objetos obtidos:" + lista.Count());
            foreach (var item in lista)
            {
                Console.WriteLine("Novo evento:" + item.Data.ToString("dd/MM/yyyy") + " Hora:" + item.Data.ToString("hh:mm"));
            }
            Console.WriteLine("Pressione uma tecla para finalizar!");
            Console.ReadKey();
        }

        public void GerarDadosTeste()
        {
            var evento = new EventoModel()
            {
                Data = DateTime.Now,
                Descricao = "Evento teste01",
                DataInclusao = DateTime.Now,
                Avisar = true
            };
            _eventoRepo.Incluir(evento);
        }
    }
}
