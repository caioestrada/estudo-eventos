using C.Estudo.Events.Domain.Entities;

namespace C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices
{
    public interface IOrbcorePublish
    {
        void PublishEvent(Orbcore orbcore);
    }
}
