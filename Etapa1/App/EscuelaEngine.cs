using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
            {
            //De aqui se sacó un texto para el inicializador.
            }
        public void Inicializar()
            {
                Escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");

                Escuela.Cursos = new List<Curso>() // Inclusión de la lista como constructor.
                {
                    new Curso() {Nombre="101", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="201", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="301", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="401", Jornada=TiposJornada.Tarde},
                    new Curso() {Nombre="501", Jornada=TiposJornada.Tarde}
                };
             }
    }
        
}