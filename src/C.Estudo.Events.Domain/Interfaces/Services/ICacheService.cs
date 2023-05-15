using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Interfaces.Services
{
    public interface ICacheService
    {
        object GetKey(string key);
        IList<string> GetKeys();
        void Remove(string key);
        void Set(string key, object data);
    }
}
