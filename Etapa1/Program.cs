// See https://aka.ms/new-console-template for more information
using CoreEscuala.Util;
using CoreEscuela;
using CoreEscuela.Entidades;

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