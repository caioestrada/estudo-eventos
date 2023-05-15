using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Repositories;
using C.Estudo.Events.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Services
{
    public class OrbcoreService : IOrbcoreService
    {
        private readonly IOrbcoreRepository _orbcoreRepository;

        public OrbcoreService(IOrbcoreRepository orbcoreRepository)
        {
            _orbcoreRepository = orbcoreRepository;
        }

        public Orbcore Add(Orbcore orbcore)
        {
            return _orbcoreRepository.Add(orbcore);
        }

        public void DeleteAll()
        {
            _orbcoreRepository.DeleteAll();
        }

        public List<Orbcore> GetAll()
        {
            return _orbcoreRepository.GetAll();
        }
    }
}
