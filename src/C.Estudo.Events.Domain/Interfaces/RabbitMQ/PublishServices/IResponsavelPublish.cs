using System;
using System.Collections.Generic;
using System.Text;

namespace C.Estudo.Events.Domain.Interfaces.RabbitMQ.PublishServices
{
    public interface IResponsavelPublish
    {
        void PublishEvent(string responsavel);
    }
}
