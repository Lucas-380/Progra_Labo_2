using Entidades;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujoAzul;
            string dibujoRojo;

            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);

            boliAzul.Pintar(10, out dibujoAzul);
            boliRojo.Pintar(5, out dibujoRojo);

            Console.WriteLine(dibujoAzul);
            Console.WriteLine(dibujoRojo);


        }
    }
}