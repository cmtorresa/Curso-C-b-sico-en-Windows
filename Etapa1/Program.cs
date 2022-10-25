// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");

        escuela.Cursos = new Curso[]// Cambio esta Curso[] arregloCursos, por escuela.Cursos
        {
            new Curso() {Nombre="101"},new Curso() {Nombre="201"},new Curso() {Nombre="301"}
        };

        
        /*arregloCursos[0] =new Curso() {
            Nombre="101"
        };
        arregloCursos[1] =new Curso() {
            Nombre="201"
        };
        arregloCursos[2]=new Curso() {
            Nombre="301"
        };*/
        
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