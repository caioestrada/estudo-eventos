using C.Estudo.Events.AutsisService.BackgroundServices;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.Events.AutsisService.Configurations
{
    public static class RabbitMQConfiguration
    {
        public static void AddRabbitMQConfig(this IServiceCollection services)
        {
            services.AddHostedService<OrbcoreEventHandler>();
        }
    }
}
