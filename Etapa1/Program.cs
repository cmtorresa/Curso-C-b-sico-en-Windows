// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi School", 2012);
        escuela.Country="Colombia";
        escuela.City="Bogotá";
        escuela.TipoEscuela = TiposEscuela.primaria;
        Console.WriteLine(escuela);
    }
}