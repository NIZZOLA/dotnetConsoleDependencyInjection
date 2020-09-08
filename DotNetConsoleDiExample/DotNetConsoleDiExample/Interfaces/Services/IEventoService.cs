using DotNetConsoleDiExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetConsoleDiExample.Interfaces.Services
{
    public interface IEventoService
    {
        void ProcessarFila();
        void GerarDadosTeste();
    }
}
