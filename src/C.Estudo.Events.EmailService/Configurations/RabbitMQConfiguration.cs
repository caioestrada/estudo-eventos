using C.Estudo.Events.EmailService.BackgroundServices;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.Events.EmailService.Configurations
{
    public static class RabbitMQConfiguration
    {
        public static void AddRabbitMQConfig(this IServiceCollection services)
        {
            services.AddHostedService<ReponsavelEventHandler>();
        }
    }
}
