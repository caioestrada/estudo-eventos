using C.Estudo.Events.Domain.Entities;

namespace C.Estudo.Events.Domain.Interfaces.Services
{
    public interface IOrbcorePublishService
    {
        void PublishEvent(Orbcore orbcore);
    }
}
