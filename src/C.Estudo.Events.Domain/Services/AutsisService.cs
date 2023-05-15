using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Repositories;
using C.Estudo.Events.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Services
{
    public class AutsisService : IAutsisService
    {
        private readonly IAutsisRepository _autsisRepository;

        public AutsisService(IAutsisRepository autsisRepository)
        {
            _autsisRepository = autsisRepository;
        }

        public Autsis Add(Autsis autsis)
        {
            return _autsisRepository.Add(autsis);
        }

        public void DeleteAll()
        {
            _autsisRepository.DeleteAll();
        }

        public List<Autsis> GetAll()
        {
            return _autsisRepository.GetAll();
        }
    }
}
