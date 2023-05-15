using C.Estudo.Events.Domain.Interfaces.Cache;
using C.Estudo.Events.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Services
{
    public class CacheService : ICacheService
    {
        private readonly ICacheRepository _cache;

        public CacheService(ICacheRepository cache)
        {
            _cache = cache;
        }

        public object GetKey(string key)
        {
            return _cache.GetKey(key);
        }

        public IList<string> GetKeys()
        {
            return _cache.GetKeys();
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Set(string key, object data)
        {
            _cache.Set(key, data, 30);
        }
    }
}
