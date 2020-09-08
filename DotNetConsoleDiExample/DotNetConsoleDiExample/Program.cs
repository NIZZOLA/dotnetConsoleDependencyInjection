using DotNetConsoleDiExample.Context;
using DotNetConsoleDiExample.Interfaces.Repository;
using DotNetConsoleDiExample.Interfaces.Services;
using DotNetConsoleDiExample.Repository;
using DotNetConsoleDiExample.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetConsoleDiExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var eventService = serviceProvider.GetService<IEventoService>();
            
            Console.WriteLine("Iniciando a aplicação");
            eventService.GerarDadosTeste();
            eventService.ProcessarFila();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEventoService,EventoService>()
                .AddScoped<IEventoRepository, EventoRepository>()
                .AddDbContext<DatabaseContext>( opt => opt.UseInMemoryDatabase("test"));
        }
    }
}
