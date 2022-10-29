using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuala.Entidades
{
    public class Alumno
    {
       public string? UniqueId {get; private set;}
        public string? Nombre {get;set;}
        public List<Asignatura> Asignaturas { get; set; } // Includa porque es una propiedad

        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
    
}