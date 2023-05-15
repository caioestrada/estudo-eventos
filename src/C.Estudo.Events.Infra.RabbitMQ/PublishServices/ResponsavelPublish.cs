using C.Estudo.Events.Domain.Events;
using C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using System;

namespace C.Estudo.Events.Infra.RabbitMQ.PublishServices
{
    public class ResponsavelPublish : IResponsavelPublish
    {
        private readonly IConfiguration _configuration;

        public ResponsavelPublish(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void PublishEvent(string responsavel)
        {
            using (var bus = RabbitHutch.CreateBus(Environment.GetEnvironmentVariable("RABBITCONNECTION") ?? _configuration.GetSection("RabbitSettings").GetSection("Connection").Value))
            {
                bus.Publish(new OrbcoreResponsavelEvent(Guid.NewGuid(), responsavel));
            }
        }
    }
}
