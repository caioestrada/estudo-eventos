using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices;
using C.Estudo.Events.Domain.Interfaces.Services;

namespace C.Estudo.Events.Domain.Services
{
    public class OrbcorePublishService : IOrbcorePublishService
    {
        private readonly IOrbcorePublish _orbcorePublish;

        public OrbcorePublishService(IOrbcorePublish orbcorePublish)
        {
            _orbcorePublish = orbcorePublish;
        }

        public void PublishEvent(Orbcore orbcore)
        {
            _orbcorePublish.PublishEvent(orbcore);
        }
    }
}
