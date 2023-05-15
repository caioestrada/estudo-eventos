using C.Estudo.Events.Domain.Interfaces.Cache;
using C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices;
using C.Estudo.Events.Domain.Interfaces.Repositories;
using C.Estudo.Events.Domain.Interfaces.Services;
using C.Estudo.Events.Domain.Services;
using C.Estudo.Events.Infra.Cache;
using C.Estudo.Events.Infra.Data.Repositories;
using C.Estudo.Events.Infra.RabbitMQ.PublishServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.Events.Infra.IoC
{
    public static class DependencyServices
    {
        public static void RegisterDependency(this IServiceCollection services, IConfiguration configuration)
        {
            //Configuration
            services.AddSingleton<IConfiguration>(configuration);

            // Domain
            services.AddScoped<IAutsisService, AutsisService>();
            services.AddScoped<IOrbcoreService, OrbcoreService>();
            services.AddScoped<IResponsavelPublishService, ResponsavelPublishService>();
            services.AddScoped<IOrbcorePublishService, OrbcorePublishService>();
            services.AddScoped<ICacheService, CacheService>();

            // Repository
            services.AddScoped<IAutsisRepository, AutsisRepository>();
            services.AddScoped<IOrbcoreRepository, OrbcoreRepository>();

            // RabbitMQ
            services.AddScoped<IResponsavelPublish, ResponsavelPublish>();
            services.AddScoped<IOrbcorePublish, OrbcorePublish>();

            // Cache
            services.AddScoped<ICacheRepository, CacheRepository>();
        }
    }
}
