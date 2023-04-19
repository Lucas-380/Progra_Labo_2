using Billetes;

namespace Ejercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesos peso = 398;
            Dolar dolar = (Dolar)peso;

            Euro euro = 1.8;
            Dolar dolar1 = (Dolar)euro;

            Dolar dolares = 5;

            Console.WriteLine(dolar.GetCantidad()); //1
            Console.WriteLine(dolar1.GetCantidad()); //2

            Dolar result = dolares - peso;
            Dolar result2 = dolares + euro;

            Console.WriteLine(result.GetCantidad()); // 4
            Console.WriteLine(result2.GetCantidad()); // 7

        }
    }
}