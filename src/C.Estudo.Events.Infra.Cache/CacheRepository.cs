using C.Estudo.Events.Domain.Interfaces.Cache;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace C.Estudo.Events.Infra.Cache
{
    public class CacheRepository : ICacheRepository
    {
        private readonly IMemoryCache _cache;
        protected static readonly ConcurrentDictionary<string, bool> _allKeys = new ConcurrentDictionary<string, bool>();

        public CacheRepository(IMemoryCache cache)
        {
            _cache = cache;
        }

        public object GetKey(string key) => _cache.Get(key);

        public IList<string> GetKeys() => _allKeys.Keys.ToList();

        public virtual void Remove(string key)
        {
            if (!_allKeys.TryRemove(key, out _))
                _allKeys.TryUpdate(key, false, true);

            _cache.Remove(key);
        }

        public virtual void Set(string key, object data, int cacheTimeInMinutes)
        {
            if (data != null)
            {
                _allKeys.TryAdd(key, true);
                _cache.Set(key, data, new MemoryCacheEntryOptions() { SlidingExpiration = TimeSpan.FromMinutes(cacheTimeInMinutes) });
            }
        }
    }
}
