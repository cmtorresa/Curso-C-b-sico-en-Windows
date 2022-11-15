using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase // Una clase abstracta no permite generar instancias de esta. Pero si heredar
    {
        public string? UniqueId {get; private set;}
        public string? Nombre {get;set;}

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {UniqueId}".ToString();
        }
    }
}