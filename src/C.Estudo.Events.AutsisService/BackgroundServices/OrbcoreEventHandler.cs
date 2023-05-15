using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Events;
using C.Estudo.Events.Domain.Interfaces.Services;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace C.Estudo.Events.AutsisService.BackgroundServices
{
    public class OrbcoreEventHandler : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IConfiguration _configuration;
        private IBus _bus;

        public OrbcoreEventHandler(IConfiguration configuration, IServiceScopeFactory scopeFactory)
        {
            _configuration = configuration;
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _bus = RabbitHutch.CreateBus(Environment.GetEnvironmentVariable("RABBITCONNECTION") ?? _configuration.GetSection("RabbitSettings").GetSection("Connection").Value);
            _bus.Subscribe<AtualizarOrbcoreEvent>("AutsisGateway", AtualizarSistema);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
            }

            _bus.Dispose();
        }

        private void AtualizarSistema(AtualizarOrbcoreEvent orbcoreEvent)
        {
            var autsis = new Autsis(orbcoreEvent.Orbcore.Objeto);
            autsis.InserirFuncionalidades(orbcoreEvent.Orbcore.Metodos);

            using (var scope = _scopeFactory.CreateScope())
            {
                var autsisService = scope.ServiceProvider.GetRequiredService<IAutsisService>();
                autsisService.Add(autsis);
            }
        }
    }
}
