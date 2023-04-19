using System.Drawing;
using Geometria;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(3, 2), new Punto(8, 5));

            Console.WriteLine($"El area del rectangulo es {rectangulo.GetArea()}");
            Console.WriteLine($"El perimetro del rectangulo es {rectangulo.GetPerimetro()}");
        }
    }
}