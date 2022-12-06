
using CoreEscuela.Util;

namespace CoreEscuela.Entidades
{
    public sealed class EscuelaEngine // Una clase sellada no permite que otros hereden de ella. Pero psi permite crear instancias
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

        public void ImprimirDiccionario(Dictionary<LlaveDiccionario,IEnumerable<ObjetoEscuelaBase>> dic) 
        {
            foreach (var obj in dic)
            {
                Printer.WriteTitle(obj.Key.ToString());

                foreach (var val in obj.Value)
                {
                    Console.WriteLine(val);                    
                }
            }

        }

        public Dictionary<LlaveDiccionario,IEnumerable<ObjetoEscuelaBase>> GetDiccionarioObjetos() 
        {
            
            var diccionario= new Dictionary<LlaveDiccionario,IEnumerable<ObjetoEscuelaBase>>();

            diccionario.Add(LlaveDiccionario.Escuela, new[] {Escuela});
            diccionario.Add(LlaveDiccionario.Cursos, Escuela.Cursos.Cast<ObjetoEscuelaBase>());
            var listatmp = new List<Evaluacion>();
            var listatmpas = new List<Asignatura>();
            var listatmpal = new List<Alumno>();
            foreach (var cur in Escuela.Cursos)
            {
                listatmpas.AddRange(cur.Asignaturas);
                listatmpal.AddRange(cur.Alumnos);

                foreach (var alum in cur.Alumnos)
                {
                    listatmp.AddRange(alum.Evaluaciones);
                }
            }
            diccionario[LlaveDiccionario.Cursos] = Escuela.Cursos.Cast<ObjetoEscuelaBase>();
            diccionario.Add(LlaveDiccionario.Asignaturas, listatmpas.Cast<ObjetoEscuelaBase>());
            diccionario.Add(LlaveDiccionario.Alumno, listatmpal.Cast<ObjetoEscuelaBase>());
            diccionario.Add(LlaveDiccionario.Evaluacion, listatmp.Cast<ObjetoEscuelaBase>());

            return diccionario;
        }

        /*public List<ObjetoEscuelaBase> GetObjetoEscuela(
            out int conteoEvaluaciones,
            out int conteoAlumnos,
            out int conteoCursos,
            out int conteoAsignaturas,
            bool traeEvaluaciones = true,
            bool traeAlumno = true,
            bool traeCursos = true,
            bool traeAsignaturas = true
            )
        {
            conteoEvaluaciones=0;
            conteoAsignaturas=0;
            conteoAlumnos=0;
            var listaObj = new List<ObjetoEscuelaBase> ();
            listaObj.Add(Escuela);
            listaObj.AddRange(Escuela.Cursos);
            conteoCursos=Escuela.Cursos.Count;
                foreach (var curso in Escuela.Cursos)
                {
                    conteoAsignaturas += curso.Asignaturas.Count;
                    listaObj.AddRange(curso.Asignaturas);
                    conteoAlumnos+= curso.Alumnos.Count;
                    listaObj.AddRange(curso.Alumnos);

                    if (traeEvaluaciones)
                    {
                        foreach (var alumno in curso.Alumnos)
                        {
                            listaObj.AddRange(alumno.Evaluaciones);
                            conteoEvaluaciones += alumno.Evaluaciones.Count;
                        }
                    }
                }
            return listaObj;

        }*/
        private void CargarAsignatura()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<CoreEscuela.Entidades.Asignatura> ListaAsignaturas = new List<CoreEscuela.Entidades.Asignatura>()
                {
                    new CoreEscuela.Entidades.Asignatura {Nombre="Matematicas"},
                    new CoreEscuela.Entidades.Asignatura {Nombre="Ciencias"},
                    new CoreEscuela.Entidades.Asignatura {Nombre="Castellano"},
                    new CoreEscuela.Entidades.Asignatura {Nombre="Sociales"}
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
                                select new CoreEscuela.Entidades.Alumno { Nombre= $" {n1} {n2} {a1}"};
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