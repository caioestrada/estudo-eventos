using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Interfaces.Cache
{
    public interface ICacheRepository
    {
        object GetKey(string key);
        IList<string> GetKeys();
        void Remove(string key);
        void Set(string key, object data, int cacheTimeInMinutes);
    }
}
