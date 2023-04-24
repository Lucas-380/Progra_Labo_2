using Entidades;

namespace Ejercicio_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = (NumeroBinario)"1001";
            Console.WriteLine(((NumeroDecimal)numeroBinario).Numero);

            NumeroDecimal numeroDecimal = (NumeroDecimal)9;
            Console.WriteLine(((NumeroBinario)numeroDecimal).Numero);


            Console.WriteLine($"El numero binario es {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");
            Console.WriteLine($"El numero decimal es {numeroDecimal.Numero}, sumado con el decimal da un total de {numeroBinario + numeroDecimal}");
            
        }
    }
}