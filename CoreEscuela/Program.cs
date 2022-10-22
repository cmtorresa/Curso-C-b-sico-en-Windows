class Escuela
{
    public string? nombre;
    public string? direccion;

    public int year;
    public string? ceo;

    public void Timbrar() 
    {
       Console.Beep(1000,3000);

    }
    
}
internal class Program
{
    private static void Main(string[] args)
    {
        var miEscuela = new Escuela();
        miEscuela.nombre = "Platzi Academy";
        miEscuela.direccion = "Al lado del que vende casa";
        miEscuela.year = 1987;
        miEscuela.ceo= "Freddy vega";
        Console.WriteLine("Esta timbando la consola!!!");
        miEscuela.Timbrar();

        //Console.WriteLine("Hello, World!");
    }
}