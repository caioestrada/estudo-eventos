using System.Collections.Generic;

namespace C.Estudo.Events.Domain.Entities
{
    public class Orbcore : Entity
    {
        public string Objeto { get; private set; }
        public string Responsavel { get; private set; }
        public List<string> Metodos { get; private set; }

        public Orbcore(string objeto, string responsavel)
        {
            Objeto = objeto;
            Responsavel = responsavel;
            Metodos = new List<string>();
        }

        public void InserirMetodos(List<string> metodos)
        {
            Metodos.AddRange(metodos);
        }
    }
}
