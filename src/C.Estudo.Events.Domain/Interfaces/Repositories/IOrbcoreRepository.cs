using C.Estudo.Events.Domain.Entities;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Interfaces.Repositories
{
    public interface IOrbcoreRepository
    {
        List<Orbcore> GetAll();
        Orbcore Add(Orbcore orbcore);
        void DeleteAll();
    }
}
