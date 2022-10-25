// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi School", 2012,TiposEscuela.primaria, pais:"Colombia", ciudad:"Bogotá");

        var arregloCursos = new Curso[3];// Se debe poner la cantidad de posiciones que va a tener la matriz.

        arregloCursos[0] =new Curso() {
            Nombre="101"
        };
        arregloCursos[1] =new Curso() {
            Nombre="201"
        };
        arregloCursos[2]=new Curso() {
            Nombre="301"
        };
        
        Console.WriteLine(escuela);
        System.Console.WriteLine("===============================\n");
        imprimirCursos(arregloCursos);
       
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