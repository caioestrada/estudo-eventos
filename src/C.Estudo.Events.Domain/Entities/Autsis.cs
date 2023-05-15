using System;
using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Entities
{
    public class Autsis : Entity
    {
        public string Sistema { get; private set; }
        public List<string> Funcionalidades { get; private set; }

        public Autsis(string sistema)
        {
            Id = Guid.NewGuid();
            Sistema = sistema;
            Funcionalidades = new List<string>();
        }

        public void InserirFuncionalidades(List<string> funcionalidades)
        {
            Funcionalidades.AddRange(funcionalidades);
        }
    }
}
