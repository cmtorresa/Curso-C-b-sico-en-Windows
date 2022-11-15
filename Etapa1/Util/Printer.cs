namespace CoreEscuela.Util
{
    public class Printer
    {

        public static void DibujarLinea(int tam=10, char v='=')
        {
            Console.WriteLine("".PadLeft(tam, v));
        }

        public static void WriteTitle(string titulo)
        {
            var tamaño =titulo.Length + 4;
            DibujarLinea(tamaño);
            Console.WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz = 2000, int tiempo=500, int cantidad =1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}