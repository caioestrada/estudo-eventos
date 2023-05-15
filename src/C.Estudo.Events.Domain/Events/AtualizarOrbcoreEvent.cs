using C.Estudo.Events.Domain.Entities;
using System;

namespace C.Estudo.Events.Domain.Events
{
    public class AtualizarOrbcoreEvent
    {
        public Guid Id { get; set; }
        public Orbcore Orbcore { get; set; }

        public AtualizarOrbcoreEvent(Orbcore orbcore)
        {
            Id = orbcore.Id ;
            Orbcore = orbcore;
        }
    }
}
