using C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices;
using C.Estudo.Events.Domain.Interfaces.Services;

namespace C.Estudo.Events.Domain.Services
{
    public class ResponsavelPublishService : IResponsavelPublishService
    {
        private readonly IResponsavelPublish _responsavelPublish;

        public ResponsavelPublishService(IResponsavelPublish responsavelPublish)
        {
            _responsavelPublish = responsavelPublish;
        }

        public void PublishEvent(string responsavel)
        {
            _responsavelPublish.PublishEvent(responsavel);
        }
    }
}
