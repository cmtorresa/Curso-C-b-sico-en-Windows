// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");

        escuela.Cursos = new List<Curso>() // Inclusión de la lista como constructor.
        {
            new Curso() {Nombre="101", Jornada=TiposJornada.Mañana},
            new Curso() {Nombre="201", Jornada=TiposJornada.Mañana},
            new Curso() {Nombre="301", Jornada=TiposJornada.Mañana}
        };

        escuela.Cursos.Add(new Curso(){Nombre="102", Jornada=TiposJornada.Tarde});
        escuela.Cursos.Add(new Curso(){Nombre="202", Jornada=TiposJornada.Tarde});

        var otraColecion =new List<Curso>() // Inclusión de la lista como constructor.
        {
            new Curso() {Nombre="401", Jornada=TiposJornada.Mañana},
            new Curso() {Nombre="501", Jornada=TiposJornada.Mañana},
            new Curso() {Nombre="502", Jornada=TiposJornada.Tarde}
        };

        otraColecion.Clear();

        escuela.Cursos.AddRange(otraColecion);

        
        Console.WriteLine(escuela);
        System.Console.WriteLine("===============================\n");
        imprimirCusrosEscuela(escuela); // Introducir esta mejor funció para imprimir código
       
    }

    private static void imprimirCusrosEscuela(Escuela escuela)
    {
        Console.WriteLine("=========================");
        Console.WriteLine($"Cursos de la Escuela");
        Console.WriteLine("=========================");

        foreach (var curso in escuela.Cursos)
        {
           Console.WriteLine($"Nombre: {curso.Nombre}, con ID: {curso.UniqueId} Unica referencia" );    
        }
    }

    private static void imprimirCursos(Curso[] arregloCursos)
    {
        int contador =0;
        /*while (contador<arregloCursos.Length)
        {
            Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, con ID: {arregloCursos[contador].UniqueId} Unica referencia" );    
            contador++;
        }*/

        foreach (var item in arregloCursos)
        {
           Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, con ID: {arregloCursos[contador].UniqueId} Unica referencia" );    
            contador++; 
        }
        
    }
}