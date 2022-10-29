namespace CoreEscuala.Util
{
    public class Printer
    {

        public static void DibujarLinea(int tam=10, char v='=')
        {
            Console.WriteLine("".PadLeft(tam, v));
        }
    }
}