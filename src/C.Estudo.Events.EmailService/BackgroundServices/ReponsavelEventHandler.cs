using C.Estudo.Events.Domain.Events;
using C.Estudo.Events.Domain.Interfaces.Services;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace C.Estudo.Events.EmailService.BackgroundServices
{
    public class ReponsavelEventHandler : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IConfiguration _configuration;
        private IBus _bus;

        public ReponsavelEventHandler(IConfiguration configuration, IServiceScopeFactory scopeFactory)
        {
            _configuration = configuration;
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _bus = RabbitHutch.CreateBus(Environment.GetEnvironmentVariable("RABBITCONNECTION") ?? _configuration.GetSection("RabbitSettings").GetSection("Connection").Value);
            _bus.Subscribe<OrbcoreResponsavelEvent>("EmailGateway", EnviarEmail);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
            }

            _bus.Dispose();
        }

        private void EnviarEmail(OrbcoreResponsavelEvent orbcoreEvent)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var cacheService = scope.ServiceProvider.GetRequiredService<ICacheService>();
                cacheService.Set(orbcoreEvent.Id.ToString(), orbcoreEvent.Responsavel);
            }
        }
    }
}
