﻿// See https://aka.ms/new-console-template for more information
using CoreEscuela;
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var engine = new EscuelaEngine();
        engine.Inicializar();
              
        System.Console.WriteLine("Bienvenido a la escuela\n===============================\n");
        imprimirCusrosEscuela(engine.Escuela); // Introducir esta mejor funció para imprimir código

             
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
   
}