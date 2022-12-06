// See https://aka.ms/new-console-template for more information
using CoreEscuela.Util;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.App;

internal class Program
{
    private static void Main(string[] args)
    {
        var engine = new EscuelaEngine();
        engine.Inicializar();
              
        System.Console.WriteLine("\n===============================\n Bienvenido a la escuela\n===============================\n");
        Printer.DibujarLinea(10);
        Printer.DibujarLinea(20);
        System.Console.Beep(1000,2000);
        imprimirCusrosEscuela(engine.Escuela); // Introducir esta mejor funció para imprimir código

        var reporteador = new Reporteador(engine.GetDiccionarioObjetos());
        var evaList= reporteador.GetListaEvaluaciones();
        var lisAsig = reporteador.GetListaAsignaturas();
        var listEvalXAsig= reporteador.GetDicEvXAsig();

        //var dictmp = engine.GetDiccionarioObjetos();

        //engine.ImprimirDiccionario(dictmp);

        /*
        var listaObjetos = engine.GetObjetoEscuela(
            out int conteoEvaluaciones,
            out int conteoAlumnos,
            out int conteoCursos,
            out int conteoAsignaturas
        );

       var listaILugar = from obj in listaObjetos
                            where obj is Alumno // También se pueden usar en lugar de ILugar, Alumno.
                            select (Alumno) obj ; // Trae resultados de clase alumno. */

        //engine.Escuela.LimpiarLugar();

        //var obj = new ObjetoEscuelaBase();             
    }

    private static void imprimirCusrosEscuela(Escuela escuela)
    {
        Console.WriteLine($"Cursos de la Escuela");
        Console.WriteLine("=========================");

        foreach (var curso in escuela.Cursos)
        {
           Console.WriteLine($"Nombre: {curso.Nombre}, con ID: {curso.UniqueId} Unica referencia" );    
        }
    }
   
}