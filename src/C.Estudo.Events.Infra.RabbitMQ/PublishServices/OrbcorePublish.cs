using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Events;
using C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using System;

namespace C.Estudo.Events.Infra.RabbitMQ.PublishServices
{
    public class OrbcorePublish : IOrbcorePublish
    {
        private readonly IConfiguration _configuration;

        public OrbcorePublish(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void PublishEvent(Orbcore orbcore)
        {
            using (var bus = RabbitHutch.CreateBus(Environment.GetEnvironmentVariable("RABBITCONNECTION") ?? _configuration.GetSection("RabbitSettings").GetSection("Connection").Value))
            {
                bus.Publish(new AtualizarOrbcoreEvent(orbcore));
            }
        }
    }
}
