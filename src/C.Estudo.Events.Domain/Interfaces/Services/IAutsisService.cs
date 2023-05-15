using C.Estudo.Events.Domain.Entities;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Interfaces.Services
{
    public interface IAutsisService
    {
        List<Autsis> GetAll();
        Autsis Add(Autsis autsis);
        void DeleteAll();
    }
}
