using CoreEscuala.Entidades;
using CoreEscuela.Entidades;


namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");
            CargarCursos();
            CargarAsignatura();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
               
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        Random rnd= new Random(System.Environment.TickCount);

                            for (var i=0; i<5; i++) // Genera cinco evaluciones con el metodo constructor de la clase evaluacion
                            {
                                var parcial = new Evaluacion()
                                {
                                    Asignatura= asignatura,
                                    Nombre=$"Asignatura: {asignatura.Nombre} Parcial: {i+1}",
                                    Nota=(float)(5*rnd.NextDouble()),
                                    Alumno = alumno
                                };
                                alumno.Evaluaciones.Add(parcial); // Adiciona a Alumno, las evaluaciones.
                            }          
                        
                    }
                    
                }
                
            }
        }

        private void CargarAsignatura()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<CoreEscuala.Entidades.Asignatura> ListaAsignaturas = new List<CoreEscuala.Entidades.Asignatura>()
                {
                    new CoreEscuala.Entidades.Asignatura {Nombre="Matematicas"},
                    new CoreEscuala.Entidades.Asignatura {Nombre="Ciencias"},
                    new CoreEscuala.Entidades.Asignatura {Nombre="Castellano"},
                    new CoreEscuala.Entidades.Asignatura {Nombre="Sociales"}
                };
                curso.Asignaturas = ListaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var ListaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new CoreEscuala.Entidades.Alumno { Nombre= $" {n1} {n2} {a1}"};
            return ListaAlumnos.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>() // Inclusión de la lista como constructor.
                {
                    new Curso() {Nombre="101", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="201", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="301", Jornada=TiposJornada.Mañana},
                    new Curso() {Nombre="401", Jornada=TiposJornada.Tarde},
                    new Curso() {Nombre="501", Jornada=TiposJornada.Tarde}
                };

            Random rnd= new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,30);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
        
}