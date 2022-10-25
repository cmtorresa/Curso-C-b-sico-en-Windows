// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");
        var curso1 =new Curso() {
            Nombre="101"
        };
        var curso2 =new Curso() {
            Nombre="201"
        };
        var curso3 =new Curso() {
            Nombre="301"
        };
        Console.WriteLine(escuela);
        System.Console.WriteLine("===============================");
        Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
        System.Console.WriteLine("===============================");
        Console.WriteLine(curso2.Nombre + ", " + curso2.UniqueId);
        System.Console.WriteLine("===============================");
        Console.WriteLine(curso3.Nombre + ", " + curso3.UniqueId);
    }
}