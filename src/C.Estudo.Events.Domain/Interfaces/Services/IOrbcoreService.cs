using C.Estudo.Events.Domain.Entities;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Interfaces.Services
{
    public interface IOrbcoreService
    {
        List<Orbcore> GetAll();
        Orbcore Add(Orbcore orbcore);
        void DeleteAll();
    }
}
