using System;

namespace C.Estudo.Events.Domain.Events
{
    public class OrbcoreResponsavelEvent
    {
        public Guid Id { get; set; }
        public string Responsavel { get; set; }

        public OrbcoreResponsavelEvent(Guid id, string responsavel)
        {
            Id = id;
            Responsavel = responsavel;
        }
    }
}
