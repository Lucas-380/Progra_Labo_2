using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();

            list.Add(new Circulo(5));
            list.Add(new Rectangulo(4,6));
            list.Add(new Cuadrado(8));

            int contador = 1;
            foreach (Figura figura in list)
            {
                Console.WriteLine($"=============== FIGURA {contador} ===================");
                Console.WriteLine(figura.GetType());
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine("Area: " + (figura.CalcularSuperficie()).ToString("0.##"));
                Console.WriteLine("Perimetro: " + (figura.CalcularPerimetro()).ToString("0.##"));
                Console.WriteLine("============================================\n");
                contador++;
            }


        }
    }
}